USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[Us05_Users_Abilities_Levels]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Us05_Users_Abilities_Levels](
	[Us05_Id] [int] IDENTITY(1,1) NOT NULL,
	[Us05_Us01_id] [int] NOT NULL,
	[Us05_Sp01_id] [int] NOT NULL,
	[Us05_Level] [numeric](5, 2) NULL,
	[Us05_Level_W] [numeric](5, 2) NULL,
 CONSTRAINT [PK_Us05_Users_Abilities_Levels] PRIMARY KEY CLUSTERED 
(
	[Us05_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Us05_Users_Abilities_Levels]  WITH CHECK ADD  CONSTRAINT [FK_Us05_Users_Abilities_Levels_SP01_SpecialAbilities] FOREIGN KEY([Us05_Sp01_id])
REFERENCES [dbo].[SP01_SpecialAbilities] ([SP01_Id])
GO
ALTER TABLE [dbo].[Us05_Users_Abilities_Levels] CHECK CONSTRAINT [FK_Us05_Users_Abilities_Levels_SP01_SpecialAbilities]
GO
