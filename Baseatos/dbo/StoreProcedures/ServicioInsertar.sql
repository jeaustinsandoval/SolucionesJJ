
-- =============================================
-- Author:        <Jeaustin Sandoval - Jeffry Vargas>
-- Create date: <19/4/22>
-- Description:    <Procedimiento que inserta los datos>
-- =============================================

CREATE PROCEDURE [dbo].[ServicioInsertar]
-------------------------------------------------
 @IdServicio INT ,
 @NombreServicio VARCHAR (128),
 @PlazoEntrega INT ,
 @CostoServicio DECIMAL (18, 2) ,
 @Estado BIT = '1',
 @CuentaContable VARCHAR (50)  
-------------------------------------------------
AS
 BEGIN
  SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

  BEGIN TRY

  INSERT INTO dbo.Servicio
  (
	 IdServicio,
	 NombreServicio,
	 PlazoEntrega ,
	 CostoServicio ,
	 Estado ,
	 CuentaContable 

  )
  VALUES
  (
	 @IdServicio,
	 @NombreServicio,
	 @PlazoEntrega ,
	 @CostoServicio ,
	 @Estado ,
	 @CuentaContable 

  )

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