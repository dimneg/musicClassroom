USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Stereotype_Edu_type]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_Stereotype_Edu_type]
(
	@edu_type int,
	@Abil int
)
RETURNS numeric(5,2)
AS
BEGIN
	
	DECLARE @Edu_Type_Factor numeric (5,2)
	set @Edu_Type_Factor =
	(
	case @Abil 
	when 1 then
				(
				 select V from V_education_type_V
				 where dbo.[Fn_getEducationType](@edu_type)=ltrim(rtrim(education_type))
				 )
				  / 30
	when 2 then
				(
				 select A from V_education_type_A
				 where dbo.[Fn_getEducationType](@edu_type)=ltrim(rtrim(education_type))
				 )
				  / 30
	
     end
     )
	
	

	
	RETURN @Edu_Type_Factor 
END
--select dbo.[Fn_Stereotype_Edu_type] (1,1)
GO
