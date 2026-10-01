/* =============================================================
   SISTEMA DE GESTIÓN DE CLÍNICA MÉDICA
   Script de base de datos - ClinicaDB
   Ejecutar completo en SQL Server Management Studio (F5)
   ============================================================= */

-- Si la base ya existe la borramos para crearla de nuevo
USE master;
GO
IF DB_ID('ClinicaDB') IS NOT NULL
BEGIN
    ALTER DATABASE ClinicaDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE ClinicaDB;
END
GO

CREATE DATABASE ClinicaDB;
GO

USE ClinicaDB;
GO

/* ------------------- TABLAS DE SEGURIDAD ------------------- */

-- Roles: Administrador, Médico, Recepcionista
CREATE TABLE Roles (
    IdRol INT PRIMARY KEY IDENTITY(1,1),
    NombreRol VARCHAR(50) NOT NULL UNIQUE
);

-- Permisos: cada pantalla del sistema
CREATE TABLE Permisos (
    IdPermiso INT PRIMARY KEY IDENTITY(1,1),
    NombrePermiso VARCHAR(50) NOT NULL UNIQUE
);

-- Qué permisos tiene cada rol (tabla intermedia)
CREATE TABLE RolPermisos (
    IdRol INT NOT NULL,
    IdPermiso INT NOT NULL,
    PRIMARY KEY (IdRol, IdPermiso),
    FOREIGN KEY (IdRol) REFERENCES Roles(IdRol),
    FOREIGN KEY (IdPermiso) REFERENCES Permisos(IdPermiso)
);

-- Usuarios: la clave se guarda encriptada con BCrypt
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    Usuario VARCHAR(50) NOT NULL UNIQUE,
    Clave VARCHAR(255) NOT NULL,
    NombreCompleto VARCHAR(100) NOT NULL,
    IdRol INT NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    FOREIGN KEY (IdRol) REFERENCES Roles(IdRol)
);

/* ------------------- TABLAS DE LA CLÍNICA ------------------- */

CREATE TABLE Especialidades (
    IdEspecialidad INT PRIMARY KEY IDENTITY(1,1),
    NombreEspecialidad VARCHAR(100) NOT NULL UNIQUE
);

-- IdUsuario: el usuario con el que el médico entra al sistema
CREATE TABLE Medicos (
    IdMedico INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Telefono VARCHAR(15),
    Correo VARCHAR(100),
    IdEspecialidad INT NOT NULL,
    IdUsuario INT NULL,
    FOREIGN KEY (IdEspecialidad) REFERENCES Especialidades(IdEspecialidad),
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(IdUsuario)
);

CREATE TABLE Pacientes (
    IdPaciente INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    DUI VARCHAR(10),
    FechaNacimiento DATE NOT NULL,
    Genero VARCHAR(10) NOT NULL,
    Telefono VARCHAR(15),
    Direccion VARCHAR(200)
);

-- Estado: Pendiente, Atendida, Cancelada
CREATE TABLE Citas (
    IdCita INT PRIMARY KEY IDENTITY(1,1),
    IdPaciente INT NOT NULL,
    IdMedico INT NOT NULL,
    Fecha DATE NOT NULL,
    Hora VARCHAR(5) NOT NULL,
    Motivo VARCHAR(200) NOT NULL,
    Estado VARCHAR(20) NOT NULL DEFAULT 'Pendiente',
    FOREIGN KEY (IdPaciente) REFERENCES Pacientes(IdPaciente),
    FOREIGN KEY (IdMedico) REFERENCES Medicos(IdMedico)
);

-- Historial clínico: lo que el médico anota en cada consulta
CREATE TABLE Historial (
    IdHistorial INT PRIMARY KEY IDENTITY(1,1),
    IdPaciente INT NOT NULL,
    IdMedico INT NOT NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),
    Diagnostico VARCHAR(300) NOT NULL,
    Tratamiento VARCHAR(300),
    FOREIGN KEY (IdPaciente) REFERENCES Pacientes(IdPaciente),
    FOREIGN KEY (IdMedico) REFERENCES Medicos(IdMedico)
);

-- Bitácora: registro de actividades (quién hizo qué y cuándo)
CREATE TABLE Bitacora (
    IdBitacora INT PRIMARY KEY IDENTITY(1,1),
    Usuario VARCHAR(50),
    Accion VARCHAR(200),
    Fecha DATETIME DEFAULT GETDATE()
);
GO

/* ------------------- DATOS INICIALES ------------------- */

INSERT INTO Roles (NombreRol) VALUES ('Administrador');
INSERT INTO Roles (NombreRol) VALUES ('Médico');
INSERT INTO Roles (NombreRol) VALUES ('Recepcionista');

