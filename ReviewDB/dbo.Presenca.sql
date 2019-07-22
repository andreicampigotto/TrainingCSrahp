CREATE TABLE [dbo].[Presenca]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[Diario] INT NOT NULL,
	[Aluno] INT NOT NULL,

	CONSTRAINT [FK_Presenca_Diario] 
	FOREIGN KEY ([Diario]) 
	REFERENCES [Diarios]([Id]),

	CONSTRAINT [FK_Presenca_Aluno] 
	FOREIGN KEY ([Aluno]) 
	REFERENCES [Alunos]([Id]),
)
