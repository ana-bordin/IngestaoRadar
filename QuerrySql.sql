CREATE DATABASE AdmRadar

USE AdmRadar

CREATE TABLE DadoRadar
(
    Id INT IDENTITY(1,1) NOT NULL,
    Concessionaria VARCHAR(MAX),
    AnoDoPnvSnv INT NOT NULL,
    TipoDeRadar VARCHAR(MAX),
    Rodovia VARCHAR(MAX),
    Uf VARCHAR(MAX),
    KmM DECIMAL(6,3),
    Municipio VARCHAR(MAX),
    TipoPista VARCHAR(MAX),
    Sentido VARCHAR(MAX),
    Situacao VARCHAR(MAX),
    DataDaInativacao VARCHAR(MAX),
    Latitude DECIMAL (8,6),
    Longitude DECIMAL (8,6),
    VelocidadeLeve INT,
	
	CONSTRAINT pk_Dados_Radares PRIMARY KEY (Id)
);

DROP TABLE DadoRadar