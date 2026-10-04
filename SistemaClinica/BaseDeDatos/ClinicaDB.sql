CREATE DATABASE ClinicaDB;
GO

USE ClinicaDB;
GO

CREATE TABLE Rol (
    idRol INT PRIMARY KEY IDENTITY(1,1),
    nombreRol VARCHAR(50) NOT NULL
);

CREATE TABLE Permiso (
    idPermiso INT PRIMARY KEY IDENTITY(1,1),
    nombrePermiso VARCHAR(50) NOT NULL
);

CREATE TABLE RolPermiso (
    idRolPermiso INT PRIMARY KEY IDENTITY(1,1),
    id_Rol INT NOT NULL,
    id_Permiso INT NOT NULL,
    FOREIGN KEY (id_Rol) REFERENCES Rol(idRol),
    FOREIGN KEY (id_Permiso) REFERENCES Permiso(idPermiso)
);

CREATE TABLE Usuario (
    idUsuario INT PRIMARY KEY IDENTITY(1,1),
    nombreUsuario VARCHAR(50) NOT NULL UNIQUE,
    clave VARCHAR(255) NOT NULL,
    nombreCompleto VARCHAR(100) NOT NULL,
    id_Rol INT NOT NULL,
    activo BIT DEFAULT 1,
    FOREIGN KEY (id_Rol) REFERENCES Rol(idRol)
);


CREATE TABLE Especialidad (
    idEspecialidad INT PRIMARY KEY IDENTITY(1,1),
    nombreEspecialidad VARCHAR(100) NOT NULL
);

CREATE TABLE Medico (
    idMedico INT PRIMARY KEY IDENTITY(1,1),
    nombreMedico VARCHAR(100) NOT NULL,
    telefono VARCHAR(15),
    correo VARCHAR(100),
    id_Especialidad INT NOT NULL,
    id_Usuario INT NULL,
    FOREIGN KEY (id_Especialidad) REFERENCES Especialidad(idEspecialidad),
    FOREIGN KEY (id_Usuario) REFERENCES Usuario(idUsuario)
);

CREATE TABLE Paciente (
    idPaciente INT PRIMARY KEY IDENTITY(1,1),
    nombrePaciente VARCHAR(100) NOT NULL,
    dui VARCHAR(10),
    fechaNacimiento DATE NOT NULL,
    genero VARCHAR(10) NOT NULL,
    telefono VARCHAR(15),
    direccion VARCHAR(200)
);

CREATE TABLE Cita (
    idCita INT PRIMARY KEY IDENTITY(1,1),
    id_Paciente INT NOT NULL,
    id_Medico INT NOT NULL,
    fecha DATE NOT NULL,
    hora VARCHAR(5) NOT NULL,
    motivo VARCHAR(200) NOT NULL,
    estado VARCHAR(20) DEFAULT 'Pendiente',
    FOREIGN KEY (id_Paciente) REFERENCES Paciente(idPaciente),
    FOREIGN KEY (id_Medico) REFERENCES Medico(idMedico)
);

CREATE TABLE Historial (
    idHistorial INT PRIMARY KEY IDENTITY(1,1),
    id_Paciente INT NOT NULL,
    id_Medico INT NOT NULL,
    fecha DATETIME DEFAULT GETDATE(),
    diagnostico VARCHAR(300) NOT NULL,
    tratamiento VARCHAR(300),
    FOREIGN KEY (id_Paciente) REFERENCES Paciente(idPaciente),
    FOREIGN KEY (id_Medico) REFERENCES Medico(idMedico)
);

CREATE TABLE Bitacora (
    idBitacora INT PRIMARY KEY IDENTITY(1,1),
    usuario VARCHAR(50),
    accion VARCHAR(200),
    fecha DATETIME DEFAULT GETDATE()
);
GO


INSERT INTO Rol (nombreRol) VALUES ('Administrador');   -- 1
INSERT INTO Rol (nombreRol) VALUES ('Medico');          -- 2
INSERT INTO Rol (nombreRol) VALUES ('Recepcionista');   -- 3

INSERT INTO Permiso (nombrePermiso) VALUES ('Pacientes');       -- 1
INSERT INTO Permiso (nombrePermiso) VALUES ('Medicos');         -- 2
INSERT INTO Permiso (nombrePermiso) VALUES ('Especialidades');  -- 3
INSERT INTO Permiso (nombrePermiso) VALUES ('Citas');           -- 4
INSERT INTO Permiso (nombrePermiso) VALUES ('Historial');       -- 5
INSERT INTO Permiso (nombrePermiso) VALUES ('Usuarios');        -- 6
INSERT INTO Permiso (nombrePermiso) VALUES ('Permisos');        -- 7
INSERT INTO Permiso (nombrePermiso) VALUES ('Bitacora');        -- 8

-- Administrador
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (1, 1);
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (1, 2);
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (1, 3);
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (1, 4);
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (1, 5);
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (1, 6);
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (1, 7);
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (1, 8);

-- Medico
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (2, 4);
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (2, 5);

-- Recepcionista
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (3, 1);
INSERT INTO RolPermiso (id_Rol, id_Permiso) VALUES (3, 4);

