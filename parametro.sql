USE [Estacionamiento]
GO

/****** Object:  Table [dbo].[parametro]    Script Date: 31/8/2016 12:05:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create  TABLE [dbo].[parametro](
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

