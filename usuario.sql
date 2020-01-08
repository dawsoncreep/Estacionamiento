USE [Estacionamiento]
GO

/****** Object:  Table [dbo].[usuario]    Script Date: 17/07/2016 03:18:10 p. m. ******/
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

