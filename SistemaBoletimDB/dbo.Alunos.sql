CREATE TABLE [dbo].[Alunos] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Nome]       VARCHAR (100) NOT NULL,
    [Disciplina] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    
	CONSTRAINT [FK_Alunos_Disciplina] 
	FOREIGN KEY ([Disciplina]) 
	REFERENCES [dbo].[Disciplinas] ([Id])
);

