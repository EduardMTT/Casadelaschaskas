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

#Categoria creada por default
INSERT INTO categoria VALUES(NULL,'Extras');
/*INSERT INTO categoria VALUES(NULL,'Helados'),(NULL,'Snacks'),(NULL,'Paletas');
SELECT No_Producto,Producto,Tamaño,Precio,Imagen,FKNo_Categoria FROM categoria c LEFT JOIN productos p ON c.No_Categoria = p.FKNo_Categoria WHERE c.No_Categoria=2; 

DELETE FROM Categoria WHERE No_Categoria=9;
INSERT INTO Productos VALUES (NULL,'Palomitas','CHICA',24,'C:\Users\eduar\Desktop\Proyecto Casa de las Chaskas\Casadelaschaskas\CasaDeLasChaskas\bin\Debug\Imagenes\hacks.png',2);

TRUNCATE TABLE Productos;

SET FOREIGN_KEY_CHECKS = 1;*/


