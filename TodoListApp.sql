USE [master]
GO
/****** Object:  Database [TodoListApp]    Script Date: 6/17/2021 10:09:27 PM ******/
CREATE DATABASE [TodoListApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TodoListMVC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\TodoListMVC.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TodoListMVC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\TodoListMVC_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TodoListApp] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TodoListApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TodoListApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TodoListApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TodoListApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TodoListApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TodoListApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [TodoListApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TodoListApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TodoListApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TodoListApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TodoListApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TodoListApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TodoListApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TodoListApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TodoListApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TodoListApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TodoListApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TodoListApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TodoListApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TodoListApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TodoListApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TodoListApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TodoListApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TodoListApp] SET RECOVERY FULL 
GO
ALTER DATABASE [TodoListApp] SET  MULTI_USER 
GO
ALTER DATABASE [TodoListApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TodoListApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TodoListApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TodoListApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TodoListApp] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TodoListApp', N'ON'
GO
ALTER DATABASE [TodoListApp] SET QUERY_STORE = OFF
GO
USE [TodoListApp]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [TodoListApp]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/17/2021 10:09:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 6/17/2021 10:09:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Status] [int] NULL,
	[Owner] [int] NULL,
	[CategoryID] [int] NULL,
	[IsCompleted] [bit] NULL,
	[DueDate] [datetime] NULL,
	[OverDue] [bit] NULL,
	[CreateDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [int] NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 6/17/2021 10:09:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](200) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[PassWord] [nvarchar](200) NULL,
	[Birth] [datetime] NULL,
	[Email] [nvarchar](200) NULL,
	[Phone] [nvarchar](200) NULL,
	[Note] [nvarchar](1000) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Task] ADD  CONSTRAINT [DF_Task_IsCompleted]  DEFAULT ((0)) FOR [IsCompleted]
GO
ALTER TABLE [dbo].[Task] ADD  CONSTRAINT [DF_Task_OverDue]  DEFAULT (NULL) FOR [OverDue]
GO
ALTER TABLE [dbo].[Task] ADD  CONSTRAINT [DF_Tasks_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Category', @level2type=N'COLUMN',@level2name=N'Status'
GO
USE [master]
GO
ALTER DATABASE [TodoListApp] SET  READ_WRITE 
GO
