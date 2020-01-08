USE [Estacionamiento]
GO

/****** Object:  StoredProcedure [dbo].[SP_tabla_renta]    Script Date: 17/07/2016 03:18:56 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_tabla_renta]
   	@Operacion varchar(1),
  	@idRenta int,
	@fechaHoraInicio datetime,
	@fechaHoraTermino datetime,
	@boletoPerdido bit,
	@total decimal,
	@descuento decimal

AS
BEGIN
 

/* -------------------------------------------------------------------------------------
    Table:       renta 
   ------------------------------------------------------------------------------------- */



/* -------------------------------------------------------------------------------------
    Description: Operacion de insercion de registro.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'I'  BEGIN
   DECLARE @regs int
   SET @regs=(SELECT MAX(idRenta)+1 FROM renta)
   IF @regs IS NULL  SET @regs=1000;
 
  INSERT INTO renta
        (
		idRenta,
		fechaHoraInicio,
		fechaHoraTermino,
		boletoPerdido,
		total,
		descuento

	)
  VALUES
        (
        @regs,
		
		@fechaHoraInicio,
		@fechaHoraTermino,
		@boletoPerdido,
		@total,
		@descuento

	)
END

 
/* -------------------------------------------------------------------------------------
    Description: Operacion de actualizacion de un registro.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'U'  BEGIN
  UPDATE renta SET
  
		
		fechaHoraInicio = @fechaHoraInicio,
		fechaHoraTermino = @fechaHoraTermino,
		boletoPerdido = @boletoPerdido,
		total = @total,
		descuento = @descuento

 
  WHERE idRenta=@idRenta
END
 

/* -------------------------------------------------------------------------------------
    Description: Operacion de eliminaci�n de un registro.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'D'  BEGIN
   DELETE FROM renta WHERE idRenta=@idRenta
END
 

/* -------------------------------------------------------------------------------------
    Description: Operacion de busqueda de un registro por su ID.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'F'  BEGIN
   SELECT  * 
   FROM renta
   WHERE  idRenta=@idRenta
END
 

/* -------------------------------------------------------------------------------------
    Description: Operacion de seleccion de todos los registros.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'S'  BEGIN
   SELECT  *
   FROM renta
END
 
 
/* -------------------------------------------------------------------------------------
    Description: Operacion para obtener el utimo id generado
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'L'  BEGIN
   SELECT top 1 (idRenta)
   FROM renta
END
 

END

GO

