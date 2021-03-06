USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Stereotype_Age]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION  [dbo].[Fn_Stereotype_Age]
(
	@age int,	   --user 's age
	@Abil int	   --visual,Audio
)
RETURNS numeric(5,2)
AS
BEGIN
	
	DECLARE @age_factor numeric(5,2)
	
	set @age_factor =
	
	   (case @Abil
	   when 1 then
	   (
		   select v /30
		   from [V_agegroup_V] 
		   where  [dbo].[Fn_getAgeGroup](@age)=ltrim(rtrim(agegroup))
		   	   )
						
	   when 2 then
	    (
		   select A / 30
		   from [V_agegroup_A] 
		   where  [dbo].[Fn_getAgeGroup](@age)=ltrim(rtrim(agegroup))
	     )
					 
	   
	                         
	  end) 
	 return @age_factor                  

	--select * from [dbo].[V_agegroup_V]
	--select * from [dbo].[V_agegroup_A]
	--select [dbo].[Fn_Stereotype_Age](18,1)
	/*select v 
		   from [V_agegroup_V] 
		   where  [dbo].[Fn_getAgeGroup](13)=agegroup*/

END
GO
