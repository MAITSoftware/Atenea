create database `Atenea`;
use `Atenea`;
create table `usuarios` (
	`ci` VARCHAR(8) NOT NULL PRIMARY KEY,
    `nombre` VARCHAR(10) NOT NULL,
    `apellido` VARCHAR(10) NOT NULL,
    `contraseña` VARCHAR(20) NOT NULL
);

create table `libros` (
	`título` VARCHAR(20) NOT NULL,
    `autor` VARCHAR(20) NOT NULL default '',
    `portada` LONGBLOB,
    `categoría` INT default 0,
    `id` VARCHAR(20) PRIMARY KEY NOT NULL);
    