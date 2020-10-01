-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2020-09-29 18:28:33.029



CREATE DATABASE FABRICA_AUTOMOTRIZ
GO

USE FABRICA_AUTOMOTRIZ
GO
-- tables
-- Table: AUTOPLANES

CREATE TABLE AUTOPLANES (
    id_autoplan int NOT NULL identity(1,1),
    observaciones varchar(200) NOT NULL,
    cant_cuota int NOT NULL,
    interes int NOT NULL,
    id_pedido int NOT NULL,
    CONSTRAINT AUTOPLANES_pk PRIMARY KEY (id_autoplan)
);

-- Table: BARRIOS
CREATE TABLE BARRIOS (
    id_barrio int NOT NULL identity(1,1),
    barrio varchar(20) NOT NULL,
    id_localidad int ,
    CONSTRAINT BARRIOS_pk PRIMARY KEY (id_barrio)
);

-- Table: CLIENTES
CREATE TABLE CLIENTES (
    id_cliente int NOT NULL identity(1,1),
    nombre varchar(30) NOT NULL,
    apellido varchar(30) ,
    doc int NOT NULL,
    id_tipo_identificacion int NOT NULL,
    id_tipo_cliente int NOT NULL,
    email varchar(30) ,
    telefono bigint ,
    calle varchar(30) ,
    altura int ,
    id_barrio int ,
    CONSTRAINT CLIENTES_pk PRIMARY KEY (id_cliente)
);

-- Table: COLORES
CREATE TABLE COLORES (
    id_color int NOT NULL,
    descripcion int NOT NULL,
    CONSTRAINT COLORES_pk PRIMARY KEY (id_color)
);

-- Table: CUOTAS_AUOTPLAN
CREATE TABLE CUOTAS_AUOTPLAN (
    id_cuota int NOT NULL identity(1,1),
    fecha date NOT NULL,
    fecha_vencimiento date NOT NULL,
    nro_cuota int NOT NULL,
    id_autoplan int NOT NULL,
    id_factura int ,
    CONSTRAINT CUOTAS_AUOTPLAN_pk PRIMARY KEY (id_cuota)
);

-- Table: DETALLES_FACTURAS
CREATE TABLE DETALLES_FACTURAS (
    id_detalle int NOT NULL identity(1,1),
    id_factura int NOT NULL,
    precio decimal(19,4) NOT NULL,
    cantidad int NOT NULL,
    id_producto int NOT NULL,
    descuento_producto int ,
    CONSTRAINT DETALLES_FACTURAS_pk PRIMARY KEY (id_detalle)
);

-- Table: DETALLE_PEDIDO
CREATE TABLE DETALLE_PEDIDO (
    id_det_pedido int NOT NULL identity(1,1),
    id_pedido int NOT NULL,
    id_producto int NOT NULL,
    cantidad int NOT NULL,
    CONSTRAINT DETALLE_PEDIDO_pk PRIMARY KEY (id_det_pedido)
);


-- Table: FACTURAS
CREATE TABLE FACTURAS (
    id_factura int NOT NULL identity(1,1),
    fecha date NOT NULL,
    id_cliente int NOT NULL,
    descuento_total int ,
    id_vendedor int ,
    id_tipo_factura int NOT NULL,
    observacion varchar(150),
    id_pedido int,
    CONSTRAINT FACTURAS_pk PRIMARY KEY (id_factura)
);

-- Table: FORMAS_PAGOS
CREATE TABLE FORMAS_PAGOS (
    id_forma_pago int NOT NULL identity(1,1),
    descripcion varchar(50) NOT NULL,
    CONSTRAINT FORMAS_PAGOS_pk PRIMARY KEY (id_forma_pago)
);

-- Table: FORMAS_PAGOSxFACTURAS
CREATE TABLE FORMAS_PAGOSxFACTURAS (
    id_forma_pago_factura int NOT NULL identity(1,1),
    id_factura int NOT NULL,
    id_forma_pago int NOT NULL,
    CONSTRAINT FORMAS_PAGOSxFACTURAS_pk PRIMARY KEY (id_forma_pago_factura)
);

