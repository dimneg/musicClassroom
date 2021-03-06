USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[US01_Users]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[US01_Users](
	[US01_Id] [int] NOT NULL,
	[US01_UserName] [nvarchar](50) NOT NULL,
	[US01_Password] [nvarchar](50) NOT NULL,
	[US01_Name] [nvarchar](50) NOT NULL,
	[US01_Surname] [nvarchar](50) NOT NULL,
	[US01_Age] [int] NOT NULL,
	[US01_TheoryExperience] [int] NOT NULL,
	[US01_Gender] [bit] NOT NULL,
	[US01_CurrentLvl] [float] NULL,
	[Us01_EducationType_Us05_id] [int] NULL,
	[Us01_TotalMusicYears] [int] NULL,
	[Us01_TotalTraining] [nvarchar](50) NULL,
 CONSTRAINT [PK_US01_Users] PRIMARY KEY CLUSTERED 
(
	[US01_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[US01_Users]  WITH CHECK ADD  CONSTRAINT [FK_US01_Users_Us05_User_Education_Type] FOREIGN KEY([Us01_EducationType_Us05_id])
REFERENCES [dbo].[Us05_User_Education_Type] ([Us05_id])
GO
ALTER TABLE [dbo].[US01_Users] CHECK CONSTRAINT [FK_US01_Users_Us05_User_Education_Type]
GO
