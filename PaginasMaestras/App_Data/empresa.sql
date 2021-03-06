Use Master;

if exists(Select * FROM SysDataBases WHERE name='Empresa')
BEGIN
	DROP DATABASE Empresa
END
go

create database Empresa 
on(
	name = 'Empresa',
	filename = 'c:\Empresa.mdf'
)
go

USE  Empresa
go

CREATE TABLE  Empleados (
	 cedula   int  NOT NULL PRIMARY KEY,
	 pass varchar(50),
	 nombre   varchar (50) NULL
)
go

CREATE TABLE Asalariados(
	cedula int PRIMARY KEY FOREIGN KEY References Empleados (cedula),
	sueldo float
)
go

CREATE TABLE Jornaleros(
	cedula int PRIMARY KEY FOREIGN KEY References Empleados (cedula),
	horas int
)
go


INSERT INTO   Empleados (cedula, nombre, pass) VALUES(1111111,'Lia I','11');
INSERT INTO   Empleados (cedula, nombre, pass) VALUES(2222222,'Mia II','22');
INSERT INTO   Empleados (cedula, nombre, pass) VALUES(3333333,'Rosa III','33');
INSERT INTO   Empleados (cedula, nombre, pass) VALUES(4444444,'Juan IV','44');
INSERT INTO   Empleados (cedula, nombre, pass) VALUES(5555555,'Ana V','55');
go

INSERT INTO Asalariados VALUES (1111111, 12000)
INSERT INTO Asalariados VALUES (2222222, 14000)

INSERT INTO Jornaleros VALUES (3333333, 100)
INSERT INTO Jornaleros VALUES (4444444, 150)
INSERT INTO Jornaleros VALUES (5555555, 200)
go

CREATE PROC LogueoAsalariado
@cedula int,
@pass varchar(50)
AS
begin
	SELECT * FROM Empleados e INNER JOIN Asalariados a ON e.cedula = a.cedula
		WHERE e.cedula = @cedula AND e.pass = @pass
end
go

CREATE PROC LogueoJornalero
@cedula int,
@pass varchar(50)
AS
begin
	SELECT * FROM Empleados e INNER JOIN Jornaleros j ON e.cedula = j.cedula
		WHERE e.cedula = @cedula AND e.pass = @pass
end
go

exec LogueoJornalero 3333333,33