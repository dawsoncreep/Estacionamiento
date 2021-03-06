USE [master]
GO
/****** Object:  Database [Estacionamiento]    Script Date: 23/01/2017 05:54:03 p. m. ******/
CREATE DATABASE [Estacionamiento]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Estacionamiento', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Estacionamiento.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Estacionamiento_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Estacionamiento_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Estacionamiento] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Estacionamiento].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Estacionamiento] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Estacionamiento] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Estacionamiento] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Estacionamiento] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Estacionamiento] SET ARITHABORT OFF 
GO
ALTER DATABASE [Estacionamiento] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Estacionamiento] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Estacionamiento] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Estacionamiento] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Estacionamiento] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Estacionamiento] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Estacionamiento] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Estacionamiento] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Estacionamiento] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Estacionamiento] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Estacionamiento] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Estacionamiento] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Estacionamiento] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Estacionamiento] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Estacionamiento] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Estacionamiento] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Estacionamiento] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Estacionamiento] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Estacionamiento] SET RECOVERY FULL 
GO
ALTER DATABASE [Estacionamiento] SET  MULTI_USER 
GO
ALTER DATABASE [Estacionamiento] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Estacionamiento] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Estacionamiento] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Estacionamiento] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Estacionamiento', N'ON'
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 23/01/2017 05:54:03 p. m. ******/
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 23/01/2017 05:54:03 p. m. ******/
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLSERVERAGENT]    Script Date: 23/01/2017 05:54:03 p. m. ******/
CREATE LOGIN [NT SERVICE\SQLSERVERAGENT] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\ReportServer]    Script Date: 23/01/2017 05:54:03 p. m. ******/
CREATE LOGIN [NT SERVICE\ReportServer] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT Service\MSSQLSERVER]    Script Date: 23/01/2017 05:54:03 p. m. ******/
CREATE LOGIN [NT Service\MSSQLSERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 23/01/2017 05:54:03 p. m. ******/
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [DESKTOP-B80T1SG\getronics]    Script Date: 23/01/2017 05:54:03 p. m. ******/
CREATE LOGIN [DESKTOP-B80T1SG\getronics] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 23/01/2017 05:54:03 p. m. ******/
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'%ÕKV\F}ÍÒ(K Jí(H&´KL¸>', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 23/01/2017 05:54:03 p. m. ******/
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'''ª
`È{>£N)ÏáNfÊCiÌ·ÿºÀÙ¡', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLSERVERAGENT]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQLSERVER]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [DESKTOP-B80T1SG\getronics]
GO

USE [Estacionamiento]
GO
/****** Object:  StoredProcedure [dbo].[reporteDiario]    Script Date: 23/01/2017 05:54:03 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[SP_tabla_parametro]    Script Date: 23/01/2017 05:54:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_tabla_parametro]
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
/****** Object:  StoredProcedure [dbo].[SP_tabla_renta]    Script Date: 23/01/2017 05:54:03 p. m. ******/
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
/****** Object:  StoredProcedure [dbo].[SP_tabla_usuario]    Script Date: 23/01/2017 05:54:03 p. m. ******/
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
/****** Object:  UserDefinedFunction [dbo].[NormalizeHourForCompare]    Script Date: 23/01/2017 05:54:03 p. m. ******/
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
/****** Object:  UserDefinedFunction [dbo].[ultimoRegistro]    Script Date: 23/01/2017 05:54:03 p. m. ******/
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
/****** Object:  Table [dbo].[parametro]    Script Date: 23/01/2017 05:54:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parametro](
	[costoHora] [decimal](5, 2) NULL,
	[descuento] [decimal](5, 2) NULL,
	[nombreEmpresa] [nvarchar](255) NULL,
	[domicilio] [nvarchar](1500) NULL,
	[rfc] [nvarchar](13) NULL,
	[minTolerancia] [int] NULL,
	[idParametro] [int] NULL,
	[costoDia] [decimal](5, 2) NULL,
	[costoMes] [decimal](5, 2) NULL,
	[boletoPerdido] [decimal](5, 2) NULL,
	[leyenda] [nvarchar](300) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[renta]    Script Date: 23/01/2017 05:54:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[renta](
	[idRenta] [int] NOT NULL,
	[fechaHoraInicio] [datetime] NOT NULL,
	[fechaHoraTermino] [datetime] NULL,
	[boletoPerdido] [bit] NULL,
	[total] [decimal](5, 2) NULL,
	[descuento] [decimal](5, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuario]    Script Date: 23/01/2017 05:54:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[idUsuario] [int] NOT NULL,
	[usuario] [nvarchar](255) NULL,
	[contraseña] [nvarchar](50) NULL,
	[rol] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[parametro] ([costoHora], [descuento], [nombreEmpresa], [domicilio], [rfc], [minTolerancia], [idParametro], [costoDia], [costoMes], [boletoPerdido], [leyenda]) VALUES (CAST(10.00 AS Decimal(5, 2)), CAST(0.00 AS Decimal(5, 2)), N'ESTACIONAMIENTO', N'DOMICILIO', N'RFC', 10, 1, CAST(100.00 AS Decimal(5, 2)), CAST(100.00 AS Decimal(5, 2)), CAST(50.00 AS Decimal(5, 2)), N'LEYENDA')
INSERT [dbo].[renta] ([idRenta], [fechaHoraInicio], [fechaHoraTermino], [boletoPerdido], [total], [descuento]) VALUES (1000, CAST(0x0000A6F900D39080 AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[renta] ([idRenta], [fechaHoraInicio], [fechaHoraTermino], [boletoPerdido], [total], [descuento]) VALUES (1001, CAST(0x0000A6F900AD3F5D AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[usuario] ([idUsuario], [usuario], [contraseña], [rol]) VALUES (1, N'admin', N'admin', 1)
USE [master]
GO
ALTER DATABASE [Estacionamiento] SET  READ_WRITE 
GO
