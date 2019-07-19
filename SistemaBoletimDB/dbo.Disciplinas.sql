CREATE TABLE [dbo].[Disciplinas] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [NomeDiscipla] VARCHAR (100) NOT NULL,
    [Ativo]        BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

