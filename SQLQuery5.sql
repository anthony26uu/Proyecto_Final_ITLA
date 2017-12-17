CREATE TABLE [dbo].[Series] (
    [SerieaId] INT            IDENTITY (1, 1) NOT NULL,
    [Titulo]      NVARCHAR (MAX) NULL,
    [Genero]      NVARCHAR (MAX) NULL,
    [Duracion]    INT            NOT NULL,
    [Precio]      FLOAT (53)     NOT NULL,
    [Existencia] INT NULL, 
    CONSTRAINT [PK_dbo.Series] PRIMARY KEY CLUSTERED ([SerieaId] ASC)
);

