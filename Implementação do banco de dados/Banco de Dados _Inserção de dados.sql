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
	TIPO_DE_CONTA VARCHAR(20) NOT NULL,
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

/* Inserindo dados nas tabelas */
INSERT INTO CLIENTE ( EMAIL, NOME_COMPLETO, SEXO, CPF, TELEFONE, CELULAR, DATA_NASCIMENTO)
VALUES ( 'brunamarquezinn@gmail.com','Bruna Marquezine', 'F', '4447788', '999999999', '888888888', '1980-12-17' ),
('manuzinha@gmail.com','Manuella Gavassi', 'F', '34300999', '888999999', '222888888', '1999-09-13' ),
('catarina@gmail.com','Catarina Maria', 'F', '44477788', '444999999', '844488888', '2000-09-03' ),
('luizsantos@gmail.com','Luiz Santos Souza', 'M', '36600999', '888966699', '266688888', '1980-05-23' ),
('cleopires@gmail.com','Cl�o Pires', 'F', '55554399', '555599999', '552888888', '1971-10-15' );

INSERT INTO	PROFISSIONAL(EMAIL, NOME_COMPLETO, SEXO, CPF, TELEFONE, CELULAR, DATA_NASCIMENTO,BANCO, TIPO_DE_CONTA, AGENCIA, CONTA_COM_DIGITO)
VALUES ('kefera@gmail.com','Kefera Silva', 'F', '99111111', '111111111', '211111111', '1958-11-30', 'Ita�', '333', '55555','11111111' ),
('mariabethania@gmail.com','Maria Beth�nia Oliveira', 'F', '888111111', '811111111', '811111111', '2002-03-02', 'Bradesco', '333', '88555','881111' ),
('gilbertogil@gmail.com','Gilberto Gil', 'M', '7771111', '711111111', '711111111', '1980-11-09', 'Ita�', 'Corrente', '333','55111' );

INSERT INTO	ENDERECO(LOGRADOURO, NUMERO, COMPLEMENTO, REFERENCIA, BAIRRO, CIDADE, ESTADO)
VALUES ('Rua Flor', '900', 'Pedra da Ostra', 'Mercad�o', 'Colinas', 'Presidente Prudente', 'SP'),
('Rua Jaci', '900', 'Br�s', 'Clube de Campo', 'Vila Maria', 'S�o Paulo', 'SP'),
('Rua Farol', '40', 'Leme ', 'Pedra da Luz', 'Escola Lima', 'Belo Horizonte', 'BH'),
('Mauro de Pr�spero', '930', 'Col�gio AAA', 'Mercad�o', 'Colinas', 'Presidente Prudente', 'SP');

INSERT INTO	ATENDIMENTO(LOGRADOURO, NUMERO, COMPLEMENTO, REFERENCIA, BAIRRO, CIDADE, ESTADO)
VALUES


/* Selecionando as tabelas do Banco de Dados */
SELECT * FROM CLIENTE;
SELECT * FROM PROFISSIONAL;
SELECT * FROM ENDERECO;






