CREATE TABLE [dbo].[Pessoa] (
    [Id]             INT         IDENTITY (1, 1) NOT NULL,
    [nome]           NCHAR (100) NULL,
    [Cidade]         NCHAR (50)  NULL,
    [Endereco]       NCHAR (50)  NULL,
    [Celular]        NCHAR (50)  NULL,
    [Email]          NCHAR (50)  NULL,
    [Datanascimento] NCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

