USE [BookingHotel_Web1]
GO
/****** Object:  Table [dbo].[banner]    Script Date: 7/4/2020 7:57:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[banner](
	[Id_banner] [varchar](8) NOT NULL,
	[imageLink] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_banner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 7/4/2020 7:57:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[Id_Booking] [int] IDENTITY(1,1) NOT NULL,
	[Status] [bit] NULL,
	[Note] [nvarchar](max) NULL,
	[Id_Customer] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Booking] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BookingDetail]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BookingDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StartDay] [date] NULL,
	[EndDay] [date] NULL,
	[Adult_Amount] [char](1) NULL,
	[Children_Amount] [char](1) NULL,
	[Total_Amount] [float] NULL,
	[Status] [bit] NULL,
	[Id_Room] [varchar](8) NULL,
	[Id_Booking] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[Id_Contact] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NULL,
	[Id_Customer] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gallery]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gallery](
	[Id_Glr] [varchar](8) NOT NULL,
	[ImageLink] [varchar](200) NULL,
	[Active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Glr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ImageRoom]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ImageRoom](
	[Id_image] [varchar](8) NOT NULL,
	[imageLink] [varchar](200) NULL,
	[Id_Room] [varchar](8) NULL,
	[Slide1] [nchar](20) NULL,
	[Slide2] [nchar](20) NULL,
	[Slide3] [nchar](20) NULL,
	[Slide4] [nchar](20) NULL,
	[Slide5] [nchar](20) NULL,
	[Slide6] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_image] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ImageService]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ImageService](
	[Id_image] [varchar](8) NOT NULL,
	[imageLink] [varchar](200) NULL,
	[Id_Service] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_image] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Introduce]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Introduce](
	[Id] [varchar](8) NOT NULL,
	[imageLink] [varchar](200) NULL,
	[note1] [nvarchar](max) NULL,
	[note2] [nvarchar](max) NULL,
	[note3] [nvarchar](max) NULL,
	[note4] [nvarchar](max) NULL,
	[note5] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NotePreviews]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NotePreviews](
	[Id] [varchar](30) NOT NULL,
	[Note1] [nvarchar](max) NULL,
	[Note2] [nvarchar](max) NULL,
	[Id_Type] [varchar](8) NULL,
	[Note3] [nvarchar](max) NULL,
	[Note4] [nvarchar](max) NULL,
	[Note5] [nvarchar](max) NULL,
	[Note6] [nvarchar](max) NULL,
 CONSTRAINT [PK_NotePreviews] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Promotion]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Promotion](
	[Id_Prom] [varchar](8) NOT NULL,
	[Title] [nvarchar](300) NULL,
	[ImageLink] [varchar](200) NULL,
	[Active] [bit] NULL,
	[Detail] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Prom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Room]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Room](
	[Id_Room] [varchar](8) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Price] [float] NULL,
	[Status] [bit] NULL,
	[Active] [bit] NULL,
	[Id_Type] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Room] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoomType]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RoomType](
	[Id_Type] [varchar](8) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Bed_Amount] [varchar](1) NULL,
	[Size] [tinyint] NULL,
	[Adult_Amount] [char](1) NULL,
	[Children_Amount] [char](1) NULL,
	[Active] [bit] NULL,
	[Note] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Service]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Service](
	[Id_Service] [varchar](8) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Active] [bit] NULL,
	[ID_Type] [varchar](8) NULL,
	[Image_service] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Service] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ServiceType]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ServiceType](
	[ID_Type] [varchar](8) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Content_Service] [nvarchar](max) NULL,
 CONSTRAINT [PK_ServiceType] PRIMARY KEY CLUSTERED 
(
	[ID_Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Id_User] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[UserName] [varchar](30) NULL,
	[PassWord] [varchar](30) NULL,
	[Sex] [bit] NULL,
	[Email] [varchar](50) NULL,
	[Address] [nvarchar](20) NULL,
	[Phone] [char](12) NULL,
	[Status] [bit] NULL,
	[Permission] [bit] NULL,
	[ImageLink] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Phongview]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[Phongview]
as

select RoomType.Name,Room.Id_Room,ImageRoom.Slide1,Slide2,Slide3,Slide4,Slide5,Slide6,NotePreviews.Note1,NotePreviews.Note2,RoomType.Note,Note3,Note4,Note5,Note6
from Room,RoomType,ImageRoom,NotePreviews
where Room.Id_Type=RoomType.Id_Type and Room.Id_Room=ImageRoom.Id_Room and NotePreviews.Id_Type=RoomType.Id_Type


GO
/****** Object:  View [dbo].[RoomViewForCartModel]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RoomViewForCartModel]
as
SELECT        dbo.Room.Id_Room, dbo.Room.Price, dbo.RoomType.Name, dbo.ImageRoom.imageLink, dbo.ImageRoom.Id_image
FROM            dbo.Room INNER JOIN
                         dbo.RoomType ON dbo.RoomType.Id_Type = dbo.Room.Id_Type INNER JOIN
                         dbo.ImageRoom ON dbo.ImageRoom.Id_Room = dbo.Room.Id_Room

GO
/****** Object:  View [dbo].[SearchView]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[SearchView]
as
select Room.Price,Room.Id_Room,RoomType.Name,RoomType.Adult_Amount,RoomType.Bed_Amount,RoomType.Children_Amount,RoomType.Size,RoomType.Note,ImageRoom.imageLink
from Room,RoomType,ImageRoom
where Room.Id_Type=RoomType.Id_Type and Room.Id_Room=ImageRoom.Id_Room


GO
/****** Object:  View [dbo].[ServiceView]    Script Date: 7/4/2020 7:57:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ServiceView]
as
select Service.Id_Service,Service.Image_service,Service.Name,ServiceType.Content_Service,ServiceType.Name as Nametype
from  ServiceType,Service
where Service.ID_Type=ServiceType.ID_Type


GO
INSERT [dbo].[banner] ([Id_banner], [imageLink]) VALUES (N'MBN01', N'bn1.jpg')
INSERT [dbo].[banner] ([Id_banner], [imageLink]) VALUES (N'MBN02', N'bn2.jpg')
INSERT [dbo].[banner] ([Id_banner], [imageLink]) VALUES (N'MBN03', N'bn3.jpg')
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (1, 0, N'1', 3)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (2, NULL, NULL, 4)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (3, NULL, NULL, 4)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (4, NULL, NULL, 4)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (13, NULL, NULL, 4)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (14, NULL, NULL, 4)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (15, NULL, NULL, 4)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (16, NULL, NULL, 4)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (17, NULL, NULL, NULL)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (18, NULL, NULL, 4)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (19, NULL, NULL, 5)
INSERT [dbo].[Booking] ([Id_Booking], [Status], [Note], [Id_Customer]) VALUES (20, NULL, NULL, 5)
SET IDENTITY_INSERT [dbo].[Booking] OFF
SET IDENTITY_INSERT [dbo].[BookingDetail] ON 

INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (1, CAST(N'2020-01-01' AS Date), CAST(N'2020-01-05' AS Date), N'2', N'1', 1000000, 1, N'MP01', 1)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (2, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (3, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (4, NULL, NULL, NULL, NULL, 2, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (5, CAST(N'2020-01-01' AS Date), CAST(N'2020-01-06' AS Date), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (6, CAST(N'2020-07-04' AS Date), CAST(N'2020-07-05' AS Date), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (7, CAST(N'2020-07-04' AS Date), CAST(N'2020-07-05' AS Date), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (8, CAST(N'2020-07-04' AS Date), CAST(N'2020-07-05' AS Date), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (9, CAST(N'2020-07-04' AS Date), CAST(N'2020-07-05' AS Date), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (11, CAST(N'2020-07-04' AS Date), CAST(N'2020-07-05' AS Date), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (12, CAST(N'2020-07-04' AS Date), CAST(N'2020-07-05' AS Date), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BookingDetail] ([Id], [StartDay], [EndDay], [Adult_Amount], [Children_Amount], [Total_Amount], [Status], [Id_Room], [Id_Booking]) VALUES (13, CAST(N'2020-07-04' AS Date), CAST(N'2020-07-05' AS Date), NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[BookingDetail] OFF
SET IDENTITY_INSERT [dbo].[Contact] ON 

INSERT [dbo].[Contact] ([Id_Contact], [Content], [Id_Customer]) VALUES (1, N'tôi test liên hệ', 3)
SET IDENTITY_INSERT [dbo].[Contact] OFF
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr01', N'80625893.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr02', N'80625894.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr03', N'80625895.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr04', N'80625899.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr05', N'81119043.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr06', N'80626001.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr07', N'83973660.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr08', N'83973661.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr09', N'phong12.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr10', N'phong8.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr11', N'phong5.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr12', N'phong7.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr13', N'phong4.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr14', N'phong2.jpg', NULL)
INSERT [dbo].[Gallery] ([Id_Glr], [ImageLink], [Active]) VALUES (N'Glr15', N'83973662.jpg', NULL)
INSERT [dbo].[ImageRoom] ([Id_image], [imageLink], [Id_Room], [Slide1], [Slide2], [Slide3], [Slide4], [Slide5], [Slide6]) VALUES (N'MA01', N'80625894.jpg', N'MP01', N'80625899.jpg        ', N'80625894.jpg        ', N'80625895.jpg        ', N'80626001.jpg        ', N'83973662.jpg        ', N'phong3.jpg          ')
INSERT [dbo].[ImageRoom] ([Id_image], [imageLink], [Id_Room], [Slide1], [Slide2], [Slide3], [Slide4], [Slide5], [Slide6]) VALUES (N'MA02', N'80625893.jpg', N'MP02', N'80625894.jpg        ', N'N80626001.jpg       ', N'80626002.jpg        ', N'phong7.jpg          ', N'83973662.jpg        ', N'phong3.jpg          ')
INSERT [dbo].[ImageRoom] ([Id_image], [imageLink], [Id_Room], [Slide1], [Slide2], [Slide3], [Slide4], [Slide5], [Slide6]) VALUES (N'MA03', N'80626002.jpg', N'MP03', N'80626002.jpg        ', N'80626001.jpg        ', N'phong8.jpg          ', N'phong6.jpg          ', N'phong5.jpg          ', N'83973662.jpg        ')
INSERT [dbo].[ImageRoom] ([Id_image], [imageLink], [Id_Room], [Slide1], [Slide2], [Slide3], [Slide4], [Slide5], [Slide6]) VALUES (N'MA04', N'phong1.jpg', N'MP04', N'phong2.jpg          ', N'phong4.jpg          ', N'phong12.jpg         ', N'phong5.jpgL         ', N'83973662.jpg        ', N'phong3.jpg          ')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA01', N'gym.jpg', N'MDV02')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA02', N'hb1.jpg', N'MDV03')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA03', N'hb2.jpg', N'MDV03')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA04', N'hb3.jpg', N'MDV03')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA05', N'hb4.jpg', N'MDV03')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA06', N'nh6.jpg', N'MDV01')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA07', N'gym.jpg', N'MDV01')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA08', N'nh3.jpg', N'MDV04')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA09', N'nh4.jpg', N'MDV04')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA10', N'nh5.jpg', N'MDV04')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA11', N'nh6.jpg', N'MDV04')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA12', N'nh7.jpg', N'MDV04')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA13', N'spa1.jpg', N'MDV01')
INSERT [dbo].[ImageService] ([Id_image], [imageLink], [Id_Service]) VALUES (N'MA14', N'spa2.jpg', N'MDV01')
INSERT [dbo].[Introduce] ([Id], [imageLink], [note1], [note2], [note3], [note4], [note5]) VALUES (N'Gt01', N'81119049.jpg', N' GrandHotel là một khách
                                                                    sạn sang trọng, đẳng cấp hàng đầu tại Việt Nam. Đến
                                                                    với Grand Hotel, bạn không chỉ được đắm mình trong
                                                                    cuộc sống vương giả với đầy đủ tiện nghi, dịch vụ
                                                                    chuyên nghiệp, chất lượng hàng đầu mà còn cảm nhận
                                                                    được không khí ấm cúng, thoải mái và dễ chịu như
                                                                    gia đình ngay tại nhà.', N'Grand hotel là một nơi an toàn, thân thiện cho mọi
                                                                    người khi ở Hà Nội. Tọa lạc tại một vị trí đắc địa,
                                                                    ngay trung tâm thành phố, dễ dàng đến các điểm du
                                                                    lịch của Hà Nội, khách sạn có thể dễ dàng đến tất cả
                                                                    các điểm du lịch nổi tiếng. Đây cũng là một điểm đến
                                                                    lý tưởng nhờ dịch vụ cao cấp được cung cấp bởi khách
                                                                    sạn. Tất cả các phòng đều được thiết kế theo phong
                                                                    cách hiện đại pha trộn giữa kiến ​​trúc cổ điển, độc
                                                                    đáo, hài hòa giữa vẻ đẹp truyền thống của người Việt
                                                                    và sự tinh tế của phương Tây. Đội ngũ nhân viên
                                                                    khách sạn là những nhân viên giàu kinh nghiệm,
                                                                    chuyên nghiệp và nhiệt tình, không ngừng nâng cao
                                                                    các kỹ năng và chất lượng chuyên nghiệp, luôn sẵn
                                                                    sàng phục vụ khách hàng với phương châm "mang lại
                                                                    giá trị cốt lõi cho khách hàng".', N' Điểm nổi bật của khách sạn Grand chúng tôi là hệ
                                                                    thống nhà hàng phục vụ chuyên nghiệp mang đậm chất
                                                                    Á-Âu với nhà hàng thương hiệu Grand hotel. Ngay tại
                                                                    đây, bạn có thể thưởng thức những món ăn đặc biệt
                                                                    với hương vị tuyệt vời nhất theo phong cách châu Á,
                                                                    được chế biến từ những nguyên liệu tươi ngon nhất
                                                                    dưới sự kiểm tra nghiêm ngặt để đảm bảo an toàn cho
                                                                    thực phẩm. Sản phẩm dưới bàn tay khéo léo của đội
                                                                    ngũ đầu bếp giàu kinh nghiệm.', N' Ngoài ra, trong thời gian lưu trú tại khách sạn, bạn
                                                                    cũng có thể tận hưởng các tiện nghi tại chỗ miễn phí
                                                                    như phòng tập thể dục, spa, hồ bơi, ... Công việc
                                                                    hàng ngày, thói quen hàng ngày, sức khỏe và sức khỏe
                                                                    của bạn là Duy trì tại nhà.', N'Tuyệt vời, thoải mái và ấn tượng là những cảm giác
                                                                    mà du khách nhận xét về khách sạn Grand sau thời
                                                                    gian ở đây và đó cũng là điều chúng tôi - những
                                                                    người có duyên phục vụ bạn cảm thấy tự hào nhất. Với
                                                                    những dịch vụ uy tín và chất lượng được xây dựng từ
                                                                    những nỗ lực bền bỉ nhất, Grand Hotel cam kết mang
                                                                    đến cho bạn chất lượng cuộc sống cao nhất, những
                                                                    khoảnh khắc đẹp nhất, hạnh phúc nhất, kỳ nghỉ nhất
                                                                    của bạn là kỷ niệm mãi mãi không bao giờ quên.')
INSERT [dbo].[NotePreviews] ([Id], [Note1], [Note2], [Id_Type], [Note3], [Note4], [Note5], [Note6]) VALUES (N'id1', N'Diện tích: 45m 2', N'Điều hòa hai chiều
', N'MLP01', N'Có wifi và Internet', N'Có trè và cafe miễn phí', N'Ban công', N'Quán bar nhỏ và quán giải khát')
INSERT [dbo].[NotePreviews] ([Id], [Note1], [Note2], [Id_Type], [Note3], [Note4], [Note5], [Note6]) VALUES (N'id2', N'Giường Kingsize có chăn, ga, gối lông 100% cotton
', N'TV LCD 40 inch của Sony
', N'MLP03', N'Diện tích 100m 2', N'Bàn trà với trà và cà phê miễn phí', N'Tắm hơi với hệ thống nước nóng lạnh', N'Điện thoại quay số trực tiếp quốc tế')
INSERT [dbo].[NotePreviews] ([Id], [Note1], [Note2], [Id_Type], [Note3], [Note4], [Note5], [Note6]) VALUES (N'id3', N'Diện tích 70m 2
', N'NULPhòng khách với phòng khách bằng daL', N'MLP04', N'TV LCD 40 inch của Sony', N'Bàn trà với trà và cà phê miễn phí', N'Minibar và nước ngọt', N'Dịch vụ phòng')
INSERT [dbo].[NotePreviews] ([Id], [Note1], [Note2], [Id_Type], [Note3], [Note4], [Note5], [Note6]) VALUES (N'id4', N'Phòng tắm có tường kính và vòi hoa sen
', N'Điện thoại quay số trực tiếp quốc tế
', N'MLP02', N'Diện tích: 20m 2', N'Máy điều hòa', N'Bàn trà và cà phê', N'Wifi và internet miễn phí')
INSERT [dbo].[Promotion] ([Id_Prom], [Title], [ImageLink], [Active], [Detail]) VALUES (N'MKM01', N'Khuyến mãi lớn', NULL, NULL, N'1')
INSERT [dbo].[Promotion] ([Id_Prom], [Title], [ImageLink], [Active], [Detail]) VALUES (N'MKM02', N'Khuyến mãi mùa hè 2020', N'80626001.jpg', 1, N'- Với hệ thống Grandhotel bạn sẽ không chỉ tận hưởng trải nghiệm kỳ nghỉ tuyệt vời với những trải nghiệm thú vị mà còn tận hưởng với những chương trình khuyến mãi cực kỳ hấp dẫn.')
INSERT [dbo].[Promotion] ([Id_Prom], [Title], [ImageLink], [Active], [Detail]) VALUES (N'MKM03', N'Khuyến mãi thành lập khách sạn Grandhotel', N'80625894.jpg', 1, N'- Bạn sẽ được tận hưởng rất nhiều ưu đãi khi GrandHotel mới mở cửa.')
INSERT [dbo].[Room] ([Id_Room], [Name], [Price], [Status], [Active], [Id_Type]) VALUES (N'12', NULL, 11, 0, NULL, N'MLP03')
INSERT [dbo].[Room] ([Id_Room], [Name], [Price], [Status], [Active], [Id_Type]) VALUES (N'MP01', N'101', 400000, NULL, 1, N'MLP01')
INSERT [dbo].[Room] ([Id_Room], [Name], [Price], [Status], [Active], [Id_Type]) VALUES (N'MP02', N'102', 300000, 0, 1, N'MLP02')
INSERT [dbo].[Room] ([Id_Room], [Name], [Price], [Status], [Active], [Id_Type]) VALUES (N'MP03', N'103', 400000, 0, 1, N'MLP03')
INSERT [dbo].[Room] ([Id_Room], [Name], [Price], [Status], [Active], [Id_Type]) VALUES (N'MP04', N'104', 800000, 1, 1, N'MLP04')
INSERT [dbo].[RoomType] ([Id_Type], [Name], [Bed_Amount], [Size], [Adult_Amount], [Children_Amount], [Active], [Note]) VALUES (N'MLP01', N'phong-deluxe', N'2', 45, N'1', N'1', 1, N'phong-deluxe')
INSERT [dbo].[RoomType] ([Id_Type], [Name], [Bed_Amount], [Size], [Adult_Amount], [Children_Amount], [Active], [Note]) VALUES (N'MLP02', N'phong-Superior', N'1', 20, N'2', N'1', 1, N'phong-Superior')
INSERT [dbo].[RoomType] ([Id_Type], [Name], [Bed_Amount], [Size], [Adult_Amount], [Children_Amount], [Active], [Note]) VALUES (N'MLP03', N'phong-Suite', N'3', 70, N'3', N'1', 1, N'phong-Suite')
INSERT [dbo].[RoomType] ([Id_Type], [Name], [Bed_Amount], [Size], [Adult_Amount], [Children_Amount], [Active], [Note]) VALUES (N'MLP04', N'phong-luxury', N'2', 100, N'2', N'1', 1, N'phong-luxury')
INSERT [dbo].[Service] ([Id_Service], [Name], [Active], [ID_Type], [Image_service]) VALUES (N'MDV01', N'nhahang', NULL, N'ST000001', N'nhahang.jpg')
INSERT [dbo].[Service] ([Id_Service], [Name], [Active], [ID_Type], [Image_service]) VALUES (N'MDV02', N'gym', 1, N'ST000004', N'gym.jpg')
INSERT [dbo].[Service] ([Id_Service], [Name], [Active], [ID_Type], [Image_service]) VALUES (N'MDV03', N'hoboi', 1, N'ST000002', N'hoboi.jpg')
INSERT [dbo].[Service] ([Id_Service], [Name], [Active], [ID_Type], [Image_service]) VALUES (N'MDV04', N'spa', 1, N'ST000003', N'spa.jpg')
INSERT [dbo].[ServiceType] ([ID_Type], [Name], [Content_Service]) VALUES (N'ST000001', N'Nhà hàng chuẩn 5 sao', N'Nhà Hàng Hội An Hotel & Spa sẽ mang đến cho bạn sự trải nghiệm ẩm thực Việt thật sự khó quên, khi thưởng thức ẩm thực hòa quyện cùng vẻ đẹp của thiên nhiên và bầu không khí tươi mát đặc trưng của miền nhiệt đới. Từ giản dị đến tinh tế, những món ăn được trang trí mắt mắt kích thích khẩu vị của bạn.

Ẩm thực Việt Nam vốn nổi tiếng bởi sự thanh đạm nhưng vẫn giữ được nét tinh tế trong hương vị. Không những vậy, các món ăn có thể làm bạn bất ngờ với những kết hợp đặc biệt giữa các nguyên liệu. Đại diện cho sự kết hợp tinh tế đó phải nhắc đến các món ăn truyền thống Việt Nam. Nhờ nằm trong vùng khí hậu nhiệt đới, thảm thực vật phát triển phong phú đã cung cấp cho các món ăn Việt sự lựa chọn các loại thảo mộc phong phú tốt cho sức khỏe. Bên cạnh đó, những phương thức nấu ăn xưa độc đáo được truyền lại từ các thế hệ trước cũng góp phần tạo nên sự đậm đà trong hương vị của từng món ăn.

Hãy đến với chúng tôi để có thể thưởng thức những đặc sản mang đậm hương vị Việt! Chắc chắn bạn sẽ không thể nào quên!')
INSERT [dbo].[ServiceType] ([ID_Type], [Name], [Content_Service]) VALUES (N'ST000002', N'Bể bơi', N'Đây là hồ bơi nước nóng hiện đại bậc nhất nơi đây, nơi du khách vừa có thể thỏa sức bơi lội vừa tận hưởng không khí tự nhiên trong lành. Bạn sẽ vô cùng mát mẻ, sảng khoải, nếu được ngâm mình trong làn nước xanh ngắt và trong vắt ngắm nhìn cảnh hoàng hôn thơ mộng và bình minh trên biển. Mọi mệt nhọc trong cuộc họp hay ngày vui chơi sẽ được giải tỏa hết, thư giãn và thả lỏng cơ thể trong làn nước xanh mát.')
INSERT [dbo].[ServiceType] ([ID_Type], [Name], [Content_Service]) VALUES (N'ST000003', N'Spa', N'Tạm gác lại những bộn bề của cuộc sống để đến với Grand Hotel & Spa. Một không gian yên bình mang đậm bản sắc văn hóa địa phương cùng mùi hương thảo mộc đầy thư thái như ôm lấy cơ thể và đánh thức tâm trí bạn. Sau một ngày dài tham quan phố núi mờ sương, ngâm mình trong bồn lá thuốc đặc trưng của người dân tộc Dao Đỏ chắc chắn sẽ giúp bạn tìm lại sự cân bằng, xua tan mệt mỏi.')
INSERT [dbo].[ServiceType] ([ID_Type], [Name], [Content_Service]) VALUES (N'ST000004', N'Gym', N'Phòng tập Gym của Hội An Hotel & Spa sở hữu một không gian tập rộng rãi với đầy đủ trang thiết bị hiện đại. Tất cả những dụng cụ tập đều được đầu tư hiện đại để đảm bảo việc tập luyện của Quý khách thuận tiện và hiệu quả. Đội ngũ huấn luyện viên cá nhân có hiểu biết chuyên sâu về dinh dưỡng cũng như luyện tập luôn hướng dẫn bạn từ những động tác nhỏ nhất, đến lộ trình dinh dưỡng và luyện tập trong suốt quá trình bạn sinh hoạt tại đây.')
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (2, N'Đặng Quang Đạt', N'22', N'2', NULL, N'Email', N'Address', N'1           ', NULL, NULL, N'Admin.jpg')
INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (3, N'User name', N'2', N'1', 1, N'Email', N'Address', N'1           ', NULL, 0, NULL)
INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (4, N'User name', N'3', N'1', 1, N'Email', N'Address', N'1           ', NULL, 0, NULL)
INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (5, N'Name', N'4', N'1', 1, N'Email', N'Address', N'1           ', NULL, 0, NULL)
INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (6, N'Hoang', N'admin1', N'123', 1, N'hoang160799@gmail.com', N'Thanh Hoa', N'0123456     ', NULL, 1, NULL)
INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (7, N'Hoàng a3', N'1', N'1', NULL, N'Hoang99@gmail.com', N'Address', N'1           ', NULL, 1, NULL)
INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (9, N'11', N'11', N'11', 1, N'11', N'11', N'11          ', NULL, NULL, NULL)
INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (10, N'1', N'testttt', N'1', 1, N'1', N'1', N'1           ', NULL, NULL, NULL)
INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (11, N'Nguyễn Thị Thùy Linh', N'testt', N'1', 0, N'linh99@gmail.com', N'Thái Bình', N'0932313489  ', NULL, 0, NULL)
INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (12, N'Name', N'User name', N'Password', 1, N'Email', N'Address', N'1           ', NULL, 0, NULL)
INSERT [dbo].[Users] ([Id_User], [Name], [UserName], [PassWord], [Sex], [Email], [Address], [Phone], [Status], [Permission], [ImageLink]) VALUES (13, N'123', N'5', N'1', NULL, NULL, NULL, N'1           ', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD FOREIGN KEY([Id_Customer])
REFERENCES [dbo].[Users] ([Id_User])
GO
ALTER TABLE [dbo].[BookingDetail]  WITH CHECK ADD FOREIGN KEY([Id_Booking])
REFERENCES [dbo].[Booking] ([Id_Booking])
GO
ALTER TABLE [dbo].[BookingDetail]  WITH CHECK ADD FOREIGN KEY([Id_Room])
REFERENCES [dbo].[Room] ([Id_Room])
GO
ALTER TABLE [dbo].[Contact]  WITH CHECK ADD FOREIGN KEY([Id_Customer])
REFERENCES [dbo].[Users] ([Id_User])
GO
ALTER TABLE [dbo].[ImageRoom]  WITH CHECK ADD FOREIGN KEY([Id_Room])
REFERENCES [dbo].[Room] ([Id_Room])
GO
ALTER TABLE [dbo].[ImageService]  WITH CHECK ADD FOREIGN KEY([Id_Service])
REFERENCES [dbo].[Service] ([Id_Service])
GO
ALTER TABLE [dbo].[NotePreviews]  WITH CHECK ADD  CONSTRAINT [FK_NotePreviews_RoomType] FOREIGN KEY([Id_Type])
REFERENCES [dbo].[RoomType] ([Id_Type])
GO
ALTER TABLE [dbo].[NotePreviews] CHECK CONSTRAINT [FK_NotePreviews_RoomType]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD FOREIGN KEY([Id_Type])
REFERENCES [dbo].[RoomType] ([Id_Type])
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_ServiceType] FOREIGN KEY([ID_Type])
REFERENCES [dbo].[ServiceType] ([ID_Type])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_ServiceType]
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
         Begin Table = "Room"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RoomType"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ImageRoom"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 208
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
      Begin ColumnWidths = 11
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
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'RoomViewForCartModel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'RoomViewForCartModel'
GO
