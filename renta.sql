USE [Estacionamiento]
GO

/****** Object:  Table [dbo].[renta]    Script Date: 17/07/2016 03:17:58 p. m. ******/
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

