-- =============================================
-- Author:        <Jeffry Vargas>
-- Create date:   <21/04/22>
-- Description:   <Procedimiento que lista los clientes>
-- =============================================
CREATE PROCEDURE [dbo].[ClienteLista]
AS
BEGIN 
	SET NOCOUNT ON

	SELECT 
	       IdCliente
		 , CONCAT(Nombre,' ',PrimerApellido,' ',SegundoApellido) AS 'Nombre'
		 
	FROM
	     dbo.Cliente 

END