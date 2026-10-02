-- Insertar datos DML
insert into Jugadores
(nombre, apellido, edad)
values ('Eli', 'Tiquicala', 23)

insert into Jugadores
(nombre, apellido, edad)
values ('Algo', 'Tiqui', 24)

select * from Jugadores
go

select nombre from Jugadores
go

delete Jugadores
where id>1