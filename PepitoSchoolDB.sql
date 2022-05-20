create database PepitoSchoolDB

go

use PepitoSchool

create table Estudiante(
	id int primary key identity(1,1),
	nombres varchar(40) not null,
	apellidos varchar(40) not null,
	carnet varchar (12) not null,
	phone varchar(16) not null,
	direccion varchar(200) not null,
	correo varchar(100) not null,
	matematica int not null,
	contabilidad int not null,
	programacion int not null,
	estadistica int not null
)