USE [master]
GO
/****** Object:  Database [BDLibros]    Script Date: 3/5/2023 14:33:38 ******/
CREATE DATABASE [BDLibros]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDLibros', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019\MSSQL\DATA\BDLibros.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDLibros_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019\MSSQL\DATA\BDLibros_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BDLibros] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDLibros].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDLibros] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDLibros] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDLibros] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDLibros] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDLibros] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDLibros] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDLibros] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDLibros] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDLibros] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDLibros] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDLibros] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDLibros] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDLibros] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDLibros] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDLibros] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDLibros] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDLibros] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDLibros] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDLibros] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDLibros] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDLibros] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDLibros] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDLibros] SET RECOVERY FULL 
GO
ALTER DATABASE [BDLibros] SET  MULTI_USER 
GO
ALTER DATABASE [BDLibros] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDLibros] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDLibros] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDLibros] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDLibros] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDLibros] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BDLibros', N'ON'
GO
ALTER DATABASE [BDLibros] SET QUERY_STORE = OFF
GO
USE [BDLibros]
GO
/****** Object:  Table [dbo].[Autor]    Script Date: 3/5/2023 14:33:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autor](
	[Firstname] [nvarchar](30) NULL,
	[Lastname] [nvarchar](30) NULL,
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Autor] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AutorLibro]    Script Date: 3/5/2023 14:33:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AutorLibro](
	[Isbn] [nvarchar](13) NULL,
	[AuthorID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libro]    Script Date: 3/5/2023 14:33:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro](
	[Editionnumber] [nvarchar](3) NULL,
	[Title] [nvarchar](50) NULL,
	[Isbn] [nvarchar](13) NOT NULL,
 CONSTRAINT [PK_Libro] PRIMARY KEY CLUSTERED 
(
	[Isbn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Autor] ON 

INSERT [dbo].[Autor] ([Firstname], [Lastname], [AuthorID]) VALUES (N'Synthia', N'Gonzalez', 7)
INSERT [dbo].[Autor] ([Firstname], [Lastname], [AuthorID]) VALUES (N'Carlos', N'Cerda', 8)
INSERT [dbo].[Autor] ([Firstname], [Lastname], [AuthorID]) VALUES (N'Javier', N'Castellon', 1002)
INSERT [dbo].[Autor] ([Firstname], [Lastname], [AuthorID]) VALUES (N'Grace', N'Grace', 1003)
INSERT [dbo].[Autor] ([Firstname], [Lastname], [AuthorID]) VALUES (N'Carlos', N'Diego', 1004)
INSERT [dbo].[Autor] ([Firstname], [Lastname], [AuthorID]) VALUES (N'Jose', N'Duran', 2002)
INSERT [dbo].[Autor] ([Firstname], [Lastname], [AuthorID]) VALUES (N'Julio', N'Iglesias', 3002)
SET IDENTITY_INSERT [dbo].[Autor] OFF
GO
INSERT [dbo].[AutorLibro] ([Isbn], [AuthorID]) VALUES (N'0000000000001', 7)
INSERT [dbo].[AutorLibro] ([Isbn], [AuthorID]) VALUES (N'0000000000003', 8)
INSERT [dbo].[AutorLibro] ([Isbn], [AuthorID]) VALUES (N'0000000000004', 1004)
GO
INSERT [dbo].[Libro] ([Editionnumber], [Title], [Isbn]) VALUES (N'1', N'Pride and Prejudice', N'0000000000001')
INSERT [dbo].[Libro] ([Editionnumber], [Title], [Isbn]) VALUES (N'1', N'War and Peace', N'0000000000002')
INSERT [dbo].[Libro] ([Editionnumber], [Title], [Isbn]) VALUES (N'1', N'The Stranger', N'0000000000003')
INSERT [dbo].[Libro] ([Editionnumber], [Title], [Isbn]) VALUES (N'1', N'Don Quixote', N'0000000000004')
INSERT [dbo].[Libro] ([Editionnumber], [Title], [Isbn]) VALUES (N'1', N'Iliad', N'0000000000005')
GO
ALTER TABLE [dbo].[AutorLibro]  WITH CHECK ADD  CONSTRAINT [FK_AutorLibro_Autor] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Autor] ([AuthorID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AutorLibro] CHECK CONSTRAINT [FK_AutorLibro_Autor]
GO
ALTER TABLE [dbo].[AutorLibro]  WITH CHECK ADD  CONSTRAINT [FK_AutorLibro_Libro] FOREIGN KEY([Isbn])
REFERENCES [dbo].[Libro] ([Isbn])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AutorLibro] CHECK CONSTRAINT [FK_AutorLibro_Libro]
GO
/****** Object:  StoredProcedure [dbo].[FindAll]    Script Date: 3/5/2023 14:33:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FindAll]
AS
SELECT a.Firstname, a.Lastname,l.Title,l.Editionnumber
FROM [dbo].[Autor] a
INNER JOIN [dbo].[AutorLibro] axl
ON a.AuthorID = axl.AuthorID
INNER JOIN [dbo].[Libro] l
ON axl.Isbn = l.Isbn
GO
USE [master]
GO
ALTER DATABASE [BDLibros] SET  READ_WRITE 
GO
