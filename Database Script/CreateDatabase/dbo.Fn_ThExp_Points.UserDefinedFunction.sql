USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_ThExp_Points]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_ThExp_Points]
	
	(@US01_Id int)

RETURNS numeric (5,2)

AS
BEGIN

	DECLARE @exp int
	DECLARE @partialGrade numeric (5,2)
	DECLARE @m numeric (5,2)
	DECLARE @b numeric (5,2)
	
	set @exp= 
			(select US01_TheoryExperience from dbo.US01_Users
			 where US01_Id=@US01_Id )
	set @partialGrade =0
	set @m= (
	         select Set01_Value from Set01_Settings
	         where Set01_Setting='Fn_Th_Exp_Rgr_sl'
	         ) --new addition 26/12/2012
	
	 /* regression slope @m=0.85 */
	 
	 
	set @b=
			(
	         select Set01_Value from Set01_Settings
	         where Set01_Setting='Fn_Th_Exp_Rgr_Intrc'
	         ) --new addition 26/12/2012
	 /*regression y intercept @b=1.18  */
	 
	if (@exp <=10)
	     set @partialGrade= (@m*@exp)+ @b /*regression formula y=mx+b*/
	else 
	if (@exp is null)
	     set @partialGrade=0
	else
	     set @partialGrade=10
	           
	RETURN @partialGrade

END
GO
