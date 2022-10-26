--Crea la base de datos planilla
create database DB_Planillas_Corp

----- Usar la base de datos 

use DB_Planillas_Corp 

----------------------------------
-- Se crea la tabla empleados

create table Empleados( ---- se crea la tabla empleados y sus 5 respectivos atributos con la PK Cedula
Cedula Bigint primary key,
Nombre varchar (25) Not null,
Apellidos varchar (80) Not Null,
Direccion varchar (80) Not Null,
Telefono varchar (15) Not Null,
)

create table Planilla( ---- se crea la tabla Planilla y sus 5 respectivos atributos con la PK tipo_empleado y con una llave foranea cedula
tipo_empleado Bigint primary key,  --- otra opcion es ponerla es poner este campo varchar, para este caso la deje Bigint
Salario_base int Not null, 
Comision int  Not Null,
Cantidad_ventas int  Not null,
Monto_ventas int  Not null,
Cedula bigint foreign key (cedula) references Empleados (Cedula) not null --- se crea la llave foranea Cedula de la tabla empleados
)


--- DML ---------

-- ----Insert 1 registro en cada tabla ( Empleados - Planilla)

insert into Empleados(Cedula,Nombre,Apellidos,Direccion,Telefono) --- se realiza la inclusion de 1 registro y sus respectivos campos
values(110960132,'Erick','Herrera','Barva Heredia','70177307') -- se ingresan los registros.

insert into Planilla(tipo_empleado,Salario_base,Comision,Cantidad_ventas,Monto_ventas,Cedula) --- se realiza la inclusion de 1 registro y sus respectivos campos
values(1111,500000,10,4,200000,110960132) -- se ingresan los registros.


--- DQL --------- Se consulta la base de datos empleados

select * from Empleados -- se realiza una consulta para verificar que se incluyeron los registros.
select * from Planilla  -- se realiza una consulta para verificar que se incluyeron los registros.


--delete  Planilla -- para borrar registros.
--delete  Empleados -- para borrar registros.