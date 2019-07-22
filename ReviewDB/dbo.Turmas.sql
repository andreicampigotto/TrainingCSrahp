CREATE TABLE [dbo].[Turmas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Nome] VARCHAR(100) NOT NULL, 
    [Obs] VARCHAR(250) NULL,
	[Ativo] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatAlt] DATETIME NOT NULL, 
    
	CONSTRAINT [FK_Turmas_Usuarios_Inc] 
	FOREIGN KEY ([UsuInc]) 
	REFERENCES [Usuarios]([Id]),

	CONSTRAINT [FK_Turmas_Usuarios_Ant] 
	FOREIGN KEY ([UsuAlt]) 
	REFERENCES [Usuarios]([Id]),

)
