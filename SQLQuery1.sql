CREATE DATABASE Tikinidas
go

--use Tikinidas
--go

-- Esto es comentario 
create table Jugadores(
id int primary key identity(1,1), 
nombre varchar(50) not null,
apellido varchar(50) not null,
edad int null
);