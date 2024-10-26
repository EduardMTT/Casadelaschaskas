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

INSERT INTO Categoria VALUES(NULL, 'helado');
SELECT * FROM Categoria;

SELECT * FROM productos;

/*INSERT INTO categoria VALUES(NULL,'Helados'),(NULL,'Paletas'),(NULL,'SNACKS'),(NULL,'EXTRAS');

-- Insertar productos en la categoría de Helados (ID de categoría = 1)
/*INSERT INTO Productos (Producto, Tamaño, Precio, Imagen, FKNo_Categoria) 
VALUES 
('Helado de Vainilla', 'Grande', 2.50, '', 1),
('Helado de Chocolate', 'Mediano', 2.00, '', 1),
('Helado de Fresa', 'Pequeño', 1.75, '', 1),
('Helado de Mango', 'Grande', 2.50, '', 1),
('Helado de Limón', 'Mediano', 2.00, '', 1);

-- Insertar productos en la categoría de Paletas (ID de categoría = 2)
INSERT INTO Productos (Producto, Tamaño, Precio, Imagen, FKNo_Categoria) 
VALUES 
('Paleta de Nuez', 'Grande', 1.50, '', 2),
('Paleta de Fresa', 'Mediana', 1.25, '', 2),
('Paleta de Chocolate', 'Grande', 1.50, '', 2),
('Paleta de Coco', 'Pequeña', 1.00, '', 2),
('Paleta de Mango', 'Mediana', 1.25, '', 2);

-- Insertar productos en la categoría de SNACKS (ID de categoría = 3)
INSERT INTO Productos (Producto, Tamaño, Precio, Imagen, FKNo_Categoria) 
VALUES 
('Papas Fritas', 'Grande', 1.50, '', 3),
('Churros', 'Mediano', 1.25, '', 3),
('Maní Salado', 'Pequeño', 1.00, '', 3),
('Galletas de Chocolate', 'Grande', 1.75, '', 3),
('Nachos con Queso', 'Mediano', 2.00, '', 3);

-- Insertar productos en la categoría de EXTRAS (ID de categoría = 4)
/*INSERT INTO Productos (Producto, Tamaño, Precio, Imagen, FKNo_Categoria) 
VALUES 
('Topping de Chocolate', 'Pequeño', 0.50, '', 4),
('Topping de Fresa', 'Pequeño', 0.50, '', 4),
('Topping de Nuez', 'Pequeño', 0.75, '', 4),
('Topping de Coco', 'Pequeño', 0.50, '', 4),
('Salsa de Caramelo', 'Mediano', 1.00, '', 4);



/*SELECT 
v.Fecha, v.Cliente,
p.Producto, p.Precio, p.`Tamaño`,
dv.Cantidad_Producto, dv.Total
FROM detalles_ventas dv
JOIN venta v ON dv.FKID_Venta = v.ID
JOIN productos p ON dv.FKNo_Producto = p.No_Producto ORDER BY v.Fecha DESC;*/
SELECT SUM(Total) FROM registro_ventas WHERE Fecha='2024-09-18';
SELECT * FROM registro_ventas;

SET FOREIGN_KEY_CHECKS = 0;

TRUNCATE TABLE detalles_ventas;
TRUNCATE TABLE registro_ventas;
TRUNCATE TABLE venta;

SET FOREIGN_KEY_CHECKS = 1;

SELECT v.Fecha, v.Cliente,
       p.Producto, p.Precio, p.Tamaño,
       dv.Cantidad_Producto, dv.Total
FROM detalles_ventas dv
JOIN venta v ON dv.FKID_Venta = {ID} -- Sustituir {ID} por el valor correcto
JOIN productos p ON dv.FKNo_Producto = p.No_Producto
WHERE v.Cliente = '{venta.Cliente}';
