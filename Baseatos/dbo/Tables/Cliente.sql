CREATE TABLE [dbo].[Cliente]
(
	[IdCliente] INT NOT NULL IDENTITY(1,1) CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED ([IdCliente] ASC), 
    [Identificacion] VARCHAR(128) NULL, 
    [IdTipoIdentificacion] INT NULL, 
    [Nombre] VARCHAR(128) NULL, 
    [PrimerApellido] VARCHAR(128) NULL, 
    [SegundoApellido] VARCHAR(128) NULL, 
    [FechaNacimiento] DATETIME NULL, 
    [Nacionalidad] INT NULL, 
    [FechaDefuncion] DATETIME NULL, 
    [Genero] CHAR(1) NULL, 
    [NombreApellidosPadre] VARCHAR(200) NULL, 
    [NombreApellidosMadre] VARCHAR(200) NULL, 
    [Pasaporte] VARCHAR(50) NULL, 
    [CuentaIBAN] VARCHAR(50) NULL, 
    [CorreoNotifica] VARCHAR(128) NULL
)
