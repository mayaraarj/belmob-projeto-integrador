CREATE DATABASE BELMOB;

CREATE TABLE CLIENTE(
	ID_CLIENTE INT IDENTITY PRIMARY KEY NOT NULL,
	EMAIL VARCHAR(100) NOT NULL,
	NOME_COMPLETO VARCHAR(100) NOT NULL,
	SEXO CHAR NOT NULL,
	CPF INT NOT NULL,
	TELEFONE VARCHAR(20),
	CELULAR VARCHAR(20) NOT NULL,
	DATA_NASCIMENTO DATE NOT NULL
);

CREATE TABLE PROFISSIONAL(
	ID_PROFISSIONAL INT IDENTITY PRIMARY KEY NOT NULL,
	EMAIL VARCHAR(100) NOT NULL,
	NOME_COMPLETO VARCHAR(100) NOT NULL,
	SEXO CHAR NOT NULL,
	CPF INT NOT NULL,
	TELEFONE VARCHAR(20) NOT NULL,
	CELULAR INT NOT NULL,
	DATA_NASCIMENTO DATE NOT NULL,
	BANCO VARCHAR(20) NOT NULL,
	TIPO_DE_CONTA CHAR NOT NULL,
	AGENCIA INT NOT NULL,
	CONTA_COM_DIGITO INT NOT NULL,
);

CREATE TABLE ENDERECO(
	ID_ENDERECO  INT IDENTITY PRIMARY KEY NOT NULL,
	LOGRADOURO VARCHAR(100) NOT NULL,
	NUMERO INT NOT NULL,
	COMPLEMENTO VARCHAR(100),
	REFERENCIA VARCHAR(100),
	BAIRRO VARCHAR(100) NOT NULL,
	CIDADE VARCHAR(100) NOT NULL,
	ESTADO VARCHAR(100) NOT NULL
); 

CREATE TABLE ATENDIMENTO(
	ID_ATENDIMENTO INT IDENTITY PRIMARY KEY NOT NULL,
	DATA_ DATE NOT NULL,
	HORARIO TIME NOT NULL,
	ID_ENDERECO INT NOT NULL, 
	ID_CLIENTE INT NOT NULL,
	ID_PROFISSIONAL INT NOT NULL
	);

	ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ID_CLIENTE FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE (ID_CLIENTE);
	ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ID_PROFISSIONAL FOREIGN KEY (ID_PROFISSIONAL) REFERENCES PROFISSIONAL (ID_PROFISSIONAL);
	ALTER TABLE ATENDIMENTO ADD CONSTRAINT FK_ID_ENDERECO FOREIGN KEY (ID_ENDERECO) REFERENCES ENDERECO (ID_ENDERECO);