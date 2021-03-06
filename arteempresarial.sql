USE [nuevo]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 13/12/2019 01:16:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[idArticulo] [int] IDENTITY(1,1) NOT NULL,
	[idtipoarticulo] [int] NOT NULL,
	[DescripcionArticulo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[idArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 13/12/2019 01:16:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[idCliente] [bigint] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [bigint] NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Celular1] [varchar](24) NOT NULL,
	[Celular2] [varchar](24) NULL,
	[Correo] [varchar](60) NULL,
	[Direccion] [varchar](255) NULL,
	[NombreEmpresa] [varchar](60) NULL,
	[FechaCreacion] [date] NULL,
	[RTN] [varchar](20) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 13/12/2019 01:16:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfiles](
	[idPerfil] [bigint] IDENTITY(1,1) NOT NULL,
	[DescripcionPerfil] [nvarchar](50) NOT NULL,
	[PerfilEstado] [bit] NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[idPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo de Articulo]    Script Date: 13/12/2019 01:16:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo de Articulo](
	[idtipoarticulo] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionTipoArticulo] [varchar](60) NOT NULL,
 CONSTRAINT [PK_Tipo de Articulo] PRIMARY KEY CLUSTERED 
(
	[idtipoarticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/12/2019 01:16:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](25) NOT NULL,
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Contrasena] [nvarchar](max) NOT NULL,
	[FKidperfil] [bigint] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta de Detalle]    Script Date: 13/12/2019 01:16:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta de Detalle](
	[idVentaDetalle] [bigint] IDENTITY(1,1) NOT NULL,
	[idVenta] [bigint] NOT NULL,
	[idArticulo] [int] NOT NULL,
	[Precio] [decimal](18, 2) NULL,
	[Cantidad] [int] NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[Impuesto] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Venta de Detalle] PRIMARY KEY CLUSTERED 
(
	[idVentaDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 13/12/2019 01:16:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[idVenta] [bigint] IDENTITY(1,1) NOT NULL,
	[idCliente] [bigint] NOT NULL,
	[IdUsuario] [bigint] NULL,
	[Fecha] [date] NULL,
	[Subtotal] [decimal](18, 2) NULL,
	[Totalimpuesto] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Tipo de Articulo] FOREIGN KEY([idtipoarticulo])
REFERENCES [dbo].[Tipo de Articulo] ([idtipoarticulo])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Tipo de Articulo]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Usuarios]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([FKidperfil])
REFERENCES [dbo].[Perfiles] ([idPerfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
ALTER TABLE [dbo].[Venta de Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Venta de Detalle_Articulos] FOREIGN KEY([idArticulo])
REFERENCES [dbo].[Articulos] ([idArticulo])
GO
ALTER TABLE [dbo].[Venta de Detalle] CHECK CONSTRAINT [FK_Venta de Detalle_Articulos]
GO
ALTER TABLE [dbo].[Venta de Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Venta de Detalle_Ventas] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Ventas] ([idVenta])
GO
ALTER TABLE [dbo].[Venta de Detalle] CHECK CONSTRAINT [FK_Venta de Detalle_Ventas]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Clientes] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Clientes] ([idCliente])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Clientes]
GO
