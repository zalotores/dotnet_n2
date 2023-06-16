--Ejercicios Consultas SQL

--A partir de la base de datos DISCOS_DB te propongo que realices las siguientes consultas SQL a modo de práctica:

select* from DISCOS
select* from ESTILOS
select* from TIPOSEDICION

--1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, Estilo (no el id, sino la descripción).

select D.Titulo, D.FechaLanzamiento, E.Descripcion as Estilo from DISCOS D, ESTILOS E where D.idEstilo = E.Id

--2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 

insert into ESTILOS values ('Country')
insert into ESTILOS values ('Hip Hop')
insert into ESTILOS values ('Classic')

insert into TIPOSEDICION values ('Avi')

--3. Insertar al menos dos discos nuevos cargando correctamente su información.

insert into DISCOS values ('Dark Side of the Moon', '1973-03-01', 12, 'https://es.wikipedia.org/wiki/The_Dark_Side_of_the_Moon#/media/Archivo:The_Dark_Side_of_the_Moon_Cover.svg', 3, 1)
insert into DISCOS values ('Una y Mil Veces', '2005-06-26', 9, 'https://www.cmtv.com.ar/tapas-cd/pinonunaymil.webp', 5, 4)

--4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where.

update  DISCOS set FechaLanzamiento = '1973-03-25', CantidadCanciones = 10 where Id = 5

--5. Borrar un disco a elección.

delete from DISCOS where Id = 3

--6. Traer todos los estilos que estén asociados a algún disco.

select distinct E.Descripcion from DISCOS D, ESTILOS E where D.IdEstilo = E.Id

--7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).

select D.Titulo as Nombre, E.Descripcion as Estilo, T.Descripcion as Edicion from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id

--8. Traer todos los discos que contengan en su nombre la sílaba "ho".

select * from DISCOS where Titulo like '%ho%'

practico terminado