INSERT INTO Permisos (NombrePermiso) VALUES ('Pacientes');
INSERT INTO Permisos (NombrePermiso) VALUES ('Medicos');
INSERT INTO Permisos (NombrePermiso) VALUES ('Especialidades');
INSERT INTO Permisos (NombrePermiso) VALUES ('Citas');
INSERT INTO Permisos (NombrePermiso) VALUES ('Historial');
INSERT INTO Permisos (NombrePermiso) VALUES ('Usuarios');
INSERT INTO Permisos (NombrePermiso) VALUES ('Permisos');
INSERT INTO Permisos (NombrePermiso) VALUES ('Bitacora');

-- Administrador (1): acceso total
INSERT INTO RolPermisos (IdRol, IdPermiso) SELECT 1, IdPermiso FROM Permisos;
-- Médico (2): ver sus citas y actualizar historiales
INSERT INTO RolPermisos (IdRol, IdPermiso) VALUES (2, 4);
INSERT INTO RolPermisos (IdRol, IdPermiso) VALUES (2, 5);
-- Recepcionista (3): agendar citas y gestionar pacientes
INSERT INTO RolPermisos (IdRol, IdPermiso) VALUES (3, 1);
INSERT INTO RolPermisos (IdRol, IdPermiso) VALUES (3, 4);

-- Contraseñas encriptadas con BCrypt:
-- admin = Admin123!   |   recepcion = Recep123!   |   drlopez = Medico123!
INSERT INTO Usuarios (Usuario, Clave, NombreCompleto, IdRol) VALUES
('admin', '$2b$11$SdVLcEGMccTSU8qe3VoytOhRH0vQGmGqLopz5HRjr0NPgxKCdGdwW', 'Administrador', 1);
INSERT INTO Usuarios (Usuario, Clave, NombreCompleto, IdRol) VALUES
('recepcion', '$2b$11$Pvr2CRolGD7e2FXxtx0tkuhF013d5oAwjZbU/x6YDJ8X3nMdaPy9y', 'María Pérez', 3);
INSERT INTO Usuarios (Usuario, Clave, NombreCompleto, IdRol) VALUES
('drlopez', '$2b$11$/LgLxgD5LXnX7jBYRwZs.ukb1IvhzwEKlkhmEO0.F1Ny6E89IgTXS', 'Carlos López', 2);

INSERT INTO Especialidades (NombreEspecialidad) VALUES ('Medicina General');
INSERT INTO Especialidades (NombreEspecialidad) VALUES ('Pediatría');
INSERT INTO Especialidades (NombreEspecialidad) VALUES ('Cardiología');
INSERT INTO Especialidades (NombreEspecialidad) VALUES ('Ginecología');

-- El Dr. López (médico 1) está ligado al usuario drlopez (usuario 3)
INSERT INTO Medicos (Nombre, Telefono, Correo, IdEspecialidad, IdUsuario) VALUES ('Carlos López', '7000-1111', 'clopez@clinica.com', 1, 3);
INSERT INTO Medicos (Nombre, Telefono, Correo, IdEspecialidad, IdUsuario) VALUES ('Ana Rivas', '7000-2222', 'arivas@clinica.com', 2, NULL);
INSERT INTO Medicos (Nombre, Telefono, Correo, IdEspecialidad, IdUsuario) VALUES ('Jorge Castillo', '7000-3333', 'jcastillo@clinica.com', 3, NULL);

INSERT INTO Pacientes (Nombre, DUI, FechaNacimiento, Genero, Telefono, Direccion) VALUES ('José Ramírez', '01234567-8', '1985-04-12', 'Masculino', '7111-0001', 'San Salvador');
INSERT INTO Pacientes (Nombre, DUI, FechaNacimiento, Genero, Telefono, Direccion) VALUES ('Gabriela Méndez', '02345678-9', '1992-09-30', 'Femenino', '7111-0002', 'Santa Tecla');
INSERT INTO Pacientes (Nombre, DUI, FechaNacimiento, Genero, Telefono, Direccion) VALUES ('Luis Aguilar', NULL, '2015-01-20', 'Masculino', '7111-0003', 'Soyapango');

INSERT INTO Citas (IdPaciente, IdMedico, Fecha, Hora, Motivo) VALUES (1, 1, CAST(GETDATE() AS DATE), '08:00', 'Dolor de cabeza');
INSERT INTO Citas (IdPaciente, IdMedico, Fecha, Hora, Motivo) VALUES (2, 1, CAST(GETDATE() AS DATE), '09:00', 'Chequeo general');
INSERT INTO Citas (IdPaciente, IdMedico, Fecha, Hora, Motivo) VALUES (3, 2, CAST(GETDATE() AS DATE), '10:00', 'Control de niño sano');
GO

/* ------------------- CONSULTAS DE PRUEBA ------------------- */
SELECT * FROM Roles;
SELECT * FROM Permisos;
SELECT u.Usuario, u.NombreCompleto, r.NombreRol FROM Usuarios u INNER JOIN Roles r ON u.IdRol = r.IdRol;
SELECT * FROM Pacientes;
SELECT * FROM Citas;
