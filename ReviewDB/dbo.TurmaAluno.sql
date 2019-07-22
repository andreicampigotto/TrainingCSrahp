CREATE TABLE [dbo].[TurmaAlunos]
(
	[Turma] INT NOT NULL, 
    [Aluno] INT NOT NULL, 
   
   CONSTRAINT [FK_TurmaAlunos_Turmas] 
   FOREIGN KEY ([Turma]) REFERENCES [Turmas]([Id]),

   CONSTRAINT [FK_TurmaAlunos_Alunos] 
   FOREIGN KEY ([Aluno]) REFERENCES [Alunos]([Id]),
)