/*
Las contraseñas son:
admin:Admin123!	
recepcion:Recep123!	
drlopez:Medico123!	
*/
INSERT INTO Usuario (nombreUsuario, clave, nombreCompleto, id_Rol) VALUES ('admin', '$2b$11$SdVLcEGMccTSU8qe3VoytOhRH0vQGmGqLopz5HRjr0NPgxKCdGdwW', 'Administrador', 1);
INSERT INTO Usuario (nombreUsuario, clave, nombreCompleto, id_Rol) VALUES ('recepcion', '$2b$11$Pvr2CRolGD7e2FXxtx0tkuhF013d5oAwjZbU/x6YDJ8X3nMdaPy9y', 'Maria Perez', 3);
INSERT INTO Usuario (nombreUsuario, clave, nombreCompleto, id_Rol) VALUES ('drlopez', '$2b$11$/LgLxgD5LXnX7jBYRwZs.ukb1IvhzwEKlkhmEO0.F1Ny6E89IgTXS', 'Carlos Lopez', 2);

INSERT INTO Especialidad (nombreEspecialidad) VALUES ('Medicina General');
INSERT INTO Especialidad (nombreEspecialidad) VALUES ('Pediatria');
INSERT INTO Especialidad (nombreEspecialidad) VALUES ('Cardiologia');
INSERT INTO Especialidad (nombreEspecialidad) VALUES ('Ginecologia');

INSERT INTO Medico (nombreMedico, telefono, correo, id_Especialidad, id_Usuario) VALUES ('Carlos Lopez', '7000-1111', 'clopez@clinica.com', 1, 3);
INSERT INTO Medico (nombreMedico, telefono, correo, id_Especialidad, id_Usuario) VALUES ('Ana Rivas', '7000-2222', 'arivas@clinica.com', 2, NULL);
INSERT INTO Medico (nombreMedico, telefono, correo, id_Especialidad, id_Usuario) VALUES ('Jorge Castillo', '7000-3333', 'jcastillo@clinica.com', 3, NULL);

INSERT INTO Paciente (nombrePaciente, dui, fechaNacimiento, genero, telefono, direccion) VALUES ('Jose Ramirez', '01234567-8', '1985-04-12', 'Masculino', '7111-0001', 'San Salvador');
INSERT INTO Paciente (nombrePaciente, dui, fechaNacimiento, genero, telefono, direccion) VALUES ('Gabriela Mendez', '02345678-9', '1992-09-30', 'Femenino', '7111-0002', 'Santa Tecla');
INSERT INTO Paciente (nombrePaciente, dui, fechaNacimiento, genero, telefono, direccion) VALUES ('Luis Aguilar', '', '2015-01-20', 'Masculino', '7111-0003', 'Soyapango');

INSERT INTO Cita (id_Paciente, id_Medico, fecha, hora, motivo) VALUES (1, 1, GETDATE(), '08:00', 'Dolor de cabeza');
INSERT INTO Cita (id_Paciente, id_Medico, fecha, hora, motivo) VALUES (2, 1, GETDATE(), '09:00', 'Chequeo general');
INSERT INTO Cita (id_Paciente, id_Medico, fecha, hora, motivo) VALUES (3, 2, GETDATE(), '10:00', 'Control de nino sano');
GO



CREATE VIEW vistaPacientes AS
SELECT idPaciente AS [#], nombrePaciente AS [Paciente], dui AS [DUI],
       fechaNacimiento AS [Fecha Nacimiento], genero AS [Genero],
       telefono AS [Telefono], direccion AS [Direccion]
FROM Paciente;
GO

CREATE VIEW vistaMedicos AS
SELECT m.idMedico AS [#], m.nombreMedico AS [Medico], m.telefono AS [Telefono],
       m.correo AS [Correo], e.nombreEspecialidad AS [Especialidad], u.nombreUsuario AS [Usuario]
FROM Medico m
INNER JOIN Especialidad e ON m.id_Especialidad = e.idEspecialidad
LEFT JOIN Usuario u ON m.id_Usuario = u.idUsuario;
GO

CREATE VIEW vistaCitas AS
SELECT c.idCita AS [#], c.id_Medico, p.nombrePaciente AS [Paciente], m.nombreMedico AS [Medico],
       c.fecha AS [Fecha], c.hora AS [Hora], c.motivo AS [Motivo], c.estado AS [Estado]
FROM Cita c
INNER JOIN Paciente p ON c.id_Paciente = p.idPaciente
INNER JOIN Medico m ON c.id_Medico = m.idMedico;
GO

CREATE VIEW vistaHistorial AS
SELECT h.idHistorial AS [#], h.id_Paciente, h.fecha AS [Fecha], m.nombreMedico AS [Medico],
       h.diagnostico AS [Diagnostico], h.tratamiento AS [Tratamiento]
FROM Historial h
INNER JOIN Medico m ON h.id_Medico = m.idMedico;
GO

CREATE VIEW vistaUsuarios AS
SELECT u.idUsuario AS [#], u.nombreUsuario AS [Usuario], u.nombreCompleto AS [Nombre Completo],
       r.nombreRol AS [Rol], u.activo AS [Activo]
FROM Usuario u
INNER JOIN Rol r ON u.id_Rol = r.idRol;
GO


SELECT * FROM vistaPacientes;
SELECT * FROM vistaMedicos;
SELECT * FROM vistaCitas;
SELECT * FROM vistaUsuarios;
