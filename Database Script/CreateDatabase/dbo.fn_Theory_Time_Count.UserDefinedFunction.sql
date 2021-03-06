USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_Theory_Time_Count]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_Theory_Time_Count]
(
	@US01_Id int,  --user
	@QS02_Id int   --theory type eg scales,chords,general
)
RETURNS numeric(13,2)
AS
BEGIN
	
	DECLARE @TheoryVisitsTimer numeric(13,2)
	if @QS02_Id = 0
	set  @TheoryVisitsTimer=
	  (
	  SELECT sum(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time ))
      from  Tr03_Theory_Visits
      where Tr03_Us01_Id=@US01_Id
      )
    else
    set  @TheoryVisitsTimer=
	  (
	  SELECT sum(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time ))
      from  Tr03_Theory_Visits
      where Tr03_Us01_Id=@US01_Id
      and Tr03_Qs02_id=@QS02_Id
      )
	
	RETURN @TheoryVisitsTimer

END
GO
