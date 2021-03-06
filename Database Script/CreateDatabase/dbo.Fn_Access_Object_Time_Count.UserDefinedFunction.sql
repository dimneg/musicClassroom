USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Access_Object_Time_Count]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_Access_Object_Time_Count]
(
	 @US01_Id int, --user
	 @Tr01_Id int  --action eg see image,play sound- πλεον απο special abilities
)
RETURNS numeric(13,2)
AS
BEGIN
	Declare @Access_Objects_Timer numeric(13,2)
	if  @Tr01_Id=0
	Set @Access_Objects_Timer= 
	(
		SELECT SUM((DATEDIFF(SECOND, tr04_start_time,tr04_finish_time )))
		FROM  Tr04_Access_Object tr04
		inner join Tr03_Theory_Visits Tr03
        on Tr03.Tr03_id=TR04.Tr04_Tr03_id
        where Tr03.Tr03_Us01_id=@US01_Id
     )  
	else
    Set @Access_Objects_Timer= 
	(
		SELECT SUM((DATEDIFF(SECOND, tr04_start_time,tr04_finish_time )))
		FROM  Tr04_Access_Object tr04
		inner join Tr03_Theory_Visits Tr03
        on Tr03.Tr03_id=TR04.Tr04_Tr03_id
        where Tr03.Tr03_Us01_id=@US01_Id
        and  tr04.Tr04_Tr01_id=@Tr01_Id
     )
        
	Return  @Access_Objects_Timer
END
--select[dbo].[Fn_Access_Object_Time_Count] (1,0)
GO
