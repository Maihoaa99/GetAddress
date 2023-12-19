create database websiteTMDT
go
use websiteTMDT
go

create table cities 
(
	Id uniqueidentifier primary key default newId(),
	code int,
	[name] nvarchar(150)
)

create table district
(
	Id uniqueidentifier primary key default newId(),
	code int,
	[name] nvarchar(150),
	city_id uniqueidentifier foreign key references cities(Id)
)

create table communes
(
	Id uniqueidentifier primary key default newId(),
	code int,
	[name] nvarchar(150),
	district_id uniqueidentifier foreign key references district(Id)
)