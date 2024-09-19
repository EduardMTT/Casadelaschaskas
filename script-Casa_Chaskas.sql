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
	Precio DECIMAL NOT NULL,
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
	
INSERT INTO categoria VALUES(NULL,'Extras'),(NULL,'Topings'),(NULL,'Paletas');


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



/*SELECT 
v.Fecha, v.Cliente,
p.Producto, p.Precio, p.`Tamaño`,
dv.Cantidad_Producto, dv.Total
FROM detalles_ventas dv
JOIN venta v ON dv.FKID_Venta = v.ID
JOIN productos p ON dv.FKNo_Producto = p.No_Producto ORDER BY v.Fecha DESC;*/
SELECT * FROM registro_ventas;