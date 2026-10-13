# Crea la base de datos y carga base.sql en una instancia local de SQL Server.
# - Si la base ya existe NO se toca (no pisa datos al reinstalar o actualizar).
# - Si algo falla a mitad de camino, borra la base a medio crear para poder reintentar.
# - Da permisos de lectura/escritura/ejecucion al grupo local "Usuarios" (autenticacion de Windows).
param(
    [string]$Instancia = ".\SQLEXPRESS",
    [string]$Base      = "PTC",
    [string]$Script    = (Join-Path $PSScriptRoot "base.sql")
)

$ErrorActionPreference = "Stop"
$Log = Join-Path $env:TEMP "instalacion_base.log"
function Escribir($msg) { "$(Get-Date -Format s)  $msg" | Out-File -FilePath $Log -Append -Encoding utf8 }

function Quote-Name($n) { "[" + $n.Replace("]", "]]") + "]" }

function Open-Conn($db) {
    $cn = New-Object System.Data.SqlClient.SqlConnection(
        "Server=$Instancia;Database=$db;Integrated Security=True;Connect Timeout=15")
    $cn.Open()
    return $cn
}

function Run-Sql($cn, $sql) {
    $cmd = $cn.CreateCommand()
    $cmd.CommandTimeout = 0
    $cmd.CommandText = $sql
    [void]$cmd.ExecuteNonQuery()
}

$cnMaster = $null
$creada   = $false
try {
    Escribir "Inicio. Instancia=$Instancia Base=$Base Script=$Script"
    if (-not (Test-Path $Script)) { throw "No existe el script $Script" }

    # El servicio de SQL puede tardar unos segundos en arrancar despues de instalarse
    for ($i = 0; $i -lt 30 -and -not $cnMaster; $i++) {
        try { $cnMaster = Open-Conn "master" }
        catch { Escribir "Esperando a SQL Server... ($($_.Exception.Message))"; Start-Sleep -Seconds 2 }
    }
    if (-not $cnMaster) { throw "No se pudo conectar a $Instancia" }

    $cmd = $cnMaster.CreateCommand()
    $cmd.CommandText = "SELECT DB_ID(@n)"
    [void]$cmd.Parameters.AddWithValue("@n", $Base)
    if ($cmd.ExecuteScalar() -isnot [DBNull]) {
        Escribir "La base $Base ya existe: no se modifica."
        exit 0
    }

    $q = Quote-Name $Base
    Run-Sql $cnMaster "CREATE DATABASE $q"
    $creada = $true
    Escribir "Base creada."

    # Cargar el script (separa los lotes por la linea GO)
    $texto  = [System.IO.File]::ReadAllText($Script)
    $lotes  = [regex]::Split($texto, '(?im)^[ \t]*GO[ \t]*\d*[ \t]*\r?$')
    $cnBase = Open-Conn $Base
    $n = 0
    foreach ($lote in $lotes) {
        if ($lote.Trim().Length -gt 0) { Run-Sql $cnBase $lote; $n++ }
    }
    Escribir "Script ejecutado: $n lotes."

    # Permisos para cualquier usuario de Windows de la PC (el nombre del grupo depende del idioma)
    $grupo = (New-Object System.Security.Principal.SecurityIdentifier "S-1-5-32-545").
                 Translate([System.Security.Principal.NTAccount]).Value
    $g = Quote-Name $grupo
    Run-Sql $cnMaster ("IF NOT EXISTS (SELECT 1 FROM sys.server_principals WHERE name = N'" +
                       $grupo.Replace("'", "''") + "') CREATE LOGIN $g FROM WINDOWS")
    Run-Sql $cnBase "CREATE USER $g FOR LOGIN $g"
    Run-Sql $cnBase "ALTER ROLE db_datareader ADD MEMBER $g"
    Run-Sql $cnBase "ALTER ROLE db_datawriter ADD MEMBER $g"
    Run-Sql $cnBase "GRANT EXECUTE TO $g"
    Escribir "Permisos otorgados a $grupo."
    $cnBase.Close()
    Escribir "OK"
    exit 0
}
catch {
    Escribir "ERROR: $($_.Exception.Message)"
    # Dejar todo limpio para poder reintentar
    if ($creada -and $cnMaster) {
        try {
            $q = Quote-Name $Base
            Run-Sql $cnMaster "ALTER DATABASE $q SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE $q"
            Escribir "Base a medio crear eliminada."
        } catch { Escribir "No se pudo limpiar: $($_.Exception.Message)" }
    }
    exit 1
}
finally {
    if ($cnMaster) { $cnMaster.Close() }
}
