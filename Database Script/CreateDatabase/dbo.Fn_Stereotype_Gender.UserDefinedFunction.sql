USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Stereotype_Gender]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_Stereotype_Gender]
(
	@gender bit,--user 's gender
	@Abil int	   --visual,Audio
)
RETURNS  numeric(5,2)
AS
BEGIN
	DECLARE @gender_factor numeric(5,2)
	
	set @gender_factor =
	(
		case @Abil  
		when 1 then
	   (
		   select V / 30
		   from [V_gender_V] 
		   where  dbo.Fn_GetGender(@gender)=ltrim(rtrim(gender))
		   	   		
		)
		when 2 then
		(
		   select A / 30
		   from [V_gender_A] 
		   where  dbo.Fn_GetGender(@gender)=ltrim(rtrim(gender))
		   	   		
		)
		end
	)

	RETURN  @gender_factor 

END
--select dbo.Fn_Stereotype_Gender ('False',1)
--select dbo.Fn_Stereotype_Gender ('True',1)
--select dbo.Fn_Stereotype_Gender ('False',2)
--select dbo.Fn_Stereotype_Gender ('True',2)
GO
