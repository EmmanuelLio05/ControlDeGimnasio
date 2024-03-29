USE [master]
GO
/****** Object:  Database [VO2MAX_CONTROL]    Script Date: 17/08/2022 10:48:20 p. m. ******/
CREATE DATABASE [VO2MAX_CONTROL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VO2MAX_CONTROL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\VO2MAX_CONTROL.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VO2MAX_CONTROL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\VO2MAX_CONTROL_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VO2MAX_CONTROL] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VO2MAX_CONTROL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VO2MAX_CONTROL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET ARITHABORT OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET  ENABLE_BROKER 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET RECOVERY FULL 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET  MULTI_USER 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VO2MAX_CONTROL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VO2MAX_CONTROL] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'VO2MAX_CONTROL', N'ON'
GO
ALTER DATABASE [VO2MAX_CONTROL] SET QUERY_STORE = OFF
GO
USE [VO2MAX_CONTROL]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [VO2MAX_CONTROL]
GO
/****** Object:  Table [dbo].[Aparato]    Script Date: 17/08/2022 10:48:20 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aparato](
	[Num_A] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_A] [varchar](50) NULL,
	[Estado_A] [bit] NULL,
 CONSTRAINT [pk_Aparato] PRIMARY KEY CLUSTERED 
(
	[Num_A] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clase]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clase](
	[Entrenador_C] [int] NULL,
	[Nombre_C] [varchar](30) NOT NULL,
	[Hora_C] [datetime] NULL,
	[Descripcion_C] [varchar](50) NULL,
 CONSTRAINT [pk_Clase] PRIMARY KEY CLUSTERED 
(
	[Nombre_C] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registros]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registros](
	[Id_R] [int] NOT NULL,
	[Numero_S] [int] NULL,
	[Hora_Entrada] [datetime] NULL,
	[Hora_Salida] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_R] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Socio]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socio](
	[Numero_S] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_S] [varchar](max) NULL,
	[Paterno_S] [varchar](max) NULL,
	[Materno_S] [varchar](max) NULL,
	[Imagen_S] [varbinary](1) NULL,
	[Direccion_S] [varchar](30) NULL,
	[Telefono_S] [varchar](30) NULL,
	[Fecha_I] [date] NULL,
	[E_Suscripcion] [bit] NULL,
	[Monto] [float] NULL,
 CONSTRAINT [pk_Socio] PRIMARY KEY CLUSTERED 
(
	[Numero_S] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Toma_Clase]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Toma_Clase](
	[Numero_S] [int] NULL,
	[Numero_E] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usa_Aparato]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usa_Aparato](
	[Numero_S] [int] NULL,
	[Numero_E] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[nID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_U] [varchar](50) NULL,
	[Contraseña_U] [varchar](10) NULL,
	[Profesion_U] [varchar](20) NULL,
	[Direccion_U] [varchar](30) NULL,
	[Telefono_U] [varchar](20) NULL,
	[Tipo_U] [varchar](1) NULL,
 CONSTRAINT [pk_Usuario] PRIMARY KEY CLUSTERED 
(
	[nID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aparato] ON 
GO
INSERT [dbo].[Aparato] ([Num_A], [Descripcion_A], [Estado_A]) VALUES (1, N'Banco press', 1)
GO
INSERT [dbo].[Aparato] ([Num_A], [Descripcion_A], [Estado_A]) VALUES (2, N'Prensa de piernas', 1)
GO
INSERT [dbo].[Aparato] ([Num_A], [Descripcion_A], [Estado_A]) VALUES (3, N'Máquina de dorsal', 1)
GO
INSERT [dbo].[Aparato] ([Num_A], [Descripcion_A], [Estado_A]) VALUES (4, N'Bicicleta estática', 1)
GO
INSERT [dbo].[Aparato] ([Num_A], [Descripcion_A], [Estado_A]) VALUES (5, N'Ciclo Indoor', 1)
GO
INSERT [dbo].[Aparato] ([Num_A], [Descripcion_A], [Estado_A]) VALUES (6, N'Elíptica', 1)
GO
INSERT [dbo].[Aparato] ([Num_A], [Descripcion_A], [Estado_A]) VALUES (7, N'Cinta de correr', 1)
GO
INSERT [dbo].[Aparato] ([Num_A], [Descripcion_A], [Estado_A]) VALUES (8, N'Máquinas de remo', 1)
GO
INSERT [dbo].[Aparato] ([Num_A], [Descripcion_A], [Estado_A]) VALUES (9, N'Máquina de femorales', 1)
GO
INSERT [dbo].[Aparato] ([Num_A], [Descripcion_A], [Estado_A]) VALUES (10, N'Poleas cruzadas', 0)
GO
SET IDENTITY_INSERT [dbo].[Aparato] OFF
GO
INSERT [dbo].[Clase] ([Entrenador_C], [Nombre_C], [Hora_C], [Descripcion_C]) VALUES (1, N'Body Combat', CAST(N'2021-12-01T10:00:00.000' AS DateTime), N'Duración 1:20')
GO
INSERT [dbo].[Clase] ([Entrenador_C], [Nombre_C], [Hora_C], [Descripcion_C]) VALUES (4, N'Xcore', CAST(N'2021-12-03T08:00:00.000' AS DateTime), N'Duración 1:20')
GO
INSERT [dbo].[Clase] ([Entrenador_C], [Nombre_C], [Hora_C], [Descripcion_C]) VALUES (2, N'Yoga', CAST(N'2021-12-02T08:00:00.000' AS DateTime), N'Duración 1:20')
GO
INSERT [dbo].[Clase] ([Entrenador_C], [Nombre_C], [Hora_C], [Descripcion_C]) VALUES (3, N'Zumba', CAST(N'2021-12-02T10:00:00.000' AS DateTime), N'Duración 1:20')
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (2, 2, CAST(N'2021-06-29T23:29:33.550' AS DateTime), CAST(N'2021-06-29T23:29:47.020' AS DateTime))
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (3, 2, CAST(N'2021-06-29T23:32:34.267' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (4, 2, CAST(N'2021-06-29T23:36:51.877' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (5, 2, CAST(N'2021-06-29T23:36:56.200' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (6, 2, CAST(N'2021-06-29T23:38:25.067' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (7, 2, CAST(N'2021-06-29T23:39:57.010' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (8, 2, CAST(N'2021-06-29T23:40:01.630' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (9, 2, CAST(N'2021-06-29T23:40:41.743' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (10, 2, CAST(N'2021-06-29T23:47:48.927' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (11, 2, CAST(N'2021-06-29T23:47:51.620' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (12, 2, CAST(N'2021-06-29T23:48:57.527' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (13, 3, CAST(N'2021-06-29T23:49:05.630' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (14, 5, CAST(N'2021-06-29T23:49:08.177' AS DateTime), NULL)
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (15, 3, CAST(N'2021-07-02T12:43:35.107' AS DateTime), CAST(N'2021-07-02T12:44:00.690' AS DateTime))
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (16, 2, CAST(N'2021-07-02T12:44:13.613' AS DateTime), CAST(N'2021-07-02T12:44:48.947' AS DateTime))
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (17, 5, CAST(N'2021-07-02T12:44:15.020' AS DateTime), CAST(N'2021-07-02T12:44:52.633' AS DateTime))
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (18, 6, CAST(N'2021-07-02T12:44:16.357' AS DateTime), CAST(N'2021-07-02T12:45:13.003' AS DateTime))
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (19, 1, CAST(N'2021-07-02T12:44:18.820' AS DateTime), CAST(N'2021-07-02T12:45:13.007' AS DateTime))
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (20, 5, CAST(N'2021-07-02T12:48:16.190' AS DateTime), CAST(N'2021-07-02T12:48:24.217' AS DateTime))
GO
INSERT [dbo].[Registros] ([Id_R], [Numero_S], [Hora_Entrada], [Hora_Salida]) VALUES (21, 4, CAST(N'2021-07-02T12:52:29.537' AS DateTime), CAST(N'2021-07-02T12:53:05.673' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Socio] ON 
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (1, N'Marley', N'Rippin', N'Padilla', NULL, N'911 Blanda Wall Apt. 491', N'(952) 837-6602', CAST(N'2021-12-01' AS Date), 1, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (2, N'Owen', N'Robel', N'Padilla', NULL, N'4984 Osvaldo Corner', N'(940) 646-6975-3626', CAST(N'2021-08-02' AS Date), 1, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (3, N'Isaac', N'Friesen', N'', NULL, N'91560 Hudson Haven', N'(593) 756-6939', CAST(N'2021-04-03' AS Date), 0, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (4, N'Jody', N'Crooks', N'Smit', NULL, N'65702 Hilario Ridge Apt. 714', N'1-304-251-9055', CAST(N'2021-02-04' AS Date), 1, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (5, N'Humberto', N'Upton', N'Casas', NULL, N'45929 Gottlieb Fall Suite 695', N'+1 (691) 747-2513', CAST(N'2021-05-05' AS Date), 1, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (6, N'Cornelius', N'Monahan', N'', NULL, N'81673 Dare Route', N'545-436-4233', CAST(N'2021-09-06' AS Date), 0, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (7, N'Mariela', N'Perez', N'Torres', NULL, N'223 Ruecker Stravenue Suite', N'(920) 512-3652', CAST(N'2021-11-07' AS Date), 0, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (8, N'Andre', N'Jast', N'', NULL, N'443 West Shoal Apt. 074', N'1-341-231-9014', CAST(N'2021-01-08' AS Date), 1, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (9, N'German', N'Torres', N'Olmos', NULL, N'35080 Bo Crest Apt. 540', N'(510) 657-2373-2143', CAST(N'2021-04-09' AS Date), 1, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (10, N'Jannie', N'Donnelly', N'', NULL, N'5293 Barrows Passage Suite', N'(789) 628-4421', CAST(N'2021-08-10' AS Date), 1, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (11, N'Angel', N'Martinez', N'', NULL, N'TEC LEON', N'1111111', CAST(N'2021-08-10' AS Date), 1, 350)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (12, N'Emilio', N'', N'Hernandez', NULL, N'Dirección', N'', CAST(N'2021-07-02' AS Date), 0, 654)
GO
INSERT [dbo].[Socio] ([Numero_S], [Nombre_S], [Paterno_S], [Materno_S], [Imagen_S], [Direccion_S], [Telefono_S], [Fecha_I], [E_Suscripcion], [Monto]) VALUES (13, N'Angel', N'Ramirez', N'Martinez', NULL, N'La Aparicion', N'Ramirez', CAST(N'2021-07-02' AS Date), 1, 350)
GO
SET IDENTITY_INSERT [dbo].[Socio] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([nID], [Nombre_U], [Contraseña_U], [Profesion_U], [Direccion_U], [Telefono_U], [Tipo_U]) VALUES (1, N'Saul Segura', N'THExClou', N'Preparador físico', N'929 Eleanore Roads Apt. 968', N'1-396-931-7879', N'A')
GO
INSERT [dbo].[Usuario] ([nID], [Nombre_U], [Contraseña_U], [Profesion_U], [Direccion_U], [Telefono_U], [Tipo_U]) VALUES (2, N'Javier Said', N'WmANotED', N'Preparador físico', N'24943 Alverta Springs', N'1-985-975-5858', N'E')
GO
INSERT [dbo].[Usuario] ([nID], [Nombre_U], [Contraseña_U], [Profesion_U], [Direccion_U], [Telefono_U], [Tipo_U]) VALUES (3, N'Alejandro Macias', N'ElbARCHE', N'Preparador físico', N'77749 Dale Meadow', N'515-918-8317', N'E')
GO
INSERT [dbo].[Usuario] ([nID], [Nombre_U], [Contraseña_U], [Profesion_U], [Direccion_U], [Telefono_U], [Tipo_U]) VALUES (4, N'Javier Martinez', N'oCHoSIdE', N'Preparador físico', N'62291 Edwin Isle', N'834-301-8277-3165', N'E')
GO
INSERT [dbo].[Usuario] ([nID], [Nombre_U], [Contraseña_U], [Profesion_U], [Direccion_U], [Telefono_U], [Tipo_U]) VALUES (5, N'Hugo Ramirez', N'RtOmENel', N'Preparador físico', N'Stravenue Suite 610', N'471-643-2194', N'E')
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Clase]  WITH CHECK ADD  CONSTRAINT [fk_Clase] FOREIGN KEY([Entrenador_C])
REFERENCES [dbo].[Usuario] ([nID])
GO
ALTER TABLE [dbo].[Clase] CHECK CONSTRAINT [fk_Clase]
GO
ALTER TABLE [dbo].[Registros]  WITH CHECK ADD FOREIGN KEY([Numero_S])
REFERENCES [dbo].[Socio] ([Numero_S])
GO
ALTER TABLE [dbo].[Toma_Clase]  WITH CHECK ADD FOREIGN KEY([Numero_S])
REFERENCES [dbo].[Socio] ([Numero_S])
GO
ALTER TABLE [dbo].[Toma_Clase]  WITH CHECK ADD FOREIGN KEY([Numero_E])
REFERENCES [dbo].[Usuario] ([nID])
GO
ALTER TABLE [dbo].[Usa_Aparato]  WITH CHECK ADD FOREIGN KEY([Numero_S])
REFERENCES [dbo].[Socio] ([Numero_S])
GO
ALTER TABLE [dbo].[Usa_Aparato]  WITH CHECK ADD FOREIGN KEY([Numero_E])
REFERENCES [dbo].[Aparato] ([Num_A])
GO
/****** Object:  StoredProcedure [dbo].[Aparato_Disable]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Aparato_Disable]
	@Num_A AS int
AS
BEGIN
	UPDATE Aparato
	SET [Estado_A] = 0
	WHERE [Num_A] = @Num_A
END
GO
/****** Object:  StoredProcedure [dbo].[Aparato_GetAll]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Aparato_GetAll]
AS
BEGIN
	SELECT * FROM dbo.Aparato
END
GO
/****** Object:  StoredProcedure [dbo].[Aparato_GetOne]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Aparato_GetOne]
	@Num_A AS int
AS
BEGIN
	SELECT * FROM dbo.Aparato
	WHERE [Num_A] = @Num_A
END
GO
/****** Object:  StoredProcedure [dbo].[Aparato_Insert]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------Aparato------------------------
CREATE PROCEDURE [dbo].[Aparato_Insert]
	@Estado_A AS bit,
	@Descripcion_A AS varchar(50)
	--@Num_A AS int
AS
BEGIN 
	INSERT INTO Aparato VALUES(
		--@Num_A,
		@Descripcion_A,
		@Estado_A)
END
GO
/****** Object:  StoredProcedure [dbo].[Aparato_Update]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Aparato_Update]
@Estado_A AS bit,
@Descripcion_A AS varchar(50),
@Num_A AS int
AS
BEGIN
	UPDATE Aparato
	SET [Estado_A] = @Estado_A,
[Descripcion_A] = @Descripcion_A
	WHERE [Num_A] = @Num_A
END
GO
/****** Object:  StoredProcedure [dbo].[Clase_GetAll]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Clase_GetAll]
AS
BEGIN
	SELECT * FROM dbo.Clase
END
GO
/****** Object:  StoredProcedure [dbo].[Clase_GetOne]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Clase_GetOne]
	@Nombre_C AS VARCHAR(MAX)
AS
BEGIN
	SELECT * FROM dbo.Clase
	WHERE [Nombre_C] = @Nombre_C
END
GO
/****** Object:  StoredProcedure [dbo].[Clase_Insert]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------Clase----------------------------
CREATE PROCEDURE [dbo].[Clase_Insert]
	@Entrenador_C int,
	@Nombre_C varchar (30),
	@Hora_C datetime,
	@Descripcion_C varchar (50)
AS
BEGIN 
	INSERT INTO Clase VALUES(
		@Entrenador_C,
		@Nombre_C,
		@Hora_C,
		@Descripcion_C)
END
GO
/****** Object:  StoredProcedure [dbo].[Clase_Update]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Clase_Update]
	@Entrenador_C int,
	@Nombre_C varchar (30),
	@Hora_C datetime,
	@Descripcion_C varchar (50)
AS
BEGIN
	UPDATE Clase
	SET [Entrenador_C] = @Entrenador_C,
	[Hora_C] = @Hora_C,
	Descripcion_C = @Descripcion_C
	WHERE Nombre_C = @Nombre_C
END
GO
/****** Object:  StoredProcedure [dbo].[Ejecuta_SQL]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Ejecuta_SQL]
	-- Add the parameters for the stored procedure here
			@sql as nvarchar(max)
           
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
		
    -- Insert statements for procedure here
	EXEC sp_executesql @sql	
 
END
GO
/****** Object:  StoredProcedure [dbo].[Informacion_Aparatos]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Informacion_Aparatos]
as
SET NOCOUNT ON; 
select Estado_A, count (Estado_A) as Num_Equipos
from Aparato 
where Estado_A = 1
group by Estado_A
Union
select Estado_A, count (Estado_A) as Num_Equipos
from Aparato 
where Estado_A = 0
group by Estado_A
GO
/****** Object:  StoredProcedure [dbo].[Informacion_Socios]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Informacion_Socios]
as
SET NOCOUNT ON; 
select E_Suscripcion, count (E_Suscripcion) as Num_Clientes, sum(Monto) as Monto_Total
from Socio 
where E_Suscripcion = 1
group by E_Suscripcion
Union
select E_Suscripcion, count (E_Suscripcion) as Num_Clientes, sum(Monto) as Monto_Total
from Socio 
where E_Suscripcion = 0
group by E_Suscripcion
GO
/****** Object:  StoredProcedure [dbo].[Registro_GetAll]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Registro_GetAll]
AS
BEGIN
	SELECT * FROM dbo.Registros
END
GO
/****** Object:  StoredProcedure [dbo].[Registro_GetBySocio]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Registro_GetBySocio]
	@Numero_S AS int
AS
BEGIN
	SELECT * FROM dbo.Registros
	WHERE [Numero_S] = @Numero_S
END
GO
/****** Object:  StoredProcedure [dbo].[Registro_GetMaxID]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Registro_GetMaxID]
AS
BEGIN
	SELECT ISNULL(MAX(Id_R),1) FROM dbo.Registros
END
GO
/****** Object:  StoredProcedure [dbo].[Registro_In]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Registro_In]
	@Hora_Entrada AS datetime,
	@Numero_S AS int,
	@Id_R AS int
AS
BEGIN 
	INSERT INTO Registros(Hora_Entrada,
						[Numero_S],
						[Id_R]) 
				VALUES(@Hora_Entrada,
						@Numero_S,
						@Id_R)
END
GO
/****** Object:  StoredProcedure [dbo].[Registro_Out]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Registro_Out]
	@Hora_Salida AS datetime,
	@Id_R AS int
AS
BEGIN
	UPDATE Registros
	SET [Hora_Salida] = @Hora_Salida
	WHERE [Id_R] = @Id_R
END
GO
/****** Object:  StoredProcedure [dbo].[Socio_Disable]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Socio_Disable]
	@Numero_S AS int
AS
BEGIN
	UPDATE Socio
	SET [E_Suscripcion] = 0
	WHERE [Numero_S] = @Numero_S
END
GO
/****** Object:  StoredProcedure [dbo].[Socio_GetAll]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Socio_GetAll]
AS
BEGIN
	SELECT * FROM dbo.Socio
END
GO
/****** Object:  StoredProcedure [dbo].[Socio_GetOne]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Socio_GetOne]
	@Numero_S AS int
AS
BEGIN
	SELECT * FROM dbo.Socio
	WHERE [Numero_S] = @Numero_S
END
GO
/****** Object:  StoredProcedure [dbo].[Socio_Insert]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------Socio----------------------------------
CREATE PROCEDURE [dbo].[Socio_Insert]
	@Monto AS float,
	@E_Suscripcion AS bit,
	@Fecha_I AS datetime,
	@Telefono_S AS varchar(30),
	@Direccion_S AS varchar(30),
	--@Imagen_S AS varbinary(1),
	@Paterno_S AS varchar (MAX),
	@Materno_S AS varchar (MAX),
	@Nombre_S AS varchar(MAX)
AS
BEGIN 
	INSERT INTO Socio(
		Nombre_S,
		Paterno_S,
		Materno_S,
		
		Direccion_S,
		Telefono_S,
		Fecha_I,
		E_Suscripcion,
		Monto) 
		VALUES(
		--@Numero_S,
		@Nombre_S,
		@Paterno_S,
		@Materno_S,
		--@Imagen_S,
		@Direccion_S,
		@Telefono_S,
		@Fecha_I,
		@E_Suscripcion,
		@Monto
	)
END
GO
/****** Object:  StoredProcedure [dbo].[Socio_Update]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Socio_Update]
	@Monto AS float,
	@E_Suscripcion AS bit,
	@Fecha_I AS datetime,
	@Telefono_S AS varchar(30),
	@Direccion_S AS varchar(30),
	@Imagen_S AS varbinary(1),
	@Paterno_S AS varchar (MAX),
	@Materno_S AS varchar (MAX),
	@Nombre_S AS varchar(MAX),
	@Numero_S AS int
AS
BEGIN
	UPDATE Socio
	SET [Monto] = @Monto,
		[E_Suscripcion] = @E_Suscripcion,
		[Fecha_I] = @Fecha_I,
		[Telefono_S] = @Telefono_S,
		[Direccion_S] = @Direccion_S,
		[Imagen_S] = @Imagen_S,
		[Paterno_S] = @Paterno_S,
		[Materno_S] = @Materno_S,
		[Nombre_S] = @Nombre_S
	WHERE [Numero_S] = @Numero_S
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_GetAll]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--CREATE PROCEDURE Usuario_Disable
--	@Numero_S AS int
--AS
--BEGIN
--	UPDATE Usuario
--	SET [E_Suscripcion] = 0
--	WHERE [Numero_S] = @Numero_S
--END
--GO

CREATE PROCEDURE [dbo].[Usuario_GetAll]
AS
BEGIN
	SELECT * FROM dbo.Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_GetOne]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_GetOne]
	@nID AS int
AS
BEGIN
	SELECT * FROM dbo.Usuario
	WHERE [nID] = @nID
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Insert]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Insert]
	@Nombre_U as varchar (50),
	@Contraseña_U as varchar (10),
	@Profesion_U as varchar (20),
	@Direccion_U as varchar (30),
	@Telefono_U as varchar (20),
	@Tipo_U as varchar (1)
AS
BEGIN 
	INSERT INTO Usuario VALUES(
	@Nombre_U,
	@Contraseña_U,
	@Profesion_U,
	@Direccion_U,
	@Telefono_U,
	@Tipo_U)
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Login]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_Login]
	@Nombre_U as varchar (50),
	@Contraseña_U as varchar (10)
AS
BEGIN
	SELECT * FROM dbo.Usuario
	WHERE Nombre_U = @Nombre_U AND Contraseña_U = @Contraseña_U
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Update]    Script Date: 17/08/2022 10:48:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_Update]
	@nID as int, --??
	@Nombre_U as varchar (50),
	@Contraseña_U as varchar (10),
	@Profesion_U as varchar (20),
	@Direccion_U as varchar (30),
	@Telefono_U as varchar (20)
AS
BEGIN
	UPDATE Usuario
	SET [Nombre_U] = @Nombre_U,
		[Contraseña_U] = @Contraseña_U,
		[Profesion_U] = @Profesion_U,
		[Direccion_U] = @Direccion_U,
		[Telefono_U] = @Telefono_U
	WHERE [nID] = @nID
END
GO
USE [master]
GO
ALTER DATABASE [VO2MAX_CONTROL] SET  READ_WRITE 
GO
