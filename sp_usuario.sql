USE [Estacionamiento]
GO

/****** Object:  StoredProcedure [dbo].[SP_tabla_usuario]    Script Date: 17/07/2016 03:19:05 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_tabla_usuario]
   	@Operacion varchar(1),
  	@idUsuario int,
	@usuario nvarchar(255),
	@contraseña nvarchar(50),
	@rol int

AS
BEGIN
 

/* -------------------------------------------------------------------------------------
    Table:       usuario 
   ------------------------------------------------------------------------------------- */



/* -------------------------------------------------------------------------------------
    Description: Operacion de insercion de registro.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'I'  BEGIN
   DECLARE @regs int
   SET @regs=(SELECT MAX(idUsuario)+1 FROM usuario)
   IF @regs IS NULL  SET @regs=1;
 
  INSERT INTO usuario
        (
		idUsuario,
		usuario,
		contraseña,
		rol

	)
  VALUES
        (
        @regs,
		
		@usuario,
		@contraseña,
		@rol

	)
END

 
/* -------------------------------------------------------------------------------------
    Description: Operacion de actualizacion de un registro.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'U'  BEGIN
  UPDATE usuario SET
  
		
		usuario = @usuario,
		contraseña = @contraseña,
		rol = @rol

 
  WHERE idUsuario=@idUsuario
END
 

/* -------------------------------------------------------------------------------------
    Description: Operacion de eliminaci�n de un registro.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'D'  BEGIN
   DELETE FROM usuario WHERE idUsuario=@idUsuario
END
 

/* -------------------------------------------------------------------------------------
    Description: Operacion de busqueda de un registro por su ID.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'F'  BEGIN
   SELECT  * 
   FROM usuario
   WHERE  idUsuario=@idUsuario
END
 

/* -------------------------------------------------------------------------------------
    Description: Operacion de seleccion de todos los registros.
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'S'  BEGIN
   SELECT  *
   FROM usuario
END
 

/* -------------------------------------------------------------------------------------
    Description: Operacion de busqueda de un registro para su ingreso al sistema
   ------------------------------------------------------------------------------------- */
IF @Operacion = 'A'  BEGIN
   SELECT  * 
   FROM usuario
   WHERE  usuario.usuario= @usuario and usuario.contraseña = @contraseña
END

END

GO

