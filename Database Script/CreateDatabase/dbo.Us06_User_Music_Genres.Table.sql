USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[Us06_User_Music_Genres]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Us06_User_Music_Genres](
	[Us06_id] [int] NOT NULL,
	[Us06_Us01_id] [int] NULL,
	[Us06_Pl03_id] [int] NULL,
 CONSTRAINT [PK_Us06_User_Music_Genres] PRIMARY KEY CLUSTERED 
(
	[Us06_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Us06_User_Music_Genres]  WITH CHECK ADD  CONSTRAINT [FK_Us06_User_Music_Genres_Pl03_Poll_MusicGenres] FOREIGN KEY([Us06_Pl03_id])
REFERENCES [dbo].[Pl03_Poll_MusicGenres] ([Pl03_id])
GO
ALTER TABLE [dbo].[Us06_User_Music_Genres] CHECK CONSTRAINT [FK_Us06_User_Music_Genres_Pl03_Poll_MusicGenres]
GO
ALTER TABLE [dbo].[Us06_User_Music_Genres]  WITH CHECK ADD  CONSTRAINT [FK_Us06_User_Music_Genres_US01_Users] FOREIGN KEY([Us06_Us01_id])
REFERENCES [dbo].[US01_Users] ([US01_Id])
GO
ALTER TABLE [dbo].[Us06_User_Music_Genres] CHECK CONSTRAINT [FK_Us06_User_Music_Genres_US01_Users]
GO
