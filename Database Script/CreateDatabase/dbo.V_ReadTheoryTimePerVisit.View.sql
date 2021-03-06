USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  View [dbo].[V_ReadTheoryTimePerVisit]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[V_ReadTheoryTimePerVisit] as
SELECT 	[Tr03_Us01_Id] AS USER_ID,SUM(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time )	) AS DUR, count(*)  AS NUM,
								SUM(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time )	)/  count(*) AS TperV
								
								FROM
								Tr03_Theory_Visits GROUP BY [Tr03_Us01_Id]
GO
