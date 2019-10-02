Create database BaseDeDados
GO
USE BaseDeDadosHbsis
GO
CREATE TABLE [dbo].[Tipos] ( 
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Descricao]   NCHAR (50) NULL, --[1]Carros [2]Motos
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE [dbo].[Marcas] (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
	[Codigo] INT        NULL,
    [CodigoMarca] INT        NULL,
    [Marca]   NCHAR (50) NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO
CREATE TABLE [dbo].[Modelo] (
    [Id]     INT        IDENTITY (1, 1) NOT NULL,
	[Codigo] INT        NULL,
    [MarcaCodigo] INT        NULL,
	[CodigoTipo] INT   NULL, 
    [Descricao]   NCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO

INSERT INTO Tipos
(Codigo, Descricao) values (1, 'Carro'), (2, 'Moto')
GO

INSERT INTO Marcas
(Codigo,[CodigoMarca], [Marca]) values (1, 1, 'Audi'), (2,2,'Honda')
GO

INSERT INTO Modelo
(Codigo, [MarcaCodigo], [CodigoTipo],[Descricao]) values (1,1,1, 'A6 Avant')
GO

