USE [Estacionamiento]
GO




INSERT INTO [dbo].[parametro]
           ([costoHora]
           ,[descuento]
           ,[nombreEmpresa]
           ,[domicilio]
           ,[rfc]
           ,[minTolerancia]
           ,[idParametro]
           ,[costoDia]
           ,[costoMes]
           ,[boletoPerdido]
           ,[leyenda])
     VALUES
           (
		    10.0
           ,0
           ,'ESTACIONAMIENTO'
           ,'DOMICILIO'
           ,'RFC'
           ,10
           ,1
		   ,100
           ,100
           ,50
           ,'LEYENDA')
GO

USE [Estacionamiento]
GO

INSERT INTO [dbo].[usuario]
           ([idUsuario]
           ,[usuario]
           ,[contraseña]
           ,[rol])
     VALUES
           (1
           ,'admin'
           ,'admin'
           ,1)
GO





