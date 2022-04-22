
-- =============================================
-- Author:      <Jeaustin Sandoval>
-- Create date: <19/4/22>
-- Description: <Procedimiento que obtiene los datos>
-- =============================================
CREATE PROCEDURE [dbo].[SolicitudObtener]
-------------------------------------------------
 @IdSolicitud INT = NULL
-------------------------------------------------
AS
BEGIN 
	SET NOCOUNT ON

	SELECT
	 SO.IdSolicitud,
	 SO.Cantidad,
	 SO.Monto ,
	 SO.FechaEntrega ,
	 SO.UsuarioEntrega ,
	 SO.Observaciones,
	 C.IdCliente,
	 CONCAT(C.Nombre,' ',C.PrimerApellido,' ',C.SegundoApellido) AS 'Nombre',
	 S.IdServicio,
	 S.NombreServicio

	FROM
	    dbo.Solicitud SO
		INNER JOIN dbo.Cliente C on SO.IdCliente = C.IdCliente
		INNER JOIN dbo.Servicio S on SO.IdServicio = S.IdServicio
	WHERE
	    (@IdSolicitud IS NULL OR SO.IdSolicitud=@IdSolicitud)

END