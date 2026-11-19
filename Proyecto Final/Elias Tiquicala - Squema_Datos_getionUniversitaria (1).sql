-- =====================================================
-- CREACIÓN Y CONFIGURACIÓN DE LA BASE DE DATOS
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'GestionUniversitaria')
    CREATE DATABASE GestionUniversitaria;
GO

USE GestionUniversitaria;
GO

-- =====================================================
-- 1. TABLAS CATÁLOGO / INDEPENDIENTES
-- =====================================================

-- Catálogo de Carreras
CREATE TABLE carrera (
    id_carrera INT IDENTITY(1,1) PRIMARY KEY,
    nombre_carrera VARCHAR(100) NOT NULL,
    duracion_anios INT
);
GO

-- Tabla de Profesores
CREATE TABLE profesor (
    id_profesor INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    email VARCHAR(100),
    edad INT CHECK (edad >= 18),
    antiguedad_docente INT CHECK (antiguedad_docente >= 0)
);
GO

-- Tabla de Alumnos (Legajo preparado para ser asignado desde C#)
CREATE TABLE alumno (
    id_alumno INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    dni VARCHAR(20) UNIQUE NOT NULL, 
    legajo VARCHAR(150) UNIQUE NULL, 
    email VARCHAR(100),
    edad INT CHECK (edad >= 17)
);
GO

-- Catálogo de Estados Académicos (Relación con Inscripción)
CREATE TABLE estado_academico (
    id_estado INT PRIMARY KEY,
    descripcion VARCHAR(50) NOT NULL
);
GO

INSERT INTO estado_academico (id_estado, descripcion) VALUES 
(1, 'Aprobado'),
(2, 'Regular'),
(3, 'Desaprobado');
GO

-- Catálogo de Tipos de Acceso / Roles
CREATE TABLE tipo_acceso (
    id_tipo_acceso INT PRIMARY KEY,
    descripcion_rol VARCHAR(50) NOT NULL
);
GO

INSERT INTO tipo_acceso (id_tipo_acceso, descripcion_rol) VALUES 
(1, 'Alumno'),
(2, 'Profesor'),
(3, 'Admin'),
(4, 'DBAAdmin');
GO


-- =====================================================
-- 2. TABLAS PRINCIPALES CON RELACIONES
-- =====================================================

-- Tabla de Materias (Relación M:1 con Carrera, Relación 1:M con Profesor)
CREATE TABLE materia (
    id_materia INT IDENTITY(1,1) PRIMARY KEY,
    nombre_materia VARCHAR(100) NOT NULL,
    creditos INT,
    id_carrera INT NOT NULL,
    id_profesor INT NULL,
    
    CONSTRAINT FK_materia_carrera FOREIGN KEY (id_carrera) 
        REFERENCES carrera(id_carrera),
        
    CONSTRAINT FK_materia_profesor FOREIGN KEY (id_profesor) 
        REFERENCES profesor(id_profesor)
);
GO

-- Tabla Intermedia (Relación M:N Alumno - Materia con Clave Primaria Compuesta)
CREATE TABLE alumno_materia (
    id_alumno INT NOT NULL,
    id_materia INT NOT NULL,
    fecha_inscripcion DATE NOT NULL DEFAULT GETDATE(),
    id_estado INT NOT NULL,
    
    CONSTRAINT PK_alumno_materia PRIMARY KEY (id_alumno, id_materia),
    
    CONSTRAINT FK_alumno_materia_alumno FOREIGN KEY (id_alumno) 
        REFERENCES alumno(id_alumno),
        
    CONSTRAINT FK_alumno_materia_materia FOREIGN KEY (id_materia) 
        REFERENCES materia(id_materia),
        
    CONSTRAINT FK_alumno_materia_estado FOREIGN KEY (id_estado) 
        REFERENCES estado_academico(id_estado)
);
GO

-- Tabla de Notas por Materia (Vinculada a la cursada del alumno)
CREATE TABLE alumno_materia_notas (
    id_nota INT IDENTITY(1,1) PRIMARY KEY,
    id_alumno INT NOT NULL,
    id_materia INT NOT NULL,
    calificacion DECIMAL(4,2) CHECK (calificacion BETWEEN 1 AND 10),
    fecha_evaluacion DATE NOT NULL DEFAULT GETDATE(),
    
    CONSTRAINT FK_notas_alumno_materia FOREIGN KEY (id_alumno, id_materia) 
        REFERENCES alumno_materia(id_alumno, id_materia)
);
GO

-- Documentación de Alumnos (Relación 1:M - Un alumno, muchos documentos)
CREATE TABLE documentacion_alumno (
    id_documento INT IDENTITY(1,1) PRIMARY KEY,
    id_alumno INT NOT NULL,
    tipo_documento VARCHAR(50) NOT NULL, 
    estado_entrega VARCHAR(20) NOT NULL CHECK (estado_entrega IN ('Pendiente', 'Entregado', 'Aprobado')),
    fecha_presentacion DATE NULL,
    
    CONSTRAINT FK_documentacion_alumno FOREIGN KEY (id_alumno) 
        REFERENCES alumno(id_alumno)
);
GO


-- =====================================================
-- 3. TABLAS DE ACCESOS Y SEGURIDAD
-- =====================================================

-- Accesos de Alumnos
CREATE TABLE acceso_alumno (
    id_acceso_alumno INT IDENTITY(1,1) PRIMARY KEY,
    id_alumno INT NOT NULL,
    usuario VARCHAR(50) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    id_tipo_acceso INT NOT NULL DEFAULT 1,
    ultimo_login DATETIME,
    
    CONSTRAINT FK_acceso_alumno FOREIGN KEY (id_alumno) REFERENCES alumno(id_alumno),
    CONSTRAINT FK_acceso_alumno_tipo FOREIGN KEY (id_tipo_acceso) REFERENCES tipo_acceso(id_tipo_acceso)
);
GO

-- Accesos de Profesores
CREATE TABLE acceso_profesores (
    id_acceso_profesor INT IDENTITY(1,1) PRIMARY KEY,
    id_profesor INT NOT NULL,
    usuario VARCHAR(50) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    id_tipo_acceso INT NOT NULL DEFAULT 2,
    ultimo_login DATETIME,
    
    CONSTRAINT FK_acceso_profesor FOREIGN KEY (id_profesor) REFERENCES profesor(id_profesor),
    CONSTRAINT FK_acceso_profesor_tipo FOREIGN KEY (id_tipo_acceso) REFERENCES tipo_acceso(id_tipo_acceso)
);
GO

-- Accesos de Administradores
CREATE TABLE acceso_administrador (
    id_acceso_admin INT IDENTITY(1,1) PRIMARY KEY,
    nombre_usuario VARCHAR(50) NOT NULL,
    usuario VARCHAR(50) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    id_tipo_acceso INT NOT NULL, 
    ultimo_login DATETIME,
    
    CONSTRAINT FK_acceso_admin_tipo FOREIGN KEY (id_tipo_acceso) REFERENCES tipo_acceso(id_tipo_acceso)
);
GO


USE GestionUniversitaria;
GO

-- Inserción de las tecnicaturas de la UTN Delta
INSERT INTO carrera (nombre_carrera, duracion_anios) VALUES 
('Tecnicatura Universitaria en Programación', 2),
('Tecnicatura Universitaria en Mantenimiento Industrial', 3),
('Tecnicatura Universitaria en Logística', 3),
('Tecnicatura Universitaria en Redes Eléctricas', 2);
GO

USE GestionUniversitaria;
GO

-- Inserción de profesores basados en científicos e inventores históricos
INSERT INTO profesor (nombre, apellido, email, edad, antiguedad_docente) VALUES 
('Alessandro', 'Volta', 'avolta@utndelta.edu.ar', 55, 20),      -- Ideal para Redes Eléctricas o Física
('Ada', 'Lovelace', 'alovelace@utndelta.edu.ar', 36, 10),      -- Ideal para Programación
('Nikola', 'Tesla', 'ntesla@utndelta.edu.ar', 60, 25),        -- Ideal para Redes Eléctricas / Mantenimiento
('Grace', 'Hopper', 'ghopper@utndelta.edu.ar', 58, 22),       -- Ideal para Programación / Sistemas
('Marie', 'Curie', 'mcurie@utndelta.edu.ar', 50, 18),         -- Ideal para Mantenimiento / Química
('Alan', 'Turing', 'aturing@utndelta.edu.ar', 41, 15);        -- Ideal para Programación
GO

USE GestionUniversitaria;
GO

-- Inserción de Materias vinculadas a Carreras y Profesores
INSERT INTO materia (nombre_materia, creditos, id_carrera, id_profesor) VALUES 
-- ==========================================
-- TECNICATURA UNIVERSITARIA EN PROGRAMACIÓN (id_carrera = 1)
-- ==========================================
('Programación I', 10, 1, 2),         -- Ada Lovelace
('Base de Datos I', 8, 1, 6),         -- Alan Turing
('Programación II', 10, 1, 4),        -- Grace Hopper
('Arquitectura y Sistemas Operativos', 6, 1, 6), -- Alan Turing

-- ==========================================
-- TECNICATURA EN MANTENIMIENTO INDUSTRIAL (id_carrera = 2)
-- ==========================================
('Matemática Aplicada', 8, 2, 5),     -- Marie Curie
('Conocimiento de los Materiales', 8, 2, 5), -- Marie Curie
('Elementos de Máquinas', 9, 2, 3),   -- Nikola Tesla
('Seguridad e Higiene Industrial', 6, 2, 5), -- Marie Curie

-- ==========================================
-- TECNICATURA UNIVERSITARIA EN LOGÍSTICA (id_carrera = 3)
-- ==========================================
('Principios de Administración', 6, 3, 4), -- Grace Hopper
('Logística I', 8, 3, 4),             -- Grace Hopper
('Estadística y Costos', 8, 3, 5),    -- Marie Curie
('Cadena de Abastecimiento', 8, 3, 4), -- Grace Hopper

-- ==========================================
-- TECNICATURA EN REDES ELÉCTRICAS (id_carrera = 4)
-- ==========================================
('Electrotecnia', 10, 4, 1),          -- Alessandro Volta
('Instalaciones y Máquinas Eléctricas', 10, 4, 3), -- Nikola Tesla
('Generación y Transmisión de Energía', 9, 4, 1), -- Alessandro Volta
('Mediciones Eléctricas', 7, 4, 1);   -- Alessandro Volta
GO

USE GestionUniversitaria;
GO

-- Inserción de 20 alumnos/as inspirados en deportistas destacados
INSERT INTO alumno (nombre, apellido, dni, legajo, email, edad) VALUES 
('Lionel', 'Messi', '28111222', 'LM-28111222', 'lmessi@utndelta.edu.ar', 39),
('Paula', 'Pareto', '30222333', 'PP-30222333', 'ppareto@utndelta.edu.ar', 40),
('Emanuel', 'Ginóbili', '25333444', 'EG-25333444', 'eginobili@utndelta.edu.ar', 48),
('Luciana', 'Aymar', '27444555', 'LA-27444555', 'laymar@utndelta.edu.ar', 48),
('Diego', 'Maradona', '12555666', 'DM-12555666', 'dmaradona@utndelta.edu.ar', 65),
('Gabriela', 'Sabatini', '20666777', 'GS-20666777', 'gsabatini@utndelta.edu.ar', 56),
('Juan Martín', 'del Potro', '32777888', 'JDP-32777888', 'jdelpotro@utndelta.edu.ar', 37),
('Maravilla', 'Martínez', '26888999', 'MM-26888999', 'mmartinez@utndelta.edu.ar', 49),
('Serena', 'Williams', '34999000', 'SW-34999000', 'swilliams@utndelta.edu.ar', 44),
('Michael', 'Jordan', '15000111', 'MJ-15000111', 'mjordan@utndelta.edu.ar', 63),
('Usain', 'Bolt', '33111000', 'UB-33111000', 'ubolt@utndelta.edu.ar', 39),
('Simone', 'Biles', '40222111', 'SB-40222111', 'sbiles@utndelta.edu.ar', 29),
('Novak', 'Djokovic', '31333222', 'ND-31333222', 'ndjokovic@utndelta.edu.ar', 39),
('Rebeca', 'Andrade', '42444333', 'RA-42444333', 'randrade@utndelta.edu.ar', 27),
('Carlos', 'Alcaraz', '45555444', 'CA-45555444', 'calcaraz@utndelta.edu.ar', 23),
('Aitana', 'Bonmatí', '44666555', 'AB-44666555', 'abonmati@utndelta.edu.ar', 28),
('Stephen', 'Curry', '36777666', 'SC-36777666', 'scurry@utndelta.edu.ar', 38),
('Kylian', 'Mbappé', '43888777', 'KM-43888777', 'kmbappe@utndelta.edu.ar', 27),
('Yulimar', 'Rojas', '39999888', 'YR-39999888', 'yrojas@utndelta.edu.ar', 30),
('Agustín', 'Pichot', '24000999', 'AP-24000999', 'apichot@utndelta.edu.ar', 51);
GO

USE GestionUniversitaria;
GO

-- =====================================================
-- 1. INSCRIPCIONES (Tabla M:N - alumno_materia)
-- Estados: 1 = Aprobado, 2 = Regular, 3 = Desaprobado
-- =====================================================
INSERT INTO alumno_materia (id_alumno, id_materia, fecha_inscripcion, id_estado) VALUES 
-- Lionel Messi (id_alumno = 1) cursando Programación (Carrera 1)
(1, 1, '2026-03-10', 1), -- Programación I (Aprobado)
(1, 2, '2026-03-10', 1), -- Base de Datos I (Aprobado)
(1, 3, '2026-08-10', 2), -- Programación II (Regular)

-- Paula Pareto (id_alumno = 2) cursando Mantenimiento Industrial (Carrera 2)
(2, 5, '2026-03-11', 1), -- Matemática Aplicada (Aprobado)
(2, 6, '2026-03-11', 1), -- Conocimiento de los Materiales (Aprobado)

-- Emanuel Ginóbili (id_alumno = 3) cursando Logística (Carrera 3)
(3, 9, '2026-03-12', 1),  -- Principios de Administración (Aprobado)
(3, 10, '2026-03-12', 2), -- Logística I (Regular)

-- Luciana Aymar (id_alumno = 4) cursando Redes Eléctricas (Carrera 4)
(4, 13, '2026-03-10', 1), -- Electrotecnia (Aprobado)
(4, 14, '2026-03-10', 3), -- Instalaciones y Máquinas Eléctricas (Desaprobado)

-- Diego Maradona (id_alumno = 5) cursando Programación (Carrera 1)
(5, 1, '2026-03-15', 3), -- Programación I (Desaprobado)

-- Simone Biles (id_alumno = 12) cursando Programación (Carrera 1)
(12, 1, '2026-03-10', 1), -- Programación I (Aprobado)
(12, 2, '2026-03-10', 1), -- Base de Datos I (Aprobado)

-- Carlos Alcaraz (id_alumno = 15) cursando Logística (Carrera 3)
(15, 9, '2026-03-12', 1), -- Principios de Administración (Aprobado)
(15, 11, '2026-03-12', 2); -- Estadística y Costos (Regular)
GO


-- =====================================================
-- 2. CALIFICACIONES / NOTAS (Tabla alumno_materia_notas)
-- Escala del 1 al 10 (vinculada a la cursada del alumno)
-- =====================================================
INSERT INTO alumno_materia_notas (id_alumno, id_materia, calificacion, fecha_evaluacion) VALUES 
-- Notas de Lionel Messi (id_alumno = 1)
(1, 1, 9.50, '2026-07-05'), -- Programación I
(1, 2, 8.00, '2026-07-08'), -- Base de Datos I
(1, 3, 7.50, '2026-11-20'), -- Programación II

-- Notas de Paula Pareto (id_alumno = 2)
(2, 5, 10.00, '2026-07-02'), -- Matemática Aplicada
(2, 6, 9.00, '2026-07-06'),  -- Conocimiento de los Materiales

-- Notas de Emanuel Ginóbili (id_alumno = 3)
(3, 9, 8.50, '2026-07-04'),  -- Principios de Administración
(3, 10, 6.50, '2026-11-15'), -- Logística I

-- Notas de Luciana Aymar (id_alumno = 4)
(4, 13, 8.00, '2026-07-01'), -- Electrotecnia
(4, 14, 3.50, '2026-07-10'), -- Instalaciones y Máquinas Eléctricas (Desaprobado)

-- Notas de Diego Maradona (id_alumno = 5)
(5, 1, 4.00, '2026-07-05'),  -- Programación I (Desaprobado)

-- Notas de Simone Biles (id_alumno = 12)
(12, 1, 10.00, '2026-07-05'), -- Programación I
(12, 2, 9.50, '2026-07-08'), -- Base de Datos I

-- Notas de Carlos Alcaraz (id_alumno = 15)
(15, 9, 7.00, '2026-07-04'), -- Principios de Administración
(15, 11, 8.20, '2026-11-18'); -- Estadística y Costos
GO

USE GestionUniversitaria;
GO

-- =====================================================
-- EJEMPLOS DE ACCESOS CON CONTRASEÑA EN TEXTO PLANO
-- =====================================================

-- 1. Acceso para un Alumno (Lionel Messi, id_alumno = 1)
-- El tipo_acceso 1 corresponde a 'Alumno'
INSERT INTO acceso_alumno (id_alumno, usuario, password_hash, id_tipo_acceso) 
VALUES (1, 'lmessi', '123456', 1);
GO

-- 2. Acceso para un Profesor (Alessandro Volta, id_profesor = 1)
-- El tipo_acceso 2 corresponde a 'Profesor'
INSERT INTO acceso_profesores (id_profesor, usuario, password_hash, id_tipo_acceso) 
VALUES (1, 'avolta', 'volta2026', 2);
GO

-- 3. Acceso para un Administrador / DBA (Walter Guerrero)
-- El tipo_acceso 4 corresponde a 'DBAAdmin' (o 3 para 'Admin')
INSERT INTO acceso_administrador (nombre_usuario, usuario, password_hash, id_tipo_acceso) 
VALUES ('Walter Guerrero', 'wguerrero', 'admin123', 4);
GO

