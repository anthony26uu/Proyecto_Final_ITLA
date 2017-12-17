CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId]    NVARCHAR (150)  NOT NULL,
    [ContextKey]     NVARCHAR (300)  NOT NULL,
    [Model]          VARBINARY (MAX) NOT NULL,
    [ProductVersion] NVARCHAR (32)   NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED ([MigrationId] ASC, [ContextKey] ASC)
);

CREATE TABLE [dbo].[Clientes] (
    [ClienteId] INT            IDENTITY (1, 1) NOT NULL,
    [Nombres]   NVARCHAR (MAX) NULL,
    [Apellido]  VARCHAR(100) NULL,
    [Direccion] NVARCHAR (MAX) NULL,
    [Telefono]  NVARCHAR (MAX) NULL,
    [Email]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Clientes] PRIMARY KEY CLUSTERED ([ClienteId] ASC)
);

CREATE TABLE [dbo].[Facturas] (
    [FacturaId]     INT        IDENTITY (1, 1) NOT NULL,
    [ClienteId]     INT        NOT NULL,
    [Fecha]         DATETIME   NOT NULL,
    [CantidadPelicula] INT        NOT NULL,
    [SubTotal]      FLOAT (53) NOT NULL,
    [ITBIS]         FLOAT (53) NOT NULL,
    [Total]         FLOAT (53) NOT NULL,
    CONSTRAINT [PK_dbo.Facturas] PRIMARY KEY CLUSTERED ([FacturaId] ASC)
);


CREATE TABLE [dbo].[FacturasDetalles] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [FacturaId]  INT            NOT NULL,
    [PeliculaId] INT            NOT NULL,
    [Titulo]     NVARCHAR (MAX) NULL,
    [Precio]     FLOAT (53)     NOT NULL,
    CONSTRAINT [PK_dbo.FacturasDetalles] PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Peliculas] (
    [PeliculasId] INT            IDENTITY (1, 1) NOT NULL,
    [Titulo]      NVARCHAR (MAX) NULL,
    [Genero]      NVARCHAR (MAX) NULL,
    [Duracion]    INT            NOT NULL,
    [Precio]      FLOAT (53)     NOT NULL,
    CONSTRAINT [PK_dbo.Peliculas] PRIMARY KEY CLUSTERED ([PeliculasId] ASC)
);


CREATE TABLE [dbo].[Series] (
    [SeriesId]   INT            IDENTITY (1, 1) NOT NULL,
    [Titulo]     NVARCHAR (MAX) NULL,
    [Genero]     NVARCHAR (MAX) NULL,
    [Duracion]   INT            NOT NULL,
    [Precio]     FLOAT (53)     NOT NULL,
    [Existencia] INT            NULL,
    CONSTRAINT [PK_dbo.Series] PRIMARY KEY CLUSTERED ([SeriesId] ASC)
);


