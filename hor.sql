USE [Estacionamiento]
GO

/****** Object:  UserDefinedFunction [dbo].[NormalizeHourForCompare]    Script Date: 17/07/2016 03:34:01 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- Author:	DBA
-- Create date: 15 de febrero
-- Description:	Normaliza las horas para poder comprararlas como fecha
-- =========================================================================
CREATE FUNCTION [dbo].[NormalizeHourForCompare]
(
	-- Add the parameters for the function here
	@fecha as datetime  = null	
)
RETURNS datetime
AS
BEGIN
	
	Declare @F as datetime
	Declare @C as varchar(20) 

    IF @fecha IS NULL 
	--ISO FORMAT DATE yyyymmdd 
		SET @C = '20010101:00:00:00'
	ELSE
		SET @C = CAST(DATEPART(YEAR,@fecha) AS varchar(4)) + RIGHT('00' + CAST(DATEPART(MONTH,@fecha) AS varchar(2)), 2) + RIGHT('00' + CAST(DATEPART(DAY,@fecha) AS varchar(2)), 2) + ' 00:00:00 '
		
	SET @F = CAST(@C AS datetime)

	RETURN @F
END



GO

