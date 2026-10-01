/* =====================================================================
   PROYECTO : Sistema de Gestión de Clínica Médica
   SCRIPT   : 03_Consultas.sql
   OBJETIVO : Consultas de verificación (útiles para la defensa del proyecto)
   ===================================================================== */

USE ClinicaMedicaDB;
GO

-- Permisos que tiene cada rol
SELECT r.Nombre AS Rol, p.Codigo, p.Nombre AS Permiso
FROM RolPermisos rp
JOIN Roles r    ON r.IdRol = rp.IdRol
JOIN Permisos p ON p.IdPermiso = rp.IdPermiso
ORDER BY r.Nombre, p.Codigo;

-- Usuarios con su rol (las contraseñas solo se ven como hash)
SELECT u.IdUsuario, u.NombreUsuario, u.NombreCompleto, r.Nombre AS Rol, u.Activo, u.ClaveHash
FROM Usuarios u JOIN Roles r ON r.IdRol = u.IdRol;

-- Agenda de citas con nombres de paciente y médico
SELECT c.IdCita, c.Fecha, c.Hora, c.Estado,
       p.Nombres + ' ' + p.Apellidos AS Paciente,
       m.Nombres + ' ' + m.Apellidos AS Medico,
       e.Nombre AS Especialidad
FROM Citas c
JOIN Pacientes p      ON p.IdPaciente = c.IdPaciente
JOIN Medicos m        ON m.IdMedico = c.IdMedico
JOIN Especialidades e ON e.IdEspecialidad = m.IdEspecialidad
ORDER BY c.Fecha, c.Hora;

-- Últimas 50 actividades registradas en la bitácora
SELECT TOP 50 b.Fecha, u.NombreUsuario, b.Accion, b.Modulo, b.Descripcion
FROM Bitacora b LEFT JOIN Usuarios u ON u.IdUsuario = b.IdUsuario
ORDER BY b.Fecha DESC;
GO
