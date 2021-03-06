USE [QLKhoHang]
GO
/****** Object:  Table [dbo].[chitietphieunhap]    Script Date: 11/05/2017 11:38:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieunhap](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[phieunhapma] [int] NOT NULL,
	[hanghoama] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
 CONSTRAINT [PK_chitietphieunhap] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chitietphieuxuat]    Script Date: 11/05/2017 11:38:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietphieuxuat](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[phieuxuatma] [int] NOT NULL,
	[hanghoama] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
 CONSTRAINT [PK_chitietphieuxuat] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hanghoa]    Script Date: 11/05/2017 11:38:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hanghoa](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[donvitinh] [nvarchar](50) NOT NULL,
	[soluong] [int] NOT NULL,
	[xuatxu] [nvarchar](50) NOT NULL,
	[nguoinhap] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_hanghoa] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 11/05/2017 11:38:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[sdt] [nvarchar](50) NOT NULL,
	[masothue] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_nhanhanhang] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 11/05/2017 11:38:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[sdt] [nvarchar](50) NOT NULL,
	[masothue] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_nhacungcap] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieunhap]    Script Date: 11/05/2017 11:38:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieunhap](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ngaynhap] [datetime] NOT NULL,
	[nhacungcapma] [int] NOT NULL,
	[taikhoanma] [int] NOT NULL,
	[ghichu] [ntext] NULL,
 CONSTRAINT [PK_phieunhap] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieuxuat]    Script Date: 11/05/2017 11:38:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieuxuat](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ngayxuat] [datetime] NOT NULL,
	[lydoxuat] [nvarchar](50) NOT NULL,
	[khachhangma] [int] NOT NULL,
	[taikhoanma] [int] NOT NULL,
	[ghichu] [ntext] NULL,
 CONSTRAINT [PK_phieuxuat] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 11/05/2017 11:38:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_thukho] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[taikhoan] ON 

INSERT [dbo].[taikhoan] ([ma], [username], [password]) VALUES (1, N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[taikhoan] OFF
ALTER TABLE [dbo].[chitietphieunhap]  WITH CHECK ADD  CONSTRAINT [FK_chitietphieunhap_hanghoa] FOREIGN KEY([hanghoama])
REFERENCES [dbo].[hanghoa] ([ma])
GO
ALTER TABLE [dbo].[chitietphieunhap] CHECK CONSTRAINT [FK_chitietphieunhap_hanghoa]
GO
ALTER TABLE [dbo].[chitietphieunhap]  WITH CHECK ADD  CONSTRAINT [FK_chitietphieunhap_phieunhap] FOREIGN KEY([phieunhapma])
REFERENCES [dbo].[phieunhap] ([ma])
GO
ALTER TABLE [dbo].[chitietphieunhap] CHECK CONSTRAINT [FK_chitietphieunhap_phieunhap]
GO
ALTER TABLE [dbo].[chitietphieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_chitietphieuxuat_hanghoa] FOREIGN KEY([hanghoama])
REFERENCES [dbo].[hanghoa] ([ma])
GO
ALTER TABLE [dbo].[chitietphieuxuat] CHECK CONSTRAINT [FK_chitietphieuxuat_hanghoa]
GO
ALTER TABLE [dbo].[chitietphieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_chitietphieuxuat_phieuxuat] FOREIGN KEY([phieuxuatma])
REFERENCES [dbo].[phieuxuat] ([ma])
GO
ALTER TABLE [dbo].[chitietphieuxuat] CHECK CONSTRAINT [FK_chitietphieuxuat_phieuxuat]
GO
ALTER TABLE [dbo].[phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_phieunhap_nhacungcap] FOREIGN KEY([nhacungcapma])
REFERENCES [dbo].[nhacungcap] ([ma])
GO
ALTER TABLE [dbo].[phieunhap] CHECK CONSTRAINT [FK_phieunhap_nhacungcap]
GO
ALTER TABLE [dbo].[phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_phieunhap_taikhoan] FOREIGN KEY([taikhoanma])
REFERENCES [dbo].[taikhoan] ([ma])
GO
ALTER TABLE [dbo].[phieunhap] CHECK CONSTRAINT [FK_phieunhap_taikhoan]
GO
ALTER TABLE [dbo].[phieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_phieuxuat_khachhang] FOREIGN KEY([khachhangma])
REFERENCES [dbo].[khachhang] ([ma])
GO
ALTER TABLE [dbo].[phieuxuat] CHECK CONSTRAINT [FK_phieuxuat_khachhang]
GO
ALTER TABLE [dbo].[phieuxuat]  WITH CHECK ADD  CONSTRAINT [FK_phieuxuat_taikhoan] FOREIGN KEY([taikhoanma])
REFERENCES [dbo].[taikhoan] ([ma])
GO
ALTER TABLE [dbo].[phieuxuat] CHECK CONSTRAINT [FK_phieuxuat_taikhoan]
GO
