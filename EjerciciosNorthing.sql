---10 Muestra los 10 productos más caros ordenados de mayor a menor precio (usa
---TOP 10 y ORDER BY)
select top 10
	*
from Products
order by UnitPrice desc
go

---15. Muestra todos los pedidos que no tengan una región de envío especificada
---(ShipRegion IS NULL).
select 
*
from Orders
where ShipRegion is null --and OrderID > 10300
---ORDER BY OrderID asc

--PARA CONTAR CUANTOS HAY
--select 
--count (*) as Ordenes
--from Orders
--where ShipRegion is null

--Funciones Agregadas
--Que dan 1 solo resultado
--AVG -> Promedios
--MAX -> Máximo
--MIN -> Mínimo
--COUNT -> Contar
--SUM -> Acumular

--16. Calcula el precio promedio de todos los productos de la tabla Products.
select
avg(UnitPrice) as Prom
from Products

--17. Encuentra el precio del producto más caro y el del más barato (MAX y MIN).
select
--*
--avg(UnitPrice) as Prom,
Max(UnitPrice) maximo,
Min(UnitPrice) minimo
from Products

--20. Calcula el valor total del inventario multiplicando el precio unitario por las
--unidades en stock de cada producto (SUM(UnitPrice * UnitsInStock)).
select
	sum(UnitPrice* UnitsInStock)
	as valor_inventario_total
from Products

--29. Calcula el promedio de descuento (Discount) aplicado en la tabla Order Details.
select
avg(Discount) as promedioDescuento --round(avg(Discount),3) as promedioDescuento
from [Order Details]

--30. Suma el total de fletes pagados en todos los pedidos realizados a 'USA'.
select
	--ShipCountry,
	sum(ShipVia) as cantFacturadoUsa
from Orders
--where ShipCountry = 'USA'
--group by ShipCountry
--having  sum(ShipVia) > 100
--order by sum(ShipVia) desc