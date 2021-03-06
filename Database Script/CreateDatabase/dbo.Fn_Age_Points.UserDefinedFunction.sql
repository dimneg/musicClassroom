USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Age_Points]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_Age_Points]
	(@US01_Id int)

RETURNS numeric (5,2)
AS
BEGIN
	
	DECLARE @partialGrade numeric (5,2)
	DECLARE @age int
	DECLARE @m numeric (5,2)
	DECLARE @b numeric (5,2)
	DECLARE @adj_f numeric (5,2) --addition 26/12/2012
	
	
	set @age=(select US01_Age 
	from dbo.US01_Users
	where US01_Id=@US01_Id)
	
	set @adj_f =(select set01_value
	             from Set01_settings
	             where Set01_setting='Fn_Age_Pts_Norm_F')
	
	set @partialGrade =0
	set @m= 
	            (select set01_value
	             from Set01_settings
	             where Set01_setting='Fn_Age_Pts_Rgr_sl') --change 26/12/2012
		 /* regression slope  */
	set @b= 
	            (select set01_value
	             from   Set01_settings
	             where  Set01_setting='Fn_Age_Pts_Rgr_Intrc') --change 26/12/2012
	 /*regression y intercept  */
	if (@age is null)
	     set @partialGrade=0
	else
	if (@age <=45)
	     set @partialGrade= (@m*@age)+ @b /*regression formula y=mx+b*/
	else set @partialGrade=
	           case 
	              when (@age<=50)  then 9
	              when (@age>50) and (@age<=60) then 7
	              when (@age>60) and (@age<=70)then 5
	              when (@age>70) then 3
	            end
	            set @partialGrade=(@partialGrade / @adj_f *10) --change 26/12/2012)
	RETURN @partialGrade

END --select dbo.Fn_Age_Points (3)
GO
