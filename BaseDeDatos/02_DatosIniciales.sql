/* =====================================================================
   PROYECTO : Sistema de Gestión de Clínica Médica
   SCRIPT   : 02_DatosIniciales.sql
   OBJETIVO : Insertar roles, permisos, asignación rol-permiso y
              usuarios iniciales para poder entrar al sistema.
   ===================================================================== */

USE ClinicaMedicaDB;
GO

/* ---------------------------------------------------------------------
   1. ROLES
   --------------------------------------------------------------------- */
INSERT INTO Roles (Nombre, Descripcion) VALUES
('Administrador', 'Acceso total al sistema'),
('Médico',        'Consulta sus citas y actualiza historiales clínicos'),
('Recepcionista', 'Agenda citas y gestiona pacientes');
GO

/* ---------------------------------------------------------------------
   2. PERMISOS (el código lo usa el programa para habilitar opciones)
   --------------------------------------------------------------------- */
INSERT INTO Permisos (Codigo, Nombre, Descripcion) VALUES
('USUARIOS_GESTIONAR',       'Gestionar usuarios',          'Crear, editar y eliminar usuarios del sistema'),
('ROLES_GESTIONAR',          'Gestionar roles y permisos',  'Crear roles y asignarles permisos'),
('ESPECIALIDADES_GESTIONAR', 'Gestionar especialidades',    'CRUD de especialidades médicas'),
('MEDICOS_GESTIONAR',        'Gestionar médicos',           'CRUD de médicos'),
('PACIENTES_VER',            'Ver pacientes',               'Consultar la lista de pacientes'),
('PACIENTES_GESTIONAR',      'Gestionar pacientes',         'Crear, editar y eliminar pacientes'),
('CITAS_VER_TODAS',          'Ver todas las citas',         'Consultar las citas de todos los médicos'),
('CITAS_AGENDAR',            'Agendar citas',               'Crear, reprogramar y cancelar citas'),
('CITAS_VER_PROPIAS',        'Ver mis citas',               'El médico ve solo sus propias citas'),
('CITAS_ATENDER',            'Atender citas',               'Cambiar el estado de una cita a Atendida'),
('HISTORIAL_VER',            'Ver historial clínico',       'Consultar el historial de los pacientes'),
('HISTORIAL_EDITAR',         'Actualizar historial clínico','Registrar y modificar consultas en el historial'),
('BITACORA_VER',             'Ver bitácora',                'Consultar el registro de actividades');
GO

/* ---------------------------------------------------------------------
   3. ASIGNACIÓN DE PERMISOS A ROLES
   --------------------------------------------------------------------- */
-- Administrador: acceso total (todos los permisos)
INSERT INTO RolPermisos (IdRol, IdPermiso)
SELECT r.IdRol, p.IdPermiso FROM Roles r CROSS JOIN Permisos p
WHERE r.Nombre = 'Administrador';

-- Médico: ver sus citas y actualizar historiales
INSERT INTO RolPermisos (IdRol, IdPermiso)
SELECT r.IdRol, p.IdPermiso FROM Roles r JOIN Permisos p
  ON p.Codigo IN ('PACIENTES_VER','CITAS_VER_PROPIAS','CITAS_ATENDER','HISTORIAL_VER','HISTORIAL_EDITAR')
WHERE r.Nombre = 'Médico';

-- Recepcionista: agendar citas y gestionar pacientes
INSERT INTO RolPermisos (IdRol, IdPermiso)
SELECT r.IdRol, p.IdPermiso FROM Roles r JOIN Permisos p
  ON p.Codigo IN ('PACIENTES_VER','PACIENTES_GESTIONAR','CITAS_VER_TODAS','CITAS_AGENDAR')
WHERE r.Nombre = 'Recepcionista';
GO

/* ---------------------------------------------------------------------
   4. USUARIOS INICIALES
   Las contraseñas están encriptadas con BCrypt (factor 11).
     admin      -> Admin123!
     recepcion  -> Recep123!
     drlopez    -> Medico123!
   --------------------------------------------------------------------- */
INSERT INTO Usuarios (NombreUsuario, NombreCompleto, Correo, ClaveHash, IdRol) VALUES
('admin',     'Administrador del Sistema', 'admin@clinica.com',
 '$2b$11$SdVLcEGMccTSU8qe3VoytOhRH0vQGmGqLopz5HRjr0NPgxKCdGdwW', (SELECT IdRol FROM Roles WHERE Nombre = 'Administrador')),
('recepcion', 'María Fernanda Pérez',      'recepcion@clinica.com',
 '$2b$11$Pvr2CRolGD7e2FXxtx0tkuhF013d5oAwjZbU/x6YDJ8X3nMdaPy9y', (SELECT IdRol FROM Roles WHERE Nombre = 'Recepcionista')),
('drlopez',   'Carlos Alberto López',      'clopez@clinica.com',
 '$2b$11$/LgLxgD5LXnX7jBYRwZs.ukb1IvhzwEKlkhmEO0.F1Ny6E89IgTXS', (SELECT IdRol FROM Roles WHERE Nombre = 'Médico'));
GO

/* ---------------------------------------------------------------------
   5. DATOS DE EJEMPLO (especialidades, médicos y pacientes)
   --------------------------------------------------------------------- */
INSERT INTO Especialidades (Nombre, Descripcion) VALUES
('Medicina General', 'Atención primaria y consulta general'),
('Pediatría',        'Atención de niños y adolescentes'),
('Cardiología',      'Enfermedades del corazón y sistema circulatorio'),
('Ginecología',      'Salud del sistema reproductor femenino');
GO

INSERT INTO Medicos (Nombres, Apellidos, JVPM, Telefono, Correo, IdEspecialidad, IdUsuario) VALUES
('Carlos Alberto', 'López Martínez', '12345', '7000-1111', 'clopez@clinica.com', 1,
    (SELECT IdUsuario FROM Usuarios WHERE NombreUsuario = 'drlopez')),
('Ana Lucía',      'Rivas Hernández', '23456', '7000-2222', 'arivas@clinica.com', 2, NULL),
('Jorge Ernesto',  'Castillo Flores', '34567', '7000-3333', 'jcastillo@clinica.com', 3, NULL);
GO

INSERT INTO Pacientes (Nombres, Apellidos, DUI, FechaNacimiento, Genero, Telefono, Correo, Direccion, TipoSangre, Alergias) VALUES
('José Antonio', 'Ramírez Cruz',   '01234567-8', '1985-04-12', 'M', '7111-0001', 'jramirez@mail.com', 'San Salvador', 'O+', 'Penicilina'),
('Gabriela',     'Méndez Ortiz',   '02345678-9', '1992-09-30', 'F', '7111-0002', 'gmendez@mail.com',  'Santa Tecla',  'A+', NULL),
('Luis Fernando','Aguilar Torres', NULL,         '2015-01-20', 'M', '7111-0003', NULL,                'Soyapango',    'B-', NULL);
GO

PRINT 'Datos iniciales insertados correctamente.';
GO