-- Table: HISTORIALES_PRECIOS
CREATE TABLE HISTORIALES_PRECIOS (
    id_historial int NOT NULL identity(1,1),
    fecha_modificacion date NOT NULL,
    precio_venta decimal(19,4) NOT NULL,
    precio_mayo decimal(19,4) NOT NULL,
    id_producto int NOT NULL,
    CONSTRAINT HISTORIALES_PRECIOS_pk PRIMARY KEY (id_historial)
);

-- Table: LOCALIDADES
CREATE TABLE LOCALIDADES (
    id_localidad int NOT NULL,
    localidad varchar(20) NOT NULL,
    id_provincia int,
    CONSTRAINT LOCALIDADES_pk PRIMARY KEY (id_localidad)
);

-- Table: MATERIALES
CREATE TABLE MATERIALES (
   id_material int NOT NULL identity(1,1),
   descripcion varchar(50) NOT NULL,
   CONSTRAINT MATERIALES_pk PRIMARY KEY (id_material)
);

-- Table: ORDEN_PEDIDO
CREATE TABLE ORDEN_PEDIDO (
    id_pedido int NOT NULL identity(1,1),
    fecha_pedido date NOT NULL,
    fecha_entrega date,
    id_cliente int ,
    estado bit NOT NULL DEFAULT 0,
    observacion int ,
    CONSTRAINT ORDEN_PEDIDO_pk PRIMARY KEY (id_pedido)
);


-- Table: PRODUCTOS
CREATE TABLE PRODUCTOS (
    id_producto int NOT NULL identity(1,1),
    descripcion varchar(100),
    id_tipo_producto int NOT NULL,
    id_rubro int NOT NULL,
    id_marca int NOT NULL,
    Observaciones varchar(50),
    id_color int ,
    stock int NOT NULL,
    stock_minimo int NOT NULL,
    precio_venta decimal(19,4) NOT NULL,
    precio_mayo decimal(19,4) NOT NULL,
    CONSTRAINT PRODUCTOS_pk PRIMARY KEY (id_producto)
);

-- Table: PROVINCIAS
CREATE TABLE PROVINCIAS (
    id_provincia int NOT NULL identity(1,1),
    provincia varchar(20) NOT NULL,
    CONSTRAINT PROVINCIAS_pk PRIMARY KEY (id_provincia)
);

-- Table: RUBROS
CREATE TABLE RUBROS (
    id_rubro int NOT NULL identity(1,1),
    descripcion varchar(50) NOT NULL,
    CONSTRAINT RUBROS_pk PRIMARY KEY (id_rubro)
);

-- Table: TIPOS_CLIENTES
CREATE TABLE TIPOS_CLIENTES (
    id_tipo_cliente int NOT NULL,
    descripcion varchar(20) NOT NULL,
    CONSTRAINT TIPOS_CLIENTES_pk PRIMARY KEY (id_tipo_cliente)
);

-- Table: TIPOS_FACTURAS
CREATE TABLE TIPOS_FACTURAS (
    id_tipo_factura int NOT NULL identity(1,1),
    descripcion varchar(50) NOT NULL,
    CONSTRAINT TIPOS_FACTURAS_pk PRIMARY KEY (id_tipo_factura)
);

-- Table: TIPOS_PRODUCTOS
CREATE TABLE TIPOS_PRODUCTOS (
    id_tipo_producto int NOT NULL identity(1,1),
    descripcion varchar(20) NOT NULL,
    CONSTRAINT TIPOS_PRODUCTOS_pk PRIMARY KEY (id_tipo_producto)
);

-- Table: TIPO_IDENTIFICACION
CREATE TABLE TIPO_IDENTIFICACION (
    id_tipo_identificacion int NOT NULL,
    Identificacion Varchar(20) NOT NULL,
    CONSTRAINT TIPO_IDENTIFICACION_pk PRIMARY KEY (id_tipo_identificacion)
);

