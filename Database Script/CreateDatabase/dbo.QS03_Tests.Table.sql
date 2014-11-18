USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[QS03_Tests]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QS03_Tests](
	[QS03_Id] [int] NOT NULL,
	[QS03_QS02_Id] [int] NOT NULL,
	[QS03_QS06_id] [int] NOT NULL,
	[QS03_Sp01_id] [int] NULL,
 CONSTRAINT [PK_Tests_1] PRIMARY KEY CLUSTERED 
(
	[QS03_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[QS03_Tests]  WITH CHECK ADD  CONSTRAINT [FK_QS03_QS02_Id] FOREIGN KEY([QS03_QS02_Id])
REFERENCES [dbo].[QS02_Categories] ([QS02_Id])
GO
ALTER TABLE [dbo].[QS03_Tests] CHECK CONSTRAINT [FK_QS03_QS02_Id]
GO
ALTER TABLE [dbo].[QS03_Tests]  WITH CHECK ADD  CONSTRAINT [FK_QS03_QS06_Id] FOREIGN KEY([QS03_QS06_id])
REFERENCES [dbo].[QS06_TestLevels] ([QS06_id])
GO
ALTER TABLE [dbo].[QS03_Tests] CHECK CONSTRAINT [FK_QS03_QS06_Id]
GO
ALTER TABLE [dbo].[QS03_Tests]  WITH CHECK ADD  CONSTRAINT [FK_QS03_Tests_SP01_SpecialAbilities] FOREIGN KEY([QS03_Sp01_id])
REFERENCES [dbo].[SP01_SpecialAbilities] ([SP01_Id])
GO
ALTER TABLE [dbo].[QS03_Tests] CHECK CONSTRAINT [FK_QS03_Tests_SP01_SpecialAbilities]
GO
