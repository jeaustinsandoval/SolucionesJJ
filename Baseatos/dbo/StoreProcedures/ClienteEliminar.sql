﻿
-- =============================================
-- Author:        <Jeaustin Sandoval>
-- Create date: <19/4/22>
-- Description:    <Procedimiento que elimina los datos>
-- =============================================

CREATE PROCEDURE [dbo].[ClienteEliminar]
-------------------------------------------------
 @IdCliente INT
-------------------------------------------------
AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA 
    
	BEGIN TRY
	 
	 DELETE FROM dbo.Cliente WHERE IdCliente=@IdCliente

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