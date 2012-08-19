set language english

--Drop Triggers
drop trigger tr_inserta_articulo;
drop trigger tr_inserta_bodega;

--Drop Procedures
drop procedure sp_Inserta_Articulo;
drop procedure sp_Elimina_Articulo;
drop procedure sp_Modificar_Articulo; 
drop procedure sp_Consulta_Todos_Articulos; 
drop procedure sp_Consulta_Articulo;
drop procedure sp_Inserta_Unidad_Medida;
drop procedure sp_Elimina_Unidad_Medida;
drop procedure sp_Modificar_Unidad_Medida;
drop procedure sp_Consulta_Todas_Unidades_Medida;
drop procedure sp_Consulta_Unidad_Medida;
drop procedure sp_Crea_Saldo;
drop procedure sp_Bloquea_Usuario;
drop procedure sp_Modificar_Clave_Usuario;
drop procedure sp_Verificar_Usuario_Bloqueado;
drop procedure sp_Verificar_Usuario;
drop procedure sp_Incluir_Cuenta;


--Drops table
drop table Precio;
drop table Detalle_Documento;
drop table Equivalencia;
drop table Documento;
drop table Lista_Precio;
drop table Componente;
drop table Saldo;
drop table Articulo;
drop table Unidad_medida;
drop table Bodega;
drop table Cliente;
drop table Tipo_Documento;
drop table Empleado;
drop table Historial_Pago;
drop table Puesto;
drop table Departamento;
drop table Usuario;


--Creacion de Tablas
CREATE TABLE Unidad_medida( 
     codigo_unidad_medida VARCHAR(3)  NOT NULL , 
     descripcion VARCHAR(30)  NOT NULL,
     CONSTRAINT "pk_Unidad_Medida" PRIMARY KEY(codigo_unidad_medida) 
);
    
CREATE TABLE Articulo( 
     codigo_articulo VARCHAR(25)  NOT NULL , 
     descripcion VARCHAR(60) ,
     impuesto_ventas NUMERIC(2)  NOT NULL , 
     fecha_ultima_entrada DATETIME  NOT NULL , 
     fecha_ultima_salida DATETIME  NOT NULL , 
     costo_prom_act NUMERIC(10,2)  NOT NULL , 
     costo_prom_ant NUMERIC(10,2) , 
     costo_ult_ent_act NUMERIC(10,2) , 
     costo_ult_ent_ant NUMERIC(10,2) , 
     codigo_unidad_medida VARCHAR(3)  NOT NULL , 
	CONSTRAINT ck_art_iventas CHECK(impuesto_ventas >= 0),
	CONSTRAINT ck_art_costpromact CHECK(costo_prom_act >= 0),
	CONSTRAINT ck_art_costpromant CHECK(costo_prom_ant >= 0),
	CONSTRAINT ck_art_costultentact CHECK(costo_ult_ent_act >= 0),
	CONSTRAINT ck_art_costultentant CHECK(costo_ult_ent_ant >= 0),
	CONSTRAINT "pk_Articulo" PRIMARY KEY(codigo_articulo),
	CONSTRAINT fk1_Articulo FOREIGN KEY(codigo_unidad_medida) REFERENCES Unidad_medida(codigo_unidad_medida)
);	

CREATE TABLE Bodega( 
     codigo_bodega VARCHAR(3)  NOT NULL , 
     descripcion VARCHAR(30)  NOT NULL,
     CONSTRAINT "pk_Bodega" PRIMARY KEY (codigo_bodega)	
);
    
CREATE TABLE Cliente( 
     codigo_cliente VARCHAR(6)  NOT NULL , 
     Nombre VARCHAR(60)  NOT NULL , 
     Tipo_cedula CHAR(1)  NOT NULL , 
     cedula VARCHAR(15)  NOT NULL , 
     contacto VARCHAR(30)  NOT NULL , 
     direccion VARCHAR(100)  NOT NULL , 
     telefono VARCHAR(15) , 
     email VARCHAR(30) , 
     forma_pago CHAR (1)  NOT NULL , 
     tope_credito NUMERIC(10,2)  NOT NULL , 
     dias_plazo NUMERIC(2)  NOT NULL , 
     excento_imp CHAR (1) , 
     ultima_factura VARCHAR(15),
     CONSTRAINT "pk_Cliente" PRIMARY KEY(codigo_cliente)	
);

