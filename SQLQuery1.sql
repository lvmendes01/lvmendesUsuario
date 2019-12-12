
CREATE TABLE [dbo].[Autorizacao] (
    [Id] bigint NOT NULL IDENTITY,
    CONSTRAINT [PK_Autorizacao] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [dbo].[Sistema] (
    [Id] bigint NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    CONSTRAINT [PK_Sistema] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [dbo].[Usuario] (
    [Id] bigint NOT NULL IDENTITY,
    [Email] nvarchar(max) NULL,
    [Senha] nvarchar(max) NULL,
    [AutorizacoesId] bigint NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Usuario_Autorizacao_AutorizacoesId] FOREIGN KEY ([AutorizacoesId]) REFERENCES [dbo].[Autorizacao] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [dbo].[Perfil] (
    [Id] bigint NOT NULL IDENTITY,
    [SistemaId] bigint NULL,
    [Nome] nvarchar(max) NULL,
    [AutorizacoesId] bigint NULL,
    CONSTRAINT [PK_Perfil] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Perfil_Autorizacao_AutorizacoesId] FOREIGN KEY ([AutorizacoesId]) REFERENCES [dbo].[Autorizacao] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Perfil_Sistema_SistemaId] FOREIGN KEY ([SistemaId]) REFERENCES [dbo].[Sistema] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Perfil_AutorizacoesId] ON [dbo].[Perfil] ([AutorizacoesId]);

GO

CREATE INDEX [IX_Perfil_SistemaId] ON [dbo].[Perfil] ([SistemaId]);

GO

CREATE INDEX [IX_Usuario_AutorizacoesId] ON [dbo].[Usuario] ([AutorizacoesId]);

GO