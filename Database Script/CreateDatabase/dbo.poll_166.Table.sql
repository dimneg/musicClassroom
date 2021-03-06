USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[poll_166]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[poll_166](
	[Timestamp] [datetime] NULL,
	[SoftwareUse] [nvarchar](255) NULL,
	[Instruments] [nvarchar](255) NULL,
	[Education_type] [nvarchar](255) NULL,
	[NotInUse1] [nvarchar](255) NULL,
	[V1_ImageSee] [float] NULL,
	[A1_SoundHear] [float] NULL,
	[V2_NoteRead] [float] NULL,
	[TotalTraining] [nvarchar](255) NULL,
	[agegroup] [nvarchar](255) NULL,
	[TotalMusicYears] [nvarchar](255) NULL,
	[Gender] [nvarchar](255) NULL,
	[V3_SongScore] [float] NULL,
	[A2_SongPlay] [float] NULL,
	[NotInUse2] [nvarchar](255) NULL,
	[A3_Dicte] [float] NULL,
	[MusicGenre] [nvarchar](255) NULL,
	[TheoryTraining] [float] NULL,
	[Opt] [bit] NULL,
	[Vis] [bit] NULL
) ON [PRIMARY]
GO
