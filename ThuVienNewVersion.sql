USE [master]
GO
/****** Object:  Database [ThuVien]    Script Date: 23/5/2023 10:40:44 PM ******/
CREATE DATABASE [ThuVien]
GO
USE [ThuVien]
GO
/****** Object:  DatabaseRole [QuanLy]    Script Date: 23/5/2023 10:40:44 PM ******/
CREATE ROLE [QuanLy]
GO
/****** Object:  DatabaseRole [DocGia]    Script Date: 23/5/2023 10:40:44 PM ******/
CREATE ROLE [DocGia]
GO
ALTER ROLE [db_owner] ADD MEMBER [QuanLy]
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MASXB]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[AUTO_MASXB]()
returns char(10)
as
begin
	DECLARE @ID CHAR(10)
	IF (SELECT COUNT(MASACHXB) FROM SachXB) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MASACHXB, 9)) FROM SachXB
	SELECT @ID = CASE
				WHEN @ID >= 99999999 THEN 'S' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 9999999 THEN 'S0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 999999 THEN 'S0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 99999 THEN 'S00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 9999 THEN 'S000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 999 THEN 'S0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 99 THEN 'S00000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 9 THEN 'S000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				ELSE 'S00000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				END
	RETURN @ID
end
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MATG]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[AUTO_MATG]()
returns char(10)
as
begin
	DECLARE @ID CHAR(10)
	IF (SELECT COUNT(MATG) FROM TacGia) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MATG, 9)) FROM TacGia
	SELECT @ID = CASE
				WHEN @ID >= 9999999 THEN 'TG' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 999999 THEN 'TG' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 99999 THEN 'TG0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 9999 THEN 'TG00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 999 THEN 'TG000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 99 THEN 'TG0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 9 THEN 'TG00000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				ELSE 'TG0000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				END
	RETURN @ID
end
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MATL]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[AUTO_MATL]()
returns char(10)
as
begin
	DECLARE @ID CHAR(10)
	IF (SELECT COUNT(MA) FROM TaiLieu) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MA, 8)) FROM TaiLieu
	SELECT @ID = CASE
				WHEN @ID >= 9999999 THEN 'TL' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 999999 THEN 'TL0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 99999 THEN 'TL00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 9999 THEN 'TL000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 999 THEN 'TL0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 99 THEN 'TL00000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				WHEN @ID >= 9 THEN 'TL000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				ELSE 'TL0000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
				END
	RETURN @ID
