-- Parcial Practica

--PARTE 1: Creación de Base de Datos 
-- y Estructuras (DDL)

--Paso 1: Escriba la sentencia SQL para crear una base de datos con el nombre: 
-- Encuestas y selecciónela para su uso posterior (USE Encuestas;).
create database Encuestas
go

use Encuestas
go

--Paso 2: Escriba los scripts CREATE TABLE para cada tabla
--Tabla 1: marcas (Independiente)
create table marcas(
id int primary key identity(1,1),
nombre varchar(50) unique not null --unique=unico, no se repite
);
go

--Tabla 2: consultas (Dependiente)
create table consultas(
id int primary key identity(1,1),
nombre varchar(100) not null,
edad int not null,
gygas int not null,
id_marca int not null
);
go

--PARTE 2: Operaciones CRUD (DML)
--A partir de la estructura anterior, escriba las sentencias T-SQL solicitadas:
--	1. Inserción (CREATE): Registre dos marcas (Samsung y Motorola) y dos encuestas:
--		Persona 1: Carlos Gómez, 28 años, 15 gigas, ID marca: 1.
--		Persona 2: Lucía Pérez, 22 años, 50 gigas, ID marca: 2.

INSERT INTO marcas (nombre)
VALUES ('Samsung'),('Motorola')
go

INSERT INTO consultas (nombre, edad, gygas, id_marca)
VALUES ('Carlos Gomez', 28, 15, 1), 
('Lucía Pérez', 22, 50, 2)
go

--	2. Lectura (READ): Escriba un SELECT simple para listar todos los registros y campos de consultas.
SELECT * FROM marcas
go

SELECT * FROM consultas
go

--	3. Actualización (UPDATE): Modifique el consumo de gigas a 25 para el registro con ID 1.
UPDATE consultas
set gygas = 25
where id = 1
go
--set es setear un campo o cambiar

--	4. Borrado (DELETE): Elimine el registro de la encuesta cuyo ID sea 2.
DELETE consultas
where id = 2
go

--Parte 3: Consultas de Selección y Filtros Avanzados
--A. Filtros y Operadores Lógicos
--	1. Comparación y AND: Listar nombre, edad y gigas de los encuestados que 
--	tengan más de 25 años (> 25) y consuman más de 20 gigas (> 20).
SELECT nombre, edad, gygas
FROM consultas
where edad>25 AND gygas>20
go

--	2. Operador BETWEEN: Mostrar todos los datos de los encuestados cuya edad esté entre 20 y 30 años inclusive.
SELECT * FROM consultas
where edad BETWEEN 20 and 30
go

--	3. Operador IN: Listar las encuestas de aquellos usuarios cuyo id_marca sea 1, 3 o 4.
SELECT * FROM consultas
where id_marca IN (1,3,4)
go

--	4. Operador LIKE: Devolver el nombre y la edad de las personas cuyo nombre comience con la letra 'C'.
SELECT nombre, edad FROM consultas
where nombre LIKE 'C%'
go

--	5. Operador OR: Listar las encuestas de quienes tengan menos de 
--	20 años (< 20) o consuman exactamente 50 gigas (= 50).
SELECT * FROM consultas
where edad < 20 OR gygas = 50
go

--B. Funciones de Agregación Globales (Sin GROUP BY)
--Nota: Realice las siguientes operaciones de cálculo sobre la totalidad de la tabla sin agrupar.
--	6. COUNT: Escriba una consulta que devuelva la cantidad total de encuestas realizadas.
SELECT COUNT(*)
FROM consultas
go
--Para ver cuantas ID hay en los registros

--	7. SUM: Escriba una consulta que calcule la suma total de gigas consumidos por todos los encuestados.
SELECT SUM(gygas)
FROM consultas
go

--	8. AVG: Escriba una consulta que calcule el promedio de edad de las personas encuestadas.
SELECT AVG(edad) as PromEdad --con nombre de "PromEdad"
FROM consultas
go

--	9. MAX y MIN: Escriba una consulta que obtenga, en una misma sentencia, la edad máxima y la edad mínima registrada.
SELECT MAX(edad) as Viejo, MIN(edad) as Joven
FROM consultas
go

--Elimina la tabla completa
DROP TABLE consultas
go