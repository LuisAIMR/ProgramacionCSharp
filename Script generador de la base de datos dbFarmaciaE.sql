USE [master]
GO
/****** Object:  Database [dbFarmaciaE]    Script Date: 07/07/2021 07:34:01 p. m. ******/
CREATE DATABASE [dbFarmaciaE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbFarmaciaE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbFarmaciaE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbFarmaciaE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbFarmaciaE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbFarmaciaE] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbFarmaciaE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbFarmaciaE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbFarmaciaE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbFarmaciaE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbFarmaciaE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbFarmaciaE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbFarmaciaE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbFarmaciaE] SET  MULTI_USER 
GO
ALTER DATABASE [dbFarmaciaE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbFarmaciaE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbFarmaciaE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbFarmaciaE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbFarmaciaE] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbFarmaciaE] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbFarmaciaE] SET QUERY_STORE = OFF
GO
USE [dbFarmaciaE]
GO
/****** Object:  User [feUsuario02]    Script Date: 07/07/2021 07:34:01 p. m. ******/
CREATE USER [feUsuario02] FOR LOGIN [feUsuario02] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [feUsuario01]    Script Date: 07/07/2021 07:34:01 p. m. ******/
CREATE USER [feUsuario01] FOR LOGIN [feUsuario01] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [feUsuario02]
GO
ALTER ROLE [db_datareader] ADD MEMBER [feUsuario02]
GO
ALTER ROLE [db_datareader] ADD MEMBER [feUsuario01]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [feUsuario01]
GO
/****** Object:  Table [dbo].[Baja]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Baja](
	[idBaja] [int] IDENTITY(1,1) NOT NULL,
	[lote] [varchar](8) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[cantidad] [int] NULL,
	[motivo] [varchar](400) NULL,
	[stat] [bit] NOT NULL,
	[idProducto] [int] NULL,
 CONSTRAINT [PK_IdBaja] PRIMARY KEY CLUSTERED 
(
	[idBaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idPersonaC] [int] NOT NULL,
	[alias] [varchar](15) NOT NULL,
	[punAcum] [int] NULL,
	[stat] [bit] NOT NULL,
 CONSTRAINT [PK_IdPersonaC] PRIMARY KEY CLUSTERED 
(
	[idPersonaC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[subtotal] [float] NOT NULL,
	[iva] [float] NOT NULL,
	[total] [float] NOT NULL,
	[fecha] [date] NOT NULL,
	[stat] [bit] NOT NULL,
	[idPersonaE] [int] NULL,
	[idProveedor] [int] NULL,
 CONSTRAINT [PK_IdCompra] PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Control_Alta_Empleados]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Control_Alta_Empleados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[operacion] [varchar](10) NULL,
	[usuario] [varchar](40) NULL,
	[host] [varchar](30) NULL,
	[modificado] [datetime] NULL,
	[tabla] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCP]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCP](
	[idproducto] [int] NOT NULL,
	[idCompra] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subTotal] [float] NOT NULL,
 CONSTRAINT [PK_DetalleCP] PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC,
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePT]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePT](
	[idTurno] [int] NOT NULL,
	[idPuesto] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[asis] [varchar](12) NOT NULL,
 CONSTRAINT [PK_DetallePT] PRIMARY KEY CLUSTERED 
(
	[idTurno] ASC,
	[idPuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVD]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVD](
	[idDevolucion] [int] NOT NULL,
	[idVenta] [int] NOT NULL,
	[precioVenta] [float] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subTotal] [float] NOT NULL,
 CONSTRAINT [PK_DetalleVD] PRIMARY KEY CLUSTERED 
(
	[idDevolucion] ASC,
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVP]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVP](
	[idproducto] [int] NOT NULL,
	[idVenta] [int] NOT NULL,
	[precioVenta] [float] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subTotal] [float] NOT NULL,
 CONSTRAINT [PK_DetalleVP] PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC,
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Devolucion]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devolucion](
	[idDevolucion] [int] IDENTITY(1,1) NOT NULL,
	[lote] [varchar](8) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[nuPrecio] [float] NOT NULL,
	[cantidad] [int] NULL,
	[motivo] [varchar](400) NULL,
	[stat] [bit] NOT NULL,
	[idProducto] [int] NULL,
 CONSTRAINT [PK_IdDevolucion] PRIMARY KEY CLUSTERED 
(
	[idDevolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idPersonaE] [int] NOT NULL,
	[imagenEmp] [image] NULL,
	[stat] [bit] NOT NULL,
	[idPuesto] [int] NULL,
	[idUsuario] [int] NULL,
 CONSTRAINT [PK_IdPersonaE] PRIMARY KEY CLUSTERED 
(
	[idPersonaE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EspecialP]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EspecialP](
	[idProducto] [int] NOT NULL,
	[fechaCad] [date] NOT NULL,
	[reqReceta] [bit] NOT NULL,
	[stat] [bit] NOT NULL,
 CONSTRAINT [PK_IdProductoE] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExtraVenta]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExtraVenta](
	[idVenta] [int] NOT NULL,
	[cedDoctor] [varchar](7) NULL,
 CONSTRAINT [PK_ExtraVenta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modulo]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modulo](
	[idModulo] [int] IDENTITY(1,1) NOT NULL,
	[nombreModulo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_IdModulo] PRIMARY KEY CLUSTERED 
(
	[idModulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operacion]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operacion](
	[idOperacion] [int] IDENTITY(1,1) NOT NULL,
	[nombreOperacion] [varchar](50) NOT NULL,
	[idModulo] [int] NOT NULL,
 CONSTRAINT [PK_IdOperacion] PRIMARY KEY CLUSTERED 
(
	[idOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil_Operacion]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil_Operacion](
	[idRol] [int] NOT NULL,
	[idOperacion] [int] NOT NULL,
 CONSTRAINT [PK_IdPerfil_Operacion] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC,
	[idOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apPat] [varchar](50) NOT NULL,
	[apMat] [varchar](50) NULL,
	[fechaNac] [date] NOT NULL,
	[curp] [varchar](18) NOT NULL,
	[telefono] [varchar](10) NOT NULL,
	[stat] [bit] NOT NULL,
 CONSTRAINT [PK_IdPersona] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[lote] [varchar](8) NOT NULL,
	[nombreP] [varchar](30) NOT NULL,
	[descripcionP] [varchar](400) NULL,
	[precio] [float] NOT NULL,
	[puntosCanjeo] [int] NULL,
	[cantidadP] [int] NULL,
	[puntos] [int] NULL,
	[stat] [bit] NOT NULL,
	[idTipo] [int] NOT NULL,
 CONSTRAINT [PK_IdProducto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombrePro] [varchar](50) NOT NULL,
	[telefono] [varchar](10) NOT NULL,
	[descripcion] [varchar](400) NULL,
	[stat] [bit] NOT NULL,
 CONSTRAINT [PK_IdProveedor] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores_auditados]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores_auditados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[operacion] [varchar](10) NULL,
	[usuario] [varchar](40) NULL,
	[host] [varchar](30) NULL,
	[modificado] [datetime] NULL,
	[tabla] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puesto]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puesto](
	[idPuesto] [int] IDENTITY(1,1) NOT NULL,
	[nombrePu] [varchar](15) NOT NULL,
	[salarioTurno] [int] NOT NULL,
	[stat] [bit] NOT NULL,
 CONSTRAINT [PK_IdPuesto] PRIMARY KEY CLUSTERED 
(
	[idPuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombreRol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_IdRol] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[nombreT] [varchar](50) NOT NULL,
	[stat] [bit] NOT NULL,
 CONSTRAINT [PK_IdTipo] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[idTurno] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](9) NOT NULL,
	[horaEntrada] [time](7) NOT NULL,
	[horaSalida] [time](7) NOT NULL,
	[dia] [varchar](9) NOT NULL,
	[stat] [bit] NOT NULL,
 CONSTRAINT [PK_IdTurno] PRIMARY KEY CLUSTERED 
(
	[idTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[alias] [varchar](20) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[contra] [varchar](20) NOT NULL,
	[stat] [bit] NOT NULL,
	[fecha] [datetime] NULL,
	[idRol] [int] NULL,
 CONSTRAINT [PK_IdUsuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[subtotal] [float] NOT NULL,
	[iva] [float] NOT NULL,
	[total] [float] NOT NULL,
	[folio] [varchar](10) NOT NULL,
	[fecha] [date] NOT NULL,
	[stat] [bit] NOT NULL,
	[idPersonaE] [int] NULL,
	[idPersonaC] [int] NULL,
 CONSTRAINT [PK_IdVenta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta_auditada]    Script Date: 07/07/2021 07:34:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta_auditada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[operacion] [varchar](10) NULL,
	[usuario] [varchar](40) NULL,
	[host] [varchar](30) NULL,
	[modificado] [datetime] NULL,
	[tabla] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Baja] ON 
GO
INSERT [dbo].[Baja] ([idBaja], [lote], [nombre], [cantidad], [motivo], [stat], [idProducto]) VALUES (3, N'00000008', N'pastillas2', 3, N'el producto caduco', 1, 2)
GO
SET IDENTITY_INSERT [dbo].[Baja] OFF
GO
INSERT [dbo].[Cliente] ([idPersonaC], [alias], [punAcum], [stat]) VALUES (1, N'juan94', 0, 1)
GO
INSERT [dbo].[Cliente] ([idPersonaC], [alias], [punAcum], [stat]) VALUES (2, N'ana322', 0, 1)
GO
INSERT [dbo].[Cliente] ([idPersonaC], [alias], [punAcum], [stat]) VALUES (3, N'juan552', 0, 1)
GO
INSERT [dbo].[Cliente] ([idPersonaC], [alias], [punAcum], [stat]) VALUES (8, N'brun322', 0, 1)
GO
SET IDENTITY_INSERT [dbo].[Compra] ON 
GO
INSERT [dbo].[Compra] ([idCompra], [subtotal], [iva], [total], [fecha], [stat], [idPersonaE], [idProveedor]) VALUES (16, 1001, 45, 2003, CAST(N'2021-05-08' AS Date), 1, 8, 2)
GO
INSERT [dbo].[Compra] ([idCompra], [subtotal], [iva], [total], [fecha], [stat], [idPersonaE], [idProveedor]) VALUES (17, 2200, 55, 2255, CAST(N'2021-05-08' AS Date), 1, 5, 1)
GO
INSERT [dbo].[Compra] ([idCompra], [subtotal], [iva], [total], [fecha], [stat], [idPersonaE], [idProveedor]) VALUES (18, 2200, 333, 2733, CAST(N'2021-05-08' AS Date), 1, 5, 2)
GO
INSERT [dbo].[Compra] ([idCompra], [subtotal], [iva], [total], [fecha], [stat], [idPersonaE], [idProveedor]) VALUES (19, 1400, 123, 1523, CAST(N'2021-05-08' AS Date), 1, 4, 3)
GO
INSERT [dbo].[Compra] ([idCompra], [subtotal], [iva], [total], [fecha], [stat], [idPersonaE], [idProveedor]) VALUES (20, 1400, 234, 1644, CAST(N'2021-05-08' AS Date), 1, 8, 2)
GO
INSERT [dbo].[Compra] ([idCompra], [subtotal], [iva], [total], [fecha], [stat], [idPersonaE], [idProveedor]) VALUES (21, 2200, 34, 2234, CAST(N'2021-06-23' AS Date), 1, 8, 2)
GO
SET IDENTITY_INSERT [dbo].[Compra] OFF
GO
SET IDENTITY_INSERT [dbo].[Control_Alta_Empleados] ON 
GO
INSERT [dbo].[Control_Alta_Empleados] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (1, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-03T12:58:09.590' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Control_Alta_Empleados] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (2, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-03T13:48:59.547' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Control_Alta_Empleados] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (3, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-03T13:49:40.360' AS DateTime), N'Empleado')
GO
INSERT [dbo].[Control_Alta_Empleados] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (4, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-25T19:42:48.343' AS DateTime), N'Empleado')
GO
SET IDENTITY_INSERT [dbo].[Control_Alta_Empleados] OFF
GO
INSERT [dbo].[DetalleCP] ([idproducto], [idCompra], [precio], [cantidad], [subTotal]) VALUES (1, 16, 300, 3, 900)
GO
INSERT [dbo].[DetalleCP] ([idproducto], [idCompra], [precio], [cantidad], [subTotal]) VALUES (1, 21, 300, 5, 1500)
GO
INSERT [dbo].[DetalleCP] ([idproducto], [idCompra], [precio], [cantidad], [subTotal]) VALUES (5, 18, 45, 2, 90)
GO
INSERT [dbo].[DetalleCP] ([idproducto], [idCompra], [precio], [cantidad], [subTotal]) VALUES (7, 17, 100, 3, 300)
GO
INSERT [dbo].[DetalleCP] ([idproducto], [idCompra], [precio], [cantidad], [subTotal]) VALUES (8, 19, 200, 3, 600)
GO
INSERT [dbo].[DetallePT] ([idTurno], [idPuesto], [fecha], [asis]) VALUES (5, 5, CAST(N'2021-07-10' AS Date), N'Inasistencia')
GO
INSERT [dbo].[DetallePT] ([idTurno], [idPuesto], [fecha], [asis]) VALUES (6, 3, CAST(N'2021-05-06' AS Date), N'Asistencia')
GO
INSERT [dbo].[DetallePT] ([idTurno], [idPuesto], [fecha], [asis]) VALUES (7, 2, CAST(N'2021-05-06' AS Date), N'Asistencia')
GO
INSERT [dbo].[DetalleVD] ([idDevolucion], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (1, 13, 300, 3, 900)
GO
INSERT [dbo].[DetalleVD] ([idDevolucion], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (2, 6, 100, 3, 300)
GO
INSERT [dbo].[DetalleVD] ([idDevolucion], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (2, 14, 300, 3, 900)
GO
INSERT [dbo].[DetalleVD] ([idDevolucion], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (3, 15, 200, 5, 1000)
GO
INSERT [dbo].[DetalleVP] ([idproducto], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (1, 6, 300, 3, 900)
GO
INSERT [dbo].[DetalleVP] ([idproducto], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (1, 21, 300, 3, 900)
GO
INSERT [dbo].[DetalleVP] ([idproducto], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (2, 14, 300, 3, 900)
GO
INSERT [dbo].[DetalleVP] ([idproducto], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (3, 13, 300, 3, 900)
GO
INSERT [dbo].[DetalleVP] ([idproducto], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (3, 30, 300, 3, 900)
GO
INSERT [dbo].[DetalleVP] ([idproducto], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (4, 15, 200, 5, 1000)
GO
INSERT [dbo].[DetalleVP] ([idproducto], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (4, 27, 300, 3, 900)
GO
INSERT [dbo].[DetalleVP] ([idproducto], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (5, 38, 300, 8, 240)
GO
INSERT [dbo].[DetalleVP] ([idproducto], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (6, 28, 300, 3, 900)
GO
INSERT [dbo].[DetalleVP] ([idproducto], [idVenta], [precioVenta], [cantidad], [subTotal]) VALUES (7, 15, 300, 3, 900)
GO
SET IDENTITY_INSERT [dbo].[Devolucion] ON 
GO
INSERT [dbo].[Devolucion] ([idDevolucion], [lote], [nombre], [nuPrecio], [cantidad], [motivo], [stat], [idProducto]) VALUES (1, N'1', N'paracetamol', 250, 3, N'no era el producto que queria el cliente', 1, 1)
GO
INSERT [dbo].[Devolucion] ([idDevolucion], [lote], [nombre], [nuPrecio], [cantidad], [motivo], [stat], [idProducto]) VALUES (2, N'6', N'gasas', 75, 5, N'no era el producto que queria el cliente', 1, 6)
GO
INSERT [dbo].[Devolucion] ([idDevolucion], [lote], [nombre], [nuPrecio], [cantidad], [motivo], [stat], [idProducto]) VALUES (3, N'5', N'suero', 35, 8, N'no era el producto que queria el cliente', 1, 5)
GO
INSERT [dbo].[Devolucion] ([idDevolucion], [lote], [nombre], [nuPrecio], [cantidad], [motivo], [stat], [idProducto]) VALUES (4, N'3', N'Jarabe', 50, 4, N'no era el producto que queria el cliente', 1, 3)
GO
INSERT [dbo].[Devolucion] ([idDevolucion], [lote], [nombre], [nuPrecio], [cantidad], [motivo], [stat], [idProducto]) VALUES (5, N'00000008', N'curitas', 330, 5, N'la bolsa de curitas estaba dañada cuando se compro', 1, 7)
GO
SET IDENTITY_INSERT [dbo].[Devolucion] OFF
GO
INSERT [dbo].[Empleado] ([idPersonaE], [imagenEmp], [stat], [idPuesto], [idUsuario]) VALUES (4, 0x433A5C496D6167656E4669636865726F322E626D70, 1, 3, 4)
GO
INSERT [dbo].[Empleado] ([idPersonaE], [imagenEmp], [stat], [idPuesto], [idUsuario]) VALUES (5, NULL, 1, 5, 1)
GO
INSERT [dbo].[Empleado] ([idPersonaE], [imagenEmp], [stat], [idPuesto], [idUsuario]) VALUES (6, 0x433A5C496D6167656E4669636865726F2E626D70, 1, 4, 8)
GO
INSERT [dbo].[Empleado] ([idPersonaE], [imagenEmp], [stat], [idPuesto], [idUsuario]) VALUES (8, NULL, 1, 3, 6)
GO
INSERT [dbo].[Empleado] ([idPersonaE], [imagenEmp], [stat], [idPuesto], [idUsuario]) VALUES (21, 0x433A5C496D6167656E4669636865726F2E626D70, 1, NULL, 9)
GO
INSERT [dbo].[Empleado] ([idPersonaE], [imagenEmp], [stat], [idPuesto], [idUsuario]) VALUES (22, 0x433A5C496D6167656E4669636865726F2E626D70, 1, NULL, 10)
GO
INSERT [dbo].[Empleado] ([idPersonaE], [imagenEmp], [stat], [idPuesto], [idUsuario]) VALUES (25, 0x433A5C496D6167656E4669636865726F322E626D70, 1, 1, 12)
GO
INSERT [dbo].[EspecialP] ([idProducto], [fechaCad], [reqReceta], [stat]) VALUES (1, CAST(N'2022-02-12' AS Date), 1, 1)
GO
INSERT [dbo].[EspecialP] ([idProducto], [fechaCad], [reqReceta], [stat]) VALUES (5, CAST(N'2021-08-15' AS Date), 0, 1)
GO
INSERT [dbo].[EspecialP] ([idProducto], [fechaCad], [reqReceta], [stat]) VALUES (13, CAST(N'2022-02-12' AS Date), 1, 1)
GO
INSERT [dbo].[EspecialP] ([idProducto], [fechaCad], [reqReceta], [stat]) VALUES (15, CAST(N'2022-02-12' AS Date), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Modulo] ON 
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (1, N'USUARIOS')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (2, N'ROLES')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (3, N'PRODUCTOS')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (4, N'COMPRA')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (5, N'VENTA')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (6, N'EMPLEADOS')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (7, N'CLIENTES')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (8, N'PROVEEDORES')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (9, N'BAJAS')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (10, N'HORARIOS')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (11, N'DEVOLUCIONES')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (12, N'REPORTES-VENTAS')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (13, N'REPORTES-COMPRAS')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (14, N'REPORTES-PRODUCTOS')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (15, N'REPORTES-EMPLEADOS')
GO
INSERT [dbo].[Modulo] ([idModulo], [nombreModulo]) VALUES (16, N'REPORTES-CLIENTES')
GO
SET IDENTITY_INSERT [dbo].[Modulo] OFF
GO
SET IDENTITY_INSERT [dbo].[Operacion] ON 
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (1, N'AGREGAR', 1)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (2, N'MOSTRAR', 1)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (3, N'ACTUALIZAR', 1)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (4, N'ELIMINAR', 1)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (5, N'AGREGAR', 2)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (6, N'MOSTRAR', 2)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (7, N'ACTUALIZAR', 2)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (8, N'ELIMINAR', 2)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (9, N'AGREGAR', 3)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (10, N'MOSTRAR', 3)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (11, N'ACTUALIZAR', 3)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (12, N'ELIMINAR', 3)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (13, N'AGREGAR', 4)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (14, N'MOSTRAR', 4)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (15, N'ACTUALIZAR', 4)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (16, N'ELIMINAR', 4)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (17, N'AGREGAR', 5)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (18, N'MOSTRAR', 5)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (19, N'ACTUALIZAR', 5)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (20, N'ELIMINAR', 5)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (21, N'AGREGAR', 6)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (22, N'MOSTRAR', 6)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (23, N'ACTUALIZAR', 6)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (24, N'ELIMINAR', 6)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (25, N'AGREGAR', 7)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (26, N'MOSTRAR', 7)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (27, N'ACTUALIZAR', 7)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (28, N'ELIMINAR', 7)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (29, N'AGREGAR', 8)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (30, N'MOSTRAR', 8)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (31, N'ACTUALIZAR', 8)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (32, N'ELIMINAR', 8)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (33, N'AGREGAR', 9)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (34, N'MOSTRAR', 9)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (35, N'ACTUALIZAR', 9)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (36, N'ELIMINAR', 9)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (37, N'AGREGAR', 10)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (38, N'MOSTRAR', 10)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (39, N'ACTUALIZAR', 10)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (40, N'ELIMINAR', 10)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (41, N'AGREGAR', 11)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (42, N'MOSTRAR', 11)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (43, N'ACTUALIZAR', 11)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (44, N'ELIMINAR', 11)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (45, N'MOSTRAR', 12)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (46, N'MOSTRAR', 13)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (47, N'MOSTRAR', 14)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (48, N'MOSTRAR', 15)
GO
INSERT [dbo].[Operacion] ([idOperacion], [nombreOperacion], [idModulo]) VALUES (49, N'MOSTRAR', 16)
GO
SET IDENTITY_INSERT [dbo].[Operacion] OFF
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 1)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 2)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 3)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 4)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 5)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 6)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 7)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 8)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 9)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 10)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 11)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 12)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 13)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 14)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 15)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 16)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 17)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 18)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 19)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 20)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 21)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 22)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 23)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 24)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 25)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 26)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 27)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 28)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 29)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 30)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 31)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 32)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 33)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 34)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 35)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 36)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 37)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 38)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 39)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 40)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 41)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 42)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 43)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 44)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 45)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 46)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 47)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 48)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (1, 49)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 1)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 2)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 5)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 6)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 9)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 10)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 13)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 14)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 17)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 18)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 21)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 22)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 25)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 26)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 29)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 30)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 33)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 34)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 37)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 38)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 41)
GO
INSERT [dbo].[Perfil_Operacion] ([idRol], [idOperacion]) VALUES (2, 42)
GO
SET IDENTITY_INSERT [dbo].[Persona] ON 
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (1, N'Maria Denis', N'Islas', N'Islas', CAST(N'2000-02-02' AS Date), N'MERL011127HNTZSSA6', N'3112264185', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (2, N'Ana', N'Zepeda', N'', CAST(N'2000-02-03' AS Date), N'MERL011028HNTZSSA6', N'3221112222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (3, N'Maria', N'Hernandez', N'islas', CAST(N'2000-02-12' AS Date), N'MERL011028HNTZSSA6', N'3221112222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (4, N'Maria', N'Solis', N'Nuñez', CAST(N'2000-06-12' AS Date), N'NUSO001205HNTZMMA6', N'3112243111', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (5, N'Denis', N'nuñez', N'estrada', CAST(N'2000-10-03' AS Date), N'MERL011028HNTZSSA6', N'3221112222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (6, N'Jose', N'Meza', N'Jimenez', CAST(N'2000-02-09' AS Date), N'MERL011028HNTZSSA6', N'3221112222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (7, N'Maria', N'Meza', N'Jimenez', CAST(N'2000-04-09' AS Date), N'MERL011028HNTZMMA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (8, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (9, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (10, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (11, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (12, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (13, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (14, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (15, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (16, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (17, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (18, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (19, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (20, N'Bruno', N'Rosales', N'Estrada', CAST(N'2000-04-09' AS Date), N'RORL011028HNTZHHA6', N'3111110222', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (21, N'Andrea', N'Perez', N'Fernandez', CAST(N'2000-02-02' AS Date), N'PEFA000500HNTZSSA6', N'3115643322', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (22, N'Andrea', N'Perez', N'Fernandez', CAST(N'2000-02-02' AS Date), N'PEFA000500HNTZSSA6', N'3115643322', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (23, N'Bruno', N'Meza', N'Rosales', CAST(N'2000-01-01' AS Date), N'MEBR011028HNTZSSA6', N'3112264321', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (24, N'Bruno', N'Meza', N'Rosales', CAST(N'2000-01-01' AS Date), N'MEBR011028HNTZSSA6', N'3112264321', 1)
GO
INSERT [dbo].[Persona] ([idPersona], [nombre], [apPat], [apMat], [fechaNac], [curp], [telefono], [stat]) VALUES (25, N'Bruno', N'Meza', N'Rosales', CAST(N'2000-01-01' AS Date), N'MEBR011028HNTZSSA6', N'3112264321', 1)
GO
SET IDENTITY_INSERT [dbo].[Persona] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (1, N'10', N'Paracetamol', N'pastillas para alivitar el dolor de espalda y funciona como desinflamante', 300, 3000, 7, 4, 1, 3)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (2, N'00000010', N'Pastillas2', N'Las pastillas dos sirven para aliviar los dolores musculares', 200, 2000, 9, 33, 0, 2)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (3, N'00000003', N'jarabe', N'producto producto producto descripcion de producto', 60, 2000, 7, 24, 1, 1)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (4, N'00000004', N'melox', N'producto producto producto descripcion de producto', 89, 999, 9, 9, 1, 2)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (5, N'00000005', N'suero', N'producto producto producto descripcion de producto', 45, 1954, 2, 23, 1, 2)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (6, N'00000006', N'gasas', N'producto producto producto descripcion de producto', 85, 3000, 2, 32, 1, 3)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (7, N'00000007', N'curitas', N'producto producto producto descripcion de producto', 344, 1232, 5, 32, 1, 3)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (8, N'00000008', N'treda', N'producto producto producto descripcion de producto', 200, 9864, 10, 153, 1, 2)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (12, N'14', N'EJEMPLO', N'DESCRIPCION EJEMPLO', 100, 10, 6, 10, 1, 1)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (13, N'00000015', N'pastillaejemplo', N'descripcion de pastilla ejemplo', 33.5, 2000, 6, 15, 1, 3)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (15, N'00000017', N'pastillaejemplo', N'descripcion de pastilla ejemplo', 33.5, 2000, 6, 15, 1, 3)
GO
INSERT [dbo].[Producto] ([idProducto], [lote], [nombreP], [descripcionP], [precio], [puntosCanjeo], [cantidadP], [puntos], [stat], [idTipo]) VALUES (16, N'00000012', N'EJEMPLOCONFORMATOLOTE', N'DESCRIPCION', 100, 10, 10, 1000, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 
GO
INSERT [dbo].[Proveedor] ([idProveedor], [nombrePro], [telefono], [descripcion], [stat]) VALUES (1, N'JONSON&JONSON', N'3111111111', N'EMPRESA DEDICADA A MEDICAMENTOS DE PANTENTE', 1)
GO
INSERT [dbo].[Proveedor] ([idProveedor], [nombrePro], [telefono], [descripcion], [stat]) VALUES (2, N'PFIZER', N'3111134122', N'EMPRESA DEDICADA A MEDICAMENTOS DE PANTENTE', 1)
GO
INSERT [dbo].[Proveedor] ([idProveedor], [nombrePro], [telefono], [descripcion], [stat]) VALUES (3, N'AZTRAZENECA', N'3112284433', N'EMPRESA DEDIDCADA A REALIZACION DE VACUNAS', 1)
GO
INSERT [dbo].[Proveedor] ([idProveedor], [nombrePro], [telefono], [descripcion], [stat]) VALUES (4, N'COMERCIALIZADORASACV', N'3113337744', N'EMPRESA DEDICADA A LA COMERCIALIZACIÓN DE PASTILLAS DE PATENTE', 1)
GO
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores_auditados] ON 
GO
INSERT [dbo].[Proveedores_auditados] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (1, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-24T22:06:28.697' AS DateTime), N'Proveedor')
GO
INSERT [dbo].[Proveedores_auditados] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (2, N'update', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-24T22:10:37.397' AS DateTime), N'Proveedor')
GO
INSERT [dbo].[Proveedores_auditados] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (3, N'delete', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-24T22:17:59.563' AS DateTime), N'Proveedor')
GO
SET IDENTITY_INSERT [dbo].[Proveedores_auditados] OFF
GO
SET IDENTITY_INSERT [dbo].[Puesto] ON 
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombrePu], [salarioTurno], [stat]) VALUES (1, N'Administrador', 500, 1)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombrePu], [salarioTurno], [stat]) VALUES (2, N'montacargas 1', 500, 0)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombrePu], [salarioTurno], [stat]) VALUES (3, N'Cajero2', 200, 1)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombrePu], [salarioTurno], [stat]) VALUES (4, N'Cajero3', 400, 1)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombrePu], [salarioTurno], [stat]) VALUES (5, N'Cajero4', 400, 1)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombrePu], [salarioTurno], [stat]) VALUES (6, N'Cajero5', 400, 1)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombrePu], [salarioTurno], [stat]) VALUES (7, N'Cajero6', 400, 1)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombrePu], [salarioTurno], [stat]) VALUES (8, N'Montacarga 5', 400, 1)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombrePu], [salarioTurno], [stat]) VALUES (9, N'Intendente', 400, 1)
GO
INSERT [dbo].[Puesto] ([idPuesto], [nombrePu], [salarioTurno], [stat]) VALUES (10, N'Cajero6', 400, 1)
GO
SET IDENTITY_INSERT [dbo].[Puesto] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 
GO
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (1, N'ADMINISTRADOR')
GO
INSERT [dbo].[Rol] ([idRol], [nombreRol]) VALUES (2, N'CAPTURISTA')
GO
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo] ON 
GO
INSERT [dbo].[Tipo] ([idTipo], [nombreT], [stat]) VALUES (1, N'Generic', 0)
GO
INSERT [dbo].[Tipo] ([idTipo], [nombreT], [stat]) VALUES (2, N'Patente', 1)
GO
INSERT [dbo].[Tipo] ([idTipo], [nombreT], [stat]) VALUES (3, N'Otros', 1)
GO
SET IDENTITY_INSERT [dbo].[Tipo] OFF
GO
SET IDENTITY_INSERT [dbo].[Turno] ON 
GO
INSERT [dbo].[Turno] ([idTurno], [tipo], [horaEntrada], [horaSalida], [dia], [stat]) VALUES (5, N'matutino', CAST(N'08:00:00' AS Time), CAST(N'14:00:00' AS Time), N'sabado', 0)
GO
INSERT [dbo].[Turno] ([idTurno], [tipo], [horaEntrada], [horaSalida], [dia], [stat]) VALUES (6, N'matutino', CAST(N'08:30:00' AS Time), CAST(N'14:30:00' AS Time), N'martes', 1)
GO
INSERT [dbo].[Turno] ([idTurno], [tipo], [horaEntrada], [horaSalida], [dia], [stat]) VALUES (7, N'matutino', CAST(N'08:30:00' AS Time), CAST(N'14:30:00' AS Time), N'miercoles', 1)
GO
INSERT [dbo].[Turno] ([idTurno], [tipo], [horaEntrada], [horaSalida], [dia], [stat]) VALUES (8, N'matutino', CAST(N'08:30:00' AS Time), CAST(N'14:30:00' AS Time), N'jueves', 1)
GO
INSERT [dbo].[Turno] ([idTurno], [tipo], [horaEntrada], [horaSalida], [dia], [stat]) VALUES (9, N'matutino', CAST(N'08:30:00' AS Time), CAST(N'14:30:00' AS Time), N'viernes', 1)
GO
SET IDENTITY_INSERT [dbo].[Turno] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([idUsuario], [alias], [email], [contra], [stat], [fecha], [idRol]) VALUES (1, N'juan233', N'lalal33@gmail.com', N'AAA111', 1, NULL, NULL)
GO
INSERT [dbo].[Usuario] ([idUsuario], [alias], [email], [contra], [stat], [fecha], [idRol]) VALUES (2, N'AAAuan233', N'lalal33@gmail.com', N'AAA111', 1, NULL, NULL)
GO
INSERT [dbo].[Usuario] ([idUsuario], [alias], [email], [contra], [stat], [fecha], [idRol]) VALUES (4, N'DeniMAr6663', N'lalal33@gmail.com', N'AAA111', 1, NULL, NULL)
GO
INSERT [dbo].[Usuario] ([idUsuario], [alias], [email], [contra], [stat], [fecha], [idRol]) VALUES (6, N'juan222', N'lalal33@gmail.com', N'AAA111', 1, CAST(N'2021-06-04T00:27:29.980' AS DateTime), 2)
GO
INSERT [dbo].[Usuario] ([idUsuario], [alias], [email], [contra], [stat], [fecha], [idRol]) VALUES (8, N'juan2222', N'lalal33@gmail.com', N'AAA111', 1, NULL, NULL)
GO
INSERT [dbo].[Usuario] ([idUsuario], [alias], [email], [contra], [stat], [fecha], [idRol]) VALUES (9, N'And43ea', N'andrea123@gmail.com', N'55333andr', 1, CAST(N'2021-06-04T00:27:29.917' AS DateTime), 1)
GO
INSERT [dbo].[Usuario] ([idUsuario], [alias], [email], [contra], [stat], [fecha], [idRol]) VALUES (10, N'And4333a', N'andrea123@gmail.com', N'55333andr', 1, NULL, NULL)
GO
INSERT [dbo].[Usuario] ([idUsuario], [alias], [email], [contra], [stat], [fecha], [idRol]) VALUES (11, N'feUsuarioejemplo', N'ejemplo123@gmail.com', N'123345675', 1, CAST(N'2021-06-05T12:24:41.870' AS DateTime), NULL)
GO
INSERT [dbo].[Usuario] ([idUsuario], [alias], [email], [contra], [stat], [fecha], [idRol]) VALUES (12, N'Brun23O', N'Brun45@gmail.com', N'brun4574', 1, CAST(N'2021-06-25T19:42:48.080' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (6, 1100, 1114, 2214, N'0000000002', CAST(N'2021-05-08' AS Date), 1, 4, 1)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (13, 1100, 1114, 2214, N'0000000003', CAST(N'2021-05-08' AS Date), 1, 8, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (14, 1100, 1114, 2214, N'0000000004', CAST(N'2021-05-08' AS Date), 1, 5, 1)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (15, 1100, 1114, 2214, N'0000000005', CAST(N'2021-05-08' AS Date), 0, 4, 1)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (18, 1100, 1334, 3311, N'0000000007', CAST(N'2021-05-09' AS Date), 1, 5, 1)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (19, 500, 1000, 1500, N'0000000008', CAST(N'2021-05-09' AS Date), 1, 4, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (20, 111, 112, 223, N'0000000010', CAST(N'2021-05-18' AS Date), 1, 5, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (21, 2000, 2010, 4010, N'0000000011', CAST(N'2021-05-27' AS Date), 1, 4, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (27, 2000, 2010, 4010, N'0000000012', CAST(N'2021-06-06' AS Date), 1, 4, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (28, 2000, 2010, 4010, N'0000000013', CAST(N'2021-06-06' AS Date), 1, 4, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (30, 2000, 2010, 4010, N'0000000014', CAST(N'2021-06-07' AS Date), 1, 4, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (34, 1100, 1114, 2214, N'0000000015', CAST(N'2021-06-24' AS Date), 1, 4, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (35, 1100, 1114, 2214, N'0000000015', CAST(N'2021-06-24' AS Date), 1, 4, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (36, 1100, 1114, 2214, N'0000000015', CAST(N'2021-06-24' AS Date), 1, 4, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (37, 1100, 1114, 2214, N'0000000015', CAST(N'2021-06-24' AS Date), 1, 4, 2)
GO
INSERT [dbo].[Venta] ([idVenta], [subtotal], [iva], [total], [folio], [fecha], [stat], [idPersonaE], [idPersonaC]) VALUES (38, 1100, 1114, 2214, N'0000000015', CAST(N'2021-06-24' AS Date), 1, 4, 2)
GO
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
SET IDENTITY_INSERT [dbo].[venta_auditada] ON 
GO
INSERT [dbo].[venta_auditada] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (1, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-07T09:37:32.437' AS DateTime), N'venta')
GO
INSERT [dbo].[venta_auditada] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (2, N'update', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-07T09:45:45.953' AS DateTime), N'venta')
GO
INSERT [dbo].[venta_auditada] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (3, N'delete', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-07T09:53:01.617' AS DateTime), N'venta')
GO
INSERT [dbo].[venta_auditada] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (4, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-24T17:21:12.287' AS DateTime), N'venta')
GO
INSERT [dbo].[venta_auditada] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (5, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-24T17:21:57.150' AS DateTime), N'venta')
GO
INSERT [dbo].[venta_auditada] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (6, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-24T17:22:40.727' AS DateTime), N'venta')
GO
INSERT [dbo].[venta_auditada] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (7, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-24T17:23:54.310' AS DateTime), N'venta')
GO
INSERT [dbo].[venta_auditada] ([id], [operacion], [usuario], [host], [modificado], [tabla]) VALUES (8, N'insert', N'LAPTOP-5TMMPCQ2\GeRaLsS4', N'LAPTOP-5TMMPCQ2\SQLEXPRESS', CAST(N'2021-06-24T17:44:15.097' AS DateTime), N'venta')
GO
SET IDENTITY_INSERT [dbo].[venta_auditada] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_loteB]    Script Date: 07/07/2021 07:34:03 p. m. ******/
ALTER TABLE [dbo].[Baja] ADD  CONSTRAINT [UQ_loteB] UNIQUE NONCLUSTERED 
(
	[lote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_nombreB]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_nombreB] ON [dbo].[Baja]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_aliasC]    Script Date: 07/07/2021 07:34:03 p. m. ******/
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [UQ_aliasC] UNIQUE NONCLUSTERED 
(
	[alias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_AliasC]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_AliasC] ON [dbo].[Cliente]
