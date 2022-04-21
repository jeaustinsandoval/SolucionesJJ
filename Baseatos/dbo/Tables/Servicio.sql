CREATE TABLE [dbo].[Servicio]
(
	[IdServicio] INT NOT NULL IDENTITY(1,1) CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED ([IdServicio] ASC), 
    [NombreServicio] VARCHAR (128) NULL, 
    [PlazoEntrega] INT NULL, 
    [CostoServicio] DECIMAL (18, 2) NULL,
    [Estado] BIT NULL Default 1,
    [CuentaContable] VARCHAR (50) NULL
)