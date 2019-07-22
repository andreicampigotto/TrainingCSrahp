CREATE TABLE [dbo].[Locacao] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Id_Cliente] INT           NOT NULL,
    [Id_Carro]   INT           NOT NULL,
    [Obs]        VARCHAR (250) NULL,
    [UsuRet]     INT           NOT NULL,
    [Data_Ret]   DATETIME      NOT NULL,
    [UsuDev]     INT           NOT NULL,
    [Data_Dev]   DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Locacao_Id_Cliente] FOREIGN KEY ([Id_CLiente]) REFERENCES [dbo].[Clientes] ([Id]),
	CONSTRAINT [FK_Locacao_Id_Carro] FOREIGN KEY ([Id_Carro]) REFERENCES [dbo].[Carros] ([Id]),
    CONSTRAINT [FK_Locacao_Usuarios_Ret] FOREIGN KEY ([UsuRet]) REFERENCES [dbo].[Usuarios] ([Id]),
    CONSTRAINT [FK_Locacao_Usuarios_Dev] FOREIGN KEY ([UsuDev]) REFERENCES [dbo].[Usuarios] ([Id])
);

