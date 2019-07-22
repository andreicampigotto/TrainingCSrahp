CREATE TABLE [dbo].[Notas]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[Diario] INT NOT NULL,
	[Aluno] INT NOT NULL,
	[Nota] DECIMAL(2,2) NOT NULL, 
    
	CONSTRAINT [FK_Nota_Diaro] 
	FOREIGN KEY ([Diario]) 
	REFERENCES [Diarios]([Id]),

	CONSTRAINT [FK_Nota_Alunos] 
	FOREIGN KEY ([Aluno]) 
	REFERENCES [Alunos]([Id]),
)
