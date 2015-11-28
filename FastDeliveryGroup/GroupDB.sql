USE [master]
GO
/****** Object:  Database [Shipper]    Script Date: 11/22/2015 21:52:44 ******/
CREATE DATABASE [Shipper] ON  PRIMARY 
( NAME = N'Shipper', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Shipper.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Shipper_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Shipper_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Shipper] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shipper].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shipper] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Shipper] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Shipper] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Shipper] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Shipper] SET ARITHABORT OFF
GO
ALTER DATABASE [Shipper] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Shipper] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Shipper] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Shipper] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Shipper] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Shipper] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Shipper] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Shipper] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Shipper] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Shipper] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Shipper] SET  ENABLE_BROKER
GO
ALTER DATABASE [Shipper] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Shipper] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Shipper] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Shipper] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Shipper] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Shipper] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Shipper] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Shipper] SET  READ_WRITE
GO
ALTER DATABASE [Shipper] SET RECOVERY FULL
GO
ALTER DATABASE [Shipper] SET  MULTI_USER
GO
ALTER DATABASE [Shipper] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Shipper] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Shipper', N'ON'
GO
USE [Shipper]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/22/2015 21:52:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[FullName] [nvarchar](50) NOT NULL,
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Role] [bit] NOT NULL,
	[Phone] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON
