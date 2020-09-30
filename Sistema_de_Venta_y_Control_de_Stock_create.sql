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
    id_localidad int NOT NULL,
    CONSTRAINT BARRIOS_pk PRIMARY KEY (id_barrio)
);

-- Table: CLIENTES
CREATE TABLE CLIENTES (
    id_cliente int NOT NULL identity(1,1),
    id_persona int NOT NULL,
    id_empresa int NOT NULL,
    id_tipo_cliente int NOT NULL,
    email varchar(30) NOT NULL,
    telefono bigint NOT NULL,
    id_direccion int NOT NULL,
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
    id_factura int NOT NULL,
    CONSTRAINT CUOTAS_AUOTPLAN_pk PRIMARY KEY (id_cuota)
);

-- Table: DETALLES_FACTURAS
CREATE TABLE DETALLES_FACTURAS (
    id_detalle int NOT NULL identity(1,1),
    id_factura int NOT NULL,
    precio decimal(19,4) NOT NULL,
    cantidad int NOT NULL,
    id_producto int NOT NULL,
    descuento_producto int NOT NULL,
    CONSTRAINT DETALLES_FACTURAS_pk PRIMARY KEY (id_detalle)
);

-- Table: DETALLE_PEDIDO
CREATE TABLE DETALLE_PEDIDO (
    id_det_pedido int NOT NULL,
    id_pedido int NOT NULL,
    id_producto int NOT NULL,
    cantidad int NOT NULL,
    CONSTRAINT DETALLE_PEDIDO_pk PRIMARY KEY (id_det_pedido)
);

-- Table: DIRECCIONES
CREATE TABLE DIRECCIONES (
    id_direccion int NOT NULL identity(1,1),
    calle varchar(30) NOT NULL,
    numero int NOT NULL,
    id_barrio int NOT NULL,
    CONSTRAINT DIRECCIONES_pk PRIMARY KEY (id_direccion)
);

-- Table: EMPRESAS
CREATE TABLE EMPRESAS (
    id_empresa int NOT NULL identity(1,1),
    razon_social varchar(30) NOT NULL,
    cuit int NOT NULL,
    CONSTRAINT EMPRESAS_pk PRIMARY KEY (id_empresa)
);

-- Table: FACTURAS
CREATE TABLE FACTURAS (
    id_factura int NOT NULL identity(1,1),
    fecha date NOT NULL,
    id_cliente int NOT NULL,
    descuento_total int NOT NULL,
    id_vendedor int NOT NULL,
    id_tipo_factura int NOT NULL,
    observacion varchar(150) NOT NULL,
    id_pedido int NOT NULL,
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
    id_provincia int NOT NULL,
    CONSTRAINT LOCALIDADES_pk PRIMARY KEY (id_localidad)
);

-- Table: MARCAS
CREATE TABLE MARCAS (
    id_marca int NOT NULL identity(1,1),
    descripcion varchar(50) NOT NULL,
    CONSTRAINT MARCAS_pk PRIMARY KEY (id_marca)
);

-- Table: ORDEN_PEDIDO
CREATE TABLE ORDEN_PEDIDO (
    id_pedido int NOT NULL identity(1,1),
    fecha_pedido date NOT NULL,
    fecha_entrega date NOT NULL,
    id_cliente int NOT NULL,
    estado bit NOT NULL DEFAULT 0,
    observacion int NOT NULL,
    CONSTRAINT ORDEN_PEDIDO_pk PRIMARY KEY (id_pedido)
);

-- Table: PERSONAS
CREATE TABLE PERSONAS (
    id_persona int NOT NULL identity(1,1),
    nombre varchar(20) NOT NULL,
    apellido varchar(20) NOT NULL,
    id_tipo_identificacion int NOT NULL,
    dni bigint NOT NULL,
    CONSTRAINT PERSONAS_pk PRIMARY KEY (id_persona)
);

