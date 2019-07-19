CREATE TABLE [dbo].[Frequencias] (
    [Id]    INT      IDENTITY (1, 1) NOT NULL,
    [Ativo] BIT      NOT NULL,
    [Data]  DATETIME NOT NULL,
    [Aluno] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Frequencia_Alunos]
	FOREIGN KEY ([Aluno]) 
	REFERENCES [dbo].[Alunos] ([Id])
);

