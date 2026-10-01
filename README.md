# Sistema de Gestión de Clínica Médica

Proyecto de módulo — Instituto Técnico Ricaldone (BTVDS 1.3).
Aplicación de escritorio en **C# (.NET 8, Windows Forms)** con **SQL Server**, arquitectura **Modelo-Vista (MV)**.

## Funcionalidades
- **Login** con validaciones, contraseñas encriptadas con **BCrypt.Net** y bloqueo tras 3 intentos fallidos.
- **Roles**: Administrador (acceso total), Médico (sus citas + historial), Recepcionista (citas + pacientes).
- **Permisos** administrables desde el sistema (pantalla *Roles y permisos*); el menú se arma según los permisos.
- **CRUD**: Usuarios, Roles, Pacientes, Médicos, Especialidades, Citas e Historial clínico.
- **Sin duplicidad de horarios**: validación en el programa + índice único en la base de datos.
- **Try-Catch + MessageBox** en todas las pantallas; errores de SQL traducidos a mensajes claros.
- **Logging**: tabla `Bitacora` (actividades) y carpeta `Logs/` (errores técnicos).

## Estructura
```
BaseDeDatos/            Scripts SQL (01 tablas, 02 datos iniciales, 03 consultas)
ClinicaMedica/
  Modelo/
    Entidades/          Usuario, Rol, Permiso, Paciente, Medico, Especialidad, Cita, HistorialClinico, Bitacora
    DAO/                Acceso a datos (Listar, Insertar, Actualizar, Eliminar) + LoginDAO
    Utilidades/         Seguridad (BCrypt), Sesion, Logger, Validaciones, ExcepcionDatos
    Conexion.cs         Conexión, consultas parametrizadas y traducción de errores SQL
  Vista/                FrmLogin, FrmPrincipal, FrmBaseCrud y un formulario por módulo
  App.config            Cadena de conexión
Documentacion/          Documento Word (portada, índice, introducción, casos de uso, ER, diccionario) y diagramas
```

## Cómo ejecutarlo
1. En SQL Server Management Studio ejecutar **en orden** `BaseDeDatos/01_CrearBaseDatos.sql` y `BaseDeDatos/02_DatosIniciales.sql`.
2. Abrir `ClinicaMedica.sln` en **Visual Studio 2022** (carga de trabajo *Desarrollo de escritorio de .NET*).
3. En `ClinicaMedica/App.config` cambiar `Server=localhost` por su servidor (p. ej. `.\SQLEXPRESS`).
4. Presionar **F5** (los paquetes NuGet se descargan solos).

## Usuarios de prueba
| Usuario   | Contraseña  | Rol           |
|-----------|-------------|---------------|
| admin     | Admin123!   | Administrador |
| recepcion | Recep123!   | Recepcionista |
| drlopez   | Medico123!  | Médico        |