CREATE TABLE Componente( 
     codigo_componente VARCHAR(25)  NOT NULL , 
     costo NUMERIC(10,2)  NOT NULL , 
     cantidad NUMERIC(10)  NOT NULL , 
     codigo_articulo VARCHAR(25)  NOT NULL , 
     codigo_unidad_medida VARCHAR(3)  NOT NULL,
     CONSTRAINT "PK_Componente" PRIMARY KEY(codigo_componente, codigo_articulo, codigo_unidad_medida),
     CONSTRAINT fk1_Componente FOREIGN KEY(codigo_unidad_medida) 
     REFERENCES Unidad_Medida(codigo_unidad_medida),
     CONSTRAINT fk2_Componente FOREIGN KEY(codigo_articulo) 
     REFERENCES Articulo(codigo_articulo),
     CONSTRAINT fk3_Componente FOREIGN KEY(codigo_componente) 
     REFERENCES Articulo(codigo_articulo)	
);    
   
CREATE TABLE Documento( 
     numero_documento VARCHAR(15)  NOT NULL , 
     Fecha DATETIME  NOT NULL , 
     Vencimiento DATETIME  NOT NULL , 
     orden_trabajo VARCHAR(15) , 
     Forma_pago CHAR(1) , 
     Exenta CHAR(1) , 
     telefono VARCHAR(15) , 
     codigo_cliente VARCHAR(6),
     CONSTRAINT "pk_Documento" PRIMARY KEY (numero_documento), 	 
     CONSTRAINT fk1_Documento FOREIGN KEY(codigo_cliente) 
       REFERENCES Cliente(codigo_cliente)
);
    
CREATE TABLE Detalle_Documento(  
    cantidad NUMERIC(10)  NOT NULL , 
    imp_venta NUMERIC(8,2)  NOT NULL , 
    precio NUMERIC(8,2)  NOT NULL , 
    costo NUMERIC(8,2)  NOT NULL , 
    descuento NUMERIC(10) , 
    numero_documento VARCHAR(15)  NOT NULL ,
    linea_doc NUMERIC(6) NOT NULL, 
    codigo_bodega VARCHAR(3) , 
    codigo_unidad_medida VARCHAR(3)  NOT NULL , 
    codigo_articulo VARCHAR(25)  NOT NULL,
    CONSTRAINT "pk_Detalle_Documento" PRIMARY KEY(numero_documento,linea_doc),
	CONSTRAINT fk1_Detalle_Doc FOREIGN KEY(codigo_articulo) 
		REFERENCES Articulo(codigo_articulo),  
	CONSTRAINT fk2_Detalle_Doc FOREIGN KEY(codigo_bodega) 
		REFERENCES Bodega(codigo_bodega),
	CONSTRAINT fk3_Detalle_Doc FOREIGN KEY(codigo_unidad_medida) 
		REFERENCES Unidad_Medida(codigo_unidad_medida),
	CONSTRAINT fk4_Detalle_Doc FOREIGN KEY(numero_documento) 
		REFERENCES Documento(numero_documento)
);

CREATE TABLE Equivalencia( 
    factor NUMERIC(10)  NOT NULL , 
    codigo_unidad_medida VARCHAR(3)  NOT NULL , 
    codigo_articulo VARCHAR(25)  NOT NULL,
    CONSTRAINT "pk_Equivalencia" PRIMARY KEY(codigo_articulo,codigo_unidad_medida),
	CONSTRAINT fk1_Equivalencia FOREIGN KEY(codigo_unidad_medida) 
		REFERENCES Unidad_Medida(codigo_unidad_medida),
	CONSTRAINT fk2_Equivalencia FOREIGN KEY(codigo_articulo)
		REFERENCES Articulo(codigo_articulo)
);     
    
CREATE TABLE Lista_Precio( 
	codigo_lista_precio VARCHAR(3)  NOT NULL , 
    descripcion VARCHAR(30)  NOT NULL,
    CONSTRAINT "pk_Lista_Precio" PRIMARY KEY(codigo_lista_precio)
);

CREATE TABLE Precio( 
    Precio NUMERIC(10,2)  NOT NULL , 
    codigo_articulo VARCHAR(25)  NOT NULL , 
    codigo_lista_precio VARCHAR(3)  NOT NULL , 
    codigo_unidad_medida VARCHAR(3)  NOT NULL,
    CONSTRAINT PK_Precio PRIMARY KEY(codigo_articulo,codigo_lista_precio, codigo_unidad_medida ),
	CONSTRAINT fk1_Precio FOREIGN KEY(codigo_unidad_medida)
		REFERENCES Unidad_medida(codigo_unidad_medida),  
	CONSTRAINT fk2_Precio FOREIGN KEY(codigo_lista_precio)
		REFERENCES Lista_Precio(codigo_lista_precio),
	CONSTRAINT fk3_Precio FOREIGN KEY(codigo_articulo) 
		REFERENCES Articulo(codigo_articulo)
);

