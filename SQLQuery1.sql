CREATE DATABASE NaturVida
USE NaturVida

--Vendedores
CREATE TABLE Vendedores(
Codigo INT PRIMARY KEY,
Usuario VARCHAR(15),
Contraseña VARCHAR(250),
Nombre VARCHAR(50),
)
--Parte Facturacion
CREATE TABLE Factura(
IdFactu INT IDENTITY(1,1) PRIMARY KEY,
Fecha DATE,
Documento_Cliente INT,
Codigo_Vendedor INT

FOREIGN KEY (Documento_Cliente) REFERENCES Cliente (Documento),
FOREIGN KEY (Codigo_Vendedor) REFERENCES Vendedores (Codigo)
)

--Parte Cliente
CREATE TABLE Cliente(
Documento INT PRIMARY KEY,
Nombre Varchar(250),
Direccion Varchar(250),
Telefono varchar(10),
Correo Varchar(250) UNIQUE
)

CREATE TABLE Productos(
Codigo INT PRIMARY KEY,
Descripción VARCHAR(50),
Valor_Unidad INT,
Cantidad INT
)

--Factura detalle
CREATE TABLE Factura_Detalle(
Id INT IDENTITY(1,1) PRIMARY KEY,
Numero_Factura INT,
Codigo_Productos INT,
Cantidad INT,
Valor_Unidad INT

FOREIGN KEY (Numero_Factura) REFERENCES Factura(IdFactu),
FOREIGN KEY (Codigo_Productos) REFERENCES Productos (Codigo)
)

CREATE TABLE Factura(
IdFactu INT IDENTITY(1,1) PRIMARY KEY,
Fecha DATE,
Documento_Cliente INT,
Codigo_Vendedor INT

FOREIGN KEY (Documento_Cliente) REFERENCES Cliente (Documento),
FOREIGN KEY (Codigo_Vendedor) REFERENCES Vendedores (Codigo)
)
-- Datos

INSERT INTO Vendedores VALUES -- Contraseña admin es admin
(1212,'admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Eladmin'),
(1542,'Carlos1995','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Carlos Andres Lopez Rodriguez'),
(4584,'Luis1805','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Luis Fernando Rojas Rojas'),
(8574,'AnaR7','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Ana Milena Robles Lopez'),
(1365,'Andre85','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Andres Felipe Jerez'),
(7586,'Lupita22','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Guadalupe Anaya Rojas');

