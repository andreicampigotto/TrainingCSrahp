CREATE TABLE [dbo].[Alunos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Aluno] VARCHAR(100) NOT NULL, 
    [Ativo] BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatAlt] DATETIME NOT NULL, 
    
	CONSTRAINT [FK_Alunos_Usuarios_Inc] 
	FOREIGN KEY ([UsuInc]) 
	REFERENCES [Usuarios]([Id]),

	CONSTRAINT [FK_Alunos_Usuarios_Ant] 
	FOREIGN KEY ([UsuAlt]) 
	REFERENCES [Usuarios]([Id]),
)
