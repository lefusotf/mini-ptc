/* =====================================================================
   PROYECTO : Sistema de Gestión de Clínica Médica
   SCRIPT   : 01_CrearBaseDatos.sql
   OBJETIVO : Crear la base de datos y todas sus tablas.
   MOTOR    : SQL Server 2019 o superior
   ORDEN    : Ejecutar 01 -> 02 -> 03
   ===================================================================== */

USE master;
GO

-- Si la base ya existe se elimina para empezar desde cero
IF DB_ID('ClinicaMedicaDB') IS NOT NULL
BEGIN
    ALTER DATABASE ClinicaMedicaDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE ClinicaMedicaDB;
END
GO

CREATE DATABASE ClinicaMedicaDB;
GO

USE ClinicaMedicaDB;
GO

/* =====================================================================
   SEGURIDAD: Roles, Permisos y Usuarios
   ===================================================================== */

-- Roles del sistema (Administrador, Médico, Recepcionista)
CREATE TABLE Roles (
    IdRol        INT IDENTITY(1,1) NOT NULL,
    Nombre       VARCHAR(50)       NOT NULL,
    Descripcion  VARCHAR(200)      NULL,
    CONSTRAINT PK_Roles PRIMARY KEY (IdRol),
    CONSTRAINT UQ_Roles_Nombre UNIQUE (Nombre)
);
GO

-- Permisos: cada acción que se puede realizar dentro del sistema
CREATE TABLE Permisos (
    IdPermiso    INT IDENTITY(1,1) NOT NULL,
    Codigo       VARCHAR(50)       NOT NULL,   -- código usado por el programa (ej. CITAS_AGENDAR)
    Nombre       VARCHAR(100)      NOT NULL,   -- nombre legible para el usuario
    Descripcion  VARCHAR(200)      NULL,
    CONSTRAINT PK_Permisos PRIMARY KEY (IdPermiso),
    CONSTRAINT UQ_Permisos_Codigo UNIQUE (Codigo)
);
GO

-- Tabla intermedia (muchos a muchos): qué permisos tiene cada rol
CREATE TABLE RolPermisos (
    IdRol      INT NOT NULL,
    IdPermiso  INT NOT NULL,
    CONSTRAINT PK_RolPermisos PRIMARY KEY (IdRol, IdPermiso),
    CONSTRAINT FK_RolPermisos_Roles    FOREIGN KEY (IdRol)     REFERENCES Roles(IdRol)       ON DELETE CASCADE,
    CONSTRAINT FK_RolPermisos_Permisos FOREIGN KEY (IdPermiso) REFERENCES Permisos(IdPermiso) ON DELETE CASCADE
);
GO

-- Usuarios que inician sesión. La contraseña se guarda como hash BCrypt (nunca en texto plano)
CREATE TABLE Usuarios (
    IdUsuario         INT IDENTITY(1,1) NOT NULL,
    NombreUsuario     VARCHAR(50)       NOT NULL,
    NombreCompleto    VARCHAR(100)      NOT NULL,
    Correo            VARCHAR(100)      NULL,
    ClaveHash         VARCHAR(100)      NOT NULL,          -- hash BCrypt (60 caracteres)
    IdRol             INT               NOT NULL,
    Activo            BIT               NOT NULL DEFAULT 1,
    IntentosFallidos  INT               NOT NULL DEFAULT 0, -- se bloquea al llegar a 3
    FechaCreacion     DATETIME          NOT NULL DEFAULT GETDATE(),
    UltimoAcceso      DATETIME          NULL,
    CONSTRAINT PK_Usuarios PRIMARY KEY (IdUsuario),
    CONSTRAINT UQ_Usuarios_NombreUsuario UNIQUE (NombreUsuario),
    CONSTRAINT FK_Usuarios_Roles FOREIGN KEY (IdRol) REFERENCES Roles(IdRol)
);
GO

/* =====================================================================
   CATÁLOGOS: Especialidades, Médicos y Pacientes
   ===================================================================== */

CREATE TABLE Especialidades (
    IdEspecialidad  INT IDENTITY(1,1) NOT NULL,
    Nombre          VARCHAR(100)      NOT NULL,
    Descripcion     VARCHAR(250)      NULL,
    CONSTRAINT PK_Especialidades PRIMARY KEY (IdEspecialidad),
    CONSTRAINT UQ_Especialidades_Nombre UNIQUE (Nombre)
);
GO

-- Un médico puede (opcionalmente) estar ligado a un usuario para iniciar sesión
CREATE TABLE Medicos (
    IdMedico        INT IDENTITY(1,1) NOT NULL,
    Nombres         VARCHAR(100)      NOT NULL,
    Apellidos       VARCHAR(100)      NOT NULL,
    JVPM            VARCHAR(20)       NOT NULL,   -- número de Junta de Vigilancia de la Profesión Médica
    Telefono        VARCHAR(15)       NULL,
    Correo          VARCHAR(100)      NULL,
    IdEspecialidad  INT               NOT NULL,
    IdUsuario       INT               NULL,
    Activo          BIT               NOT NULL DEFAULT 1,
    CONSTRAINT PK_Medicos PRIMARY KEY (IdMedico),
    CONSTRAINT UQ_Medicos_JVPM UNIQUE (JVPM),
    CONSTRAINT FK_Medicos_Especialidades FOREIGN KEY (IdEspecialidad) REFERENCES Especialidades(IdEspecialidad),
    CONSTRAINT FK_Medicos_Usuarios       FOREIGN KEY (IdUsuario)      REFERENCES Usuarios(IdUsuario)
);
GO

