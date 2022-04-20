CREATE TABLE [dbo].[Solicitud]
(
IdSolicitud INT NOT NULL CONSTRAINT [PK_Solicitud] PRIMARY KEY CLUSTERED (IdSolicitud ASC),
IdCliente INT NOT NULL CONSTRAINT [FK_Solicitud_Cliente] FOREIGN KEY (IdCliente)REFERENCES dbo.Cliente (IdCliente),
 IdServicio INT NOT NULL CONSTRAINT [FK_Solicitud_Servicio] FOREIGN KEY (IdServicio) REFERENCES
dbo.Servicio (IdServicio),
 Cantidad INT NOT NULL CONSTRAINT [DF_Servicio_cantidad] DEFAULT ((1)) ,
 Monto DECIMAL (18, 2) NOT NULL,
 FechaEntrega DATETIME NULL,
 UsuarioEntrega VARCHAR (50) NULL,
 Observaciones VARCHAR(250) NULL 
)
