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
	
CREATE TABLE Extras(
	No_Extra INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(50) NOT NULL,
	Precio INT NOT NULL,
	Imagen BLOB NOT NULL);
	
CREATE TABLE Detalles_Ventas(
	FKID_Venta INT NOT NULL,
	FKNo_Producto INT NOT NULL,
	FKNo_Extra INT,
	Cantidad_Producto INT NOT NULL,
	Cantidad_Extra INT NOT NULL,
	Total DECIMAL(10.5) NOT NULL,
	FOREIGN KEY(FKID_Venta) REFERENCES Venta(ID),
	FOREIGN KEY(FKNo_Producto) REFERENCES Productos(No_Producto),
	FOREIGN KEY(FKNo_Extra) REFERENCES Extras(No_Extra),
	CONSTRAINT Clave_Compuesta PRIMARY KEY(FKID_Venta,FKNo_Producto));

CREATE TABLE Frutas(
	No_Fruta INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(50) NOT NULL);
	
CREATE TABLE Sabores(
	No_Sabor INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(50) NOT NULL);
	
INSERT INTO categoria VALUES(NULL,'Helados'),(NULL,'Snacks'),(NULL,'Paletas');
SELECT No_Producto,Producto,Tamaño,Precio,Imagen,FKNo_Categoria FROM categoria c LEFT JOIN productos p ON c.No_Categoria = p.FKNo_Categoria WHERE c.No_Categoria=2; 

DELETE FROM Categoria WHERE No_Categoria=9;
-- Insertar 20 productos en la categoría número 3
INSERT INTO Productos (Producto, Tamaño, Precio, Imagen, FKNo_Categoria)
VALUES
('Producto1', 'Pequeño', 10.00, 'ruta/a/imagen1.jpg', 3),
('Producto2', 'Mediano', 15.00, 'ruta/a/imagen2.jpg', 3),
('Producto3', 'Grande', 20.00, 'ruta/a/imagen3.jpg', 3),
('Producto4', 'Pequeño', 11.00, 'ruta/a/imagen4.jpg', 3),
('Producto5', 'Mediano', 16.00, 'ruta/a/imagen5.jpg', 3),
('Producto6', 'Grande', 21.00, 'ruta/a/imagen6.jpg', 3),
('Producto7', 'Pequeño', 12.00, 'ruta/a/imagen7.jpg', 3),
('Producto8', 'Mediano', 17.00, 'ruta/a/imagen8.jpg', 3),
('Producto9', 'Grande', 22.00, 'ruta/a/imagen9.jpg', 3),
('Producto10', 'Pequeño', 13.00, 'ruta/a/imagen10.jpg', 3),
('Producto11', 'Mediano', 18.00, 'ruta/a/imagen11.jpg', 3),
('Producto12', 'Grande', 23.00, 'ruta/a/imagen12.jpg', 3),
('Producto13', 'Pequeño', 14.00, 'ruta/a/imagen13.jpg', 3),
('Producto14', 'Mediano', 19.00, 'ruta/a/imagen14.jpg', 3),
('Producto15', 'Grande', 24.00, 'ruta/a/imagen15.jpg', 3),
('Producto16', 'Pequeño', 15.00, 'ruta/a/imagen16.jpg', 3),
('Producto17', 'Mediano', 20.00, 'ruta/a/imagen17.jpg', 3),
('Producto18', 'Grande', 25.00, 'ruta/a/imagen18.jpg', 3),
('Producto19', 'Pequeño', 16.00, 'ruta/a/imagen19.jpg', 3),
('Producto20', 'Mediano', 21.00, 'ruta/a/imagen20.jpg', 3);

