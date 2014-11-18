USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[Sp04_Tree2_L2]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sp04_Tree2_L2](
	[Sp04_id] [int] IDENTITY(1,1) NOT NULL,
	[Sp04_Sp02_id] [int] NULL,
	[Sp04_tree2_descr] [nvarchar](50) NULL,
	[Sp04_Weight] [numeric](7, 3) NULL,
 CONSTRAINT [PK_Sp04_tree2] PRIMARY KEY CLUSTERED 
(
	[Sp04_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Sp04_Tree2_L2]  WITH CHECK ADD  CONSTRAINT [FK_Sp04_Tree2_L2_Sp02_Tree_L1] FOREIGN KEY([Sp04_Sp02_id])
REFERENCES [dbo].[Sp02_Tree_L1] ([Sp02_id])
GO
ALTER TABLE [dbo].[Sp04_Tree2_L2] CHECK CONSTRAINT [FK_Sp04_Tree2_L2_Sp02_Tree_L1]
GO
