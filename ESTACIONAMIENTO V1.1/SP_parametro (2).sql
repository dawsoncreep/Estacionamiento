CREATE PROCEDURE SP_tabla_parametro
   	@Operacion varchar(1),
  	@costoHora decimal,
	@descuento decimal,
	@nombreEmpresa nvarchar(255),
	@domicilio nvarchar(1500),
	@rfc nvarchar(13),
	@minTolerancia int,
	@idParametro int,
	@costoDia decimal,
	@costoMes decimal,
	@boletoPerdido decimal,
	@leyenda nvarchar(300)

AS
BEGIN
 

/* -------------------------------------------------------------------------------------
    Table:       parametro 
   ------------------------------------------------------------------------------------- */



/* -------------------------------------------------------------------------------------
    Description: Operacion de insercion de registro.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'I'  BEGIN
   DECLARE @regs int
   SET @regs=(SELECT MAX(costoHora)+1 FROM parametro)
   IF @regs IS NULL  SET @regs=1;
 
  INSERT INTO parametro
        (
		costoHora,
		descuento,
		nombreEmpresa,
		domicilio,
		rfc,
		minTolerancia,
		idParametro,
		costoDia,
		costoMes,
		boletoPerdido,
		leyenda

	)
  VALUES
        (
        @regs,
		
		@descuento,
		@nombreEmpresa,
		@domicilio,
		@rfc,
		@minTolerancia,
		@idParametro,
		@costoDia,
		@costoMes,
		@boletoPerdido,
		@leyenda

	)
END

 
/* -------------------------------------------------------------------------------------
    Description: Operacion de actualizacion de un registro.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'U'  BEGIN
  UPDATE parametro SET
  
		
		descuento = @descuento,
		nombreEmpresa = @nombreEmpresa,
		domicilio = @domicilio,
		rfc = @rfc,
		minTolerancia = @minTolerancia,
		idParametro = @idParametro,
		costoDia = @costoDia,
		costoMes = @costoMes,
		boletoPerdido = @boletoPerdido,
		leyenda = @leyenda

 
  WHERE costoHora=@costoHora
END
 

/* -------------------------------------------------------------------------------------
    Description: Operacion de eliminaci�n de un registro.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'D'  BEGIN
   DELETE FROM parametro WHERE costoHora=@costoHora
END
 

/* -------------------------------------------------------------------------------------
    Description: Operacion de busqueda de un registro por su ID.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'F'  BEGIN
   SELECT  * 
   FROM parametro
   WHERE  costoHora=@costoHora
END
 

/* -------------------------------------------------------------------------------------
    Description: Operacion de seleccion de todos los registros.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'S'  BEGIN
   SELECT  *
   FROM parametro
END
 
END
GO
