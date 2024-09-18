DROP DATABASE Casa_de_las_Chaskas;
CREATE DATABASE Casa_de_las_Chaskas;
USE Casa_de_las_Chaskas;

CREATE TABLE Categoria(
	No_Categoria INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(50) NOT NULL);
	
CREATE TABLE Productos(
	No_Producto INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	Producto VARCHAR(50) NOT NULL,
	Tamaño VARCHAR(50) NOT NULL,
	Precio DECIMAL(10.5) NOT NULL,
	Imagen TEXT NOT NULL,
	FKNo_Categoria INT NOT NULL,
	FOREIGN KEY(FKNo_Categoria) REFERENCES Categoria(No_Categoria));
	
CREATE TABLE Venta(
	ID INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	Fecha DATE NOT NULL, 
	Cliente VARCHAR(50) NOT NULL);
	
CREATE TABLE Detalles_Ventas(
	FKID_Venta INT NOT NULL,
	FKNo_Producto INT NOT NULL,
	FKNo_Extra INT,
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
	
INSERT INTO categoria VALUES(NULL,'Extras'),(NULL,'Topings'),(NULL,'Paletas');
SELECT No_Producto,Producto,Tamaño,Precio,Imagen,FKNo_Categoria FROM categoria c LEFT JOIN productos p ON c.No_Categoria = p.FKNo_Categoria WHERE c.No_Categoria=2; 


SET FOREIGN_KEY_CHECKS = 1;


SELECT * FROM Productos;

