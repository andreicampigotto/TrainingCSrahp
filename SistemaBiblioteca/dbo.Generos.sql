CREATE TABLE [dbo].[Generos] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Tipo]      VARCHAR (200)  NOT NULL,
    [Descricao] VARCHAR (1200) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

