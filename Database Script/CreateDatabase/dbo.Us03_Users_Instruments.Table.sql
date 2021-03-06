USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[Us03_Users_Instruments]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Us03_Users_Instruments](
	[US03_id] [int] NOT NULL,
	[US03_IN01_id] [int] NOT NULL,
	[Us03_US01_id] [int] NOT NULL,
 CONSTRAINT [PK_Us03_Users_Instruments] PRIMARY KEY CLUSTERED 
(
	[US03_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Us03_Users_Instruments]  WITH CHECK ADD  CONSTRAINT [FK_Us03_Users_Instruments_IN01_Instruments] FOREIGN KEY([US03_IN01_id])
REFERENCES [dbo].[IN01_Instruments] ([IN01_Id])
GO
ALTER TABLE [dbo].[Us03_Users_Instruments] CHECK CONSTRAINT [FK_Us03_Users_Instruments_IN01_Instruments]
GO
ALTER TABLE [dbo].[Us03_Users_Instruments]  WITH CHECK ADD  CONSTRAINT [FK_Us03_Users_Instruments_Us01_Users] FOREIGN KEY([Us03_US01_id])
REFERENCES [dbo].[US01_Users] ([US01_Id])
GO
ALTER TABLE [dbo].[Us03_Users_Instruments] CHECK CONSTRAINT [FK_Us03_Users_Instruments_Us01_Users]
GO