-- Table: PRODUCTOS
CREATE TABLE PRODUCTOS (
    id_producto int NOT NULL identity(1,1),
    descripcion varchar(100) NOT NULL,
    id_tipo_producto int NOT NULL,
    id_rubro int NOT NULL,
    id_marca int NOT NULL,
    Observaciones varchar(50) NOT NULL,
    id_color int NOT NULL,
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
    descripcion int NOT NULL,
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
    id_direccion int NOT NULL,
    id_persona int NOT NULL,
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



-- Reference: CLIENTES_DIRECCIONES (table: CLIENTES)
ALTER TABLE CLIENTES ADD CONSTRAINT FK_CLIENTES_DIRECCIONES FOREIGN KEY (id_direccion)
    REFERENCES DIRECCIONES (id_direccion);

-- Reference: CLIENTES_EMPRESAS (table: CLIENTES)
ALTER TABLE CLIENTES ADD CONSTRAINT FK_CLIENTES_EMPRESAS FOREIGN KEY (id_empresa)
    REFERENCES EMPRESAS (id_empresa);

-- Reference: CLIENTES_PERSONAS (table: CLIENTES)
ALTER TABLE CLIENTES ADD CONSTRAINT FK_CLIENTES_PERSONAS FOREIGN KEY (id_persona)
    REFERENCES PERSONAS (id_persona);

-- Reference: CLIENTES_TIPOS_CLIENTES (table: CLIENTES)
ALTER TABLE CLIENTES ADD CONSTRAINT FK_CLIENTES_TIPOS_CLIENTES FOREIGN KEY (id_tipo_cliente)
    REFERENCES TIPOS_CLIENTES (id_tipo_cliente);

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

-- Reference: DIRECCIONES_BARRIOS (table: DIRECCIONES)
ALTER TABLE DIRECCIONES ADD CONSTRAINT FK_DIRECCIONES_BARRIOS FOREIGN KEY (id_barrio)
    REFERENCES BARRIOS (id_barrio);

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

-- Reference: PERSONAS_TIPO_IDENTIFICACION (table: PERSONAS)
ALTER TABLE PERSONAS ADD CONSTRAINT FK_PERSONAS_TIPO_IDENTIFICACION FOREIGN KEY  (id_tipo_identificacion)
    REFERENCES TIPO_IDENTIFICACION (id_tipo_identificacion);

-- Reference: PRODUCTOS_COLORES (table: PRODUCTOS)
ALTER TABLE PRODUCTOS ADD CONSTRAINT FK_PRODUCTOS_COLORES FOREIGN KEY(id_color)
    REFERENCES COLORES (id_color);

-- Reference: PRODUCTOS_MARCAS (table: PRODUCTOS)
ALTER TABLE PRODUCTOS ADD CONSTRAINT FK_PRODUCTOS_MARCAS FOREIGN KEY (id_marca)
    REFERENCES MARCAS (id_marca);

-- Reference: PRODUCTOS_RUBROS (table: PRODUCTOS)
ALTER TABLE PRODUCTOS ADD CONSTRAINT FK_PRODUCTOS_RUBROS FOREIGN KEY (id_rubro)
    REFERENCES RUBROS (id_rubro);

-- Reference: PRODUCTOS_TIPOS_PRODUCTOS (table: PRODUCTOS)
ALTER TABLE PRODUCTOS ADD CONSTRAINT FK_PRODUCTOS_TIPOS_PRODUCTOS FOREIGN KEY (id_tipo_producto)
    REFERENCES TIPOS_PRODUCTOS (id_tipo_producto);

-- Reference: VENDEDORES_DIRECCIONES (table: VENDEDORES)
ALTER TABLE VENDEDORES ADD CONSTRAINT FK_VENDEDORES_DIRECCIONES FOREIGN KEY (id_direccion)
    REFERENCES DIRECCIONES (id_direccion);

-- Reference: VENDEDORES_PERSONAS (table: VENDEDORES)
ALTER TABLE VENDEDORES ADD CONSTRAINT FK_VENDEDORES_PERSONAS FOREIGN KEY (id_persona)
    REFERENCES PERSONAS (id_persona);

-- End of file.

