--usar (localdb)\MSSQLLocalDB
create database gestion_ahorros;
GO
USE [gestion_ahorros]

CREATE TABLE usuarios (
    	"id" INT PRIMARY KEY IDENTITY (1, 1),
    	"mail" VARCHAR (150) NOT NULL UNIQUE,
    	"password" varchar(128) NOT NULL,
	"first_name" varchar(150) NOT NULL,
	"last_name" varchar(150) NOT NULL,
	"balance_pesos" real NOT NULL,
	"balance_dolar" real NOT NULL,
	"date_joined" datetime NOT NULL,
	"last_login" datetime NULL,
);

CREATE TABLE movimientos (
    	"id" INT PRIMARY KEY IDENTITY (1, 1),
	"total" real NOT NULL,
	"tipo" varchar(150) NOT NULL,
	"tipo_detalle" varchar(150) NULL,
	"hora" datetime NOT NULL,
	"id_usuario" INT NOT NULL,
	 FOREIGN KEY ("id_usuario") REFERENCES usuarios (id)
);
