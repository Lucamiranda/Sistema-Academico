CREATE DATABASE SISTEMA_ACADEMICO;

USE sistema_academico;

CREATE TABLE tblPeriodos(

perid int not null PRIMARY KEY,
pernome varchar (50) not null, 
persigla varchar (5)

)

CREATE TABLE tblCursos(
curid int not nulL PRIMARY KEY,
curnome varchar (50) not null,
cursigla varchar (25) not null,
curobservacao varchar (500) null,
perid int not null,
FOREIGN KEY (perid) REFERENCES tblperiodos(perid),
)

CREATE TABLE tblDisciplinas(
disid int not null PRIMARY KEY,
disnome varchar(50) not null, 
dissigla varchar(25) not null,
disobervacao varchar(500) null,
)

CREATE TABLE tblDisciplinaCurso(
curid int not null,
disid int not null,
PRIMARY KEY(curid, disid),
FOREIGN KEY (curid) REFERENCES tblCursos(curid),
FOREIGN KEY (disid) REFERENCES tblDisciplinas(disid),
)


