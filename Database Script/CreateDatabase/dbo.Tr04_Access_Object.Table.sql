USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[Tr04_Access_Object]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tr04_Access_Object](
	[Tr04_Id] [int] NOT NULL,
	[Tr04_Tr03_Id] [int] NOT NULL,
	[Tr04_Tr01_Id] [int] NOT NULL,
	[Tr04_Start_Time] [datetime] NOT NULL,
	[Tr04_Finish_Time] [datetime] NOT NULL,
 CONSTRAINT [PK_Tr04_Access_Object] PRIMARY KEY CLUSTERED 
(
	[Tr04_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tr04_Access_Object]  WITH CHECK ADD  CONSTRAINT [FK_Tr04_Access_Object_Tr01_Transaction_Types] FOREIGN KEY([Tr04_Tr01_Id])
REFERENCES [dbo].[SP01_SpecialAbilities] ([SP01_Id])
GO
ALTER TABLE [dbo].[Tr04_Access_Object] CHECK CONSTRAINT [FK_Tr04_Access_Object_Tr01_Transaction_Types]
GO
ALTER TABLE [dbo].[Tr04_Access_Object]  WITH CHECK ADD  CONSTRAINT [FK_Tr04_Access_Object_Tr03_Theory_Visits] FOREIGN KEY([Tr04_Tr03_Id])
REFERENCES [dbo].[Tr03_Theory_Visits] ([Tr03_Id])
GO
ALTER TABLE [dbo].[Tr04_Access_Object] CHECK CONSTRAINT [FK_Tr04_Access_Object_Tr03_Theory_Visits]
GO
