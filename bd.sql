create database maxierp
character set utf8
collate utf8_spanish_ci;

use maxierp;

create table tipo_producto (
	codigo int not null AUTO_INCREMENT,
	nombre varchar(150) null,
	PRIMARY KEY(codigo)
) ENGINE=InnoDB;

create table producto (
	codigo int not null AUTO_INCREMENT,
	nombre varchar(150) null,
	descripcion varchar(255) null,
	marca varchar(100) null,
	stock int null,
	precio double null,
	cod_tipo_producto int not null,
	PRIMARY KEY(codigo),
	Foreign key(cod_tipo_producto) references tipo_producto(codigo)
	ON DELETE RESTRICT
	ON	UPDATE RESTRICT
) ENGINE=InnoDB;

create table usuario (
	codigo int not null AUTO_INCREMENT,
	nombre varchar(20) null,
	login varchar(20) null,
	pass varchar(64) null,
	apellidos varchar(100) null,
	direccion varchar(150) null,
	dni char(9) null,
	telefono char(12) null,
	admin bit null,
	PRIMARY KEY(codigo)
) ENGINE=InnoDB;

create table cliente (
	codigo int not null AUTO_INCREMENT,
	nombre varchar(100) null,
	apellidos varchar(100) null,
	direccion varchar(150) null,
	dni char(8) null,
	telefono char(12) null,
	PRIMARY KEY(codigo)
) ENGINE=InnoDB;

create table venta (
	codigo int not null AUTO_INCREMENT,
	cod_cliente int null,
	num_venta varchar(50) null,
	fecha DATETIME null,
	iva double null,
	PRIMARY KEY(codigo),
	Foreign key(cod_cliente) references cliente(codigo)
	ON DELETE RESTRICT
	ON	UPDATE RESTRICT
) ENGINE=InnoDB;

create table venta_producto (
	codigo int not null AUTO_INCREMENT,
	cod_venta int not null,
	cod_producto int not null,
	precio_unidad double null,
	cantidad int null,
	PRIMARY KEY(codigo),
	Foreign key(cod_venta) references venta(codigo)
	ON DELETE RESTRICT
	ON	UPDATE RESTRICT,
	Foreign key(cod_producto) references producto(codigo)
	ON DELETE RESTRICT
	ON	UPDATE RESTRICT
) ENGINE=InnoDB;


/*DATOS PRUEBA*/
INSERT INTO tipo_producto (nombre) VALUES ("Ordenadores"), ("Ratones"), ("Impresora");

INSERT INTO producto (nombre, descripcion, marca, precio, stock, cod_tipo_producto) VALUES 
			("Portatil MSI 62GLm-7REX", "ordenador portail","MSI" , 1050.5, 10, 1),
			("Portatil Asus 123", "ordenador portail asus","Asus" , 600, 0, 1),
			("impresora Epson 123", "impresora epson color/negro","Epson" , 50.99, 5, 3);
		
INSERT INTO usuario (nombre, login, pass, apellidos, direccion, dni, telefono, admin) VALUES 
			("Brais", "admin", "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918",  "Dominguez", "c/ principe 17", "36174071Q", "685945268", true),/* pass:  admin*/	
			("Paco", "paquito", "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918",  "Chocolatero", "c/ principe 17", "36174071Q", "698754859", 0);/* pass:  admin*/	

INSERT INTO cliente (nombre, apellidos, direccion, dni, telefono) VALUES 
			("Colegio Vivas", "", "c/ principe 17", "36174071Q", "986258458"),
			("Paco", "López", "c/ principe 17", "36174071Q", "698745896");
			
INSERT INTO venta (cod_cliente, num_venta, fecha, iva) VALUES 
			(1, "V-20190605-0001", now(),0.21),
			(2, "V-20190605-0002", now(),0.21);
			
INSERT INTO venta_producto (cod_venta, cod_producto, precio_unidad, cantidad) VALUES 
			(1, 1, 1050.5, 1),
			(1, 3, 50, 1),
			(2, 2, 600, 3);