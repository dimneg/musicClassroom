USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[Pl03_Poll_MusicGenres]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pl03_Poll_MusicGenres](
	[Pl03_id] [int] IDENTITY(1,1) NOT NULL,
	[Pl03_genre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Pl03_Poll_MusicGenres] PRIMARY KEY CLUSTERED 
(
	[Pl03_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
