﻿USE [Vir]
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 11/18/2016 11:00:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMERS](
	[ID] [int] NOT NULL,
	[NAME] [varchar](20) NOT NULL,
	[AGE] [int] NOT NULL,
	[ADDRESS] [char](25) NULL,
	[DESCRIPTION] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CUSTOMERS] ([ID], [NAME], [AGE], [ADDRESS], [DESCRIPTION]) VALUES (100, N'Perumal;', 31, N'KKD                      ', N'Coimbatore')
GO
INSERT [dbo].[CUSTOMERS] ([ID], [NAME], [AGE], [ADDRESS], [DESCRIPTION]) VALUES (101, N'Kumar', 32, N'KKD                      ', N'Coimbatore')
GO