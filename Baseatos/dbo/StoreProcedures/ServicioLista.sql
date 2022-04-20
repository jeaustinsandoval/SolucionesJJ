-- =============================================
-- Author:        <Jeffry Vargas>
-- Create date:   <19/4/22>
-- Description:   <Procedimiento que obtiene los datos>
-- =============================================
CREATE PROCEDURE [dbo].[ServicioLista]
AS
BEGIN 
	SET NOCOUNT ON

	SELECT 
	       IdServicio
		 , NombreServicio
		 
	FROM
	     dbo.Servicio 

END