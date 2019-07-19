CREATE TABLE [dbo].[Turma] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [Aluno]      INT NOT NULL,
    [Disciplina] INT NOT NULL,
	[Status] BIT NOT NULL, 

    CONSTRAINT [FK_Alunos_Disciplinas] 
	FOREIGN KEY ([Disciplina]) 
	REFERENCES [Disciplinas]([Id]),

	CONSTRAINT [FK_Alunos_Alunos] 
	FOREIGN KEY ([Aluno]) 
	REFERENCES [Alunos]([Id]),

    PRIMARY KEY CLUSTERED ([Id] ASC)
);