CREATE TABLE Saldo( 
	saldo_anterior NUMERIC(10,2)  NOT NULL , 
    entradas NUMERIC(10,2)  NOT NULL , 
    salidas NUMERIC(10,2)  NOT NULL , 
    codigo_articulo VARCHAR(25)  NOT NULL , 
    codigo_bodega VARCHAR(3)  NOT NULL,
    CONSTRAINT pk_Saldo PRIMARY KEY(codigo_articulo, codigo_bodega),
	CONSTRAINT fk1_Saldo FOREIGN KEY(codigo_articulo) 
		REFERENCES Articulo(codigo_articulo),
	CONSTRAINT fk2_Saldo FOREIGN KEY(codigo_bodega) 
		REFERENCES Bodega( codigo_bodega)    
);

CREATE TABLE Tipo_Documento( 
	codigo_tipo_doc NUMERIC(3)  NOT NULL , 
    descripcion VARCHAR(30)  NOT NULL , 
    tipo VARCHAR(2)  NOT NULL,
    CONSTRAINT "pk_Tipo_Documento" PRIMARY KEY(codigo_tipo_doc)   
);

CREATE TABLE Departamento(
	codigo_departamento NUMERIC (2) NOT NULL , 
    nombre VARCHAR (20) NOT NULL , 
    cant_max_puetos NUMERIC (2) NOT NULL , 
    CONSTRAINT "pk_departamento" PRIMARY KEY NONCLUSTERED (codigo_departamento)
);

CREATE TABLE Empleado(
	codigo_empleado NUMERIC (2) NOT NULL , 
    cedula NUMERIC (10) NOT NULL , 
    nombre VARCHAR (20) NOT NULL , 
    apellido1 VARCHAR (20) NOT NULL , 
    apellido_2 VARCHAR (20) NOT NULL , 
    fecha_ingreso DATETIME NOT NULL , 
    telefono NUMERIC (10) , 
    email VARCHAR (50) , 
    fecha_nacimiento DATETIME NOT NULL , 
    direccion VARCHAR (80) , 
    nombre_usuario VARCHAR (20) NOT NULL , 
    CONSTRAINT "pk_empleado" PRIMARY KEY NONCLUSTERED (codigo_empleado)
);


CREATE TABLE Historial_Pago(
	fecha DATETIME NOT NULL , 
    horas NUMERIC (2) NOT NULL , 
    horas_extra NUMERIC (2) , 
    periodo VARCHAR (10) NOT NULL , 
    retencion_ccss NUMERIC (2) NOT NULL , 
    ahorro NUMERIC (10) , 
    codigo_empleado NUMERIC (2) NOT NULL , 
    CONSTRAINT "pk_historial" PRIMARY KEY NONCLUSTERED (Fecha, codigo_empleado)
);

CREATE TABLE Puesto(
	codigo_puesto NUMERIC (2) NOT NULL , 
    nombre VARCHAR (20) NOT NULL , 
    salario NUMERIC (10) NOT NULL , 
    codigo_departamento NUMERIC (2) NOT NULL , 
    codigo_empleado NUMERIC (2) NOT NULL , 
    cant_max_empleados NUMERIC NOT NULL , 
    CONSTRAINT "pk_puesto" PRIMARY KEY NONCLUSTERED (codigo_puesto),
	CONSTRAINT fk1_Puesto FOREIGN KEY(codigo_departamento) 
		REFERENCES Departamento(codigo_departamento)
);

