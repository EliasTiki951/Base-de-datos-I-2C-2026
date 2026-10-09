CREATE DATABASE Tikinidas
go

use Tikinidas
go

-- Esto es comentario 
create table Jugadores(
id int primary key identity(1,1), 
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Edad int null
);
go

--Borra toda la tabla
DROP TABLE Jugadores;

create table Jugadores(
id int primary key identity(1,1), 
P_Nombre varchar(50) not null,
S_Nombre varchar(50) not null,
Apellido varchar(50) not null,
Edad int null
);
go

INSERT INTO Jugadores (P_Nombre, S_Nombre, Apellido, Edad)
VALUES ('Auto','Dariel', 'Timoneco', 32);
go

INSERT INTO Jugadores (P_Nombre, S_Nombre, Apellido, Edad)
VALUES ('Saulo','Santo', 'Timoneco', 32);
go

SELECT * FROM Jugadores;
go