-- Table: VENDEDORES
CREATE TABLE VENDEDORES (
    id_vendedor int NOT NULL identity(1,1),
    nombre varchar(30) NOT NULL,
    apellido varchar(30) NOT NULL,
    id_barrio int ,
    calle int ,
    altura int ,
    id_tipo_identificacion int NOT NULL,
    doc int NOT NULL,
    telefono bigint,
    CONSTRAINT VENDEDORES_pk PRIMARY KEY (id_vendedor)
);
GO
-- foreign keys
-- Reference: AUTOPLANES_ORDEN_PEDIDO (table: AUTOPLANES)
ALTER TABLE AUTOPLANES ADD CONSTRAINT FK_AUTOPLANES_ORDEN_PEDIDO FOREIGN KEY (id_pedido)
    REFERENCES ORDEN_PEDIDO (id_pedido);

-- Reference: BARRIOS_LOCALIDADES (table: BARRIOS)
ALTER TABLE BARRIOS ADD CONSTRAINT FK_BARRIOS_LOCALIDADES FOREIGN KEY  (id_localidad)
    REFERENCES LOCALIDADES (id_localidad);

-- Reference: CLIENTES_BARRIOS (table: CLIENTES)
ALTER TABLE CLIENTES ADD CONSTRAINT FK_CLIENTES_BARRIOS FOREIGN KEY (id_barrio)
    REFERENCES BARRIOS (id_barrio);

-- Reference: CLIENTES_TIPOS_CLIENTES (table: CLIENTES)
ALTER TABLE CLIENTES ADD CONSTRAINT FK_CLIENTES_TIPOS_CLIENTES FOREIGN KEY (id_tipo_cliente)
    REFERENCES TIPOS_CLIENTES (id_tipo_cliente);

-- Reference: CLIENTES_TIPO_IDENTIFICACION (table: CLIENTES)
ALTER TABLE CLIENTES ADD CONSTRAINT FK_CLIENTES_TIPO_IDENTIFICACION FOREIGN KEY (id_tipo_identificacion)
    REFERENCES TIPO_IDENTIFICACION (id_tipo_identificacion);

-- Reference: CUOTAS_AUOTPLAN_AUTOPLANES (table: CUOTAS_AUOTPLAN)
ALTER TABLE CUOTAS_AUOTPLAN ADD CONSTRAINT FK_CUOTAS_AUOTPLAN_AUTOPLANES FOREIGN KEY (id_autoplan)
    REFERENCES AUTOPLANES (id_autoplan);

-- Reference: CUOTAS_AUOTPLAN_FACTURAS (table: CUOTAS_AUOTPLAN)
ALTER TABLE CUOTAS_AUOTPLAN ADD CONSTRAINT FK_CUOTAS_AUOTPLAN_FACTURAS FOREIGN KEY (id_factura)
    REFERENCES FACTURAS (id_factura);

-- Reference: DETALLES_FACTURAS_FACTURAS (table: DETALLES_FACTURAS)
ALTER TABLE DETALLES_FACTURAS ADD CONSTRAINT FK_DETALLES_FACTURAS_FACTURAS FOREIGN KEY (id_factura)
    REFERENCES FACTURAS (id_factura);

-- Reference: DETALLES_FACTURAS_PRODUCTOS (table: DETALLES_FACTURAS)
ALTER TABLE DETALLES_FACTURAS ADD CONSTRAINT FK_DETALLES_FACTURAS_PRODUCTOS FOREIGN KEY (id_producto)
    REFERENCES PRODUCTOS (id_producto);

-- Reference: DETALLE_PEDIDO_ORDEN_PEDIDO (table: DETALLE_PEDIDO)
ALTER TABLE DETALLE_PEDIDO ADD CONSTRAINT FK_DETALLE_PEDIDO_ORDEN_PEDIDO FOREIGN KEY (id_pedido)
    REFERENCES ORDEN_PEDIDO (id_pedido);

