CREATE TABLE [dbo].[Livros]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Registro] INT NOT NULL,
	[Titulo] VARCHAR(1200) NOT NULL, 
    [Isbn] VARCHAR(15) NOT NULL, 
    [Genero] INT NOT NULL, 
    [Editora] INT NOT NULL, 
    [Sinopse] NVARCHAR(MAX) NULL, 
	[Observacoes] VARCHAR(1000) NULL,
	[Ativo]	bit NOT NULl,
    [UsuInc] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatAlt] NCHAR(10) NOT NULL, 
    
	CONSTRAINT [FK_Livros_ToGenero] 
	FOREIGN KEY ([Genero]) 
	REFERENCES [Generos]([Id]),
	
    CONSTRAINT [FK_Livros_ToEditora] 
	FOREIGN KEY ([Editora]) 
	REFERENCES [Editoras]([Id]),
	
	CONSTRAINT [FK_Livros_UsuInc] 
	FOREIGN KEY ([UsuInc]) 
	REFERENCES [Usuarios]([Id]),
	
	CONSTRAINT [FK_Livros_UsuAlt] 
	FOREIGN KEY ([UsuAlt]) 
	REFERENCES [Usuarios]([Id])

)