(
	[alias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_ApPatC]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_ApPatC] ON [dbo].[Cliente]
(
	[punAcum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_FechaC]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_FechaC] ON [dbo].[Compra]
(
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_TotalC]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_TotalC] ON [dbo].[Compra]
(
	[total] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Asistencia]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_Asistencia] ON [dbo].[DetallePT]
(
	[asis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_FechaPT]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_FechaPT] ON [dbo].[DetallePT]
(
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_nombreD]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_nombreD] ON [dbo].[Devolucion]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_IdUsuario]    Script Date: 07/07/2021 07:34:03 p. m. ******/
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [UQ_IdUsuario] UNIQUE NONCLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_StatEmpleado]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_StatEmpleado] ON [dbo].[Empleado]
(
	[stat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_FechaCad]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_FechaCad] ON [dbo].[EspecialP]
(
	[fechaCad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_ReqReceta]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_ReqReceta] ON [dbo].[EspecialP]
(
	[reqReceta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_CedDoctorVP]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_CedDoctorVP] ON [dbo].[ExtraVenta]
(
	[cedDoctor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_ApPatE]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_ApPatE] ON [dbo].[Persona]
(
	[apPat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_CurpE]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_CurpE] ON [dbo].[Persona]
(
	[curp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_nombreE]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_nombreE] ON [dbo].[Persona]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_lote]    Script Date: 07/07/2021 07:34:03 p. m. ******/