INSERT INTO Cliente Values
(14100142,'José Dante Amato Martínez','Cra. 17 #12 # 13, Bucaramanga','3124578912',
'Josedante12@gmail.com'),
(16421785,'Juan Miguel Abdo Francis','Cra. 35 ##52- 69, Bucaramanga, Santander','3209378645',
'Abdoju17@gmail.com'),
(19873048,'Jose Francisco Perez',' Cl. 33 #21-15, Floridablanca, Santander','3144123783',
'Josefran@outlook.com'),
(22479990,'Pablo Daniel Schwarz ','Cl. 33 ##29 - 64, Bucaramanga, Santander','3227278568',
'PabloDniel23@gmail.com'),
(22516311, 'Eduardo Julio Piriz','Cl. 50 ##27a - 59, Bucaramanga, Santander','3004569321',
'EduardoPiriz@gmail.com'),
(22528066,'Gerardo Prospero','Cl. 8N#3 ##130, Piedecuesta, Santander','3118967544',
'Gerardo2403@gmail.com'),
(23452786,'María Lucinda Aguirre Cruz','Samanes #30-116, Las Mercedes,
Bucaramanga','3112234578', 'Maria672@hotmail.com'),
(32651141,'Rosa Cristina Lenzner','Carrera 18_18-05, San Gil, Santander','3145671200',
'Rosa0101@hotmail.com'),
(32668195,'Ricardo Elpidio Costa','Cl. 32 ## 30-15, Bucaramanga, Santander','3227568982',
'Ricardo234@gmail.com'),
(32789559,'Efrain Andres Cabrera','Cl. 37 ##3-16, Bucaramanga, Santander','3214567432',
'Efrainandres02@gmail.com'),
(32890499,' Nicolari Raquel Elizabet','Cl. 54 N, Bucaramanga, Santander','3152123458',
'RaquelElizabet@hotmail.com'),
(34879675,' Herlaynne Segura Jiménez','Cra. 34 ##18-05, Bogotá, Cundinamarca','3118459351',
'Herlay2002@gmail.com'),
(55224208,'Boris Silvestre Funtes','Cra. 10 #No 6-84, San Gil, Santander','3227189456',
'Borissill@outlook.com'),
(56783241,'Claudia Marcela Martinez Galvis','Cra. 24 #898, Bucaramanga,
Santander','3226785251', ' Claudiamar@hotmail.com'),
(72043455,'Jose Bartolome Madera','Cra. 19 #1242, Bucaramanga, Santander','3209897567',
'Bartolome2345@gmail.com'),
(72181696,'María Cristina Barreiro ','Dg. 105 ##29a-30, Bucaramanga,
Santander','3116789564', 'Cristinamaria45@hotmail.com'),
(73156765,'Francisco Javier Álvarez Leffmans','Cra. 17C ##55-44 Apto 306, Bucaramanga,
Santander','3207689645', 'Leffjavier@gmail.com'),
(80845402,'Daniel Carlos Blanco','Cra. 31 #53-35, Bucaramanga, Santander','3126789560',
'Danielcarlo09@gmail.com'),
(785675423,'Rodolfo Barragán García','Cra. 40 #4863, Bucaramanga','3209298634',
'Rodolbarragan@hotmail.com'),
(1067452691,'Reinaldo Narvaez','Cra. 24 ##101 79, Bucaramanga','3227135894',
'reinald_34@hotmail.com'),
(1075475921,'María Del Carmen Amigo Castañeda','Cra. 20 #22-78, Bucaramanga,
Santander','3124578458', 'Maria0202outlook.com'),
(1095475238,'Maria Victoria Higuita Otero','Cra. 24 ## 17 - 61, Bucaramanga,
Santander','3124567836', 'Maria1700@gmail.com'),
(1097456324,'Juan Fernando Uribe','Carrera 3 ##3-18 Floridablanca, Santander','3226754560',
'juanjuribe33@gmail.com'),
(1097563281,'José Ferdusi Avalos Romero','Cra. 32 ##33-36, Bucaramanga,
Santander','3227459369', 'Jos2407@outlook.com'),
(1098456743,'Pablo Álvarez Maldonado','Cl. 12 ## 10, Bucaramanga, Santander','3004567983',
'Alvarez03@outlook.com'),
(1098830652,'Oscar Andres Cardenas Garces','Cra. 34 ## 48 - 93, Bucaramanga,
Santander','3117683071', 'Osandres@gmail.com'),
(1098839567,'Arturo Ángeles','Calle 37 No. 26-15Apto 203D, Bucaramanga,
Santander','3156734897', 'Arturoaaa@gmail.com'),
(1129509728,'Winston Franklin Beloqui','Carrera 9#12-34, Lebrija, Santander','3007865432',
'Wfranflin23@hotmail.com'),
(1129572839,'Juan Carlos Perez','Cra. 27 #18-45, Bucaramanga, Santander','3105678451',
'Juanccc@outlook.com'),
(1297455327,'Maria Ines Abadie Fossatti','Tv. 29 #104-112, Bucaramanga,
Santander','3126754324', 'Mariaines02@gmail.com')

INSERT INTO Productos VALUES
(2695,'Castalo de Indias Tabletas 1.500gr',4500,8),
(2570,'Antax jarabe 360ml',35700,6),
(2341,'Arnica gotas 90gr',15000,10),
(2822,'Sangre de dragon crema 60gr',12000,5),
(2343,'Mieltertos Jarabe 250ml',18000,4),
(2966,'Ice Gel Crema 110gr',10000,11),
(2857,'Miesterto Sobre 14gr',1500,40),
(2148,'Arnica Crema 60gr',8000,7),
(2739,'Finacid Jarabe 360ml',24500,7),
(3089,'Calendula Jarabe 240ml',18000,4),
(3312,'Labfarve Hojas de Tomate Jarabe 120ml',14200,6),
(3695,'labfarve Ortiga Gotas 60ml',13400,10),
(3404,'Arandano Capsulas 400mg',20000,9),
(3564,'Extracto de Ruibarbo Gotas 60ml',14600,11),
(3681,'Faroliva Aceite de olivia Lata 140ml',10000,8),
(3731,'Faroliva Aceite de olivia Botella 500ml',25000,5),
(3891,'Botanitas Miel de abeja Botella 340gr',14400,6),
(3956,'Prostafort Forte Capsula 160gr', 23500,4),
(4075,'Curcuma Botella 50gr',14000,8),
(4151,'Meta mucil Polvo 175gr',1200,4),
(4232,'Raizarrilla Plus Jarabe 360ml',18400,10),
(4453,'Propomielito Jarabe 350ml',16400,12),
(4456,'Passiflora Gotas 60ml',8000,24),
(4865,'Ovix: Gotas 80ml',11600,12),
(4639,'Valeriana Officinalis L Gotas 60ml',8000,14),
(4742,'Glucosamina mix Caja 1.500gr',40800,5),
(4808,'Green Marihuana Grema 20gr',24000,10),
(0659,'Chais Caja 20 Bolsas', 25000, 15),
(1010,'Chang: Botellas 12 oz', 19000, 25),
(0120,'Jarabe de anís Botella 550 ml',10000, 12),
(0046,'Mishi Kobe Niku Paquete 500g',97000, 17),
(4008,'Ikura Botella 200 ml', 31000, 55),
(5455, 'Queso Cabrales Caja 1 kg.', 21050, 36),
(2501,'Konbu Cajas de 2 kg', 45000, 20),
(3562,'Tofu Paquetes 100 g.', 23500, 66),
(0254, 'Genen Shouyu Botellas 250 ml', 15500, 46),
(0251, 'Pavlova Cajas 500 g', '64500', 19),
(0911, 'Alice cordero Latas 1 kg', 39000, 350),
(0245, 'Carnarvon Tigers Paqetes de 16 kg.', 62500, 100),
(8021, 'Gustaf ́s Knäckebröd 24 Paquetes - 500 g.', 21000,82),
(1021, 'Tunnbrod 12 Paquetes - 250 g.', 9000, 3)

--Tabla producto Procedimientos Almacenados

--INSERTAR
CREATE PROC SP_INSERTARPRODUCT
@Codigo INT,
@Descri VARCHAR(30),
@ValUnd INT,
@Cantida INT
AS
INSERT INTO Productos VALUES(@Codigo,@Descri,@ValUnd,@Cantida)

--ACTUALIZAR
CREATE PROC SP_ACTUALIZARPROD
@Cod INT,
@CodNew INT, 
@Descri VARCHAR(30),
@ValUnd INT,
@Cant INT
AS
UPDATE Productos SET Codigo =@CodNew, Descripción = @Descri, Valor_Unidad = @ValUnd,Cantidad = @Cant
WHERE Codigo = @Cod

--ELIMINAR
CREATE PROC SP_ELIMINARPROD
@Cod INT 
AS
DELETE Productos
WHERE Codigo = @Cod

--Tabal Clientes Procedimientos Almacenados

--INSERTAR
CREATE PROC SP_INSERTARCLIENT
@Docu INT,
@Nombre VARCHAR(250),
@Direccion VARCHAR (250),
@Tel VARCHAR(10),
@Corr VARCHAR(250)
AS
INSERT INTO Cliente VALUES(@Docu,@Nombre,@Direccion,@Tel,@Corr)

--ACTUALIZAR
CREATE PROC SP_ACTUALCLIENT
@Docu INT,
@DocuNew INT,
@Nombre VARCHAR(250),
@Direccion VARCHAR (250),
@Tel VARCHAR(10),
@Corr VARCHAR(250)
AS
UPDATE Cliente SET Documento = @DocuNew,Nombre = @Nombre,Direccion = @Direccion,Telefono = @Tel,Correo = @Corr
WHERE Documento = @Docu

--ELIMINAR
CREATE PROC SP_ELIMINARCLIENT
@Docu INT
AS
DELETE Cliente
WHERE Documento = @Docu

--Tabla Factura y Factura detalle

	CREATE PROC SP_AGGFACT
	@Fech DATE,
	@DoClient INT,
	@CodVende INT
	AS
	INSERT INTO Factura VALUES(@Fech,@DoClient,@CodVendE)

	CREATE PROC SP_AGGFACTDETA
	@IDFac INT,
	@CodProd INT,
	@Cant INT,
	@ValUnidad INT
	AS
	INSERT INTO Factura_Detalle VALUES(@IDFac,@CodProd,@Cant,@ValUnidad)


--Descontar cantidades

	CREATE PROC SP_DESCONTARCANT
	@Codprod INT,
	@Cantidad INT
	AS
	UPDATE Productos SET Cantidad = Cantidad - @Cantidad
	WHERE Codigo = @Codprod

-- Parte inventarios


CREATE PROC SP_BUSCARINVENTARIO
@Prod INT
AS
SELECT P.Descripción,P.Cantidad,SUM(F.Cantidad) AS 'Vendido' FROM Factura_Detalle AS F
JOIN Productos AS P on F.Codigo_Productos = P.Codigo
where P.Codigo = @Prod GROUP BY P.Descripción,P.Cantidad

CREATE PROC SP_BUSCARINVENTARIOS
AS
SELECT P.Descripción,P.Cantidad,SUM(F.Cantidad) AS 'Vendido' FROM Factura_Detalle AS F
JOIN Productos AS P on F.Codigo_Productos = P.Codigo
GROUP BY P.Descripción,P.Cantidad



-----------------------------
create proc MostrarClientes
as
select*from Cliente
go
-------------------proc de vendedores
create proc MostrarVendores
as
select*from Vendedores
go


create proc BuscarVendores
@Codigo int
as
select * from Vendedores WHERE Codigo=@Codigo
go

CREATE PROC SP_INSERTARVENDORES
@Codigo INT,
@Usuario VARCHAR,
@Contraseña Varchar,
@Nombre varchar
AS
INSERT INTO Vendedores VALUES (@Codigo,@Usuario,@Contraseña,@Nombre)

--ACTUALIZAR

CREATE PROC SP_ACTUALIZARVENDORES
@Codigo INT,
@Usuario VARCHAR,
@Contraseña Varchar,
@Nombre varchar
AS
UPDATE Vendedores SET  Usuario = @Usuario, Contraseña = @Contraseña,Nombre = @Nombre
WHERE Codigo = @Codigo

--ELIMINAR
CREATE PROC SP_ELIMINARVEND
@Codigo INT 
AS
DELETE Vendedores
WHERE Codigo = @Codigo

------------------------------------------------------
create proc BuscarNfactura
as
select  top 1 IdFactu from factura order by IdFactu desc
go


create proc BuscarCliente
@Documento int
as
select * from Cliente WHERE Documento=@Documento
go



----Consultas 

select * from Factura
select * from Factura_Detalle
select*from Cliente
select*from Productos
SELECT*FROM Vendedores