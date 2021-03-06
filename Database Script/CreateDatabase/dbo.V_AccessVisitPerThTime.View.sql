USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  View [dbo].[V_AccessVisitPerThTime]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[V_AccessVisitPerThTime] as 
						select tr03_us01_id as user_id, Tr04_Tr01_Id,
						cast(SUM(DATEDIFF(SECOND, tr04_start_time,Tr04_Finish_Time )	)*1.00 as numeric(5,2)) AS DurObj,
						cast (sum(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time ))*1.00 as numeric(5,2)) as DurTh,
						cast(SUM(DATEDIFF(SECOND, tr04_start_time,Tr04_Finish_Time )*1.00	)
						                     /
						sum(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time ))*1.00 as numeric(5,2)) as AccPerVisit
						
						
						from Tr04_Access_Object Tr04
						right join Tr03_Theory_Visits Tr03
						on Tr03.Tr03_id=TR04.Tr04_Tr03_id
						
						group by tr03.tr03_us01_id,tr04.Tr04_Tr01_Id
GO