-- Reference: DETALLE_PEDIDO_PRODUCTOS (table: DETALLE_PEDIDO)
ALTER TABLE DETALLE_PEDIDO ADD CONSTRAINT FK_DETALLE_PEDIDO_PRODUCTOS FOREIGN KEY (id_producto)
    REFERENCES PRODUCTOS (id_producto);


-- Reference: FACTURAS_CLIENTES (table: FACTURAS)
ALTER TABLE FACTURAS ADD CONSTRAINT FK_FACTURAS_CLIENTES FOREIGN KEY (id_cliente)
    REFERENCES CLIENTES (id_cliente);

-- Reference: FACTURAS_ORDEN_PEDIDO (table: FACTURAS)
ALTER TABLE FACTURAS ADD CONSTRAINT FK_FACTURAS_ORDEN_PEDIDO FOREIGN KEY (id_pedido)
    REFERENCES ORDEN_PEDIDO (id_pedido);

-- Reference: FACTURAS_TIPOS_FACTURAS (table: FACTURAS)
ALTER TABLE FACTURAS ADD CONSTRAINT FK_FACTURAS_TIPOS_FACTURAS FOREIGN KEY (id_tipo_factura)
    REFERENCES TIPOS_FACTURAS (id_tipo_factura);

-- Reference: FACTURAS_VENDEDORES (table: FACTURAS)
ALTER TABLE FACTURAS ADD CONSTRAINT FK_FACTURAS_VENDEDORES FOREIGN KEY (id_vendedor)
    REFERENCES VENDEDORES (id_vendedor);

-- Reference: FORMAS_PAGOSxFACTURAS_FACTURAS (table: FORMAS_PAGOSxFACTURAS)
ALTER TABLE FORMAS_PAGOSxFACTURAS ADD CONSTRAINT FK_FORMAS_PAGOSxFACTURAS_FACTURAS FOREIGN KEY (id_factura)
    REFERENCES FACTURAS (id_factura);

-- Reference: FORMAS_PAGOSxFACTURAS_FORMAS_PAGOS (table: FORMAS_PAGOSxFACTURAS)
ALTER TABLE FORMAS_PAGOSxFACTURAS ADD CONSTRAINT FK_FORMAS_PAGOSxFACTURAS_FORMAS_PAGOS FOREIGN KEY (id_forma_pago)
    REFERENCES FORMAS_PAGOS (id_forma_pago);

-- Reference: HISTORIALES_PRECIOS_PRODUCTOS (table: HISTORIALES_PRECIOS)
ALTER TABLE HISTORIALES_PRECIOS ADD CONSTRAINT FK_HISTORIALES_PRECIOS_PRODUCTOS FOREIGN KEY (id_producto)
    REFERENCES PRODUCTOS (id_producto);

-- Reference: LOCALIDADES_PROVINCIAS (table: LOCALIDADES)
ALTER TABLE LOCALIDADES ADD CONSTRAINT FK_LOCALIDADES_PROVINCIAS FOREIGN KEY(id_provincia)
    REFERENCES PROVINCIAS (id_provincia);

-- Reference: ORDEN_PEDIDO_CLIENTES (table: ORDEN_PEDIDO)
ALTER TABLE ORDEN_PEDIDO ADD CONSTRAINT FK_ORDEN_PEDIDO_CLIENTES FOREIGN KEY(id_cliente)
    REFERENCES CLIENTES (id_cliente);

-- Reference: PRODUCTOS_COLORES (table: PRODUCTOS)
ALTER TABLE PRODUCTOS ADD CONSTRAINT FK_PRODUCTOS_COLORES FOREIGN KEY(id_color)
    REFERENCES COLORES (id_color);

-- Reference: PRODUCTOS_MATERIALES (table: PRODUCTOS)
ALTER TABLE PRODUCTOS ADD CONSTRAINT FK_PRODUCTOS_MATERIALES FOREIGN KEY (id_marca)
    REFERENCES MATERIALES (id_material);

