USE [Estacionamiento]
GO

/****** Object:  UserDefinedFunction [dbo].[ultimoRegistro]    Script Date: 17/07/2016 03:34:14 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jaime Castorena
-- Create date: 01/07/2016
-- Description:	
-- =============================================
CREATE FUNCTION [dbo].[ultimoRegistro] ()

	-- Add the parameters for the function here
	--@renta int

RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Result int

	-- Add the T-SQL statements to compute the return value here
	SELECT @Result = ( select top(1) renta.idRenta from renta order by fechaHoraInicio desc )

	-- Return the result of the function
	RETURN @Result

END

GO

