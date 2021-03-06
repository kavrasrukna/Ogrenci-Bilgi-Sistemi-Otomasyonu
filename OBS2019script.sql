USE [master]
GO
/****** Object:  Database [OBS]    Script Date: 10.6.2022 15:59:59 ******/
CREATE DATABASE [OBS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OBS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OBS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OBS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OBS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OBS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OBS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OBS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OBS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OBS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OBS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OBS] SET ARITHABORT OFF 
GO
ALTER DATABASE [OBS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OBS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OBS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OBS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OBS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OBS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OBS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OBS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OBS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OBS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OBS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OBS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OBS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OBS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OBS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OBS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OBS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OBS] SET RECOVERY FULL 
GO
ALTER DATABASE [OBS] SET  MULTI_USER 
GO
ALTER DATABASE [OBS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OBS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OBS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OBS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OBS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OBS] SET QUERY_STORE = OFF
GO
USE [OBS]
GO
/****** Object:  User [HP_\RÜKNA]    Script Date: 10.6.2022 16:00:00 ******/
CREATE USER [HP_\RÜKNA] FOR LOGIN [HP_\RÜKNA] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_datareader] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [HP_\RÜKNA]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [HP_\RÜKNA]
GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolumler](
	[bolum_id] [int] IDENTITY(1,1) NOT NULL,
	[bolum_adi] [nvarchar](50) NULL,
	[ogrencisayisi] [int] NULL,
 CONSTRAINT [PK_Bolumler] PRIMARY KEY CLUSTERED 
(
	[bolum_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dersler]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dersler](
	[ders_id] [int] IDENTITY(1,1) NOT NULL,
	[ders_adi] [nvarchar](50) NULL,
	[ogretmen_id] [int] NULL,
 CONSTRAINT [PK_Dersler] PRIMARY KEY CLUSTERED 
(
	[ders_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanıcılar]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanıcılar](
	[kullanicino] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciadi] [varchar](50) NULL,
	[sifre] [varchar](50) NULL,
	[mail] [varchar](50) NULL,
	[telefon] [char](20) NULL,
 CONSTRAINT [PK_Kullanıcılar] PRIMARY KEY CLUSTERED 
(
	[kullanicino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notlar]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notlar](
	[not_id] [int] IDENTITY(1,1) NOT NULL,
	[ders_id] [int] NULL,
	[ogrenci_no] [int] NULL,
	[vize] [int] NULL,
	[final] [int] NULL,
	[ortalama] [int] NULL,
	[durum] [nvarchar](50) NULL,
 CONSTRAINT [PK_Notlar] PRIMARY KEY CLUSTERED 
(
	[not_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenciler]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenciler](
	[ogrenci_no] [int] IDENTITY(1,1) NOT NULL,
	[ogrenci_adi] [nvarchar](50) NULL,
	[ogrenci_soyadi] [nvarchar](50) NULL,
	[bolum_id] [int] NULL,
 CONSTRAINT [PK_Ogrenciler] PRIMARY KEY CLUSTERED 
(
	[ogrenci_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogretmenler]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogretmenler](
	[ogretmen_id] [int] IDENTITY(1,1) NOT NULL,
	[ogretmen_adi] [nvarchar](50) NULL,
	[ogretmen_soyadi] [nvarchar](50) NULL,
	[ogretmen_brans] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ogretmenler] PRIMARY KEY CLUSTERED 
(
	[ogretmen_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bolumler] ON 

INSERT [dbo].[Bolumler] ([bolum_id], [bolum_adi], [ogrencisayisi]) VALUES (1, N'BÖTE', 50)
INSERT [dbo].[Bolumler] ([bolum_id], [bolum_adi], [ogrencisayisi]) VALUES (2, N'Elektronik Mühendisliği', 45)
INSERT [dbo].[Bolumler] ([bolum_id], [bolum_adi], [ogrencisayisi]) VALUES (3, N'Eczacılık', 25)
INSERT [dbo].[Bolumler] ([bolum_id], [bolum_adi], [ogrencisayisi]) VALUES (4, N'Matematik', 15)
INSERT [dbo].[Bolumler] ([bolum_id], [bolum_adi], [ogrencisayisi]) VALUES (5, N'Fizik', 20)
INSERT [dbo].[Bolumler] ([bolum_id], [bolum_adi], [ogrencisayisi]) VALUES (6, N'Türkçe Öğretmenliği', 60)
SET IDENTITY_INSERT [dbo].[Bolumler] OFF
GO
SET IDENTITY_INSERT [dbo].[Dersler] ON 

INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (1, N'Eğitimde Bilgi Teknolojileri I', 1)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (2, N'Programlama Dilleri I ', 1)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (3, N'Bilgisayar Donanımı', 1)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (4, N'Osmanlı Türkçesi ', 2)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (5, N'Edebiyat Bilgi ve Kuramları', 3)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (6, N'Türk Dil Bilgisi', 4)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (7, N'Fizik', 2)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (8, N'Nükleer Fizik', 5)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (9, N'Genel Matematik', 5)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (10, N'Analitik Geometri', 1008)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (11, N'Farmakognozi', 4)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (12, N'Mikrobiyoloji', 2)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (13, N'Mantıksal Devre Tasarımı', 1006)
INSERT [dbo].[Dersler] ([ders_id], [ders_adi], [ogretmen_id]) VALUES (14, N'Bilgisayar Destekli Teknik Resim', 1007)
SET IDENTITY_INSERT [dbo].[Dersler] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanıcılar] ON 

INSERT [dbo].[Kullanıcılar] ([kullanicino], [kullaniciadi], [sifre], [mail], [telefon]) VALUES (1, N'Rükna', N'1234', N'rukna@gmail.com', N'(539) 444-6767      ')
INSERT [dbo].[Kullanıcılar] ([kullanicino], [kullaniciadi], [sifre], [mail], [telefon]) VALUES (3, N'Kübra', N'1234', N'kubra@gmail.com', N'(536) 959-8659      ')
INSERT [dbo].[Kullanıcılar] ([kullanicino], [kullaniciadi], [sifre], [mail], [telefon]) VALUES (10, N'Gülcan', N'6767', N'gulcan@gmail.com', N'(536) 969-8989      ')
INSERT [dbo].[Kullanıcılar] ([kullanicino], [kullaniciadi], [sifre], [mail], [telefon]) VALUES (2003, N'a', N'a', N'a', N'(555) 555-5555      ')
SET IDENTITY_INSERT [dbo].[Kullanıcılar] OFF
GO
SET IDENTITY_INSERT [dbo].[Notlar] ON 

INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (1, 1, 1, 100, 70, 65, N'geçti')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (2, 2, 2, 80, 82, 81, N'geçti')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (3, 3, 2, 55, 0, 40, N'kaldı')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (4, 4, 3, 40, 0, 30, N'kaldı')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (5, 5, 3, 45, 66, 50, N'kaldı')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (6, 6, 4, 95, 30, 42, N'kaldı')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (7, 7, 5, 65, 75, 62, N'kaldı')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (8, 8, 5, 75, 75, 75, N'geçti')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (9, 9, 6, 85, 88, 80, N'geçti')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (10, 10, 6, 95, 79, 75, N'geçti')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (11, 11, 4, 100, 67, 65, N'geçti')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (12, 12, 2, 56, 0, 28, N'kaldı')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (13, 13, 3, 65, 63, 60, N'kaldı')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (14, 14, 3, 60, 73, 67, N'geçti')
INSERT [dbo].[Notlar] ([not_id], [ders_id], [ogrenci_no], [vize], [final], [ortalama], [durum]) VALUES (1015, 1, 1, 100, 10, 10, N'Kaldı')
SET IDENTITY_INSERT [dbo].[Notlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenciler] ON 

INSERT [dbo].[Ogrenciler] ([ogrenci_no], [ogrenci_adi], [ogrenci_soyadi], [bolum_id]) VALUES (1, N'Ali', N'Taş', 1)
INSERT [dbo].[Ogrenciler] ([ogrenci_no], [ogrenci_adi], [ogrenci_soyadi], [bolum_id]) VALUES (2, N'Ayşe', N'Çetin', 1)
INSERT [dbo].[Ogrenciler] ([ogrenci_no], [ogrenci_adi], [ogrenci_soyadi], [bolum_id]) VALUES (3, N'Kübra', N'Öztürk', 2)
INSERT [dbo].[Ogrenciler] ([ogrenci_no], [ogrenci_adi], [ogrenci_soyadi], [bolum_id]) VALUES (4, N'Zeynep', N'Tunç', 3)
INSERT [dbo].[Ogrenciler] ([ogrenci_no], [ogrenci_adi], [ogrenci_soyadi], [bolum_id]) VALUES (5, N'Deniz', N'Sevimli', 2)
INSERT [dbo].[Ogrenciler] ([ogrenci_no], [ogrenci_adi], [ogrenci_soyadi], [bolum_id]) VALUES (6, N'Mehmet', N'Akalın', 4)
SET IDENTITY_INSERT [dbo].[Ogrenciler] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogretmenler] ON 

INSERT [dbo].[Ogretmenler] ([ogretmen_id], [ogretmen_adi], [ogretmen_soyadi], [ogretmen_brans]) VALUES (1, N'Rükna', N'Kavraş', N'Bilgisayar ')
INSERT [dbo].[Ogretmenler] ([ogretmen_id], [ogretmen_adi], [ogretmen_soyadi], [ogretmen_brans]) VALUES (2, N'Kübra', N'Şahin', N'Bilgisayar')
INSERT [dbo].[Ogretmenler] ([ogretmen_id], [ogretmen_adi], [ogretmen_soyadi], [ogretmen_brans]) VALUES (3, N'Ayşenur', N'Uğuz', N'Fizik')
INSERT [dbo].[Ogretmenler] ([ogretmen_id], [ogretmen_adi], [ogretmen_soyadi], [ogretmen_brans]) VALUES (4, N'Kübra', N'Taştan', N'Türkçe')
INSERT [dbo].[Ogretmenler] ([ogretmen_id], [ogretmen_adi], [ogretmen_soyadi], [ogretmen_brans]) VALUES (5, N'Mehmet', N'Öz', N'Edebiyat')
INSERT [dbo].[Ogretmenler] ([ogretmen_id], [ogretmen_adi], [ogretmen_soyadi], [ogretmen_brans]) VALUES (1006, N'Zeynep ', N'Köse', N'Matematik')
INSERT [dbo].[Ogretmenler] ([ogretmen_id], [ogretmen_adi], [ogretmen_soyadi], [ogretmen_brans]) VALUES (1007, N'Emre', N'Coşkun', N'Bilgisayar')
INSERT [dbo].[Ogretmenler] ([ogretmen_id], [ogretmen_adi], [ogretmen_soyadi], [ogretmen_brans]) VALUES (1008, N'Cüneyt', N'Ulusu', N'Matematik')
SET IDENTITY_INSERT [dbo].[Ogretmenler] OFF
GO
ALTER TABLE [dbo].[Dersler]  WITH CHECK ADD  CONSTRAINT [FK_Dersler_Ogretmenler] FOREIGN KEY([ogretmen_id])
REFERENCES [dbo].[Ogretmenler] ([ogretmen_id])
GO
ALTER TABLE [dbo].[Dersler] CHECK CONSTRAINT [FK_Dersler_Ogretmenler]
GO
ALTER TABLE [dbo].[Notlar]  WITH CHECK ADD  CONSTRAINT [FK_Notlar_Dersler] FOREIGN KEY([ders_id])
REFERENCES [dbo].[Dersler] ([ders_id])
GO
ALTER TABLE [dbo].[Notlar] CHECK CONSTRAINT [FK_Notlar_Dersler]
GO
ALTER TABLE [dbo].[Notlar]  WITH CHECK ADD  CONSTRAINT [FK_Notlar_Ogrenciler] FOREIGN KEY([ogrenci_no])
REFERENCES [dbo].[Ogrenciler] ([ogrenci_no])
GO
ALTER TABLE [dbo].[Notlar] CHECK CONSTRAINT [FK_Notlar_Ogrenciler]
GO
ALTER TABLE [dbo].[Ogrenciler]  WITH CHECK ADD  CONSTRAINT [FK_Ogrenciler_Bolumler] FOREIGN KEY([bolum_id])
REFERENCES [dbo].[Bolumler] ([bolum_id])
GO
ALTER TABLE [dbo].[Ogrenciler] CHECK CONSTRAINT [FK_Ogrenciler_Bolumler]
GO
/****** Object:  StoredProcedure [dbo].[bolumara]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[bolumara] (
@bolum_adi nvarchar(50)
)
as 
begin
select * from Bolumler where bolum_adi=@bolum_adi 
end
GO
/****** Object:  StoredProcedure [dbo].[bolumekle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[bolumekle]
@bolum_adi nvarchar(50),
@ogrencisayisi int
as 
begin
insert into Bolumler(bolum_adi,ogrencisayisi) values (@bolum_adi,@ogrencisayisi)
end
GO
/****** Object:  StoredProcedure [dbo].[bolumguncelle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[bolumguncelle]
@bolum_id int,
@bolum_adi nvarchar(50),
@ogrencisayisi int
as 
begin
update Bolumler set bolum_adi=@bolum_adi,ogrencisayisi=@ogrencisayisi where bolum_id=@bolum_id
end
GO
/****** Object:  StoredProcedure [dbo].[bolumlistele]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[bolumlistele]
as 
begin
select*from Bolumler
end
GO
/****** Object:  StoredProcedure [dbo].[bolumsil]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[bolumsil]
@bolum_id int
as 
begin
delete from Bolumler where bolum_id=@bolum_id
end
GO
/****** Object:  StoredProcedure [dbo].[dersara]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dersara] (
@ders_adi nvarchar(50)
)
as 
begin
select * from Dersler where ders_adi=@ders_adi 
end
GO
/****** Object:  StoredProcedure [dbo].[dersekle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dersekle]
@ders_adi nvarchar(50),
@ogretmen_id int
as 
begin
insert into Dersler(ders_adi,ogretmen_id) values (@ders_adi,@ogretmen_id)
end
GO
/****** Object:  StoredProcedure [dbo].[dersguncelle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dersguncelle]
@ders_id int,
@ders_adi nvarchar(50),
@ogretmen_id int
as 
begin
update Dersler set ders_adi=@ders_adi,ogretmen_id=@ogretmen_id where ders_id=@ders_id
end
GO
/****** Object:  StoredProcedure [dbo].[derslistele]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[derslistele]
as 
begin
select*from Dersler
end
GO
/****** Object:  StoredProcedure [dbo].[derssil]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[derssil]
@ders_id int
as 
begin
delete from Dersler where ders_id=@ders_id
end
GO
/****** Object:  StoredProcedure [dbo].[kullaniciekle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[kullaniciekle](

@kullaniciadi varchar(50),
@sifre varchar(50),
@mail varchar(50),
@telefon char(20)
)
as begin 
insert into Kullanıcılar(kullaniciadi,sifre,mail,telefon) values (@kullaniciadi,@sifre,@mail,@telefon)
end
GO
/****** Object:  StoredProcedure [dbo].[kullanicigirisi]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[kullanicigirisi](
@kullaniciadi varchar(50),
@sifre varchar(50)
)
as 
begin
select * from Kullanıcılar where kullaniciadi=@kullaniciadi and sifre=@sifre
end
GO
/****** Object:  StoredProcedure [dbo].[notara]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[notara] (
@ders_id int,
@ogrenci_no int,
@durum nvarchar(50)
)
as 
begin
select * from Notlar where ders_id=@ders_id or ogrenci_no=@ogrenci_no or durum=@durum
end
GO
/****** Object:  StoredProcedure [dbo].[notekle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[notekle]
@ders_id int,
@ogrenci_no int,
@vize int,
@final int,
@ortalama int,
@durum nvarchar(50)
as 
begin
insert into Notlar(ders_id,ogrenci_no,vize,final,ortalama,durum) values (@ders_id,@ogrenci_no,@vize,@final,@ortalama,@durum)
end
GO
/****** Object:  StoredProcedure [dbo].[notguncelle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[notguncelle]
@not_id int,
@ders_id int,
@ogrenci_no int,
@vize int,
@final int,
@ortalama int,
@durum nvarchar(50)
as 
begin
update Notlar set ders_id=@ders_id,ogrenci_no=@ogrenci_no,vize=@vize,final=@final,ortalama=@ortalama,durum=@durum where not_id=@not_id
end
GO
/****** Object:  StoredProcedure [dbo].[notlistele]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[notlistele]
as begin
Select * from [dbo].[Notlar]
end
GO
/****** Object:  StoredProcedure [dbo].[notsil]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[notsil]
@not_id int
as 
begin
delete from Notlar where not_id=@not_id
end
GO
/****** Object:  StoredProcedure [dbo].[ogrenciara]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogrenciara] (
@ogrenci_no int,
@ogrenci_adi nvarchar(50)
)
as 
begin
select * from Ogrenciler where ogrenci_no=@ogrenci_no or ogrenci_adi=@ogrenci_adi 
end
GO
/****** Object:  StoredProcedure [dbo].[ogrenciekle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogrenciekle]
@ogrenci_adi nvarchar(50),
@ogrenci_soyadi nvarchar(50),
@bolum_id int
as 
begin
insert into Ogrenciler(ogrenci_adi,ogrenci_soyadi,bolum_id) values (@ogrenci_adi,@ogrenci_soyadi,@bolum_id)
end
GO
/****** Object:  StoredProcedure [dbo].[ogrenciguncelle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogrenciguncelle]
@ogrenci_no int,
@ogrenci_adi nvarchar(50),
@ogrenci_soyadi nvarchar(50),
@bolum_id int
as 
begin
update Ogrenciler set ogrenci_adi=@ogrenci_adi,ogrenci_soyadi=@ogrenci_soyadi,bolum_id=@bolum_id where ogrenci_no=@ogrenci_no
end
GO
/****** Object:  StoredProcedure [dbo].[ogrencilistele]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogrencilistele]
as 
begin
select*from Ogrenciler
end
GO
/****** Object:  StoredProcedure [dbo].[ogrencisil]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogrencisil]
@ogrenci_no int
as 
begin
delete from Ogrenciler where ogrenci_no=@ogrenci_no
end
GO
/****** Object:  StoredProcedure [dbo].[ogretmenara]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogretmenara] (
@ogretmen_adi nvarchar(50),
@ogretmen_brans nvarchar(50)
)
as 
begin
select * from Ogretmenler where ogretmen_adi=@ogretmen_adi or ogretmen_brans=@ogretmen_brans
end
GO
/****** Object:  StoredProcedure [dbo].[ogretmenekle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogretmenekle]
@ogretmen_adi nvarchar(50),
@ogretmen_soyadi nvarchar(50),
@ogretmen_brans nvarchar(50)
as 
begin
insert into Ogretmenler(ogretmen_adi,ogretmen_soyadi,ogretmen_brans) values (@ogretmen_adi,@ogretmen_soyadi,@ogretmen_brans)
end
GO
/****** Object:  StoredProcedure [dbo].[ogretmenguncelle]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogretmenguncelle]
@ogretmen_id int,
@ogretmen_adi nvarchar(50),
@ogretmen_soyadi nvarchar(50),
@ogretmen_brans nvarchar(50)
as 
begin
update Ogretmenler set ogretmen_adi=@ogretmen_adi,ogretmen_soyadi=@ogretmen_soyadi,ogretmen_brans=@ogretmen_brans where ogretmen_id=@ogretmen_id
end
GO
/****** Object:  StoredProcedure [dbo].[ogretmenlistele]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogretmenlistele]
as 
begin
select*from Ogretmenler
end
GO
/****** Object:  StoredProcedure [dbo].[ogretmensil]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogretmensil]
@ogretmen_id int
as 
begin
delete from Ogretmenler where ogretmen_id=@ogretmen_id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ogrenci_bolum_bote]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ogrenci_bolum_bote]
AS
BEGIN
SELECT bolum_adi,ogrenci_no,ogrenci_adi,ogrenci_soyadi
FROM Bolumler b inner join Ogrenciler o on b.bolum_id=o.bolum_id
WHERE o.bolum_id=1
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ogrenci_bolum_ders_not]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ogrenci_bolum_ders_not]
AS
BEGIN
SELECT ogrenci_adi,ogrenci_soyadi,bolum_adi,ders_adi,vize,final,ortalama,durum
FROM Ogrenciler o inner join Bolumler b on o.bolum_id=b.bolum_id
inner join Notlar n on o.ogrenci_no=n.ogrenci_no
inner join Dersler d on d.ders_id=n.ders_id
WHERE o.ogrenci_no=2
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ogrenci_bolum_grupla]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ogrenci_bolum_grupla]
AS
BEGIN
SELECT b.bolum_adi, COUNT(b.bolum_id) AS "Öğrenci Sayısı"  
FROM Bolumler b, Ogrenciler o
WHERE b.bolum_id=o.bolum_id
GROUP BY bolum_adi 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ogrenci_durum_kaldi]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ogrenci_durum_kaldi]
AS
BEGIN
SELECT ogrenci_adi,ogrenci_soyadi,bolum_adi,ders_adi,vize,final,ortalama,durum
FROM Ogrenciler o inner join Bolumler b on o.bolum_id=b.bolum_id
inner join Notlar n on o.ogrenci_no=n.ogrenci_no
inner join Dersler d on d.ders_id=n.ders_id
WHERE durum='kaldı'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ogrenci_ortalama]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ogrenci_ortalama]
AS
BEGIN
SELECT ogrenci_adi,ogrenci_soyadi,bolum_adi,ders_adi,vize,final,ortalama,durum
FROM Ogrenciler o inner join Bolumler b on o.bolum_id=b.bolum_id
inner join Notlar n on o.ogrenci_no=n.ogrenci_no
inner join Dersler d on d.ders_id=n.ders_id
WHERE ortalama<65
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ogrenci_sayisi_bolum]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ogrenci_sayisi_bolum]
AS
BEGIN
SELECT bolum_adi,ogrencisayisi
FROM Bolumler
WHERE ogrencisayisi<30
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ogretmen_brans]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ogretmen_brans]
AS
BEGIN
SELECT ders_adi,ogretmen_adi,ogretmen_soyadi,ogretmen_brans
FROM Dersler d inner join Ogretmenler o on d.ogretmen_id=o.ogretmen_id
WHERE o.ogretmen_brans='Bilgisayar'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ogretmen_brans_matematik]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ogretmen_brans_matematik]
AS
BEGIN
SELECT ogretmen_adi,ogretmen_soyadi,ogretmen_brans
FROM Ogretmenler
WHERE ogretmen_brans='Matematik'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ogretmen_ders]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ogretmen_ders]
AS
BEGIN
SELECT ders_adi,ogretmen_adi,ogretmen_soyadi,ogretmen_brans
FROM Dersler d inner join Ogretmenler o on d.ogretmen_id=o.ogretmen_id
WHERE d.ders_id=2
END
GO
/****** Object:  StoredProcedure [dbo].[sp_vize_final]    Script Date: 10.6.2022 16:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_vize_final]
AS
BEGIN
SELECT ogrenci_adi,ogrenci_soyadi,bolum_adi,ders_adi,vize,final,ortalama,durum
FROM Ogrenciler o inner join Bolumler b on o.bolum_id=b.bolum_id
inner join Notlar n on o.ogrenci_no=n.ogrenci_no
inner join Dersler d on d.ders_id=n.ders_id
WHERE vize is not null and final=0
END
GO
USE [master]
GO
ALTER DATABASE [OBS] SET  READ_WRITE 
GO
