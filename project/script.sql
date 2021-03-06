USE [master]
GO
/****** Object:  Database [StoreManagement]    Script Date: 11/27/2015 11:00:48 ******/
CREATE DATABASE [StoreManagement] ON  PRIMARY 
( NAME = N'StoreManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MYSQL\MSSQL\DATA\StoreManagement.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StoreManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MYSQL\MSSQL\DATA\StoreManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StoreManagement] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StoreManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StoreManagement] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [StoreManagement] SET ANSI_NULLS OFF
GO
ALTER DATABASE [StoreManagement] SET ANSI_PADDING OFF
GO
ALTER DATABASE [StoreManagement] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [StoreManagement] SET ARITHABORT OFF
GO
ALTER DATABASE [StoreManagement] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [StoreManagement] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [StoreManagement] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [StoreManagement] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [StoreManagement] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [StoreManagement] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [StoreManagement] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [StoreManagement] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [StoreManagement] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [StoreManagement] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [StoreManagement] SET  DISABLE_BROKER
GO
ALTER DATABASE [StoreManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [StoreManagement] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [StoreManagement] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [StoreManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [StoreManagement] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [StoreManagement] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [StoreManagement] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [StoreManagement] SET  READ_WRITE
GO
ALTER DATABASE [StoreManagement] SET RECOVERY SIMPLE
GO
ALTER DATABASE [StoreManagement] SET  MULTI_USER
GO
ALTER DATABASE [StoreManagement] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [StoreManagement] SET DB_CHAINING OFF
GO
USE [StoreManagement]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 11/27/2015 11:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Discount](
	[CodeID] [int] NOT NULL,
	[type] [varchar](50) NULL,
	[rate] [int] NULL,
	[ProIDGift] [int] NULL,
	[DateStart] [date] NULL,
	[DateEnd] [date] NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[CodeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/27/2015 11:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CusID] [int] NOT NULL,
	[CusName] [varchar](50) NULL,
	[CusAddress] [varchar](50) NULL,
	[CusPhone] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CusID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/27/2015 11:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupID] [int] NOT NULL,
	[SupName] [varchar](50) NULL,
	[SupAddress] [varchar](50) NULL,
	[SupDebt] [float] NULL,
	[SupPhone] [int] NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 11/27/2015 11:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] NOT NULL,
	[StaffName] [varchar](50) NULL,
	[StaffRole] [varchar](50) NULL,
	[StaffAge] [int] NULL,
	[StaffSalary] [float] NULL,
	[StaffUserName] [varchar](50) NULL,
	[StaffPassWord] [varchar](50) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 11/27/2015 11:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[CusID] [int] NULL,
	[ProID] [int] NULL,
	[CodeID] [int] NULL,
	[StaffID] [int] NULL,
	[qantity] [int] NULL,
	[BillID] [int] NOT NULL,
	[date] [date] NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/27/2015 11:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProID] [int] NOT NULL,
	[ProName] [varchar](50) NULL,
	[SupID] [int] NULL,
	[producer] [varchar](50) NULL,
	[origin] [varchar](50) NULL,
	[InPrice] [float] NULL,
	[OutPrice] [float] NULL,
	[QuantityInStock] [int] NULL,
	[type] [varchar](50) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BillDetail]    Script Date: 11/27/2015 11:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetail](
	[BillID] [int] NOT NULL,
	[ProID] [int] NOT NULL,
	[QuantityInBill] [int] NULL,
 CONSTRAINT [PK_BillDetail] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC,
	[ProID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Bill_Customer]    Script Date: 11/27/2015 11:00:50 ******/
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Customer] FOREIGN KEY([CusID])
REFERENCES [dbo].[Customer] ([CusID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Customer]
GO
/****** Object:  ForeignKey [FK_Bill_Discount]    Script Date: 11/27/2015 11:00:50 ******/
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Discount] FOREIGN KEY([CodeID])
REFERENCES [dbo].[Discount] ([CodeID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Discount]
GO
/****** Object:  ForeignKey [FK_Bill_Staff]    Script Date: 11/27/2015 11:00:50 ******/
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Staff]
GO
/****** Object:  ForeignKey [FK_Product_Supplier]    Script Date: 11/27/2015 11:00:50 ******/
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([SupID])
REFERENCES [dbo].[Supplier] ([SupID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
/****** Object:  ForeignKey [FK_BillDetail_Bill]    Script Date: 11/27/2015 11:00:50 ******/
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillDetail_Bill] FOREIGN KEY([BillID])
REFERENCES [dbo].[Bill] ([BillID])
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BillDetail_Bill]
GO
/****** Object:  ForeignKey [FK_BillDetail_Product]    Script Date: 11/27/2015 11:00:50 ******/
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillDetail_Product] FOREIGN KEY([ProID])
REFERENCES [dbo].[Product] ([ProID])
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BillDetail_Product]
GO