CREATE TABLE USUARIO(
	nombre VARCHAR (20) NOT NULL , 
	descripcion VARCHAR(40) NOT NULL,
    clave VARCHAR (20) NOT NULL , 
    rol_operario BIT NOT NULL , 
    rol_administrativo BIT NOT NULL , 
    rol_contable BIT NOT NULL , 
    bloqueado BIT NOT NULL,
    CONSTRAINT "pk_usuario" PRIMARY KEY NONCLUSTERED (nombre)
); 
     
     
-- STORE PROCEDURES --   
USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Inserta_Articulo 
	-- Add the parameters for the stored procedure here
	@codigo_articulo varchar(25),
	@descripcion varchar(60),
	@impuesto_ventas numeric(2,0),
	@fecha_ultima_entrada datetime,
	@fecha_ultima_salida datetime,
	@costo_prom_act numeric(10,2),
	@costo_prom_ant numeric(10,2),
	@costo_ult_ent_act numeric(10,2),
	@costo_ult_ent_ant numeric(10,2),
	@codigo_unidad_medida varchar(3)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
   insert into Articulo values(
   	@codigo_articulo,
	@descripcion,
	@impuesto_ventas,
	@fecha_ultima_entrada,
	@fecha_ultima_salida,
	@costo_prom_act,
	@costo_prom_ant,
	@costo_ult_ent_act,
	@costo_ult_ent_ant,
	@codigo_unidad_medida
   )
END
GO



USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Elimina_Articulo
	@codigo_articulo varchar(25)
AS
BEGIN
   delete from Articulo where 
      codigo_articulo = @codigo_articulo;
END
GO
    
    
USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO   
CREATE PROCEDURE sp_Modificar_Articulo
	-- Add the parameters for the stored procedure here
	@codigo_articulo varchar(25),
	@descripcion varchar(60),
	@impuesto_ventas numeric(2,0),
	@fecha_ultima_entrada datetime,
	@fecha_ultima_salida datetime,
	@costo_prom_act numeric(10,2),
	@costo_prom_ant numeric(10,2),
	@costo_ult_ent_act numeric(10,2),
	@costo_ult_ent_ant numeric(10,2),
	@codigo_unidad_medida varchar(3)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
update Articulo 
	   set descripcion = @descripcion,
	       impuesto_ventas = @impuesto_ventas,
	       fecha_ultima_entrada = @fecha_ultima_entrada,
	       fecha_ultima_salida = @fecha_ultima_salida,
	       costo_prom_act = @costo_prom_act,
	       costo_prom_ant = @costo_prom_ant,	       	         
	       costo_ult_ent_act = @costo_ult_ent_act,
	       costo_ult_ent_ant = @costo_ult_ent_ant,
	       codigo_unidad_medida = @codigo_unidad_medida			
where 
      codigo_articulo = @codigo_articulo;
END
GO
    
    
    
USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO   
CREATE PROCEDURE sp_Consulta_Todos_Articulos
	-- Add the parameters for the stored procedure here	
AS
BEGIN
   select * from articulo;
END; 
GO



USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Consulta_Articulo
	-- Add the parameters for the stored procedure here
	@codigo_articulo varchar(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	select * from Articulo
	where codigo_articulo = @codigo_articulo
END
GO



USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Inserta_Unidad_Medida 
	-- Add the parameters for the stored procedure here
	@codigo_unidad_medida varchar(3),
	@descripcion varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
   insert into Unidad_Medida values(
    @codigo_unidad_medida,
	@descripcion
   )
END
GO



USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Elimina_Unidad_Medida
	@codigo_unidad_medida varchar(25)
AS
BEGIN
   delete from Unidad_Medida where 
      codigo_unidad_medida = @codigo_unidad_medida;
END
GO



USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO    
CREATE PROCEDURE sp_Modificar_Unidad_Medida
    @codigo_unidad_medida varchar(3),
	@descripcion varchar(30)
AS
BEGIN
update Unidad_Medida 
	   set codigo_unidad_medida = @codigo_unidad_medida,
	       descripcion = @descripcion	       			
where 
      codigo_unidad_medida = @codigo_unidad_medida;
END
GO
  


USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO        
CREATE PROCEDURE sp_Consulta_Todas_Unidades_Medida
	-- Add the parameters for the stored procedure here	
AS
BEGIN
   select * from Unidad_Medida;
END
GO
   


USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Consulta_Unidad_Medida
	@codigo_unidad_medida varchar(3)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	select * from Unidad_Medida
	where codigo_unidad_medida = @codigo_unidad_medida
END
GO


--Saldos
USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Crea_Saldo
    @saldo_anterior numeric(10,2),
    @entradas numeric(10,2),
    @salidas numeric(10,2),
	@codigo_articulo varchar(25),
	@codigo_bodega varchar(3)
AS
BEGIN
   insert into Saldo values(
      @saldo_anterior,
      @entradas,
      @salidas,
      @codigo_articulo,
      @codigo_bodega)
END
GO


USE [ENERTROL] 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Bloquea_Usuario
	@User_name VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Usuario SET bloqueado = 1 WHERE Usuario.nombre = @User_name
END
GO


USE [ENERTROL] 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Modificar_Clave_Usuario
	@User_name	varchar(50),
	@clave		varchar(50),
	@claveNueva	varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
    UPDATE Usuario set clave = @claveNueva WHERE nombre = @User_name AND clave = @clave
END
GO


USE [ENERTROL] 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Verificar_Usuario_Bloqueado
	@User_name VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Usuario.bloqueado FROM Usuario WHERE nombre = @User_name
END
GO


USE [ENERTROL] 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Verificar_Usuario
	@User_name VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Usuario.clave FROM Usuario WHERE Usuario.nombre = @User_name
END
GO


USE [ENERTROL] 
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_Incluir_Cuenta
 @User_name  varchar(20),
 @Clave   varchar(20)
AS
BEGIN
 SET NOCOUNT ON;
 INSERT INTO ENERTROL.dbo.USUARIO VALUES(@User_name, 'normal' ,@Clave, 0,0,0,0)
END
GO

 
------*************************------------------
--TRIGGERS--
USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create TRIGGER tr_inserta_articulo
ON Articulo
FOR INSERT
AS
BEGIN

SET NOCOUNT ON;

DECLARE @mi_bod VARCHAR(3)   
DECLARE @mi_art VARCHAR(25)

select @mi_art=i.codigo_articulo from inserted i;	

DECLARE mi_cursor CURSOR FOR  
SELECT codigo_bodega FROM Bodega

OPEN mi_cursor  
FETCH NEXT FROM mi_cursor INTO @mi_bod

WHILE @@FETCH_STATUS = 0  
BEGIN  
  exec sp_Crea_Saldo 0.0, 0.0, 0.0, @mi_art,@mi_bod;
--  INSERT INTO Saldo (codigo_articulo,codigo_bodega,entradas,salidas,saldo_anterior) 
--  VALUES (@mi_art,@mi_bod,0,0,0); 
  FETCH NEXT FROM mi_cursor INTO @mi_bod  
END  

CLOSE mi_cursor 
DEALLOCATE mi_cursor

END
GO



USE [ENERTROL]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create TRIGGER tr_inserta_bodega
ON Bodega
FOR INSERT
AS
BEGIN

SET NOCOUNT ON;

DECLARE @mi_bod VARCHAR(3)   
DECLARE @mi_art VARCHAR(25)

select @mi_bod=i.codigo_bodega from inserted i;	

DECLARE mi_cursor CURSOR FOR  
SELECT codigo_articulo FROM Articulo

OPEN mi_cursor  
FETCH NEXT FROM mi_cursor INTO @mi_art

WHILE @@FETCH_STATUS = 0  
BEGIN  
  exec sp_Crea_Saldo 0.0, 0.0, 0.0, @mi_art,@mi_bod;
--  INSERT INTO Saldo (codigo_articulo,codigo_bodega,entradas,salidas,saldo_anterior) 
--  VALUES (@mi_art,@mi_bod,0,0,0); 
  FETCH NEXT FROM mi_cursor INTO @mi_art  
END  

CLOSE mi_cursor 
DEALLOCATE mi_cursor

END
GO

Create Login Usuario	
	   With Password = 'ABC123';
Use ENERTROL;	   
Go
Create User El_Usuario For Login Usuario;
Go
El_Usuario WITH PASSWORD ='dd' 
Go
Create role Total;
Exec sp_addrolemember 'Total','El_Usuario'; 
Go
GRANT DELETE, INSERT, SELECT, UPDATE ON Dbo.Articulo TO Total

--drop user El_Usuario
--drop Login Usuario


--PARA PROBAR
insert into Bodega values('001','Bodega 001');
insert into Bodega values('002','Bodega 002');
insert into Bodega values('003','Bodega 003');

EXEC sp_Crea_Saldo 0.0, 0.0, 0.0, '01', 'UNI';
--Se llama el procedimiento que inserta articulo, este dispara el trigger y a su vez 
--el store procedure que crea/inserta el saldo
exec sp_Inserta_Articulo '001','cero uno',13,'07-31-2012','07-31-2012',100,90,120,110,UNI;
exec sp_Inserta_Articulo '002','cero dos',13,'07-31-2012','07-31-2012',100,90,120,110,UNI;
exec sp_Inserta_Articulo '003','cero tres',13,'07-31-2012','07-31-2012',100,90,120,110,UNI;


insert into Bodega values('004','Bodega 004');