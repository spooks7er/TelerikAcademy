USE [master]
GO
/****** Object:  Database [People]    Script Date: 8.10.2015 г. 18:17:20 ч. ******/
CREATE DATABASE [People]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'People', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\People.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'People_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\People_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [People] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [People].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [People] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [People] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [People] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [People] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [People] SET ARITHABORT OFF 
GO
ALTER DATABASE [People] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [People] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [People] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [People] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [People] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [People] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [People] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [People] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [People] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [People] SET  DISABLE_BROKER 
GO
ALTER DATABASE [People] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [People] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [People] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [People] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [People] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [People] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [People] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [People] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [People] SET  MULTI_USER 
GO
ALTER DATABASE [People] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [People] SET DB_CHAINING OFF 
GO
ALTER DATABASE [People] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [People] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [People] SET DELAYED_DURABILITY = DISABLED 
GO
USE [People]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 8.10.2015 г. 18:17:20 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[address_text] [nvarchar](150) NOT NULL,
	[town_id] [int] NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continent]    Script Date: 8.10.2015 г. 18:17:20 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 8.10.2015 г. 18:17:20 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[continent_id] [int] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 8.10.2015 г. 18:17:20 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[address_id] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Town]    Script Date: 8.10.2015 г. 18:17:20 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[country_id] [int] NOT NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([id], [address_text], [town_id]) VALUES (1, N'some random address', 2)
SET IDENTITY_INSERT [dbo].[Address] OFF
SET IDENTITY_INSERT [dbo].[Continent] ON 

INSERT [dbo].[Continent] ([id], [name]) VALUES (1, N'Europe')
INSERT [dbo].[Continent] ([id], [name]) VALUES (2, N'Asia')
INSERT [dbo].[Continent] ([id], [name]) VALUES (3, N'Africa')
INSERT [dbo].[Continent] ([id], [name]) VALUES (4, N'North America')
INSERT [dbo].[Continent] ([id], [name]) VALUES (5, N'South America')
INSERT [dbo].[Continent] ([id], [name]) VALUES (6, N'Australia')
INSERT [dbo].[Continent] ([id], [name]) VALUES (7, N'Antarctica')
SET IDENTITY_INSERT [dbo].[Continent] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (1, N'Bulgaria', 1)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (2, N'Peru', 5)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (3, N'China', 2)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (4, N'Ethiopia', 3)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (5, N'USA', 4)
INSERT [dbo].[Country] ([id], [name], [continent_id]) VALUES (6, N'Germany', 1)
SET IDENTITY_INSERT [dbo].[Country] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (1, N'Guy', N'Guyson', 1)
INSERT [dbo].[Person] ([id], [first_name], [last_name], [address_id]) VALUES (2, N'Gal', N'Guyson', 1)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Town] ON 

INSERT [dbo].[Town] ([id], [name], [country_id]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[Town] ([id], [name], [country_id]) VALUES (2, N'Berlin', 6)
SET IDENTITY_INSERT [dbo].[Town] OFF
ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Town] FOREIGN KEY([town_id])
REFERENCES [dbo].[Town] ([id])
GO
ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Town]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Continent] FOREIGN KEY([continent_id])
REFERENCES [dbo].[Continent] ([id])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Continent]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Address] FOREIGN KEY([address_id])
REFERENCES [dbo].[Address] ([id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Address]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_Country] FOREIGN KEY([country_id])
REFERENCES [dbo].[Country] ([id])
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_Country]
GO
USE [master]
GO
ALTER DATABASE [People] SET  READ_WRITE 
GO