-- Reference: PRODUCTOS_RUBROS (table: PRODUCTOS)
ALTER TABLE PRODUCTOS ADD CONSTRAINT FK_PRODUCTOS_RUBROS FOREIGN KEY (id_rubro)
    REFERENCES RUBROS (id_rubro);

-- Reference: PRODUCTOS_TIPOS_PRODUCTOS (table: PRODUCTOS)
ALTER TABLE PRODUCTOS ADD CONSTRAINT FK_PRODUCTOS_TIPOS_PRODUCTOS FOREIGN KEY (id_tipo_producto)
    REFERENCES TIPOS_PRODUCTOS (id_tipo_producto);

-- Reference: VENDEDORES_BARRIOS (table: VENDEDORES)
ALTER TABLE VENDEDORES ADD CONSTRAINT FK_VENDEDORES_BARRIOS FOREIGN KEY (id_barrio)
    REFERENCES BARRIOS (id_barrio);

-- Reference: VENDEDORES_TIPO_IDENTIFICACION (table: VENDEDORES)
ALTER TABLE VENDEDORES ADD CONSTRAINT FK_VENDEDORES_TIPO_IDENTIFICACION FOREIGN KEY (id_tipo_identificacion)
    REFERENCES TIPO_IDENTIFICACION (id_tipo_identificacion);


--DATOS
--PROVINCIAS
INSERT INTO PROVINCIAS(provincia) VALUES ('Cordoba')
INSERT INTO PROVINCIAS(provincia) VALUES ('Buenos Aires')
INSERT INTO PROVINCIAS(provincia) VALUES ('Santa Fe')

--LOCALIDADES
INSERT INTO LOCALIDADES(LOCALIDAD,id_provincia) VALUES ('Capital',1)
INSERT INTO LOCALIDADES(LOCALIDAD,id_provincia) VALUES ('Rio Cuarto',1)
INSERT INTO LOCALIDADES(LOCALIDAD,id_provincia) VALUES ('Villa Maria',1)


--BARRIOS
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('CENTRO',1) 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('ALTO ALBERDI',1) 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('OBSERVATORIO',1) 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('JARDIN,1') 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('GENERAL PAZ',1) 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('PUEYRREDON',1) 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('PARQUE HORIZONTE',1) 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('SAN MARTIN',1) 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('SAN VICENTE',1) 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('NUEVA CORDOBA',1) 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('MAIPU',1) 
INSERT INTO BARRIOS(BARRIO,id_localidad) VALUES ('PANAMERICANO',1) 


--TIPOS CLIENTES
insert into TIPOS_CLIENTES (id_tipo_cliente, descripcion) values (1,'Consumidos final')		--1
insert into TIPOS_CLIENTES (id_tipo_cliente,descripcion) values (2,'Empresa')					--2
insert into TIPOS_CLIENTES (id_tipo_cliente,descripcion) values (3,'Concesionaria')			--3
insert into TIPOS_CLIENTES (id_tipo_cliente,descripcion) values (4,'Vendedora de autopartes')	--4

--TIPOS IDENTIFICACION
insert into TIPO_IDENTIFICACION (id_tipo_identificacion, Identificacion) values (1,'DNI')		--1
insert into TIPO_IDENTIFICACION (id_tipo_identificacion,Identificacion) values (2,'CUIL')	--2

select * from CLIENTES
--CLIENTES
insert into CLIENTES (nombre, apellido, doc, id_tipo_identificacion, id_tipo_cliente,email,telefono,calle,altura,id_barrio) values ('Rodrigo', 'Sanchez','414399', 1,1,'rodri.sanchez1998@gmail.com',3515205101,'Aguas Sacha',9559,NULL);

insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Castillo', 'Marta Analia','Pedro Lozano', 1450,7,NULL,'castillo_marta@yahoo.com');
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Abarca', 'Hector','Luis Gongora', 160,12,4701314,'habarca@hotmail.com');
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Morales','Santiago','Leon y Pizarro', 55,2,155471516,NULL);
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Perez', 'Carlos Antonio','A. Garzon', 455,2,4554466,NULL);
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Morales', 'Pilar','Leon y Pizarro', 55,2,155471516,NULL);
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Paez', 'Roque','Humberto Primo', 79,1,4262630,NULL);
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Luque', 'Elvira Josefa','Mariano Usandivaras', 360,3,4502829,NULL);
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Ruiz', 'Marcos','Rivera Indarte', 780,1,NULL,'ruiz_marcos@hotmail.com');
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Moriel', 'Roberto','Santa Rosa', 73,1,NULL,NULL);
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Perez', 'Ana Maria','Av. Colon', 1655,2,NULL,NULL);
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Gonzalez', 'Adriana','San Jeronimo', 763,1,NULL,NULL);	--Cod_cliente=12
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Moralez', 'Juana','Salamanca', 2345,11,3516111222,'juanita_2018@gmail.com');
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Ariza', 'Sofia','Derqui', 876,10,3512333444,NULL);
insert into clientes (nombre, apellido, calle, altura, cod_barrio, nro_tel, [e-mail]) values ('Angellozzi', 'Matias','Ituzaingo', 1127,10,3516012345,NULL);	--Cod_cliente=15

--VENDEDORES
insert into vendedores (ape_vendedor, nom_vendedor, calle, altura, cod_barrio, nro_tel, [e-mail], fec_nac) values ('Carrizo', 'Mart?n','San Lorenzo', 369,2,NULL,'mcarrizo@latinmail.com',null);
insert into vendedores (ape_vendedor, nom_vendedor, calle, altura, cod_barrio, nro_tel, [e-mail], fec_nac) values ('Ledesma', 'Mariela','Chachapoyas', 1560,5,4526060,NULL,'22/2/1979');
insert into vendedores (ape_vendedor, nom_vendedor, calle, altura, cod_barrio, nro_tel, [e-mail], fec_nac) values ('Lopez', 'Alejandro','Alsina', 12,3,4612525,'NULL','6/3/1975');
insert into vendedores (ape_vendedor, nom_vendedor, calle, altura, cod_barrio, nro_tel, [e-mail], fec_nac) values ('Miranda', 'Marcelo','Rivera Indarte', 320,1,NULL,NULL,'7/10/1986');
insert into vendedores (ape_vendedor, nom_vendedor, calle, altura, cod_barrio, nro_tel, [e-mail], fec_nac) values ('Monti', 'Gabriel','Altoaguirre', 1245,4,4522122,NULL,'Jul 30 1982');
insert into vendedores (ape_vendedor, nom_vendedor, calle, altura, cod_barrio, nro_tel, [e-mail], fec_nac) values ('Juarez','Susana','Antofagasta', 1785,9,458976,NULL,'30/7/1982');


--AUTOPLANES


---------------------PRODUCTOS------------------------------
--TIPOS PRODUCTOS
INSERT INTO TIPOS_PRODUCTOS (descripcion) VALUES ('Autoparte')	--1
INSERT INTO TIPOS_PRODUCTOS (descripcion) VALUES ('Automovil')	--2

--COLORES
INSERT INTO COLORES (descripcion) VALUES ('Rojo')		--1
INSERT INTO COLORES (descripcion) VALUES ('Verde')		--2
INSERT INTO COLORES (descripcion) VALUES ('Amarillo')	--3
INSERT INTO COLORES (descripcion) VALUES ('Negro')		--4
INSERT INTO COLORES (descripcion) VALUES ('Gris')		--5
INSERT INTO COLORES (descripcion) VALUES ('Blanco')		--6

--RUBROS
INSERT INTO RUBROS(descripcion) VALUES ('')		--1

--MATERIALES
INSERT INTO MATERIALES(descripcion) VALUES ('Plastico')
INSERT INTO MATERIALES(descripcion) VALUES ('Acero')
INSERT INTO MATERIALES(descripcion) VALUES ('Aluminio')

INSERT INTO PRODUCTOS VALUES ()

