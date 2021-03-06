USE [master]
GO
/****** Object:  Database [PlivackaTakmicenja]    Script Date: 02-Jul-20 9:32:54 PM ******/
CREATE DATABASE [PlivackaTakmicenja]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PlivackaTakmicenja', FILENAME = N'C:\Users\Milena\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\PlivackaTakmicenja.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PlivackaTakmicenja_log', FILENAME = N'C:\Users\Milena\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\PlivackaTakmicenja.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PlivackaTakmicenja] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PlivackaTakmicenja].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PlivackaTakmicenja] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [PlivackaTakmicenja] SET ANSI_NULLS ON 
GO
ALTER DATABASE [PlivackaTakmicenja] SET ANSI_PADDING ON 
GO
ALTER DATABASE [PlivackaTakmicenja] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [PlivackaTakmicenja] SET ARITHABORT ON 
GO
ALTER DATABASE [PlivackaTakmicenja] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PlivackaTakmicenja] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [PlivackaTakmicenja] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [PlivackaTakmicenja] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [PlivackaTakmicenja] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PlivackaTakmicenja] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PlivackaTakmicenja] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET RECOVERY FULL 
GO
ALTER DATABASE [PlivackaTakmicenja] SET  MULTI_USER 
GO
ALTER DATABASE [PlivackaTakmicenja] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PlivackaTakmicenja] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PlivackaTakmicenja] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PlivackaTakmicenja] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PlivackaTakmicenja] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PlivackaTakmicenja] SET QUERY_STORE = OFF
GO
USE [PlivackaTakmicenja]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [PlivackaTakmicenja]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 02-Jul-20 9:32:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[adminID] [int] NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[ime] [varchar](50) NULL,
	[prezime] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[adminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategorija]    Script Date: 02-Jul-20 9:32:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategorija](
	[kategorijaID] [int] NOT NULL,
	[imeKategorije] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[kategorijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mesto]    Script Date: 02-Jul-20 9:32:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mesto](
	[ptt] [int] NOT NULL,
	[nazivMesta] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ptt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plivac]    Script Date: 02-Jul-20 9:32:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plivac](
	[plivacID] [int] NOT NULL,
	[imePlivaca] [varchar](50) NULL,
	[prezimePlivaca] [varchar](50) NULL,
	[datumRodjenja] [date] NULL,
	[kategorijaID] [int] NULL,
	[pol] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[plivacID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prijava]    Script Date: 02-Jul-20 9:32:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prijava](
	[plivacID] [int] NOT NULL,
	[takmicenjeID] [int] NOT NULL,
	[datumPrijave] [date] NULL,
	[pozicija] [int] NULL,
	[ostvarenoVreme] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[plivacID] ASC,
	[takmicenjeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Takmicenje]    Script Date: 02-Jul-20 9:32:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Takmicenje](
	[takmicenjeID] [int] NOT NULL,
	[nazivTakmicenja] [varchar](50) NULL,
	[datumOdrzavanja] [date] NULL,
	[brojPrijava] [int] NULL,
	[mestoOdrzavanja] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[takmicenjeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Plivac]  WITH CHECK ADD  CONSTRAINT [FK_Plivac_Kategorija] FOREIGN KEY([kategorijaID])
REFERENCES [dbo].[Kategorija] ([kategorijaID])
GO
ALTER TABLE [dbo].[Plivac] CHECK CONSTRAINT [FK_Plivac_Kategorija]
GO
ALTER TABLE [dbo].[Prijava]  WITH CHECK ADD  CONSTRAINT [FK_Prijava_Takmicenje] FOREIGN KEY([takmicenjeID])
REFERENCES [dbo].[Takmicenje] ([takmicenjeID])
GO
ALTER TABLE [dbo].[Prijava] CHECK CONSTRAINT [FK_Prijava_Takmicenje]
GO
ALTER TABLE [dbo].[Prijava]  WITH CHECK ADD  CONSTRAINT [FK_Table_Plivac] FOREIGN KEY([plivacID])
REFERENCES [dbo].[Plivac] ([plivacID])
GO
ALTER TABLE [dbo].[Prijava] CHECK CONSTRAINT [FK_Table_Plivac]
GO
ALTER TABLE [dbo].[Takmicenje]  WITH CHECK ADD  CONSTRAINT [FK_Takmicenje_Mesto] FOREIGN KEY([mestoOdrzavanja])
REFERENCES [dbo].[Mesto] ([ptt])
GO
ALTER TABLE [dbo].[Takmicenje] CHECK CONSTRAINT [FK_Takmicenje_Mesto]
GO
USE [master]
GO
ALTER DATABASE [PlivackaTakmicenja] SET  READ_WRITE 
GO