INSERT [dbo].[User] ([FullName], [UserID], [UserName], [Password], [Role], [Phone]) VALUES (N'Mai Que Tung', 1, N'tungmq', N'123', 0, N'01226617369')
SET IDENTITY_INSERT [dbo].[User] OFF
/****** Object:  StoredProcedure [dbo].[spCurrentIden]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[spCurrentIden]
(
	@table nvarchar(50)
)
as
Select Cast(IDENT_CURRENT(@table) As Int)
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT [dbo].[Product] ([ProductID], [Name], [Price]) VALUES (1, N'Blossom', 582)
INSERT [dbo].[Product] ([ProductID], [Name], [Price]) VALUES (2, N'Television', 992)
INSERT [dbo].[Product] ([ProductID], [Name], [Price]) VALUES (3, N'Computer', 674)
SET IDENTITY_INSERT [dbo].[Product] OFF
/****** Object:  Table [dbo].[Place]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Place](
	[PlaceID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Place] PRIMARY KEY CLUSTERED 
(
	[PlaceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Place] ON
INSERT [dbo].[Place] ([PlaceID], [Name]) VALUES (1, N'Quan 1')
INSERT [dbo].[Place] ([PlaceID], [Name]) VALUES (2, N'Quan 2')
SET IDENTITY_INSERT [dbo].[Place] OFF
/****** Object:  Table [dbo].[NeighborPlace]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NeighborPlace](
	[PlaceID] [int] NOT NULL,
	[NearbyPlaceID] [int] NOT NULL,
 CONSTRAINT [PK_NeighborPlace] PRIMARY KEY CLUSTERED 
(
	[PlaceID] ASC,
	[NearbyPlaceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([CustomerID], [Name], [Address], [Phone]) VALUES (N'kietta', N'Tran Anh Kiet', N'Quan 12', N'01693485358')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Address], [Phone]) VALUES (N'longnv', N'Nguyen Vu Long', N'Hoc Mon', N'01294285722')
/****** Object:  Table [dbo].[Shipper]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipper](
	[ShipperID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[PlaceID] [int] NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Shipper] PRIMARY KEY CLUSTERED 
(
	[ShipperID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Shipper] ON
INSERT [dbo].[Shipper] ([ShipperID], [Name], [PlaceID], [Phone]) VALUES (1, N'Quang Thang', 1, N'0902589723')
INSERT [dbo].[Shipper] ([ShipperID], [Name], [PlaceID], [Phone]) VALUES (2, N'Hoang Hoa Tham', 2, N'0122992456')
SET IDENTITY_INSERT [dbo].[Shipper] OFF
/****** Object:  StoredProcedure [dbo].[spGetAllCustomer]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spGetAllCustomer]
as
select * from Customer
GO
/****** Object:  StoredProcedure [dbo].[spGetAllProduct]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[spGetAllProduct]
as
select * from Product
GO
/****** Object: StoredProcedure [dbo].[InsertProduct] ****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertProduct]
(
	@Name nvarchar(50),
	@Price float
)
as
Insert Product
values (@Name,@Price)
GO
/****** Object:  StoredProcedure [dbo].[spSelectUserByUName]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spSelectUserByUName]
(
	@UserName nvarchar(50)
)
as
select * from [User] WHERE UserName = @UserName
GO
/****** Object:  StoredProcedure [dbo].[spSelectAllShipper]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spSelectAllShipper]
as
select * from Shipper
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [nvarchar](50) NOT NULL,
	[ShipperID] [int] NOT NULL,
	[ShipmentDate] [datetime] NOT NULL,
	[Total] [float] NOT NULL,
	[StaffID] [int] NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Shipment] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON
INSERT [dbo].[Invoice] ([InvoiceID], [CustomerID], [ShipperID], [ShipmentDate], [Total], [StaffID], [Status], [Description]) VALUES (3, N'kietta', 1, CAST(0x0000A55A00000000 AS DateTime), 35290, 1, N'Pending', N'Ship to Hoang Hoa Tham. Receiver: Tung qpwoedk pwoqkdp woqk pdowkqp odkwpqo kdpwoqk pdowqk')
INSERT [dbo].[Invoice] ([InvoiceID], [CustomerID], [ShipperID], [ShipmentDate], [Total], [StaffID], [Status], [Description]) VALUES (4, N'longnv', 1, CAST(0x0000A55B00000000 AS DateTime), 53662, 1, N'Pending', N'Khong co')
SET IDENTITY_INSERT [dbo].[Invoice] OFF
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
	[InvoiceID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[SubTotal] [float] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[InvoiceDetail] ([InvoiceID], [ProductID], [Quantity], [SubTotal]) VALUES (3, 3, 23, 15502)
INSERT [dbo].[InvoiceDetail] ([InvoiceID], [ProductID], [Quantity], [SubTotal]) VALUES (3, 1, 34, 19788)
INSERT [dbo].[InvoiceDetail] ([InvoiceID], [ProductID], [Quantity], [SubTotal]) VALUES (4, 2, 23, 22816)
INSERT [dbo].[InvoiceDetail] ([InvoiceID], [ProductID], [Quantity], [SubTotal]) VALUES (4, 1, 53, 30846)
/****** Object:  StoredProcedure [dbo].[spGetAllInvoice]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spGetAllInvoice]
as
select * from Invoice
GO
/****** Object:  StoredProcedure [dbo].[spAddInvoice]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spAddInvoice]
(
	
	@CustomerID nvarchar(50),
	@ShipperID int,
	@ShipmentDate datetime,
	@Total float,
	@StaffID int,
	@Status nvarchar(20),
	@Description nvarchar(100)
)
as
Insert into Invoice
values(@CustomerID,@ShipperID,@ShipmentDate,@Total,@StaffID,@Status,@Description)
GO
/****** Object:  StoredProcedure [dbo].[spInsertInvoiceDetail]    Script Date: 11/22/2015 21:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spInsertInvoiceDetail]
(
	@InvoiceID int,
	@ProductID int,
	@Quantity int,
	@SubTotal float
)
as
INSERT INTO InvoiceDetail
VALUES (@InvoiceID,@ProductID,@Quantity,@SubTotal)
GO
/****** Object: StoredProcedure [dbo].[GetAllDistrict]*****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllDistrict]
as
select * from Place
GO
/****** Object: StoredProcedure [dbo].[AddDistrict]*****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddDistrict]
(
  @Name nvarchar(50)
)
as
INSERT INTO Place
VALUES (@Name)
GO
/******* Object: StoredProcedure [dbo].[GetAllUser]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllUser]
as
select * from [User]
GO
/******* Object: StoreProcedure [dbo].[AddUser]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddUser]
(
 @FullName nvarchar(50),
 @UserName nvarchar(20),
 @Password nvarchar(Max),
 @Role bit,
 @Phone varchar(50)
)
as
INSERT INTO [User]
VALUES (@FullName,@UserName,@Password,@Role,@Phone)
GO
/****** Object: StoreProcedure [dbo].[AddCustomer]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddCustomer]
(
 @CustomerID  nvarchar(50),
 @Name nvarchar(50),
 @Address nvarchar(100),
 @Phone varchar(50)
)
as
INSERT INTO Customer
VALUES (@CustomerID,@Name,@Address,@Phone)
GO
/******* Object: StoredProcedure [dbo].[GetAllCustomer]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllCustomer]
as
select * from Customer
GO
/******* Object: StoredProcedure [dbo].[AddShipper]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddShipper]
(
 @Name nvarchar(50),
 @PlaceID int,
 @Phone nvarchar(50)
)
as
INSERT INTO Shipper
VALUES (@Name,@PlaceID,@Phone)
GO
/****** Object: StoredProcedure [dbo].[GetAllShipper]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAllShipper]
as
select * from Shipper
GO
/******* Object: StoredProcedure [dbo].[DeleteCustomer]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteCustomer]
(
 @CustomerID nvarchar(50)
)
as
DELETE Customer
Where CustomerID=@CustomerID
GO
/******* Object: StoredProcedure [dbo].[DeleteStaff]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteStaff]
(
 @UserID int
)
as
DELETE [User]
Where UserID=@UserID
GO
/******* Object: StoredProcedure [dbo].[DeleteShipper]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteShipper]
(
 @ShipperID int
)
as
DELETE Shipper
Where ShipperID=@ShipperID
GO
/******* Object: StoredProcedure [dbo].[DeleteProduct]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteProduct]
(
 @ProductID int
)
as
DELETE Product
Where ProductID=@ProductID
GO
/******* Object: StoredProcedure [dbo].[DeleteDistrict]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteDistrict]
(
 @PlaceID int
)
as
DELETE Place
Where PlaceID=@PlaceID
GO
/******* Object: StoredProcedure [dbo].[DeleteInvoice]****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeleteInvoice]
(
 @InvoiceID int
)
as
DELETE Invoice
Where InvoiceID=@InvoiceID
GO
/****** Object: StoredProcedure [dbo].[UpdateProduct] ****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateProduct]
(
@ProductID int,
@Name nvarchar(50),
@Price float
)
as
UPDATE Product set Name = @Name, Price = @Price
where ProductID=@ProductID
/****** Object:  ForeignKey [FK_Shipper_Place]    Script Date: 11/22/2015 21:52:45 ******/
ALTER TABLE [dbo].[Shipper]  WITH CHECK ADD  CONSTRAINT [FK_Shipper_Place] FOREIGN KEY([PlaceID])
REFERENCES [dbo].[Place] ([PlaceID])
GO
ALTER TABLE [dbo].[Shipper] CHECK CONSTRAINT [FK_Shipper_Place]
GO
/****** Object:  ForeignKey [FK_Invoice_Customer1]    Script Date: 11/22/2015 21:52:45 ******/
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Customer1] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Customer1]
GO
/****** Object:  ForeignKey [FK_Invoice_Shipper]    Script Date: 11/22/2015 21:52:45 ******/
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Shipper] FOREIGN KEY([ShipperID])
REFERENCES [dbo].[Shipper] ([ShipperID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Shipper]
GO
/****** Object:  ForeignKey [FK_Invoice_User]    Script Date: 11/22/2015 21:52:45 ******/
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_User] FOREIGN KEY([StaffID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_User]
GO
/****** Object:  ForeignKey [FK_InvoiceDetail_Invoice]    Script Date: 11/22/2015 21:52:45 ******/
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Invoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Invoice]
GO
/****** Object:  ForeignKey [FK_InvoiceDetail_Product]    Script Date: 11/22/2015 21:52:45 ******/
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Product]
GO
