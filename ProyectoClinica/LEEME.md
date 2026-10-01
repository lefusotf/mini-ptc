# Clínica Médica (versión sencilla)

Proyecto en **C# Windows Forms (.NET Framework 4.8)** + **SQL Server**, hecho igual que en clase:

```
Clinica.sln
BaseDeDatos/ClinicaDB.sql   ← script de la base de datos
Modelos/                    ← clases: Conexion, Usuario, Paciente, Medico, Cita, Historial...
Vistas/                     ← formularios: frmLogin, frmMenu, frmPacientes, frmCitas...
```

## Pasos
1. Abrir `BaseDeDatos/ClinicaDB.sql` en SQL Server Management Studio y ejecutarlo (F5).
2. Abrir `Clinica.sln` en Visual Studio.
3. Si su servidor no es `(localdb)\MSSQLLocalDB`, cambiarlo en `Modelos/Conexion.cs`.
4. Clic derecho en el proyecto **Vistas** → *Establecer como proyecto de inicio* → F5.

## Usuarios
| Usuario   | Contraseña | Rol           |
|-----------|------------|---------------|
| admin     | Admin123!  | Administrador |
| recepcion | Recep123!  | Recepcionista |
| drlopez   | Medico123! | Médico        |
