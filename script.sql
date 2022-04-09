USE [master]
GO
/****** Object:  Database [SangKienMBF]    Script Date: 4/6/2022 3:11:19 PM ******/
CREATE DATABASE [SangKienMBF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SangKienMBF', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SangKienMBF.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SangKienMBF_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SangKienMBF_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SangKienMBF] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SangKienMBF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SangKienMBF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SangKienMBF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SangKienMBF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SangKienMBF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SangKienMBF] SET ARITHABORT OFF 
GO
ALTER DATABASE [SangKienMBF] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SangKienMBF] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SangKienMBF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SangKienMBF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SangKienMBF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SangKienMBF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SangKienMBF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SangKienMBF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SangKienMBF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SangKienMBF] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SangKienMBF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SangKienMBF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SangKienMBF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SangKienMBF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SangKienMBF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SangKienMBF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SangKienMBF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SangKienMBF] SET RECOVERY FULL 
GO
ALTER DATABASE [SangKienMBF] SET  MULTI_USER 
GO
ALTER DATABASE [SangKienMBF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SangKienMBF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SangKienMBF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SangKienMBF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SangKienMBF] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SangKienMBF] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SangKienMBF', N'ON'
GO
ALTER DATABASE [SangKienMBF] SET QUERY_STORE = OFF
GO
USE [SangKienMBF]
GO
/****** Object:  Table [dbo].[Sangkien]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sangkien](
	[Masangkien] [varchar](10) NOT NULL,
	[Tensangkien] [nvarchar](100) NULL,
	[Thoidiemapdung] [date] NULL,
	[Diadiemapdung] [nvarchar](500) NULL,
	[Motasangkien] [ntext] NULL,
	[Dotsangkien] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Masangkien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_SangKienMASK]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_SangKienMASK]
as select Masangkien,Tensangkien from Sangkien;
GO
/****** Object:  Table [dbo].[Tacgia]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tacgia](
	[Matacgia] [varchar](10) NOT NULL,
	[Hovaten] [nvarchar](100) NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Namsinh] [date] NULL,
	[Trinhdochuyenmon] [nvarchar](100) NULL,
	[Chucvu] [nvarchar](100) NULL,
	[Sodienthoai] [varchar](10) NULL,
	[Diachi] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nguoithamgia]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nguoithamgia](
	[Manguoithamgia] [varchar](10) NOT NULL,
	[Masangkien] [varchar](10) NULL,
	[Matacgia] [varchar](10) NULL,
	[Vaitro] [nvarchar](50) NULL,
	[Tiledonggop] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Manguoithamgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[SKvaTG_view]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[SKvaTG_view] 
as
select Tacgia.Hovaten , Tacgia.Chucvu , Sangkien.Tensangkien,Sangkien.Masangkien,Sangkien.Dotsangkien from ((Tacgia join Nguoithamgia on (Nguoithamgia.Matacgia = Tacgia.Matacgia))
join Sangkien on (Sangkien.Masangkien = Nguoithamgia.Masangkien))
GO
/****** Object:  Table [dbo].[GiamKhao]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiamKhao](
	[Magiamkhao] [varchar](10) NOT NULL,
	[Tengiamkhao] [nvarchar](100) NULL,
	[Chucvutrongcongty] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Magiamkhao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chitietchamdiem]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitietchamdiem](
	[Machitietchamdiem] [varchar](10) NOT NULL,
	[Mahoidong] [varchar](10) NULL,
	[Magiamkhao] [varchar](10) NULL,
	[Masangkien] [varchar](10) NULL,
	[Diemmucdich] [float] NULL,
	[Diemnoidung] [float] NULL,
	[Diemungdung] [float] NULL,
	[Diemtrinhbay] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Machitietchamdiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[diem_view]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create VIEW [dbo].[diem_view] 
as
select Chitietchamdiem.Machitietchamdiem,Sangkien.Tensangkien,GiamKhao.Magiamkhao,Sangkien.Dotsangkien,Chitietchamdiem.Diemmucdich,Chitietchamdiem.Diemnoidung,Chitietchamdiem.Diemungdung,Chitietchamdiem.Diemtrinhbay, 
((Chitietchamdiem.Diemmucdich+Chitietchamdiem.Diemnoidung+Chitietchamdiem.Diemungdung+Chitietchamdiem.Diemtrinhbay)/4) as trungbinh
from (Sangkien join Chitietchamdiem
on (Sangkien.Masangkien = Chitietchamdiem.Masangkien)join GiamKhao on(GiamKhao.Magiamkhao = Chitietchamdiem.Magiamkhao))
GO
/****** Object:  View [dbo].[View_GiamKhaoMaGK]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[View_GiamKhaoMaGK]
as
select Magiamkhao,Tengiamkhao from GiamKhao;
GO
/****** Object:  Table [dbo].[Hoidongkhoahoc]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoidongkhoahoc](
	[Mahoidong] [varchar](10) NOT NULL,
	[Namthanhlap] [date] NULL,
	[Nhiemvu] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[Mahoidong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_HoiDongMaHD]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[View_HoiDongMaHD]
as select Mahoidong, Namthanhlap from Hoidongkhoahoc;
GO
/****** Object:  Table [dbo].[Chitiethoidong]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitiethoidong](
	[Machitiethoidong] [varchar](10) NOT NULL,
	[Mahoidong] [varchar](10) NOT NULL,
	[Magiamkhao] [varchar](10) NOT NULL,
	[Chucvutronghoidong] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Machitiethoidong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Tentaikhoan] [varchar](50) NOT NULL,
	[Magiamkhao] [varchar](10) NULL,
	[Matkhau] [varchar](50) NULL,
	[Ngaylap] [date] NULL,
	[Quyenhan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Tentaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Chitietchamdiem]  WITH CHECK ADD FOREIGN KEY([Magiamkhao])
REFERENCES [dbo].[GiamKhao] ([Magiamkhao])
GO
ALTER TABLE [dbo].[Chitietchamdiem]  WITH CHECK ADD FOREIGN KEY([Mahoidong])
REFERENCES [dbo].[Hoidongkhoahoc] ([Mahoidong])
GO
ALTER TABLE [dbo].[Chitietchamdiem]  WITH CHECK ADD FOREIGN KEY([Masangkien])
REFERENCES [dbo].[Sangkien] ([Masangkien])
GO
ALTER TABLE [dbo].[Chitiethoidong]  WITH CHECK ADD FOREIGN KEY([Magiamkhao])
REFERENCES [dbo].[GiamKhao] ([Magiamkhao])
GO
ALTER TABLE [dbo].[Chitiethoidong]  WITH CHECK ADD FOREIGN KEY([Mahoidong])
REFERENCES [dbo].[Hoidongkhoahoc] ([Mahoidong])
GO
ALTER TABLE [dbo].[Nguoithamgia]  WITH CHECK ADD FOREIGN KEY([Masangkien])
REFERENCES [dbo].[Sangkien] ([Masangkien])
GO
ALTER TABLE [dbo].[Nguoithamgia]  WITH CHECK ADD FOREIGN KEY([Matacgia])
REFERENCES [dbo].[Tacgia] ([Matacgia])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([Magiamkhao])
REFERENCES [dbo].[GiamKhao] ([Magiamkhao])
GO
/****** Object:  StoredProcedure [dbo].[Proc_SuachitietHD]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_SuachitietHD]
@machitiethd varchar(10),
@mahd varchar(10),
@magk varchar(10),
@chucvutrongHD nvarchar(100)
as
UPDATE Chitiethoidong set Mahoidong=@mahd,Magiamkhao=@magk,Chucvutronghoidong=@chucvutrongHD where Machitiethoidong=@machitiethd;
------------------------------------
GO
/****** Object:  StoredProcedure [dbo].[Proc_SuaGK]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_SuaGK] 
@MaGK varchar(10),
@TenGK nvarchar(100),
@Chucvu nvarchar(100) 
as
UPDATE GiamKhao SET Tengiamkhao=@TenGK, Chucvutrongcongty=@Chucvu where Magiamkhao=@MaGK
GO
/****** Object:  StoredProcedure [dbo].[Proc_SuaHD]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_SuaHD]
@mahd varchar(10),
@namthanhlap date,
@nhiemvu ntext
as
UPDATE Hoidongkhoahoc set Namthanhlap=@namthanhlap, Nhiemvu=@nhiemvu where Mahoidong=@mahd;
GO
/****** Object:  StoredProcedure [dbo].[Proc_SuaNTG]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_SuaNTG]
@manguoithamgia varchar(10),
@mask varchar(10),
@matacgia varchar(10),
@vaitro nvarchar(50),
@tile nvarchar(10)
as
UPDATE Nguoithamgia set  Masangkien= @mask, Matacgia=@matacgia, Vaitro=@vaitro,Tiledonggop=@tile where Manguoithamgia= @manguoithamgia ;
GO
/****** Object:  StoredProcedure [dbo].[Proc_SuaSK]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[Proc_SuaSK]
@MaSK varchar(10),
@TenSK nvarchar(100),
@Thoidiem date,
@Diadiem nvarchar(500),
@Mota ntext,
@DotSangKien nvarchar(10)
as
UPDATE Sangkien set Tensangkien=@TenSK, Thoidiemapdung=@Thoidiem, Diadiemapdung=@Diadiem, Motasangkien=@Mota, Dotsangkien=@DotSangKien
where Masangkien = @MaSK;
select * from Sangkien;
-------------------------------
GO
/****** Object:  StoredProcedure [dbo].[Proc_SuaTG]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[Proc_SuaTG]
@MaTG varchar(10),
@Hovaten nvarchar(100),
@Gioitinh nvarchar(10),
@Namsinh date,
@Trinhdo nvarchar(100),
@Chucvu nvarchar(100),
@Sodienthoai varchar(10),
@Diachi nvarchar(500)
as
UPDATE 
Tacgia set 
Hovaten=@Hovaten,
Gioitinh=@Gioitinh,
Namsinh=@Namsinh,
Trinhdochuyenmon=@Trinhdo,
Chucvu=@Chucvu,
Sodienthoai=@Sodienthoai,
Diachi=@Diachi 
where Matacgia=@MaTG;
GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemchitietHD]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_ThemchitietHD]
@machitiethd varchar(10),
@mahd varchar(10),
@magk varchar(10),
@chucvutrongHD nvarchar(100)
as INSERT INTO Chitiethoidong(Machitiethoidong, Mahoidong, Magiamkhao, Chucvutronghoidong) values (@machitiethd, @mahd, @magk,@chucvutrongHD);
--------------------------------------------------
GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemGK]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_ThemGK]
@MaGK varchar(10),
@TenGK nvarchar(100),
@Chucvu nvarchar(100)
as
INSERT INTO GiamKhao (Magiamkhao,Tengiamkhao,Chucvutrongcongty) values(@MaGK,@TenGK,@Chucvu)
GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemHD]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_ThemHD]
@mahd varchar(10),
@namthanhlap date,
@nhiemvu ntext
as
INSERT INTO Hoidongkhoahoc(Mahoidong,Namthanhlap,Nhiemvu) values (@mahd,@namthanhlap,@nhiemvu);
-----------------------------------------------------------
GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemNguoiTG]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Proc_ThemNguoiTG]
@manguoithamgia varchar(10),
@masangkien varchar(10),
@matacgia varchar(10),
@vaitro nvarchar(50),
@tiledonggpop nvarchar(10)
as 
Insert INTO Nguoithamgia (Manguoithamgia,Masangkien,Matacgia,Vaitro,Tiledonggop)
values (@manguoithamgia,@masangkien,@matacgia,@vaitro,@tiledonggpop);
GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemSangKien]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[Proc_ThemSangKien] 
@MaSK varchar(10),
@TenSK nvarchar(100),
@Thoidiemapdung date,
@Diadiemapdung nvarchar(500),
@Motasangkien ntext,
@Dotsangkien nvarchar(10)
as
INSERT INTO Sangkien (Masangkien,Tensangkien,Thoidiemapdung,Diadiemapdung,Motasangkien,Dotsangkien)
values (@MaSK,@TenSK,@Thoidiemapdung,@Diadiemapdung,@Motasangkien,@Dotsangkien);
GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemTG]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Proc_ThemTG]
@MaTG varchar(10),
@Hovaten nvarchar(100),
@Gioitinh nvarchar(10),
@Namsinh date,
@Trinhdo nvarchar(100),
@Chucvu nvarchar(100),
@Sodienthoai varchar(10),
@Diachi nvarchar(500)
as
Insert into Tacgia (Matacgia,Hovaten,Gioitinh,Namsinh,Trinhdochuyenmon,Chucvu,Sodienthoai,Diachi) 
values(@MaTG,@Hovaten,@Gioitinh,@Namsinh,@Trinhdo,@Chucvu,@Sodienthoai,@Diachi);
GO
/****** Object:  StoredProcedure [dbo].[Proc_ThemTK]    Script Date: 4/6/2022 3:11:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Proc_ThemTK]
@tentaikhoan varchar(50),
@magiamkhao varchar(10),
@matkhau varchar(50),
@ngaylap date,
@quyenhan int 
as 
insert into TaiKhoan (Tentaikhoan,Magiamkhao,Matkhau,Ngaylap,Quyenhan)
values (@tentaikhoan,@magiamkhao,@matkhau,@ngaylap,@quyenhan);
GO
USE [master]
GO
ALTER DATABASE [SangKienMBF] SET  READ_WRITE 
GO
