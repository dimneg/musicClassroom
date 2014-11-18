USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Access_Object_Time_Per_View]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_Access_Object_Time_Per_View]
(
	@US01_Id int,
	@Tr04_id int,
	@Qs02_id int
)
RETURNS numeric(13,2)
AS
BEGIN
	
	DECLARE @Access_Time_Per_Total_View_time numeric(13,2)
	
	
	if dbo.fn_Theory_Time_Count (@US01_Id,@Qs02_id  )=0
	set  @Access_Time_Per_Total_View_time=0
	else
	set @Access_Time_Per_Total_View_time=
	    dbo.Fn_Access_Object_Time_Count (@US01_Id,@Tr04_id ) /
		dbo.fn_Theory_Time_Count (@US01_Id,@Qs02_id  )
		
		

	
	RETURN @Access_Time_Per_Total_View_time
	-- select dbo.Fn_Access_Object_Time_Per_View (3,1,0 )
	-- select dbo.fn_Theory_Time_Count (3,0)

END
GO
