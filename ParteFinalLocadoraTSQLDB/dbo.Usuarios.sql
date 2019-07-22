CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
    [Nome ]  VARCHAR (100) NOT NULL,
    [Ativo]  BIT           NOT NULL,
    [UsuInc] INT           NOT NULL,
    [DatInc] DATETIME      NOT NULL,
    [UsuAlt] INT           NOT NULL,
    [DatAlt] DATETIME      NOT NULL,
)
