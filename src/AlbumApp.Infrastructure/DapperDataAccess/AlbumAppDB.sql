create database AlbumApp
go

use AlbumApp
go

CREATE TABLE Artista
(
    Id uniqueidentifier NOT NULL,
    Nome nvarchar(250),
    CriadoEm  datetime2,
    AtualizadoEm datetime2
	PRIMARY KEY CLUSTERED 
	(
		Id ASC
	)
);
go

CREATE TABLE Album
(
    Id uniqueidentifier NOT NULL,
    ArtistaId uniqueidentifier NULL,
    Nome nvarchar(150) NOT NULL,
    QuantidadeFaixas int NULL,
    Duplo bit NULL,
    CriadoEm  datetime2,
    AtualizadoEm datetime2,
    FOREIGN KEY (ArtistaId) REFERENCES Artista(Id)
	PRIMARY KEY CLUSTERED 
	(
		Id ASC
	)
);
go

CREATE TABLE Musica
(
    Id uniqueidentifier NOT NULL,
    ArtistaId uniqueidentifier NULL,    
    Nome nvarchar(100) NOT NULL,
	Compositor nvarchar(250),
    CriadoEm  datetime2,
    AtualizadoEm datetime2,
    FOREIGN KEY (ArtistaId) REFERENCES Artista(Id)
	PRIMARY KEY CLUSTERED 
	(
		Id ASC
	)    
);
go

CREATE TABLE Midia
(
    Id uniqueidentifier NOT NULL,
    AlbumId uniqueidentifier NOT NULL,
    Caminho nvarchar(4000) NOT NULL,
    Tipo int,
    Ordem int,
    CriadoEm  datetime2,
    AtualizadoEm datetime2,
    FOREIGN KEY (AlbumId) REFERENCES Album(Id)
	PRIMARY KEY CLUSTERED 
	(
		Id ASC
	)    
);
go
CREATE TABLE Faixa
(    
    AlbumId uniqueidentifier NOT NULL,
	MusicaId uniqueidentifier NOT NULL,
    Indice int,    
    CriadoEm  datetime2,
    AtualizadoEm datetime2,
    FOREIGN KEY (AlbumId) REFERENCES Album(Id),
	FOREIGN KEY (MusicaId) REFERENCES Musica(Id)
	PRIMARY KEY CLUSTERED 
	(
		AlbumId, MusicaId ASC
	)    
);
go