ALTER TABLE [dbo].[Producto] ADD  CONSTRAINT [UQ_lote] UNIQUE NONCLUSTERED 
(
	[lote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreP]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombreP] ON [dbo].[Producto]
(
	[nombreP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombrePro]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombrePro] ON [dbo].[Proveedor]
(
	[nombrePro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_nombrePu]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_nombrePu] ON [dbo].[Puesto]
(
	[nombrePu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_NombreT]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_NombreT] ON [dbo].[Tipo]
(
	[nombreT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Dia]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_Dia] ON [dbo].[Turno]
(
	[dia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Tipo]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_Tipo] ON [dbo].[Turno]
(
	[tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_AliasU]    Script Date: 07/07/2021 07:34:03 p. m. ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [UQ_AliasU] UNIQUE NONCLUSTERED 
(
	[alias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Correo]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_Correo] ON [dbo].[Usuario]
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_Usuario]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_Usuario] ON [dbo].[Usuario]
(
	[alias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_FechaV]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_FechaV] ON [dbo].[Venta]
(
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_FolioV]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_FolioV] ON [dbo].[Venta]
(
	[folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_TotalV]    Script Date: 07/07/2021 07:34:03 p. m. ******/
CREATE NONCLUSTERED INDEX [IDX_TotalV] ON [dbo].[Venta]
(
	[total] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Control_Alta_Empleados] ADD  DEFAULT (NULL) FOR [operacion]
GO
ALTER TABLE [dbo].[Control_Alta_Empleados] ADD  DEFAULT (NULL) FOR [usuario]
GO
ALTER TABLE [dbo].[Control_Alta_Empleados] ADD  DEFAULT (NULL) FOR [host]
GO
ALTER TABLE [dbo].[Control_Alta_Empleados] ADD  DEFAULT (NULL) FOR [modificado]
GO
ALTER TABLE [dbo].[Proveedores_auditados] ADD  DEFAULT (NULL) FOR [operacion]
GO
ALTER TABLE [dbo].[Proveedores_auditados] ADD  DEFAULT (NULL) FOR [usuario]
GO
ALTER TABLE [dbo].[Proveedores_auditados] ADD  DEFAULT (NULL) FOR [host]
GO
ALTER TABLE [dbo].[Proveedores_auditados] ADD  DEFAULT (NULL) FOR [modificado]
GO
ALTER TABLE [dbo].[venta_auditada] ADD  DEFAULT (NULL) FOR [operacion]
GO
ALTER TABLE [dbo].[venta_auditada] ADD  DEFAULT (NULL) FOR [usuario]
GO
ALTER TABLE [dbo].[venta_auditada] ADD  DEFAULT (NULL) FOR [host]
GO
ALTER TABLE [dbo].[venta_auditada] ADD  DEFAULT (NULL) FOR [modificado]
GO
ALTER TABLE [dbo].[Baja]  WITH CHECK ADD  CONSTRAINT [FK_IdProductoB] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[Baja] CHECK CONSTRAINT [FK_IdProductoB]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_IdPersonaC] FOREIGN KEY([idPersonaC])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_IdPersonaC]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_IdPersonaEC] FOREIGN KEY([idPersonaE])
REFERENCES [dbo].[Empleado] ([idPersonaE])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_IdPersonaEC]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Proveedor]
GO
ALTER TABLE [dbo].[DetalleCP]  WITH CHECK ADD  CONSTRAINT [FK_idCompraCP] FOREIGN KEY([idCompra])
REFERENCES [dbo].[Compra] ([idCompra])
GO
ALTER TABLE [dbo].[DetalleCP] CHECK CONSTRAINT [FK_idCompraCP]
GO
ALTER TABLE [dbo].[DetalleCP]  WITH CHECK ADD  CONSTRAINT [FK_idProductoCP] FOREIGN KEY([idproducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleCP] CHECK CONSTRAINT [FK_idProductoCP]
GO
ALTER TABLE [dbo].[DetallePT]  WITH CHECK ADD  CONSTRAINT [FK_idPuestoPT] FOREIGN KEY([idPuesto])
REFERENCES [dbo].[Puesto] ([idPuesto])
GO
ALTER TABLE [dbo].[DetallePT] CHECK CONSTRAINT [FK_idPuestoPT]
GO
ALTER TABLE [dbo].[DetallePT]  WITH CHECK ADD  CONSTRAINT [FK_idTurno] FOREIGN KEY([idTurno])
REFERENCES [dbo].[Turno] ([idTurno])
GO
ALTER TABLE [dbo].[DetallePT] CHECK CONSTRAINT [FK_idTurno]
GO
ALTER TABLE [dbo].[DetalleVD]  WITH CHECK ADD  CONSTRAINT [FK_idDevolucionVD] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[Devolucion] ([idDevolucion])
GO
ALTER TABLE [dbo].[DetalleVD] CHECK CONSTRAINT [FK_idDevolucionVD]
GO
ALTER TABLE [dbo].[DetalleVD]  WITH CHECK ADD  CONSTRAINT [FK_idVentaVD] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Venta] ([idVenta])
GO
ALTER TABLE [dbo].[DetalleVD] CHECK CONSTRAINT [FK_idVentaVD]
GO
ALTER TABLE [dbo].[DetalleVP]  WITH CHECK ADD  CONSTRAINT [FK_idProductoVP] FOREIGN KEY([idproducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleVP] CHECK CONSTRAINT [FK_idProductoVP]
GO
ALTER TABLE [dbo].[DetalleVP]  WITH CHECK ADD  CONSTRAINT [FK_idVentaVP] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Venta] ([idVenta])
GO
ALTER TABLE [dbo].[DetalleVP] CHECK CONSTRAINT [FK_idVentaVP]
GO
ALTER TABLE [dbo].[Devolucion]  WITH CHECK ADD  CONSTRAINT [FK_IdProductoD] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[Devolucion] CHECK CONSTRAINT [FK_IdProductoD]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_IdPersonaE] FOREIGN KEY([idPersonaE])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_IdPersonaE]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_IdPuesto] FOREIGN KEY([idPuesto])
REFERENCES [dbo].[Puesto] ([idPuesto])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_IdPuesto]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_IUsuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_IUsuario]
GO
ALTER TABLE [dbo].[EspecialP]  WITH CHECK ADD  CONSTRAINT [FK_IdProductoE] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[EspecialP] CHECK CONSTRAINT [FK_IdProductoE]
GO
ALTER TABLE [dbo].[ExtraVenta]  WITH CHECK ADD  CONSTRAINT [FK_ExtraVenta] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Venta] ([idVenta])
GO
ALTER TABLE [dbo].[ExtraVenta] CHECK CONSTRAINT [FK_ExtraVenta]
GO
ALTER TABLE [dbo].[Operacion]  WITH CHECK ADD  CONSTRAINT [FK_IdModulo] FOREIGN KEY([idModulo])
REFERENCES [dbo].[Modulo] ([idModulo])
GO
ALTER TABLE [dbo].[Operacion] CHECK CONSTRAINT [FK_IdModulo]
GO
ALTER TABLE [dbo].[Perfil_Operacion]  WITH CHECK ADD  CONSTRAINT [FK_IdOperacionPerfil] FOREIGN KEY([idOperacion])
REFERENCES [dbo].[Operacion] ([idOperacion])
GO
ALTER TABLE [dbo].[Perfil_Operacion] CHECK CONSTRAINT [FK_IdOperacionPerfil]
GO
ALTER TABLE [dbo].[Perfil_Operacion]  WITH CHECK ADD  CONSTRAINT [FK_IdRol_Perfil] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([idRol])
GO
ALTER TABLE [dbo].[Perfil_Operacion] CHECK CONSTRAINT [FK_IdRol_Perfil]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_IdTipo] FOREIGN KEY([idTipo])
REFERENCES [dbo].[Tipo] ([idTipo])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_IdTipo]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_IdRol] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([idRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_IdRol]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_IdPersonaCV] FOREIGN KEY([idPersonaC])
REFERENCES [dbo].[Cliente] ([idPersonaC])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_IdPersonaCV]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_IdPersonaEV] FOREIGN KEY([idPersonaE])
REFERENCES [dbo].[Empleado] ([idPersonaE])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_IdPersonaEV]
GO
ALTER TABLE [dbo].[Baja]  WITH CHECK ADD  CONSTRAINT [CK_CantidadB] CHECK  (([cantidad]>(-1)))
GO
ALTER TABLE [dbo].[Baja] CHECK CONSTRAINT [CK_CantidadB]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [CK_PunAcum] CHECK  (([punAcum]>=(0)))
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [CK_PunAcum]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [CK_FechaC] CHECK  ((datediff(year,[fecha],getdate())<=(0) AND datediff(month,[fecha],getdate())<=(0) AND datediff(day,[fecha],getdate())<=(0)))
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [CK_FechaC]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [CK_IvaC] CHECK  (([iva]>(0) AND [iva]<[subtotal]))
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [CK_IvaC]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [CK_SubTotalC] CHECK  (([subtotal]>(0)))
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [CK_SubTotalC]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [CK_TotalC] CHECK  (([total]>[subtotal]))
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [CK_TotalC]
GO
ALTER TABLE [dbo].[DetalleCP]  WITH CHECK ADD  CONSTRAINT [CK_CantidadCP] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[DetalleCP] CHECK CONSTRAINT [CK_CantidadCP]
GO
ALTER TABLE [dbo].[DetalleCP]  WITH CHECK ADD  CONSTRAINT [CK_PrecioCP] CHECK  (([Precio]>(0)))
GO
ALTER TABLE [dbo].[DetalleCP] CHECK CONSTRAINT [CK_PrecioCP]
GO
ALTER TABLE [dbo].[DetalleCP]  WITH CHECK ADD  CONSTRAINT [CK_subTotalCP] CHECK  (([subTotal]>(0)))
GO
ALTER TABLE [dbo].[DetalleCP] CHECK CONSTRAINT [CK_subTotalCP]
GO
ALTER TABLE [dbo].[DetallePT]  WITH CHECK ADD  CONSTRAINT [CK_Asis] CHECK  (([asis]='Asistencia' OR [asis]='Inasistencia'))
GO
ALTER TABLE [dbo].[DetallePT] CHECK CONSTRAINT [CK_Asis]
GO
ALTER TABLE [dbo].[DetallePT]  WITH CHECK ADD  CONSTRAINT [CK_Fecha] CHECK  ((datediff(year,[fecha],getdate())<=(0) AND datediff(month,[fecha],getdate())<=(0) AND datediff(day,[fecha],getdate())<=(0)))
GO
ALTER TABLE [dbo].[DetallePT] CHECK CONSTRAINT [CK_Fecha]
GO
ALTER TABLE [dbo].[DetalleVD]  WITH CHECK ADD  CONSTRAINT [CK_CantidadVD] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[DetalleVD] CHECK CONSTRAINT [CK_CantidadVD]
GO
ALTER TABLE [dbo].[DetalleVD]  WITH CHECK ADD  CONSTRAINT [CK_PrecioVentaVD] CHECK  (([precioVenta]>(0)))
GO
ALTER TABLE [dbo].[DetalleVD] CHECK CONSTRAINT [CK_PrecioVentaVD]
GO
ALTER TABLE [dbo].[DetalleVD]  WITH CHECK ADD  CONSTRAINT [CK_SubTotalVD] CHECK  (([subtotal]>(0)))
GO
ALTER TABLE [dbo].[DetalleVD] CHECK CONSTRAINT [CK_SubTotalVD]
GO
ALTER TABLE [dbo].[DetalleVP]  WITH CHECK ADD  CONSTRAINT [CK_CantidadVP] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[DetalleVP] CHECK CONSTRAINT [CK_CantidadVP]
GO
ALTER TABLE [dbo].[DetalleVP]  WITH CHECK ADD  CONSTRAINT [CK_PrecioVentaVP] CHECK  (([precioVenta]>(0)))
GO
ALTER TABLE [dbo].[DetalleVP] CHECK CONSTRAINT [CK_PrecioVentaVP]
GO
ALTER TABLE [dbo].[DetalleVP]  WITH CHECK ADD  CONSTRAINT [CK_SubTotalVP] CHECK  (([subtotal]>(0)))
GO
ALTER TABLE [dbo].[DetalleVP] CHECK CONSTRAINT [CK_SubTotalVP]
GO
ALTER TABLE [dbo].[Devolucion]  WITH CHECK ADD  CONSTRAINT [CK_CantidadD] CHECK  (([cantidad]>(0)))
GO
ALTER TABLE [dbo].[Devolucion] CHECK CONSTRAINT [CK_CantidadD]
GO
ALTER TABLE [dbo].[Devolucion]  WITH CHECK ADD  CONSTRAINT [CK_NuPrecio] CHECK  (([nuPrecio]>(0)))
GO
ALTER TABLE [dbo].[Devolucion] CHECK CONSTRAINT [CK_NuPrecio]
GO
ALTER TABLE [dbo].[EspecialP]  WITH CHECK ADD  CONSTRAINT [CK_FechaCad] CHECK  ((datediff(year,[fechaCad],getdate())<=(0) AND datediff(month,[fechaCad],getdate())<=(0) AND datediff(day,[fechaCad],getdate())<=(0)))
GO
ALTER TABLE [dbo].[EspecialP] CHECK CONSTRAINT [CK_FechaCad]
GO
ALTER TABLE [dbo].[ExtraVenta]  WITH CHECK ADD  CONSTRAINT [CK_cedDoctorVP] CHECK  (([cedDoctor] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[ExtraVenta] CHECK CONSTRAINT [CK_cedDoctorVP]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [CK_CurpE] CHECK  (([curp] like '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z][A-Z][A-Z][A-Z][A-Z][A-Z][0-9]'))
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [CK_CurpE]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [CK_Telefono] CHECK  (([telefono] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [CK_Telefono]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [CK_ValidarFechaMayor] CHECK  ((datediff(year,[fechaNac],getdate())>=(18) AND datediff(month,[fechaNac],getdate())>=(216) AND datediff(day,[fechaNac],getdate())>=(6575)))
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [CK_ValidarFechaMayor]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [CK_CantidadP] CHECK  (([cantidadP]>=(0) AND [CantidadP]<=(10)))
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [CK_CantidadP]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [CK_Precio] CHECK  (([precio]>(0)))
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [CK_Precio]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [CK_Puntos] CHECK  (([puntos]>=(0)))
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [CK_Puntos]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [CK_puntosCanjeo] CHECK  (([puntosCanjeo]>=(0)))
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [CK_puntosCanjeo]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [CK_TelefonoP] CHECK  (([telefono] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [CK_TelefonoP]
GO
ALTER TABLE [dbo].[Puesto]  WITH CHECK ADD  CONSTRAINT [CK_SalarioTurno] CHECK  (([salarioTurno]>(0)))
GO
ALTER TABLE [dbo].[Puesto] CHECK CONSTRAINT [CK_SalarioTurno]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [CK_Dia] CHECK  (([dia]='Lunes' OR [dia]='Martes' OR [dia]='Miercoles' OR [dia]='Jueves' OR [dia]='Viernes' OR [dia]='Sabado' OR [dia]='Domingo'))
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [CK_Dia]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [CK_Tipo] CHECK  (([tipo]='Matutino' OR [tipo]='Vespertino'))
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [CK_Tipo]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [ck_Email_01] CHECK  (([email] like '[a-z,0-9,_,-]%@[a-z,0-9,_,-]%.[a-z]%'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [ck_Email_01]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [ck_Email02] CHECK  ((NOT [email] like '%[^a-z0-9@._-]%'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [ck_Email02]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [ck_Email03] CHECK  ((NOT [email] like '%@%@%'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [ck_Email03]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [ck_Email04] CHECK  ((NOT [email] like '%.@%'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [ck_Email04]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [ck_Email05] CHECK  ((NOT [email] like '%..%'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [ck_Email05]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [ck_Email06] CHECK  ((NOT [email] like '%.'))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [ck_Email06]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [CK_FechaVP] CHECK  ((datediff(year,[fecha],getdate())=(0) AND datediff(month,[fecha],getdate())=(0) AND datediff(day,[fecha],getdate())=(0)))
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [CK_FechaVP]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [CK_FolioVP] CHECK  (([folio] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [CK_FolioVP]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [CK_IvaV] CHECK  (([iva]>(0) AND [iva]>[subtotal]))
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [CK_IvaV]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [CK_SubTotalV] CHECK  (([subtotal]>(0)))
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [CK_SubTotalV]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [CK_TotalV] CHECK  (([total]>[subtotal]))
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [CK_TotalV]
GO
/****** Object:  StoredProcedure [dbo].[proc_Empleado]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---Procedimiento almecenado
create procedure [dbo].[proc_Empleado]
@nombre VARCHAR(50),
@telefono VARCHAR (10)
as
begin 
	select * from empleado inner join Persona on Empleado.idPersonaE=Persona.idPersona
	where Persona.nombre=@nombre and Persona.telefono=@telefono;
	print 'Se encontraron resultados';
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ACTUALZIZARPROVEEDORES]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_ACTUALZIZARPROVEEDORES]
@id INT,
@NombreProveedor VARCHAR(50),
@Telefono VARCHAR(10),
@Descripcion VARCHAR(400)
AS
	UPDATE PROVEEDOR SET nombrePro=@NombreProveedor, telefono=@Telefono,descripcion=@Descripcion Where idProveedor=@id
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCARPROVEEDORES]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_BUSCARPROVEEDORES]
as
	select idProveedor, nombrePro, telefono, descripcion from proveedor
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSQUEDACOMPRAFECHA]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSQUEDACOMPRAFECHA]  --<<< SP_BUSQUEDACOMPRAFECHA>>>--
@fechaInicio DATE, --<<Parámetro de entrada para alias de usuario
@fechaFin DATE
AS
	select compra.subtotal, iva,total,fecha, detalleCP.cantidad ,nombreP,nombrePro --<<Se hace la selección de los campos..
	from Compra inner join DetalleCP on Compra.idCompra=DetalleCP.idCompra 
				inner join producto on DetalleCP.idProducto=Producto.idProducto 								
				inner join Proveedor on Proveedor.idProveedor=Compra.idProveedor -- ...de la tabla Proveedor, compra, detalleCP y producto...
	--where (fecha between @fechaInicio and @fechaFin) --... donde los parametros de entrada son @fechaInicio y @fechaFin >>--
	order by nombreP -- ordenados a partir del nombre
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSQUEDAPROVEEDOR]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSQUEDAPROVEEDOR]  --<<< SP_BUSQUEDAPROVEEDOR >>>--
@NombreBuscado VARCHAR(50) --<<Parametro de entrada para alias de usuario
AS
	select idProveedor, nombrePro, telefono, descripcion --<<Se hace la selección de los campos..
	from proveedor								-- ...de la tabla Proveedor...
	where nombrePro like '%'+@nombreBuscado+'%' --... donde el nombre sea como el parámetro de entrada @nombreBuscado>>--

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAREMPLEADO]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERTAREMPLEADO] --<<< SP_INSERTAREMPLEADO>>>--
@nombre VARCHAR(30),--<<
@apPat VARCHAR(50), --
@apMat VARCHAR(50), --
@fechaNac DATE,     --
@curp VARCHAR (18), -- 
@telefono VARCHAR(10),--Parametros de entrada
@alias VARCHAR(20),	  --
@email VARCHAR(50),   --
@contra VARCHAR(20),  --
@idPuesto int,        --
@stat int,            --
@imagenPerfil image   -->>
AS
begin--<<Inicio del procecimiento>>--
	DECLARE @idPersona int, @idUsuario int--<<Declaración de variables necesarias dentro del procedimiento almacenado
	INSERT INTO Persona VALUES(@nombre,@apPat,@apMat,@fechaNac,@curp,@telefono,@stat)--<<Inserción en la tabla persona
	set @idPersona=SCOPE_IDENTITY()--<<Asignación del valor de la variable @idPersona

	INSERT INTO Usuario	VALUES(@alias,@email,@contra,@stat,GETDATE(),NULL) --<<Inserción en la tabla usuario
	set @idUsuario=SCOPE_IDENTITY() --<<Asignación del valor de la variable @idUsuario

	INSERT INTO Empleado VALUES(@idPersona,@imagenPerfil,@stat,@idPuesto,@idUsuario)--<<Inserción en la tabla empleado
	Print('Se dio de alta un nuevo empleado')--mensaje para avisar que se inserto el empleado

	if(@@ERROR<>0)
		begin
			raiserror ('Hubo un error al ingresar la información', 16, 1)--Muestra del error  
			rollback transaction--regresa la transacción a como estaba antes de la ejecución
		end
end
--<<Fin del procedimiento almacenado/>>--
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTARPRODUCTO1]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_INSERTARPRODUCTO1]
@Lote VARCHAR(8),
@NombreP VARCHAR(30),
@DescripcionP VARCHAR(400),
@Precio FLOAT,  
@PuntosCanjeo INT,
@CantidadP INT,
@Puntos INT,
@Stat BIT,
@IdTipo INT
as

INSERT INTO Producto values (@Lote,@NombreP,@DescripcionP,@Precio,@PuntosCanjeo,@CantidadP,@Puntos,@stat,@IdTipo);
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTARPRODUCTO2]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[SP_INSERTARPRODUCTO2]
@Lote VARCHAR(8),
@NombreP VARCHAR(30),
@DescripcionP VARCHAR(400),
@Precio FLOAT,  
@PuntosCanjeo INT,
@CantidadP INT,
@Puntos INT,
@Stat BIT,
@IdTipo INT,
@fechaCad DATE,
@ReqReceta bit
as
begin
	INSERT INTO Producto values (@Lote,@NombreP,@DescripcionP,@Precio,@PuntosCanjeo,@CantidadP,@Puntos,@stat,@IdTipo);
		declare @IdProducto INT
		set @IdProducto= (select Max(idProducto) from Producto)
	INSERT INTO EspecialP VALUES (@IdProducto,@fechaCad,@ReqReceta,@Stat)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTARPROVEEDORES]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[SP_INSERTARPROVEEDORES]
@NombreProveedor VARCHAR(50),
@Telefono VARCHAR(10),
@Descripcion VARCHAR(400),
@stat bit
as 
	insert into proveedor values(@NombreProveedor,@Telefono,@Descripcion,@stat)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTARTIPO]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_INSERTARTIPO]
	@nombreTipo VARCHAR(11),
	@stat bit
As
	if(@nombreTipo='')
		print'No se pueden insertar tipos vacios'
	else
		insert into Tipo values (@nombreTipo,@stat)
GO
/****** Object:  StoredProcedure [dbo].[SP_MUESTRADATOSEMPLEADO]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MUESTRADATOSEMPLEADO] --<<< SP_MUESTRADATOSEMPLEADO>>>--
@alias VARCHAR(20), --<<Parametro de entrada para alias de usuario
@contra VARCHAR(20) --<<Parametro de entrada para la contraseña de usuario
AS
	select nombrePu, concat (nombre,+' ', apPat,+ ' ',apMat) As nombre --<<Se selecciona el nombre del puesto y la concatenación del nombre, apellido paterno y materno del empleado
	from persona inner join Empleado on idPersona=idPersonaE inner join Puesto on Empleado.idPuesto=Puesto.idPuesto--<< se muestra la...
	inner join Usuario on Empleado.idUsuario= Usuario.idUsuario													--...unión de las tablas necesarias para el proceso>>
	where alias=@alias and contra=@contra																		--<<Se realiza una sentencia where a partir de los parametros ingresados

--<<Fin del procedimiento almacenado/>>--
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTECLIENTES]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--<<<Procedimiento almacenado para reporte de clientes >>>--
Create proc [dbo].[SP_REPORTECLIENTES]
as 
select concat(Nombre,+' ',apPat,+' ',apMat) as NombreDelCliente , alias, count(idVenta) as CantidadComprasDeProductoRealizadas
from persona inner join cliente on idPersona=idPersonaC inner join venta on Cliente.idPersonaC=Venta.idPersonaC
group by Nombre, apPat, apMat, Cliente.alias

GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTEEMPLEADOS]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_REPORTEEMPLEADOS]
as 
select concat(Nombre,+' ',apPat,+' ',apMat) as NombreDelEmpleado , Usuario.alias, count(idVenta) as CantidadCVentasDeProductoRealizadas
from persona inner join Empleado on idPersona=idPersonaE inner join venta on Empleado.idPersonaE=venta.idPersonaE inner join Usuario on Empleado.idUsuario=Usuario.idUsuario
group by Nombre, apPat, apMat, Usuario.alias

GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTEPROVEEDORES]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_REPORTEPROVEEDORES]
as 
select Proveedor.nombrePro, telefono, count(idCompra) as ventasATiendaRealizadas
from Proveedor INNER jOIN Compra on Proveedor.idProveedor=Compra.idProveedor
group by nombrePro, telefono
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTEVENTAS]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_REPORTEVENTAS]
As
select Producto.idProducto, fecha,venta.folio, venta.total, DetalleVP.subtotal as SubtotalDelProducto, DetalleVP.cantidad, Producto.nombreP,CONCAT(Client.nombre,+' ', Client.apPat,+' ', Client.apMat) as Cliente ,CONCAT(Employee.nombre,+' ', Employee.apPat,+' ', Employee.apMat) as Empleado
from  Venta inner join detalleVP on Venta.idVenta=DetalleVP.idVenta 
			inner join Producto on DetalleVP.idproducto=Producto.idProducto
			inner join Cliente on venta.idPersonaC=Cliente.idPersonaC 
			inner join Empleado on venta.idPersonaE= Empleado.idPersonaE 
			inner join Persona as Client on Client.idPersona=Cliente.idPersonaC 
			inner join Persona as Employee on Employee.idPersona=Empleado.idPersonaE
order by venta.folio
GO
/****** Object:  StoredProcedure [dbo].[SP_VALIDARUSUARIO]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[SP_VALIDARUSUARIO]
@alias VARCHAR(20),
@contra VARCHAR(20)
AS
 select alias, contra from Usuario
 where alias=@alias and contra=@contra
GO
/****** Object:  Trigger [dbo].[TR_UPDATESTOCKCOMPRA]    Script Date: 07/07/2021 07:34:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[TR_UPDATESTOCKCOMPRA] --<<< TR_UPDATESTOCKCOMPRA>>>--
on [dbo].[DetalleCP]                 --<< Se especifica que será sobre la tabla: "detalleCP"--
after insert                 --<<Se activará el disparador después de una inserción a la tabla especificada anteriormente--
as
begin                                  --<< Se da inicio a lo que hará el disparador después de que se haga la inserción--
	update Producto                    --<< Se inicia una actualización en la tabla: "Producto"--
	set cantidadP=cantidadP+inserted.cantidad                                    --<< Se actualiza la cantidad de productos del producto comprado se suma la cantidad existente mas la cantidas insertada (por eso se especifica que es en "inserted")--
	from Producto join inserted on Producto.idProducto=inserted.idProducto       --<< Se especifica las tablas de la actualización (se hace una reunión porque se necesitan dos datos que estan en tablas diferentes)--
end                 --<<<Fin del trigger/>>>--  
GO
ALTER TABLE [dbo].[DetalleCP] ENABLE TRIGGER [TR_UPDATESTOCKCOMPRA]
GO
/****** Object:  Trigger [dbo].[TR_CANCELACIONPRODUCTO]    Script Date: 07/07/2021 07:34:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   trigger [dbo].[TR_CANCELACIONPRODUCTO]--<<< TR_CANCELACIONPRODUCTO>>>--
on [dbo].[DetalleVP] --<< Se especifica que será sobre la tabla: "detalleVP "--
after delete --<<Se activará el disparador después de una elimiación del registro de la tabla especificada anteriormente--
as 
begin--<< Se da inicio a lo que hará el disparador después de que se haga la eliminacion--
			 declare @idProducto int, @cantidadRegresada int --<<Declara variables necesarias para la actualización--
			
			 select														--<<Selección de las varibles dandoles un valor 
			  @idProducto= d.idProducto, @cantidadRegresada= d.cantidad -- Uso de la tabla Deleted--
			 from Deleted D												-- para almacenar los datos eliminados>>--

			 update producto											--<<
			 set cantidadP=cantidadP+@cantidadRegresada					--Actualización del stock del producto--
			 where idProducto=@idProducto								-->>

			 declare @nombrePro VARCHAR (14)							-- declaracion de la variable para cachar el nombre el producto cancelado
			 set @nombrePro=(select nombreP from Producto where idProducto=@idProducto)--- asignación del nombre de la información
			 print ('se actualizo el stock del producto ' +@nombrePro)-- Muestra de cual producto se actualizo			 
			 print ('se reañadieron: ' + cast(@cantidadRegresada as char(2)) + 'Productos' )--Muestra de la cantidad de productos que cancelaron su venta	 
end--<<<Fin del trigger/>>>--     
GO
ALTER TABLE [dbo].[DetalleVP] ENABLE TRIGGER [TR_CANCELACIONPRODUCTO]
GO
/****** Object:  Trigger [dbo].[TR_DISMINUIRSTOCK]    Script Date: 07/07/2021 07:34:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   TRIGGER [dbo].[TR_DISMINUIRSTOCK] --<<< TR_DISMINUIRSTOCK>>>--
on [dbo].[DetalleVP]  --<< Se especifica que será sobre la tabla: "detalleVP "--
after insert --<<Se activará el disparador después de una inserción a la tabla especificada anteriormente--
as
begin  --<< Se da inicio a lo que hará el disparador después de que se haga la inserción--
	declare @idProducto int, @cantidadVendida int --<<Declara variables necesarias para la actualización--

	select													--<<Selección de las varibles dandoles un valor 	
		@idProducto= i.idProducto, @cantidadVendida= i.cantidad		-- Uso de la tabla Inserted--
	from inserted I													-- para almacenar los datos insertados>>--

	if (@cantidadVendida<=(select cantidadP from Producto where idProducto=@idProducto)) --<< if para verificar que se cuentan con los productos necesarios 
		begin --Inicio del if
			declare @nombrePro VARCHAR (14)-- declaracion de la variable para cachar el nombre el producto vendido
			set @nombrePro=(select nombreP from Producto where idProducto=@idProducto)--- asignación del nombre de la información
			update Producto								--<<
			set cantidadP= cantidadP-@cantidadVendida	--Actualización del stock del producto--
			where idProducto= @idProducto				-->>
		 print ('se redujo el stock del producto ' +@nombrePro)-- Muestra de cual producto se actualizo
		 declare @stockStatus int   -- declaracion de la variable para cachar la cantidad del producto vendido
			select @stockStatus=cantidadP from Producto join inserted on Producto.idProducto=inserted.idProducto where Producto.idProducto=inserted.idProducto--Asignación de valor a la variable
			if(@stockStatus<=3) --If para verificar si la cantidad del producto es baja
				print ('El stock del producto está baja: ' + cast(@stockStatus as char(2)) + 'Productos' )--Muestra de mensaje en caos de que la cantidad de producto sea baja
		end--//>> Fin del if para verificar que se cuentan con los productos necesarios 
	else --else de if para verificar que se cuentan con los productos necesarios 
		begin --Inicio del else
			raiserror ('Hay menos libros en stock de los solicitados para la venta', 16, 1)--Muestra del error mostrado 
			rollback transaction--regresa la transacción a como estaba antes de la ejecución
		end --Fin del else
end  --<<<Fin del trigger/>>>--   
GO
ALTER TABLE [dbo].[DetalleVP] ENABLE TRIGGER [TR_DISMINUIRSTOCK]
GO
/****** Object:  Trigger [dbo].[tr_Alta_Empleados]    Script Date: 07/07/2021 07:34:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[tr_Alta_Empleados]
on [dbo].[Empleado]
after insert
as 
begin
insert into Control_Alta_Empleados(host,usuario,operacion,modificado, tabla)
   values (@@SERVERNAME,SUSER_NAME(),'insert',getdate(),'Empleado')
end
GO
ALTER TABLE [dbo].[Empleado] ENABLE TRIGGER [tr_Alta_Empleados]
GO
/****** Object:  Trigger [dbo].[TR_MOVIMIENTOSPROVEEDOR]    Script Date: 07/07/2021 07:34:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   trigger [dbo].[TR_MOVIMIENTOSPROVEEDOR] --<<<TR_MOVIMIENTOSPROVEEDOR>>>--
on [dbo].[Proveedor] --<< Se especifica que será sobre la tabla: "detalleVP "--
after insert, update, delete --<<Se activará el disparador después de una insertción, actualización o elimiación del registro de la tabla especificada anteriormente--
as
begin --<<Inicio del trigger>>--
--<<En caso de que existan las tablas inserted y deleted al momento de la ejecución del trigger, eso representa que la accion realizada es una actualizacion>>--
	if exists(SELECT * from inserted) and exists (SELECT * from deleted)	
	begin --<<Inicion del if
		insert into Proveedores_auditados (host,usuario,operacion,modificado, tabla)
		   values (@@SERVERNAME,SUSER_NAME(),'update',getdate(),'Proveedor')	
		   print ('Operación de actualización se añadio a la bitacora "Proveedores_auditados"')--Mensaje de la acción que se realizo 
	end --Cierre del if>>
	--<<En caso de que existan las tablas inserted al momento de la ejecución del trigger, eso representa que la accion realizada es una inserción>>--
	If exists (Select * from inserted) and not exists(Select * from deleted)
	begin--<<Inicion del if
		insert into Proveedores_auditados (host,usuario,operacion,modificado, tabla)	
			   values (@@SERVERNAME,SUSER_NAME(),'insert',getdate(),'Proveedor')
			   print ('Operación de inserción se añadio a la bitacora "Proveedores_auditados"')--Mensaje de la acción que se realizo 
	end --Cierre del if>>
	--<<En caso de que existan las tablas deleted al momento de la ejecución del trigger, eso representa que la accion realizada es una eliminacion>>--
	If exists(select * from deleted) and not exists(Select * from inserted)
	begin--<<Inicion del if
		insert into Proveedores_auditados (host,usuario,operacion,modificado, tabla)	
		   values (@@SERVERNAME,SUSER_NAME(),'delete',getdate(),'Proveedor')
		   print ('Operación de elimniación se añadio a la bitacora "Proveedores_auditados"')--Mensaje de la acción que se realizo 
	end--Cierre del if>>
end--<<<Fin del trigger/>>>-- 
GO
ALTER TABLE [dbo].[Proveedor] ENABLE TRIGGER [TR_MOVIMIENTOSPROVEEDOR]
GO
/****** Object:  Trigger [dbo].[tr_ventaA]    Script Date: 07/07/2021 07:34:04 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-->>Creacón de un trigger para almacenar la información dentro de la bitacora<<--
--creación de trigger tr_ventaA que se ejecuta despues de una actualización
create trigger [dbo].[tr_ventaA]
on [dbo].[Venta] 
after update 
as 
begin
insert into venta_auditada (host,usuario,operacion,modificado, tabla)
   values (@@SERVERNAME,SUSER_NAME(),'update',getdate(),'venta')
end
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [tr_ventaA]
GO
/****** Object:  Trigger [dbo].[tr_ventaE]    Script Date: 07/07/2021 07:34:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-->>Creacón de un trigger para almacenar la información dentro de la bitacora<<--
--creación de trigger tr_ventaE que se ejecuta despues de una elimación
create trigger [dbo].[tr_ventaE]
on [dbo].[Venta] 
after delete
as 
begin
insert into venta_auditada (host,usuario,operacion,modificado, tabla)
   values (@@SERVERNAME,SUSER_NAME(),'delete',getdate(),'venta')
end
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [tr_ventaE]
GO
/****** Object:  Trigger [dbo].[tr_ventaI]    Script Date: 07/07/2021 07:34:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-->>Creacón de un trigger para almacenar la información dentro de la bitacora<<--
--creación de trigger tr_ventaI que se ejecuta despues de una inserción
create trigger [dbo].[tr_ventaI]
on [dbo].[Venta] 
after insert
as 
begin
insert into venta_auditada (host,usuario,operacion,modificado, tabla)
   values (@@SERVERNAME,SUSER_NAME(),'insert',getdate(),'venta')
end
GO
ALTER TABLE [dbo].[Venta] ENABLE TRIGGER [tr_ventaI]
GO
USE [master]
GO
ALTER DATABASE [dbFarmaciaE] SET  READ_WRITE 
GO
