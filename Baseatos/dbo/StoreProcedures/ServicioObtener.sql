
-- =============================================
-- Author:        <Jeaustin Sandoval>
-- Create date:   <19/4/22>
-- Description:   <Procedimiento que obtiene los datos>
-- =============================================
CREATE PROCEDURE [dbo].[ServicioObtener]
-------------------------------------------------
 @IdServicio INT = NULL
-------------------------------------------------
AS
BEGIN 
	SET NOCOUNT ON

	SELECT
	 IdServicio,
	 NombreServicio,
	 PlazoEntrega ,
	 CostoServicio ,
	 Estado ,
	 CuentaContable  

	FROM
	    dbo.Servicio 
	WHERE
	    ( @IdServicio IS NULL OR  IdServicio = @IdServicio)
	      

END
