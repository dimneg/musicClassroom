USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Stereotype_TotalMusicYears]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION  [dbo].[Fn_Stereotype_TotalMusicYears]
(
	@tmy int,	   --user 's total music years
	@Abil int	   --visual,Audio
)
RETURNS numeric(5,2)
AS
BEGIN
	
	DECLARE @tmy_factor numeric(5,2)
	
	set @tmy_factor =
	
	   (case @Abil
	   when 1 then
	   (
		   select v / 30
		   from [V_totalmusicyears_V] 
		   where  [dbo].[Fn_getTotalMusicYears](@tmy)=ltrim(rtrim(totalmusicyears))
		   	   )
						
	   when 2 then
	    (
		   select A / 30
		   from [V_totalmusicyears_A] 
		   where  [dbo].[Fn_getTotalMusicYears](@tmy)=ltrim(rtrim(totalmusicyears))
	     )
					    
	   
	                         
	  end) 
	 return @tmy_factor                  

	--select * from [dbo].[V_agegroup_V]
	--select * from [dbo].[V_agegroup_A]
	--select [dbo].[Fn_Stereotype_Age](18,1)
	/*select v 
		   from [V_agegroup_V] 
		   where  [dbo].[Fn_getAgeGroup](13)=agegroup*/

END
GO