end
GO
/****** Object:  Table [dbo].[TaiLieu]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiLieu](
	[MA] [nchar](10) NOT NULL,
	[TUA] [nvarchar](50) NOT NULL,
	[LOAI] [nvarchar](4) NOT NULL,
 CONSTRAINT [PK_TaiLieu] PRIMARY KEY CLUSTERED 
(
	[MA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MATG] [nchar](10) NOT NULL,
	[TEN] [nvarchar](50) NOT NULL,
	[NAMSINH] [nchar](4) NOT NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MATG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SachXB]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SachXB](
	[MASACHXB] [nchar](10) NOT NULL,
	[LAN] [int] NOT NULL,
	[MASACH] [nchar](10) NOT NULL,
	[NAM] [nchar](4) NOT NULL,
	[KHOGIAY] [nvarchar](20) NULL,
	[SOTRANG] [int] NULL,
	[NHAXB] [nvarchar](100) NOT NULL,
	[GIA] [money] NOT NULL,
	[CD] [bit] NOT NULL,
	[SLNHAP] [int] NOT NULL,
 CONSTRAINT [PK_SachXB] PRIMARY KEY CLUSTERED 
(
	[MASACHXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SachTV]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SachTV](
	[ID_SACH] [bigint] NOT NULL,
	[STT] [int] NOT NULL,
	[MASACHXB] [nchar](10) NOT NULL,
	[TINHTRANG] [nvarchar](50) NULL,
 CONSTRAINT [PK_SachTV] PRIMARY KEY CLUSTERED 
(
	[ID_SACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SachMuon]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SachMuon](
	[ID_SACHMUON] [bigint] IDENTITY(1,1) NOT NULL,
	[SOTHE] [bigint] NOT NULL,
	[ID_SACH] [bigint] NOT NULL,
	[NGAYMUON] [date] NOT NULL,
	[NGAYTRA] [date] NULL,
 CONSTRAINT [PK_SachMuon] PRIMARY KEY CLUSTERED 
(
	[ID_SACHMUON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietTacGia]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietTacGia](
	[MASACH] [nchar](10) NOT NULL,
	[MATG] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ChiTietTacGia] PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC,
	[MATG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VIEW_SACHTV]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_SACHTV]
AS
SELECT ID_SACH, STT, S.TUA, TACGIA=STRING_AGG(TG.TEN,' '), LAN AS LANXB, NAM, NHAXB, CD, GIA, TINHTRANG, MUON
FROM (SELECT ID_SACH,STT,MASACHXB, TINHTRANG, 
MUON=(CASE WHEN (EXISTS(SELECT * FROM SachMuon SM WHERE STV.ID_SACH=SM.ID_SACH AND NGAYTRA IS NULL)) THEN N'Đang mượn'
ELSE N'Chưa mượn' END) 
FROM SachTV STV) STV, 
(SELECT MASACHXB, LAN, MASACH, NAM, NHAXB, CD,GIA FROM SachXB) SXB, (SELECT MA, TUA FROM TaiLieu WHERE LOAI=N'Sách') S,
(SELECT * FROM ChiTietTacGia) CTTG, (SELECT MATG, TEN FROM TacGia) TG
WHERE STV.MASACHXB=SXB.MASACHXB AND S.MA=SXB.MASACH AND CTTG.MASACH=S.MA AND CTTG.MATG=TG.MATG
GROUP BY ID_SACH, STT, S.TUA,LAN, NAM, NHAXB, CD,GIA, TINHTRANG, MUON
GO
/****** Object:  Table [dbo].[BaoPH]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoPH](
	[MABAO] [nchar](10) NOT NULL,
	[NAMPH] [nchar](4) NOT NULL,
	[DINHKY] [nvarchar](5) NOT NULL,
	[NSX] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_BaoPH] PRIMARY KEY CLUSTERED 
(
	[MABAO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaoTV]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoTV](
	[ID_BAO] [bigint] NOT NULL,
	[MABAO] [nchar](10) NOT NULL,
	[LAN] [int] NOT NULL,
	[SLNHAP] [int] NOT NULL,
	[SLTON] [int] NOT NULL,
 CONSTRAINT [PK_BaoTV] PRIMARY KEY CLUSTERED 
(
	[ID_BAO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VIEW_BAOTV]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_BAOTV]
AS
SELECT ID_BAO, B.TUA, LANPH, NAMPH, DINHKY, NSX, SLTON
FROM (SELECT MA,TUA FROM TaiLieu WHERE LOAI=N'Báo') B, (SELECT MABAO,NAMPH,DINHKY,NSX FROM BaoPH) BPH,
(SELECT ID_BAO, MABAO, LAN AS LANPH, SLTON FROM BaoTV) BTV
WHERE B.MA=BTV.MABAO AND B.MA=BPH.MABAO
GO
/****** Object:  Table [dbo].[BaoMuon]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoMuon](
	[ID_MUONBAO] [bigint] IDENTITY(1,1) NOT NULL,
	[SOTHE] [bigint] NOT NULL,
	[ID_BAO] [bigint] NOT NULL,
	[NGAYMUON] [date] NOT NULL,
	[NGAYTRA] [date] NULL,
 CONSTRAINT [PK_BaoMuon] PRIMARY KEY CLUSTERED 
(
	[ID_MUONBAO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[SOTHE] [bigint] NOT NULL,
	[NGAYCAP] [date] NOT NULL,
	[TEN] [nvarchar](50) NOT NULL,
	[NGHENGHIEP] [nvarchar](50) NOT NULL,
	[PHAI] [nvarchar](3) NOT NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[SOTHE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BaoMuon] ON 

INSERT [dbo].[BaoMuon] ([ID_MUONBAO], [SOTHE], [ID_BAO], [NGAYMUON], [NGAYTRA]) VALUES (1, 1, 1, CAST(N'2023-05-19' AS Date), CAST(N'2023-05-19' AS Date))
SET IDENTITY_INSERT [dbo].[BaoMuon] OFF
GO
INSERT [dbo].[BaoPH] ([MABAO], [NAMPH], [DINHKY], [NSX]) VALUES (N'TL00000001', N'1991', N'tháng', N'báo Tiền Phong')
INSERT [dbo].[BaoPH] ([MABAO], [NAMPH], [DINHKY], [NSX]) VALUES (N'TL00000002', N'1954', N'tháng', N'Đoàn thanh niên Cộng sản Hồ Chí Minh')
GO
INSERT [dbo].[BaoTV] ([ID_BAO], [MABAO], [LAN], [SLNHAP], [SLTON]) VALUES (1, N'TL00000001', 1, 20, 20)
INSERT [dbo].[BaoTV] ([ID_BAO], [MABAO], [LAN], [SLNHAP], [SLTON]) VALUES (2, N'TL00000001', 2, 20, 20)
INSERT [dbo].[BaoTV] ([ID_BAO], [MABAO], [LAN], [SLNHAP], [SLTON]) VALUES (3, N'TL00000002', 1, 20, 20)
INSERT [dbo].[BaoTV] ([ID_BAO], [MABAO], [LAN], [SLNHAP], [SLTON]) VALUES (4, N'TL00000002', 2, 20, 20)
GO
INSERT [dbo].[ChiTietTacGia] ([MASACH], [MATG]) VALUES (N'TL00000003', N'TG00000001')
INSERT [dbo].[ChiTietTacGia] ([MASACH], [MATG]) VALUES (N'TL00000004', N'TG00000002')
INSERT [dbo].[ChiTietTacGia] ([MASACH], [MATG]) VALUES (N'TL00000004', N'TG00000003')
INSERT [dbo].[ChiTietTacGia] ([MASACH], [MATG]) VALUES (N'TL00000005', N'TG00000004')
INSERT [dbo].[ChiTietTacGia] ([MASACH], [MATG]) VALUES (N'TL00000006', N'TG00000005')
INSERT [dbo].[ChiTietTacGia] ([MASACH], [MATG]) VALUES (N'TL00000006', N'TG00000006')
INSERT [dbo].[ChiTietTacGia] ([MASACH], [MATG]) VALUES (N'TL00000007', N'TG00000004')
GO
INSERT [dbo].[DocGia] ([SOTHE], [NGAYCAP], [TEN], [NGHENGHIEP], [PHAI]) VALUES (1, CAST(N'2023-05-19' AS Date), N'Trần Gia Long', N'Sinh viên', N'Nam')
GO
SET IDENTITY_INSERT [dbo].[SachMuon] ON 

INSERT [dbo].[SachMuon] ([ID_SACHMUON], [SOTHE], [ID_SACH], [NGAYMUON], [NGAYTRA]) VALUES (1, 1, 1, CAST(N'2023-05-19' AS Date), CAST(N'2023-05-19' AS Date))
INSERT [dbo].[SachMuon] ([ID_SACHMUON], [SOTHE], [ID_SACH], [NGAYMUON], [NGAYTRA]) VALUES (2, 1, 1, CAST(N'2023-05-19' AS Date), CAST(N'2023-05-19' AS Date))
INSERT [dbo].[SachMuon] ([ID_SACHMUON], [SOTHE], [ID_SACH], [NGAYMUON], [NGAYTRA]) VALUES (4, 1, 1, CAST(N'2023-05-19' AS Date), CAST(N'2023-05-19' AS Date))
INSERT [dbo].[SachMuon] ([ID_SACHMUON], [SOTHE], [ID_SACH], [NGAYMUON], [NGAYTRA]) VALUES (5, 1, 1, CAST(N'2023-05-19' AS Date), CAST(N'2023-05-19' AS Date))
INSERT [dbo].[SachMuon] ([ID_SACHMUON], [SOTHE], [ID_SACH], [NGAYMUON], [NGAYTRA]) VALUES (6, 1, 2, CAST(N'2023-05-19' AS Date), CAST(N'2023-05-19' AS Date))
SET IDENTITY_INSERT [dbo].[SachMuon] OFF
GO
INSERT [dbo].[SachTV] ([ID_SACH], [STT], [MASACHXB], [TINHTRANG]) VALUES (1, 1, N'S000000001', N'Tốt')
INSERT [dbo].[SachTV] ([ID_SACH], [STT], [MASACHXB], [TINHTRANG]) VALUES (2, 2, N'S000000001', N'Tốt')
INSERT [dbo].[SachTV] ([ID_SACH], [STT], [MASACHXB], [TINHTRANG]) VALUES (3, 3, N'S000000001', N'Tốt')
GO
INSERT [dbo].[SachXB] ([MASACHXB], [LAN], [MASACH], [NAM], [KHOGIAY], [SOTRANG], [NHAXB], [GIA], [CD], [SLNHAP]) VALUES (N'S000000001', 1, N'TL00000003', N'1998', N'13 x 20.5 cm3', 334, N'Nhà xuất bản trẻ', 120000.0000, 0, 10)
INSERT [dbo].[SachXB] ([MASACHXB], [LAN], [MASACH], [NAM], [KHOGIAY], [SOTRANG], [NHAXB], [GIA], [CD], [SLNHAP]) VALUES (N'S000000002', 2, N'TL00000003', N'2001', N'13 x 20.5 cm3', 336, N'Nhà xuất bản trẻ', 120000.0000, 0, 10)
INSERT [dbo].[SachXB] ([MASACHXB], [LAN], [MASACH], [NAM], [KHOGIAY], [SOTRANG], [NHAXB], [GIA], [CD], [SLNHAP]) VALUES (N'S000000003', 1, N'TL00000004', N'1951', NULL, 320, N'Nhà xuất bản Phạm Văn Tươi', 100000.0000, 0, 10)
INSERT [dbo].[SachXB] ([MASACHXB], [LAN], [MASACH], [NAM], [KHOGIAY], [SOTRANG], [NHAXB], [GIA], [CD], [SLNHAP]) VALUES (N'S000000004', 1, N'TL00000005', N'2013', NULL, 225, N'Nhà xuất bản Hội nhà văn và nhà phát hành Nhã Nam', 100000.0000, 0, 10)
INSERT [dbo].[SachXB] ([MASACHXB], [LAN], [MASACH], [NAM], [KHOGIAY], [SOTRANG], [NHAXB], [GIA], [CD], [SLNHAP]) VALUES (N'S000000005', 1, N'TL00000006', N'1989', N'Khổ nhỏ', 164, N'Nhà xuất bản Kim Đồng', 100000.0000, 0, 10)
INSERT [dbo].[SachXB] ([MASACHXB], [LAN], [MASACH], [NAM], [KHOGIAY], [SOTRANG], [NHAXB], [GIA], [CD], [SLNHAP]) VALUES (N'S000000006', 1, N'TL00000007', N'2019', N'17 x 24 cm', 448, N'Nhà xuất bản Hồng Đức', 150000.0000, 0, 10)
INSERT [dbo].[SachXB] ([MASACHXB], [LAN], [MASACH], [NAM], [KHOGIAY], [SOTRANG], [NHAXB], [GIA], [CD], [SLNHAP]) VALUES (N'S000000007', 1, N'TL00000008', N'1990', NULL, 234, N'Nhà xuất bản Trẻ', 100000.0000, 0, 10)
GO
INSERT [dbo].[TacGia] ([MATG], [TEN], [NAMSINH]) VALUES (N'TG00000001', N'J.K Rowling', N'1965')
INSERT [dbo].[TacGia] ([MATG], [TEN], [NAMSINH]) VALUES (N'TG00000002', N'Dale Carnegie', N'1888')
INSERT [dbo].[TacGia] ([MATG], [TEN], [NAMSINH]) VALUES (N'TG00000003', N'Paulo Coelho', N'1947')
INSERT [dbo].[TacGia] ([MATG], [TEN], [NAMSINH]) VALUES (N'TG00000004', N'Nguyễn Nhật Ánh', N'1955')
INSERT [dbo].[TacGia] ([MATG], [TEN], [NAMSINH]) VALUES (N'TG00000005', N'N. Gregory Mankiw', N'1958')
INSERT [dbo].[TacGia] ([MATG], [TEN], [NAMSINH]) VALUES (N'TG00000006', N'Mark P. Taylor', N'1958')
GO
INSERT [dbo].[TaiLieu] ([MA], [TUA], [LOAI]) VALUES (N'TL00000001', N'Hoa học trò', N'Báo')
INSERT [dbo].[TaiLieu] ([MA], [TUA], [LOAI]) VALUES (N'TL00000002', N'Báo nhi đồng', N'Báo')
INSERT [dbo].[TaiLieu] ([MA], [TUA], [LOAI]) VALUES (N'TL00000003', N'HarryPotter và hòn đá phù thủy', N'Sách')
INSERT [dbo].[TaiLieu] ([MA], [TUA], [LOAI]) VALUES (N'TL00000004', N'Đắc nhân tâm', N'Sách')
INSERT [dbo].[TaiLieu] ([MA], [TUA], [LOAI]) VALUES (N'TL00000005', N'Nhà giả kim', N'Sách')
INSERT [dbo].[TaiLieu] ([MA], [TUA], [LOAI]) VALUES (N'TL00000006', N'Kính vạn hoa', N'Sách')
INSERT [dbo].[TaiLieu] ([MA], [TUA], [LOAI]) VALUES (N'TL00000007', N'Kinh tế vi mô', N'Sách')
INSERT [dbo].[TaiLieu] ([MA], [TUA], [LOAI]) VALUES (N'TL00000008', N'Mắt biếc', N'Sách')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_BaoTV_MABAO_LAN]    Script Date: 23/5/2023 10:40:44 PM ******/
ALTER TABLE [dbo].[BaoTV] ADD  CONSTRAINT [UK_BaoTV_MABAO_LAN] UNIQUE NONCLUSTERED 
(
	[MABAO] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_SachTV_STT_MASACHXB]    Script Date: 23/5/2023 10:40:44 PM ******/
