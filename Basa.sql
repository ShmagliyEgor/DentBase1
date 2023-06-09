USE [master]
GO
/****** Object:  Database [StomatClinic]    Script Date: 25.05.2023 23:21:05 ******/
CREATE DATABASE [StomatClinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StomatClinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\StomatClinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StomatClinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\StomatClinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StomatClinic] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StomatClinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StomatClinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StomatClinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StomatClinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StomatClinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StomatClinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [StomatClinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StomatClinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StomatClinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StomatClinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StomatClinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StomatClinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StomatClinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StomatClinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StomatClinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StomatClinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StomatClinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StomatClinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StomatClinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StomatClinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StomatClinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StomatClinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StomatClinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StomatClinic] SET RECOVERY FULL 
GO
ALTER DATABASE [StomatClinic] SET  MULTI_USER 
GO
ALTER DATABASE [StomatClinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StomatClinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StomatClinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StomatClinic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StomatClinic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StomatClinic] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StomatClinic', N'ON'
GO
ALTER DATABASE [StomatClinic] SET QUERY_STORE = OFF
GO
USE [StomatClinic]
GO
/****** Object:  Table [dbo].[MainClient]    Script Date: 25.05.2023 23:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MainClient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[TimeRegister] [datetime] NOT NULL,
	[AgePacient] [int] NULL,
	[NumberTalon] [int] NULL,
	[Cost] [money] NULL,
 CONSTRAINT [PK_MainClient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MainClient] ON 

INSERT [dbo].[MainClient] ([id], [FIO], [Description], [TimeRegister], [AgePacient], [NumberTalon], [Cost]) VALUES (1, N'Фомин Генадий Артёмович', N'Стоматит', CAST(N'2023-05-25T12:00:00.000' AS DateTime), 19, 123456, 4000.0000)
INSERT [dbo].[MainClient] ([id], [FIO], [Description], [TimeRegister], [AgePacient], [NumberTalon], [Cost]) VALUES (2, N'test', N'test', CAST(N'2023-05-25T22:21:55.733' AS DateTime), 20, 1, 1.0000)
INSERT [dbo].[MainClient] ([id], [FIO], [Description], [TimeRegister], [AgePacient], [NumberTalon], [Cost]) VALUES (9, N'Иванов Иван ИВанович', N'Стоматит', CAST(N'2023-05-22T22:22:22.000' AS DateTime), 20, 23, 200.0000)
INSERT [dbo].[MainClient] ([id], [FIO], [Description], [TimeRegister], [AgePacient], [NumberTalon], [Cost]) VALUES (10, N'Дверной Дмитрий Генадиевич', N'Стоматит', CAST(N'2023-05-22T22:22:22.000' AS DateTime), 31, 3712, 299.0000)
INSERT [dbo].[MainClient] ([id], [FIO], [Description], [TimeRegister], [AgePacient], [NumberTalon], [Cost]) VALUES (11, N'Ромашкин Виталий Владимирович', N'Стоматит', CAST(N'2023-05-22T22:22:22.000' AS DateTime), 321, 37, 200.0000)
INSERT [dbo].[MainClient] ([id], [FIO], [Description], [TimeRegister], [AgePacient], [NumberTalon], [Cost]) VALUES (12, N'Жаба Наталья Игоревна', N'Стоматит', CAST(N'2023-05-22T22:22:22.000' AS DateTime), 123, 25, 299.9900)
SET IDENTITY_INSERT [dbo].[MainClient] OFF
GO
USE [master]
GO
ALTER DATABASE [StomatClinic] SET  READ_WRITE 
GO
