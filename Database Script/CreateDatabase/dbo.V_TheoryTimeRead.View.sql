USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  View [dbo].[V_TheoryTimeRead]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[V_TheoryTimeRead]
 as
 SELECT Tr03_Us01_Id,sum(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time )) as time
      from  Tr03_Theory_Visits
     group by  Tr03_Us01_Id
GO
