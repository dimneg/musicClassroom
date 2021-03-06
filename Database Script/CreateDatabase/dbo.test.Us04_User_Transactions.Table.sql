USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  Table [dbo].[test.Us04_User_Transactions]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test.Us04_User_Transactions](
	[Us04_id] [int] NOT NULL,
	[Us04_Tr01_id] [int] NOT NULL,
	[Us04_times] [int] NULL,
	[Us04_duration] [float] NULL,
	[Us04_Us01_id] [int] NOT NULL,
	[Us04_DateTaken] [datetime] NULL,
 CONSTRAINT [PK_Us04_User_Transactions] PRIMARY KEY CLUSTERED 
(
	[Us04_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[test.Us04_User_Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Us04_User_Transactions_TR01_Transaction_Types] FOREIGN KEY([Us04_Tr01_id])
REFERENCES [dbo].[Not_TR01_Transaction_Types] ([TR01_id])
GO
ALTER TABLE [dbo].[test.Us04_User_Transactions] CHECK CONSTRAINT [FK_Us04_User_Transactions_TR01_Transaction_Types]
GO
