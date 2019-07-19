CREATE TABLE [dbo].[Notas] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [Nota]  INT NOT NULL,
    [Aluno] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    
	CONSTRAINT [FK_Notas_Alunos] 
	FOREIGN KEY ([Aluno]) 
	REFERENCES [dbo].[Alunos] ([Id])
);

