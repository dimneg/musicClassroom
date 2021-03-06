USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  View [dbo].[V_Access_Object_time]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[V_Access_Object_time] as
select tr03_us01_id as user_id,Tr04_Tr01_Id, 
						SUM(DATEDIFF(SECOND, tr04_start_time,Tr04_Finish_Time )	) AS DUR
					
						from Tr04_Access_Object Tr04
						inner join Tr03_Theory_Visits Tr03
						on Tr03.Tr03_id=TR04.Tr04_Tr03_id
						
						group by tr03_us01_id,Tr04_Tr01_Id
GO
