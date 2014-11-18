USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[QS04_Questions]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QS04_Questions](
	[QS04_Id] [int] NOT NULL,
	[QS04_QS03_Id] [int] NOT NULL,
	[QS04_QS05_Id] [int] NOT NULL,
	[QS04_Question] [nvarchar](200) NOT NULL,
	[QS04_Image] [image] NULL,
	[QS04_Sound] [varbinary](max) NULL,
 CONSTRAINT [PK_QS04_Questions] PRIMARY KEY CLUSTERED 
(
	[QS04_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[QS04_Questions]  WITH CHECK ADD  CONSTRAINT [FK_QS04_QS03_Id] FOREIGN KEY([QS04_QS03_Id])
REFERENCES [dbo].[QS03_Tests] ([QS03_Id])
GO
ALTER TABLE [dbo].[QS04_Questions] CHECK CONSTRAINT [FK_QS04_QS03_Id]
GO
