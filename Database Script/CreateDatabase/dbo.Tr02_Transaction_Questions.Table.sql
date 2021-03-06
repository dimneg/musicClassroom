USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[Tr02_Transaction_Questions]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tr02_Transaction_Questions](
	[Tr02_id] [int] NOT NULL,
	[Tr02_Qs04_Id] [int] NOT NULL,
	[Tr02_Tr01_id] [int] NOT NULL,
 CONSTRAINT [PK_Tr02_Transaction_Questions] PRIMARY KEY CLUSTERED 
(
	[Tr02_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tr02_Transaction_Questions]  WITH CHECK ADD  CONSTRAINT [FK_Tr02_Transaction_Questions_QS04_Questions] FOREIGN KEY([Tr02_Qs04_Id])
REFERENCES [dbo].[QS04_Questions] ([QS04_Id])
GO
ALTER TABLE [dbo].[Tr02_Transaction_Questions] CHECK CONSTRAINT [FK_Tr02_Transaction_Questions_QS04_Questions]
GO
ALTER TABLE [dbo].[Tr02_Transaction_Questions]  WITH CHECK ADD  CONSTRAINT [FK_Tr02_Transaction_Questions_TR01_Transaction_Types] FOREIGN KEY([Tr02_Tr01_id])
REFERENCES [dbo].[Not_TR01_Transaction_Types] ([TR01_id])
GO
ALTER TABLE [dbo].[Tr02_Transaction_Questions] CHECK CONSTRAINT [FK_Tr02_Transaction_Questions_TR01_Transaction_Types]
GO
