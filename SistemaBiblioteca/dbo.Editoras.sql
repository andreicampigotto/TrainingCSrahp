CREATE TABLE [dbo].[Editoras] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Nome]      VARCHAR (200)  NOT NULL,
    [Descricao] VARCHAR (1000) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

