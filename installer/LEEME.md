# Cómo armar el Setup de PTC

Genera un único `Setup_PTC.exe` que en cualquier PC con Windows 10/11:

1. Copia el programa y crea los accesos directos.
2. Instala **SQL Server Express** si la PC no lo tiene (silencioso, sin preguntas).
3. Crea la base de datos y carga tus tablas, procedimientos y datos de ejemplo desde `base.sql`.
   Si la base ya existe (reinstalación o actualización), **no la toca**.

> Esta carpeta es una plantilla que **todavía no se probó en Windows ni contra un SQL Server real**. Probala en una PC o máquina virtual limpia antes de repartirla.

## Preparación (una sola vez)

1. Instalá **Inno Setup 6**: <https://jrsoftware.org/isdl.php>
2. Bajá **SQL Server Express** (la versión más nueva): <https://www.microsoft.com/sql-server/sql-server-downloads>
   → *Express* → ejecutá el instalador pequeño → **Descargar medios** → *Express Core* → idioma ENU → guardalo como
   `installer\prereqs\SQLEXPR_x64_ENU.exe`.
3. Copiá tu script `BaseDeDatos_Completa.sql` como `installer\base.sql`.
   El script ya crea la base `Gestion_administrativa_y_escolar` y se puede ejecutar varias veces sin duplicar nada. Si lo cambiás, reemplazá este archivo.
4. Abrí `setup.iss` con un editor y revisá los valores de arriba: `AppName`, `AppExe` (nombre real del `.exe`), `BuildDir` y `DbName`.

## Cada vez que saques una versión nueva

1. En Visual Studio: **Release** → *Compilar solución*.
   - **.NET Framework 4.x**: alcanza con la carpeta `bin\Release` del proyecto de la ventana (Windows 10/11 ya trae .NET 4.8). Apuntá `BuildDir` ahí.
   - **.NET 6 o más nuevo**: *clic derecho en el proyecto → Publicar → Carpeta*, con **Autocontenido** y **win-x64**, y apuntá `BuildDir` a la carpeta `publish`.
2. Abrí `setup.iss` con Inno Setup y tocá **Build → Compile** (F9).
3. El instalador queda en `installer\salida\Setup_PTC.exe`.

## El programa tiene que buscar el mismo servidor que instala el Setup

El Setup instala la instancia **`.\SQLEXPRESS`** con **autenticación de Windows**, y le da permisos a todos los usuarios de la PC. El programa tiene que conectarse a ese mismo lugar:

```
Data Source=.\SQLEXPRESS;Initial Catalog=Gestion_administrativa_y_escolar;Integrated Security=true;
```

Si en tu código el servidor está escrito a mano como `(localdb)\MSSQLLocalDB` (es lo que hace el proyecto `ClinicaMiniPtc` de este repo), en las otras PC no va a encontrarlo: hay que cambiarlo, o ajustar el instalador para que instale LocalDB. Revisalo antes de repartir el Setup.

Si el proyecto usa `Microsoft.Data.SqlClient` (.NET 6+), agregale `TrustServerCertificate=True;` al final; si no, la conexión local falla con un error de certificado.

## Cosas a tener en cuenta

- Este repo es **público**. `installer/base.sql`, `installer/prereqs/` y `installer/salida/` están en `.gitignore` para que no se suban sin querer. Subilos solo si querés que cualquiera los vea.
- Los datos que trae `base.sql` son de ejemplo (una institución ficticia). Antes de publicar el Setup, confirmá que no haya datos de personas reales.
- Si falla algo, el detalle queda en `%TEMP%\instalacion_base.log`.
- Cada PC tiene **su propia copia** de los datos. Si necesitás que varias PC compartan la misma base, instalá SQL en una sola PC (servidor), abrí el puerto 1433 y poné su IP en el connection string de las demás. Eso es otro armado.
- SQL Server Express tiene un límite de 10 GB por base, de sobra para este uso.
- Windows muestra la advertencia de SmartScreen en instaladores sin firmar. Se puede instalar igual con *Más información → Ejecutar de todas formas*.
