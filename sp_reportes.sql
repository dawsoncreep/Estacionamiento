USE [Estacionamiento]
GO

/****** Object:  StoredProcedure [dbo].[reporteDiario]    Script Date: 17/07/2016 03:18:36 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		jaime castorena
-- Create date: 06/07/2016
-- Description:	obtiene el reporte por los dias que se indiquen
-- =============================================
CREATE PROCEDURE [dbo].[reporteDiario] 
	-- Add the parameters for the stored procedure here
	@diaInicio datetime = null , 
	@diaFin datetime = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select sum(total) as TotalVenta, sum(descuento) as Descuentos, count(idrenta) as totalTickets, 
sum(CASE WHEN boletoPerdido=1 THEN 1 ELSE 0 END) as BoletosPerdidos
from renta
where cast(fechaHoraTermino as datetime) between @diaInicio and @diaFin

END

GO

