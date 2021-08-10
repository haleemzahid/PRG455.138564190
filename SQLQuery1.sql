CREATE TABLE [dbo].[Screening](
	[ScreeningId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[CloseContact] [bit] NOT NULL,
	[Travelled] [bit] NOT NULL,
	[Symptoms] [bit] NOT NULL,
	[Date] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ScreeningId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 09-Aug-21 8:59:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[UserType] [nvarchar](50) NOT NULL,
	[UserFlagged] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Screening] ON 

INSERT [dbo].[Screening] ([ScreeningId], [UserId], [CloseContact], [Travelled], [Symptoms], [Date]) VALUES (15, 15, 0, 0, 0, CAST(N'2021-08-09T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Screening] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [UserName], [UserType], [UserFlagged]) VALUES (15, N'jksd', N'student', 1)
INSERT [dbo].[User] ([UserId], [UserName], [UserType], [UserFlagged]) VALUES (16, N'asd', N'student', 0)
SET IDENTITY_INSERT [dbo].[User] OFF