ALTER TABLE [dbo].[SachTV] ADD  CONSTRAINT [UK_SachTV_STT_MASACHXB] UNIQUE NONCLUSTERED 
(
	[MASACHXB] ASC,
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_SachXB_MASACH_LAN]    Script Date: 23/5/2023 10:40:44 PM ******/
ALTER TABLE [dbo].[SachXB] ADD  CONSTRAINT [UK_SachXB_MASACH_LAN] UNIQUE NONCLUSTERED 
(
	[MASACH] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TaiLieu_TUA]    Script Date: 23/5/2023 10:40:44 PM ******/
ALTER TABLE [dbo].[TaiLieu] ADD  CONSTRAINT [UK_TaiLieu_TUA] UNIQUE NONCLUSTERED 
(
	[TUA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BaoMuon] ADD  CONSTRAINT [DF_BaoMuon_NGAYMUON]  DEFAULT (getdate()) FOR [NGAYMUON]
GO
ALTER TABLE [dbo].[BaoTV] ADD  CONSTRAINT [DF_BaoTV_LAN]  DEFAULT ((1)) FOR [LAN]
GO
ALTER TABLE [dbo].[DocGia] ADD  CONSTRAINT [DF_DocGia_NGAYCAP]  DEFAULT (getdate()) FOR [NGAYCAP]
GO
ALTER TABLE [dbo].[SachMuon] ADD  CONSTRAINT [DF_SachMuon_NGAYMUON]  DEFAULT (getdate()) FOR [NGAYMUON]
GO
ALTER TABLE [dbo].[SachXB] ADD  DEFAULT ([dbo].[AUTO_MASXB]()) FOR [MASACHXB]
GO
ALTER TABLE [dbo].[SachXB] ADD  CONSTRAINT [DF_SachXB_CD]  DEFAULT ((0)) FOR [CD]
GO
ALTER TABLE [dbo].[TacGia] ADD  DEFAULT ([dbo].[AUTO_MATG]()) FOR [MATG]
GO
ALTER TABLE [dbo].[TaiLieu] ADD  DEFAULT ([dbo].[AUTO_MATL]()) FOR [MA]
GO
ALTER TABLE [dbo].[BaoMuon]  WITH CHECK ADD  CONSTRAINT [FK_BaoMuon_BaoTV] FOREIGN KEY([ID_BAO])
REFERENCES [dbo].[BaoTV] ([ID_BAO])
GO
ALTER TABLE [dbo].[BaoMuon] CHECK CONSTRAINT [FK_BaoMuon_BaoTV]
GO
ALTER TABLE [dbo].[BaoMuon]  WITH CHECK ADD  CONSTRAINT [FK_BaoMuon_DocGia] FOREIGN KEY([SOTHE])
REFERENCES [dbo].[DocGia] ([SOTHE])
GO
ALTER TABLE [dbo].[BaoMuon] CHECK CONSTRAINT [FK_BaoMuon_DocGia]
GO
ALTER TABLE [dbo].[BaoPH]  WITH CHECK ADD  CONSTRAINT [FK_BaoPH_TaiLieu] FOREIGN KEY([MABAO])
REFERENCES [dbo].[TaiLieu] ([MA])
GO
ALTER TABLE [dbo].[BaoPH] CHECK CONSTRAINT [FK_BaoPH_TaiLieu]
GO
ALTER TABLE [dbo].[BaoTV]  WITH CHECK ADD  CONSTRAINT [FK_BaoTV_BaoPH] FOREIGN KEY([MABAO])
REFERENCES [dbo].[BaoPH] ([MABAO])
GO
ALTER TABLE [dbo].[BaoTV] CHECK CONSTRAINT [FK_BaoTV_BaoPH]
GO
ALTER TABLE [dbo].[ChiTietTacGia]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTacGia_TacGia] FOREIGN KEY([MATG])
REFERENCES [dbo].[TacGia] ([MATG])
GO
ALTER TABLE [dbo].[ChiTietTacGia] CHECK CONSTRAINT [FK_ChiTietTacGia_TacGia]
GO
ALTER TABLE [dbo].[ChiTietTacGia]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTacGia_TaiLieu] FOREIGN KEY([MASACH])
REFERENCES [dbo].[TaiLieu] ([MA])
GO
ALTER TABLE [dbo].[ChiTietTacGia] CHECK CONSTRAINT [FK_ChiTietTacGia_TaiLieu]
GO
ALTER TABLE [dbo].[SachMuon]  WITH CHECK ADD  CONSTRAINT [FK_SachMuon_DocGia1] FOREIGN KEY([SOTHE])
REFERENCES [dbo].[DocGia] ([SOTHE])
GO
ALTER TABLE [dbo].[SachMuon] CHECK CONSTRAINT [FK_SachMuon_DocGia1]
GO
ALTER TABLE [dbo].[SachMuon]  WITH CHECK ADD  CONSTRAINT [FK_SachMuon_SachTV1] FOREIGN KEY([ID_SACH])
REFERENCES [dbo].[SachTV] ([ID_SACH])
GO
ALTER TABLE [dbo].[SachMuon] CHECK CONSTRAINT [FK_SachMuon_SachTV1]
GO
ALTER TABLE [dbo].[SachTV]  WITH CHECK ADD  CONSTRAINT [FK_SachTV_SachXB] FOREIGN KEY([MASACHXB])
REFERENCES [dbo].[SachXB] ([MASACHXB])
GO
ALTER TABLE [dbo].[SachTV] CHECK CONSTRAINT [FK_SachTV_SachXB]
GO
ALTER TABLE [dbo].[SachXB]  WITH CHECK ADD  CONSTRAINT [FK_SachXB_TaiLieu] FOREIGN KEY([MASACH])
REFERENCES [dbo].[TaiLieu] ([MA])
GO
ALTER TABLE [dbo].[SachXB] CHECK CONSTRAINT [FK_SachXB_TaiLieu]
GO
ALTER TABLE [dbo].[BaoPH]  WITH CHECK ADD  CONSTRAINT [CK_BaoPH_DINHKY] CHECK  (([DINHKY]=N'Ngày' OR [DINHKY]=N'Tuần' OR [DINHKY]=N'Tháng'))
GO
ALTER TABLE [dbo].[BaoPH] CHECK CONSTRAINT [CK_BaoPH_DINHKY]
GO
ALTER TABLE [dbo].[BaoPH]  WITH CHECK ADD  CONSTRAINT [CK_BaoPH_NAMPH] CHECK  (([NAMPH] like '[0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[BaoPH] CHECK CONSTRAINT [CK_BaoPH_NAMPH]
GO
ALTER TABLE [dbo].[BaoTV]  WITH CHECK ADD  CONSTRAINT [CK_BaoTV_LAN] CHECK  (([LAN]>(0)))
GO
ALTER TABLE [dbo].[BaoTV] CHECK CONSTRAINT [CK_BaoTV_LAN]
GO
ALTER TABLE [dbo].[BaoTV]  WITH CHECK ADD  CONSTRAINT [CK_BaoTV_SLNHAP] CHECK  (([SLNHAP]>(0)))
GO
ALTER TABLE [dbo].[BaoTV] CHECK CONSTRAINT [CK_BaoTV_SLNHAP]
GO
ALTER TABLE [dbo].[BaoTV]  WITH CHECK ADD  CONSTRAINT [CK_BaoTV_SLNHAP_SLTON] CHECK  (([SLNHAP]>=[SLTON]))
GO
ALTER TABLE [dbo].[BaoTV] CHECK CONSTRAINT [CK_BaoTV_SLNHAP_SLTON]
GO
ALTER TABLE [dbo].[BaoTV]  WITH CHECK ADD  CONSTRAINT [CK_BaoTV_SLTON] CHECK  (([SLTON]>=(0)))
GO
ALTER TABLE [dbo].[BaoTV] CHECK CONSTRAINT [CK_BaoTV_SLTON]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [CK_DocGia_PHAI] CHECK  (([PHAI]=N'Nam' OR [PHAI]=N'Nữ'))
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [CK_DocGia_PHAI]
GO
ALTER TABLE [dbo].[SachXB]  WITH CHECK ADD  CONSTRAINT [CK_SachXB_GIA] CHECK  (([GIA]>(0)))
GO
ALTER TABLE [dbo].[SachXB] CHECK CONSTRAINT [CK_SachXB_GIA]
GO
ALTER TABLE [dbo].[SachXB]  WITH CHECK ADD  CONSTRAINT [CK_SachXB_NAM] CHECK  (([NAM] like '[0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[SachXB] CHECK CONSTRAINT [CK_SachXB_NAM]
GO
ALTER TABLE [dbo].[SachXB]  WITH CHECK ADD  CONSTRAINT [CK_SachXB_SLNHAP] CHECK  (([SLNHAP]>(0)))
GO
ALTER TABLE [dbo].[SachXB] CHECK CONSTRAINT [CK_SachXB_SLNHAP]
GO
ALTER TABLE [dbo].[SachXB]  WITH CHECK ADD  CONSTRAINT [CK_SachXB_SOTRANG] CHECK  (([SOTRANG]>(0)))
GO
ALTER TABLE [dbo].[SachXB] CHECK CONSTRAINT [CK_SachXB_SOTRANG]
GO
ALTER TABLE [dbo].[TaiLieu]  WITH CHECK ADD  CONSTRAINT [CK_TaiLieu_LOAI] CHECK  (([LOAI]=N'Sách' OR [LOAI]=N'Báo'))
GO
ALTER TABLE [dbo].[TaiLieu] CHECK CONSTRAINT [CK_TaiLieu_LOAI]
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
DECLARE @TENNHOM NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
SELECT
   @TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))
SELECT @TENUSER,@TENNHOM, TEN=(CASE WHEN @TENNHOM like'DocGia' 
THEN (SELECT TEN FROM DocGia  WHERE SOTHE = @TENUSER ) ELSE @TENLOGIN END)
GO
/****** Object:  StoredProcedure [dbo].[SP_MUON_BAO]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MUON_BAO]
@SOTHE BIGINT, @ID_BAO BIGINT 
AS
BEGIN
	
	IF((SELECT SLTON FROM BaoTV WHERE ID_BAO = @ID_BAO)<1)
	BEGIN
		RAISERROR(N'Xin lỗi, báo bạn chọn hiện đã không còn ở thư viện',16,1)
		RETURN
	END 
	IF(EXISTS(SELECT * FROM BaoMuon WHERE SOTHE=@SOTHE AND ID_BAO=@ID_BAO AND NGAYTRA IS NULL))
	BEGIN
		RAISERROR(N'Báo vẫn đang được chủ thẻ độc giả mượn',16,2)
		RETURN
	END
	SET XACT_ABORT ON
	BEGIN TRAN
		BEGIN TRY
			INSERT INTO BaoMuon (SOTHE,ID_BAO)
			VALUES(@SOTHE,@ID_BAO)
			
			UPDATE BaoTV
			SET SLTON=SLTON-1
			WHERE ID_BAO=@ID_BAO

			COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
			DECLARE @ErrorMessage VARCHAR(2000)
			SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
			RAISERROR(@ErrorMessage, 16, 1)
		END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_MUON_SACH]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_MUON_SACH]
@SOTHE BIGINT, @ID_SACH BIGINT 
AS
BEGIN
	IF((SELECT MUON FROM VIEW_SACHTV WHERE ID_SACH = @ID_SACH)=N'Đang mượn')
	BEGIN
		RAISERROR(N'Xin lỗi, sách bạn chọn đang được mượn',16,1)
		RETURN
	END 
	INSERT INTO SachMuon (SOTHE,ID_SACH)
	VALUES(@SOTHE,@ID_SACH)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TRA_BAO]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TRA_BAO]
@SOTHE BIGINT, @ID_BAO BIGINT
AS
BEGIN
	IF(NOT EXISTS(SELECT * FROM BaoMuon WHERE ID_BAO=@ID_BAO AND SOTHE=@SOTHE AND NGAYTRA IS NULL))
	BEGIN
		RAISERROR(N'Báo đã trả rồi hoặc độc giả chưa từng mượn',16,1)
		RETURN
	END

	SET XACT_ABORT ON
	BEGIN TRAN
		BEGIN TRY
			UPDATE BaoMuon
			SET NGAYTRA=GETDATE()
			WHERE ID_BAO=@ID_BAO AND SOTHE=@SOTHE AND NGAYTRA IS NULL
			
			UPDATE BaoTV
			SET SLTON=SLTON+1
			WHERE ID_BAO=@ID_BAO

			COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK
			DECLARE @ErrorMessage VARCHAR(2000)
			SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
			RAISERROR(@ErrorMessage, 16, 1)
		END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TRA_SACH]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TRA_SACH]
@SOTHE BIGINT, @ID_SACH BIGINT
AS
BEGIN
	IF(NOT EXISTS(SELECT * FROM SachMuon WHERE ID_SACH=@ID_SACH AND SOTHE=@SOTHE AND NGAYTRA IS NULL))
	BEGIN
		RAISERROR(N'Sách đã trả rồi hoặc độc giả chưa từng mượn',16,1)
		RETURN
	END
	UPDATE SachMuon
	SET NGAYTRA=GETDATE()
	WHERE ID_SACH=@ID_SACH AND SOTHE=@SOTHE AND NGAYTRA IS NULL
END
GO
/****** Object:  Trigger [dbo].[d_BaoMuon]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[d_BaoMuon]
On [dbo].[BaoMuon]
For Delete
As
Begin
	IF (Select NGAYTRA From deleted) IS NULL
	Begin
		Raiserror('Không thể xóa thông tin khi chưa trả báo',16,1)
	End
End
GO
ALTER TABLE [dbo].[BaoMuon] ENABLE TRIGGER [d_BaoMuon]
GO
/****** Object:  Trigger [dbo].[i_BaoMuon]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[i_BaoMuon]
On [dbo].[BaoMuon]
For insert
As
Begin
	IF (Select SLTON From BaoTV, inserted Where BaoTV.ID_BAO = inserted.ID_BAO) = 0
	Begin
		Raiserror('Báo này đã hết',16,1)
		return
	End

End
GO
ALTER TABLE [dbo].[BaoMuon] ENABLE TRIGGER [i_BaoMuon]
GO
/****** Object:  Trigger [dbo].[iu_BaoTV]    Script Date: 23/5/2023 10:40:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- BaoTV
-- Mã báo phải là của tài liệu loại báo
-- Lần xuất bản và năm xuất bản của báo thư viện phải tương đồng
-- Số lượng nhập - Số lượng tồn phải tương đồng với số lượng báo chưa mượn
Create Trigger [dbo].[iu_BaoTV]
ON [dbo].[BaoTV]
For Insert, UpDate
As
Begin
	If (Select LOAI From TaiLieu, inserted Where TaiLieu.MA = inserted.MABAO) <> N'Báo'
	Begin
		RAISERROR('Không phải mã của báo',16,1)
		return
	End

	
	Declare @slnhap int, @slton int
	Select @slnhap = BaoTV.SLNHAP, @slton = BaoTV.SLTON From BaoTV, inserted where BaoTV.ID_BAO = inserted.ID_BAO 
	IF (@slnhap - @slton) <> (Select COUNT(*) From BaoMuon, inserted Where BaoMuon.ID_BAO = inserted.ID_BAO AND BaoMuon.NGAYTRA IS NULL)
	Begin
		Raiserror('Số lượng tồn không đúng so với số lượng báo chưa mượn',16,1)
	End

End
GO
ALTER TABLE [dbo].[BaoTV] ENABLE TRIGGER [iu_BaoTV]
GO
/****** Object:  Trigger [dbo].[iu_CTTACGIA]    Script Date: 23/5/2023 10:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create TRIGGER [dbo].[iu_CTTACGIA] ON [dbo].[ChiTietTacGia]
FOR INSERT, UPDATE
AS
Begin
	IF ((SELECT LOAI FROM TaiLieu, inserted WHERE MA=inserted.MASACH)<>N'Sách')
		raiserror( 'Mã tài liệu không phải sách',16,1)
End
GO
ALTER TABLE [dbo].[ChiTietTacGia] ENABLE TRIGGER [iu_CTTACGIA]
GO
/****** Object:  Trigger [dbo].[d_SachMuon]    Script Date: 23/5/2023 10:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[d_SachMuon]
On [dbo].[SachMuon]
For Delete
As
Begin
	IF (Select NGAYTRA From deleted) IS NULL
	Begin
		Raiserror('Không được xóa thông tin khi chưa trả sách',16,1)
	End
End
GO
ALTER TABLE [dbo].[SachMuon] ENABLE TRIGGER [d_SachMuon]
GO
/****** Object:  Trigger [dbo].[i_SachMuon]    Script Date: 23/5/2023 10:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[i_SachMuon]
On [dbo].[SachMuon]
Instead of Insert
As
Begin
	IF EXISTS (Select '' From SachMuon,inserted Where SachMuon.ID_SACH = inserted.ID_SACH AND SachMuon.NGAYTRA IS NULL)
	BEGIN
		RAISERROR('Cuốn sách chưa trả',16,1)
	END
	INSERT INTO SachMuon (SOTHE,ID_SACH)
	SELECT SOTHE,ID_SACH FROM inserted
End
GO
ALTER TABLE [dbo].[SachMuon] ENABLE TRIGGER [i_SachMuon]
GO
/****** Object:  Trigger [dbo].[i_SachTV]    Script Date: 23/5/2023 10:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[i_SachTV]
On [dbo].[SachTV]
For insert
As
Begin
	IF (Select count(*) From SachTV, inserted where SachTV.MASACHXB = inserted.MASACHXB) 
		> (Select SLNHAP From SachXB, inserted where SachXB.MASACHXB = inserted.MASACHXB)
	Begin
		Raiserror('Số lượng cuốn sách đã nhiều hơn số lượng nhập',16,1);
	End
End 
GO
ALTER TABLE [dbo].[SachTV] ENABLE TRIGGER [i_SachTV]
GO
/****** Object:  Trigger [dbo].[iu_SachXB]    Script Date: 23/5/2023 10:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[iu_SachXB]
On [dbo].[SachXB]
FOR insert, update
As
Begin
	-- Kiểm tra loại tài liệu liên kết là sách --
	if(select LOAI From TaiLieu, inserted where MA = inserted.MASACH) <> N'Sách'
	begin
		raiserror('Không phải sách',16,1)
	end

	-- Kiểm tra độ tương đồng lần xuất bản và năm xuất bản --
	IF EXISTS (Select '' From SachXB, inserted Where SachXB.MASACH = inserted.MASACH AND (SachXB.LAN > inserted.LAN AND CONVERT(INT,SachXB.NAM) < CONVERT(INT,inserted.NAM)) 
																						OR (SachXB.LAN < inserted.LAN AND CONVERT(INT,SachXB.NAM) > CONVERT(INT,inserted.NAM)))
	BEGIN
		RAISERROR('Lần xuất bản và năm xuất bản so với sách xuất bản đã có không đồng nhất',16,1)
	END

	IF (Select SachXB.SLNHAP From SachXB, inserted) < (Select COUNT(*) From SachTV, inserted Where SachTV.MASACHXB = inserted.MASACHXB)
	Begin
		Raiserror('Số lượng nhập ít hơn số lượng cuốn sách cùng mã có trong thư viện',16,1)
	End
End
GO
ALTER TABLE [dbo].[SachXB] ENABLE TRIGGER [iu_SachXB]
GO
/****** Object:  Trigger [dbo].[u_TaiLieu]    Script Date: 23/5/2023 10:40:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[u_TaiLieu]
On [dbo].[TaiLieu]
For Update
As
Begin
	IF (Select LOAI From deleted) = (Select LOAI FROM inserted) return

	IF ((Select LOAI From deleted) = N'Sách')
	BEGIN
		IF EXISTS(Select '' From SachXB, deleted where SachXB.MASACH = deleted.MA)
		BEGIN
			Raiserror('Tài liệu đã có thông tin sách xuất bản',16,1)
		END
		ELSE IF EXISTS (Select '' From ChiTietTacGia, inserted where ChiTietTacGia.MASACH = inserted.MA)
		BEGIN
			Raiserror('Tài liệu đã có thông sách chi tiết tác giả',16,1)
		END
	END
	ELSE IF ((Select LOAI From deleted) = N'Báo')
	BEGIN
	IF EXISTS(Select '' From BaoPH, deleted where BaoPH.MABAO = deleted.MA)
		Raiserror('Tài liệu đã có thông tin tựa báo phát hành',16,1)
	ELSE IF EXISTS(Select '' From BaoTV, deleted where BaoTV.MABAO = deleted.MA)
		Raiserror('Tài liệu đã có thông tin báo thư viện',16,1)
	END
End
GO
ALTER TABLE [dbo].[TaiLieu] ENABLE TRIGGER [u_TaiLieu]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "SXB"
            Begin Extent = 
               Top = 9
               Left = 352
               Bottom = 206
               Right = 590
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "S"
            Begin Extent = 
               Top = 9
               Left = 647
               Bottom = 152
               Right = 885
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "CTTG"
            Begin Extent = 
               Top = 9
               Left = 942
               Bottom = 152
               Right = 1180
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TG"
            Begin Extent = 
               Top = 9
               Left = 1237
               Bottom = 152
               Right = 1475
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "STV_1"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 295
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_SACHTV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_SACHTV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEW_SACHTV'
GO
USE [master]
GO
ALTER DATABASE [ThuVien] SET  READ_WRITE 
GO
