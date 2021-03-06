CREATE DATABASE InLock_Games_Manha

USE InLock_Games_Manha

CREATE TABLE ESTUDIOS (
	EstudioId INT IDENTITY PRIMARY KEY NOT NULL,
	NomeEstudio VARCHAR(100) UNIQUE NOT NULL
	) 

CREATE TABLE JOGOS (
	JogoId INT IDENTITY PRIMARY KEY, 
	NomeJogo VARCHAR(250) UNIQUE NOT NULL, 
	Descricao VARCHAR(300) NOT NULL, 
	DataLancamento DATETIME NOT NULL,
	Valor DECIMAL NOT NULL,
	EstudioId INT FOREIGN KEY REFERENCES ESTUDIOS(EstudioId)
	);

CREATE TABLE USUARIOS (
	UsuarioId INT IDENTITY PRIMARY KEY, 
	Email VARCHAR(250) UNIQUE NOT NULL, 
	Senha VARCHAR(250) NOT NULL, 
	TipoUsuario VARCHAR(250) NOT NULL
	);

