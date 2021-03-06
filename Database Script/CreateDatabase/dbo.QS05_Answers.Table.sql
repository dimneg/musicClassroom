USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[QS05_Answers]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QS05_Answers](
	[QS05_Id] [int] NOT NULL,
	[QS05_QS04_Id] [int] NOT NULL,
	[QS05_Answer] [nvarchar](200) NOT NULL,
	[QS05_Advice] [nvarchar](200) NULL,
 CONSTRAINT [PK_QS05_Answers] PRIMARY KEY CLUSTERED 
(
	[QS05_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[QS05_Answers]  WITH CHECK ADD  CONSTRAINT [FK_QS05_QS04_Id] FOREIGN KEY([QS05_QS04_Id])
REFERENCES [dbo].[QS04_Questions] ([QS04_Id])
GO
ALTER TABLE [dbo].[QS05_Answers] CHECK CONSTRAINT [FK_QS05_QS04_Id]
GO
