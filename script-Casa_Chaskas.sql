DROP DATABASE Casa_de_las_Chaskas;
CREATE DATABASE Casa_de_las_Chaskas;
USE Casa_de_las_Chaskas;

CREATE TABLE Categoria(
	No_Categoria INT AUTO_INCREMENT PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL);
	
CREATE TABLE Productos (
    No_Producto INT AUTO_INCREMENT PRIMARY KEY,
    Producto VARCHAR(50),
    Tamaño VARCHAR(50),
    Precio DECIMAL(10,2),
    Imagen TEXT,
    Estatus VARCHAR(50),
    FKNo_Categoria INT,
    FOREIGN KEY(FKNo_Categoria) REFERENCES Categoria(No_Categoria)
);

	
CREATE TABLE Venta(
	ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	Fecha DATE NOT NULL, 
	Cliente VARCHAR(50) NOT NULL);
	
CREATE TABLE Detalles_Ventas(
	FKID_Venta INT NOT NULL,
	FKNo_Producto INT NOT NULL,
	Nombre_Producto VARCHAR(50),
	Cantidad_Producto INT NOT NULL,
	Total DECIMAL(10.5) NOT NULL,
	FOREIGN KEY(FKID_Venta) REFERENCES Venta(ID),
	FOREIGN KEY(FKNo_Producto) REFERENCES Productos(No_Producto),
	CONSTRAINT Clave_Compuesta PRIMARY KEY(FKID_Venta,FKNo_Producto));

CREATE TABLE Frutas(
	No_Fruta INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(50) NOT NULL);
	
CREATE TABLE Sabores(
	No_Sabor INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(50) NOT NULL);
CREATE TABLE Registro_Ventas (
	 ID INT PRIMARY KEY AUTO_INCREMENT,
    Fecha VARCHAR(80) NOT NULL,
    Cliente VARCHAR(255) NOT NULL,
    Producto VARCHAR(255) NOT NULL,
    Precio DOUBLE(10, 2) NOT NULL,
    Tamaño VARCHAR(50),
    Cantidad_Producto INT NOT NULL,
    Total DOUBLE(10, 2) NOT NULL
);
INSERT INTO categoria VALUES(NULL,'Snacks');
INSERT INTO categoria VALUES(NULL,'Extras');
INSERT INTO categoria VALUES(NULL,'Bebidas');
INSERT INTO categoria VALUES(NULL,'Nieves');
INSERT INTO categoria VALUES(NULL,'Paletas');
INSERT INTO categoria VALUES(NULL,'Frutas');
INSERT INTO categoria VALUES(NULL,'Chascas');

/*SET FOREIGN_KEY_CHECKS = 0;

TRUNCATE TABLE detalles_ventas;
TRUNCATE TABLE registro_ventas;
TRUNCATE TABLE venta;

SET FOREIGN_KEY_CHECKS = 1;*/
