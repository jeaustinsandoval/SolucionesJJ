-- =============================================
-- Author:        <Jeaustin Sandoval>
-- Create date: <19/4/22>
-- Description:    <Procedimiento que actualiza los datos>
-- =============================================

CREATE PROCEDURE [dbo].[ClienteActualizar]
-------------------------------------------------
 @IdCliente INT,
 @Identificacion VARCHAR (128),
 @IdTipoIdentificacion INT,
 @Nombre VARCHAR (128),
 @PrimerApellido VARCHAR (128),
 @SegundoApellido VARCHAR (128),
 @FechaNacimiento DATETIME ,
 @Nacionalidad INT ,
 @FechaDefuncion DATETIME ,
 @Genero CHAR (1) NULL,
 @NombreApellidosPadre VARCHAR (200),
 @NombreApellidosMadre VARCHAR (200),
 @Pasaporte VARCHAR (50),
 @CuentaIBAN VARCHAR(50),
 @CorreoNotifica VARCHAR(128)
-------------------------------------------------
AS
 BEGIN
  SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

  BEGIN TRY

  UPDATE dbo.Cliente SET 
	  
   	  Identificacion=	  @Identificacion
	, IdTipoIdentificacion = @IdTipoIdentificacion
	, Nombre = @Nombre
	, PrimerApellido =@PrimerApellido
	, SegundoApellido =@SegundoApellido
	, FechaNacimiento = @FechaNacimiento
	, Nacionalidad = @Nacionalidad
	, FechaDefuncion = @FechaDefuncion
	, Genero = @Genero
	, NombreApellidosPadre = @NombreApellidosPadre
	, NombreApellidosMadre = @NombreApellidosMadre
	, Pasaporte = @Pasaporte
	, CuentaIBAN = @CuentaIBAN
	, CorreoNotifica = @CorreoNotifica

  WHERE
     IdCliente=@IdCliente

  COMMIT TRANSACTION TRASA
  SELECT 0 AS CodeError, '' AS MsgError

  END TRY

	  BEGIN CATCH
		SELECT 
			   ERROR_NUMBER() AS CodeError,
			   ERROR_MESSAGE() AS MsgError

	  ROLLBACK TRANSACTION TRASA
  
  END CATCH

  END 