-- Un usuario solo puede estar ligado a un médico (se permiten varios NULL)
CREATE UNIQUE INDEX UX_Medicos_IdUsuario ON Medicos(IdUsuario) WHERE IdUsuario IS NOT NULL;
GO

CREATE TABLE Pacientes (
    IdPaciente       INT IDENTITY(1,1) NOT NULL,
    Nombres          VARCHAR(100)      NOT NULL,
    Apellidos        VARCHAR(100)      NOT NULL,
    DUI              VARCHAR(10)       NULL,       -- formato 00000000-0 (menores pueden no tener)
    FechaNacimiento  DATE              NOT NULL,
    Genero           CHAR(1)           NOT NULL,   -- M / F
    Telefono         VARCHAR(15)       NULL,
    Correo           VARCHAR(100)      NULL,
    Direccion        VARCHAR(250)      NULL,
    TipoSangre       VARCHAR(3)        NULL,
    Alergias         VARCHAR(250)      NULL,
    FechaRegistro    DATETIME          NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_Pacientes PRIMARY KEY (IdPaciente),
    CONSTRAINT CK_Pacientes_Genero CHECK (Genero IN ('M','F'))
);
GO

CREATE UNIQUE INDEX UX_Pacientes_DUI ON Pacientes(DUI) WHERE DUI IS NOT NULL;
GO

/* =====================================================================
   OPERACIÓN: Citas e Historial clínico
   ===================================================================== */

CREATE TABLE Citas (
    IdCita             INT IDENTITY(1,1) NOT NULL,
    IdPaciente         INT               NOT NULL,
    IdMedico           INT               NOT NULL,
    Fecha              DATE              NOT NULL,
    Hora               TIME(0)           NOT NULL,
    Motivo             VARCHAR(250)      NOT NULL,
    Estado             VARCHAR(20)       NOT NULL DEFAULT 'Pendiente',
    Observaciones      VARCHAR(500)      NULL,
    IdUsuarioRegistro  INT               NULL,   -- quién agendó la cita
    FechaRegistro      DATETIME          NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_Citas PRIMARY KEY (IdCita),
    CONSTRAINT FK_Citas_Pacientes FOREIGN KEY (IdPaciente)        REFERENCES Pacientes(IdPaciente),
    CONSTRAINT FK_Citas_Medicos   FOREIGN KEY (IdMedico)          REFERENCES Medicos(IdMedico),
    CONSTRAINT FK_Citas_Usuarios  FOREIGN KEY (IdUsuarioRegistro) REFERENCES Usuarios(IdUsuario),
    CONSTRAINT CK_Citas_Estado CHECK (Estado IN ('Pendiente','Confirmada','Atendida','Cancelada'))
);
GO

-- Evita la DUPLICIDAD DE HORARIOS: un médico no puede tener dos citas activas a la misma hora
CREATE UNIQUE INDEX UX_Citas_MedicoHorario ON Citas(IdMedico, Fecha, Hora) WHERE Estado <> 'Cancelada';
GO

-- Historial clínico: cada consulta atendida queda registrada (seguimiento histórico)
CREATE TABLE HistorialClinico (
    IdHistorial    INT IDENTITY(1,1) NOT NULL,
    IdPaciente     INT               NOT NULL,
    IdMedico       INT               NOT NULL,
    IdCita         INT               NULL,
    FechaConsulta  DATETIME          NOT NULL DEFAULT GETDATE(),
    Diagnostico    VARCHAR(500)      NOT NULL,
    Tratamiento    VARCHAR(500)      NULL,
    Observaciones  VARCHAR(500)      NULL,
    CONSTRAINT PK_HistorialClinico PRIMARY KEY (IdHistorial),
    CONSTRAINT FK_Historial_Pacientes FOREIGN KEY (IdPaciente) REFERENCES Pacientes(IdPaciente),
    CONSTRAINT FK_Historial_Medicos   FOREIGN KEY (IdMedico)   REFERENCES Medicos(IdMedico),
    CONSTRAINT FK_Historial_Citas     FOREIGN KEY (IdCita)     REFERENCES Citas(IdCita)
);
GO

/* =====================================================================
   AUDITORÍA: Bitácora de actividades (logging)
   ===================================================================== */

CREATE TABLE Bitacora (
    IdBitacora   INT IDENTITY(1,1) NOT NULL,
    IdUsuario    INT               NULL,
    Accion       VARCHAR(50)       NOT NULL,   -- LOGIN, INSERTAR, ACTUALIZAR, ELIMINAR...
    Modulo       VARCHAR(50)       NOT NULL,   -- Pacientes, Citas, Usuarios...
    Descripcion  VARCHAR(500)      NULL,
    Fecha        DATETIME          NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_Bitacora PRIMARY KEY (IdBitacora),
    CONSTRAINT FK_Bitacora_Usuarios FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario) ON DELETE SET NULL
);
GO

PRINT 'Base de datos y tablas creadas correctamente.';
GO
