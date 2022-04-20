
-- =============================================
-- Author:        <Jeaustin Sandoval>
-- Create date: <19/4/22>
-- Description:    <Procedimiento que obtiene los datos>
-- =============================================
CREATE PROCEDURE [dbo].[SolicitudObtener]
-------------------------------------------------
 @IdSolicitud INT = NULL
-------------------------------------------------
AS
BEGIN 
	SET NOCOUNT ON

	SELECT
	 S.IdSolicitud ,
	 C.IdCliente , --CLIENTE "C" DE CLIENTE
	 A.IdServicio  , --SERVICIO "A" DE APPLICATION 
	 S.Cantidad  ,
	 S.Monto ,
	 S.FechaEntrega ,
	 S.UsuarioEntrega ,
	 S.Observaciones 

	FROM
	    dbo.Solicitud S INNER JOIN dbo.Cliente C on S.IdCliente = C.IdCliente
		INNER JOIN dbo.Servicio A on S.IdServicio = A.IdServicio
	WHERE
	    (@IdSolicitud IS NULL OR S.IdSolicitud=@IdSolicitud)
	      

END