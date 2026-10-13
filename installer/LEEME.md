# Cómo armar el Setup de PTC

Genera un único `Setup_PTC.exe` que en cualquier PC con Windows 10/11:

1. Copia el programa y crea los accesos directos.
2. Instala **SQL Server Express** si la PC no lo tiene (silencioso, sin preguntas).
3. Crea la base de datos y carga tus tablas/datos desde `base.sql`.
   Si la base ya existe (reinstalación o actualización), **no la toca**.

> Esta carpeta es una plantilla que **todavía no se probó en Windows**. Probala en una PC o máquina virtual limpia antes de usarla en la clínica.

## Preparación (una sola vez)

1. Instalá **Inno Setup 6**: <https://jrsoftware.org/isdl.php>
2. Bajá **SQL Server Express** (la versión más nueva): <https://www.microsoft.com/sql-server/sql-server-downloads>
   → *Express* → ejecutá el instalador pequeño → **Descargar medios** → *Express Core* → idioma ENU → guardalo como
   `installer\prereqs\SQLEXPR_x64_ENU.exe`.
3. Generá `installer\base.sql` desde SSMS:
   clic derecho en tu base → **Tareas → Generar scripts…** → *Script de toda la base de datos y todos los objetos* →
   **Avanzadas** →
   - *Tipos de datos de los que se generará el script*: **Esquema y datos** (o **Solo esquema** si no querés copiar los pacientes reales a cada PC).
   - *Generar script de CREATE DATABASE*: **False** (el instalador ya crea la base).
   Guardalo como `installer\base.sql`.
4. Abrí `setup.iss` con un editor y cambiá los valores de arriba: `AppName`, `AppExe`, `BuildDir`, `DbName`.

## Cada vez que saques una versión nueva

1. En Visual Studio: **Release** → *Compilar solución*.
   - **.NET 6 o más nuevo**: hacé *clic derecho en el proyecto → Publicar → Carpeta* con **Autocontenido** y **win-x64**, y apuntá `BuildDir` a esa carpeta `publish` (así la otra PC no necesita instalar .NET).
   - **.NET Framework 4.x**: alcanza con la carpeta `bin\Release` (Windows 10/11 ya trae .NET 4.8).
2. Abrí `setup.iss` con Inno Setup y tocá **Build → Compile** (F9).
3. El instalador queda en `installer\salida\Setup_PTC.exe`.

## Cambiar el connection string del programa

Con este instalador cada PC usa su propio SQL Server local, así que en `App.config` (o donde lo tengas) usá autenticación de Windows, sin contraseñas guardadas:

```
Server=.\SQLEXPRESS;Database=PTC;Integrated Security=True;
```

Si tu proyecto es .NET 6+ y usa `Microsoft.Data.SqlClient`, agregale `TrustServerCertificate=True;` al final; si no, la conexión local falla con un error de certificado.

## Cosas a tener en cuenta

- **No subas `base.sql` al repo** si tiene datos reales: son datos de pacientes. Ya está en `.gitignore`.
- Si falla algo, el detalle queda en `%TEMP%\instalacion_base.log`.
- Cada PC tiene **su propia copia** de los datos. Si necesitás que varias PC compartan la misma base, instalá SQL en una sola PC (servidor), abrí el puerto 1433 y poné su IP en el connection string de las demás. Eso es otro armado.
- SQL Server Express tiene un límite de 10 GB por base, de sobra para una clínica chica.
