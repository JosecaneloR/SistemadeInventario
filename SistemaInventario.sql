Create DATABASE Inventario;
use Inventario;

CREATE TABLE Usuarios
(
	nombre varchar(25) not null,
	apellido varchar(35) not null,
	nombre_usuario varchar(25) PRIMARY KEY,
	contrasena varchar(20) not null,
	roll_de_usuario varchar(13) not null
);
INSERT INTO Usuarios VALUES
('José Ignacio', 'Canelo Rodríguez', 'josecanelo28', 'Canelo0228', 'Administrador'),
('Yangel', 'Garcia', 'PO123', '123', 'Administrador'),
('Luis Miguel', 'Polanco', 'LuisM', '456', 'Estandar');

SELECT * FROM Usuarios

CREATE TABLE PRODUCTOS
(
	Codigo_producto int Primary Key,
	Descripcion_producto varchar(30),
	Cantidad_producto int,
	Precio_unitario float
);

SELECT * FROM PRODUCTOS
INSERT INTO PRODUCTOS VALUES(34032, 'Hola', 3, 45);

CREATE PROCEDURE sp_InsertarProductos
	@Codigo_producto int,
	@Descripcion_producto varchar(30),
	@Cantidad_producto int,
	@Precio_unitario float
AS
BEGIN
	INSERT INTO PRODUCTOS (Codigo_producto, Descripcion_producto, Cantidad_producto, Precio_unitario)
	SELECT @Codigo_producto, @Descripcion_producto, @Cantidad_producto, @Precio_unitario
END

CREATE PROCEDURE sp_ModificarProductos
	@Codigo_producto int,
	@Descripcion_producto varchar(30),
	@Cantidad_producto int,
	@Precio_unitario float
AS
BEGIN
	UPDATE PRODUCTOS
	SET 
	Codigo_producto = @Codigo_producto,
	Descripcion_producto = @Descripcion_producto,
	Cantidad_producto = @Cantidad_producto,
	Precio_unitario = @Precio_unitario
	WHERE Codigo_producto = @Codigo_producto
END

CREATE PROCEDURE sp_EliminarProductos
	@Codigo_producto int
AS
BEGIN
	DELETE FROM PRODUCTOS
	WHERE Codigo_producto = @Codigo_producto
END;

SELECT * FROM PRODUCTOS



CREATE PROCEDURE sp_RegistrarVenta
	@Cantidad_vendida int,
	@Codigo_producto int
As
Begin
UPDATE PRODUCTOS
	SET
	Cantidad_producto = Cantidad_producto - @Cantidad_vendida
	WHERE Codigo_producto = @Codigo_producto
END
SELECT * FROM PRODUCTOS
exec sp_RegistrarVenta '2', '12134';

CREATE TABLE VENTAS
(
	Codigo_producto int Primary Key,
	Descripcion_producto varchar(30),
	Cantidad_disponible int,
	precio int,
	Cantidad_vendida int,
	Total_vendido int
);

INSERT INTO VENTAS
VALUES('30420', 'Pan', '3','10', '18', 18 * 10),
('27019', 'Refresco', '8', '90', '13', 13*90),
('13079', 'Fruta', '34', '25', '23', 25*23),
('00006', 'Pasta', '12', '34', '21', 21*34)
;

SELECT * FROM VENTAS
SELECT * FROM Usuarios