USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Stereotype_TotalTraining]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION  [dbo].[Fn_Stereotype_TotalTraining]
(
	@tt varchar(50),   --user 's total training
	@Abil int	   --visual,Audio
)
RETURNS numeric(5,2)
AS
BEGIN
	
	DECLARE @tt_factor numeric(5,2)
	
	set @tt_factor =
	
	   (case @Abil
	   when 1 then
	   (
		   select v / 30
		   from [V_TotalTraining_V] 
		   where  [dbo].[Fn_getTotalTraining](@tt)=ltrim(rtrim(totaltraining))
	   )  	   
						
	   when 2 then
	    (
		   select A /30
		   from [V_TotalTraining_A] 
		   where  [dbo].[Fn_getTotalTraining](@tt)=ltrim(rtrim(totaltraining))
	    )
					    
	   
	                         
	  end) 
	 return @tt_factor                 

	--select * from [dbo].[V_TOTaltraining_V]
	--select * from [dbo].[V_TOTaltraining_A]
	--select  [dbo].[Fn_Stereotype_TotalTraining] ('Είμαι πτυχιούχος κάποιου οργάνου',1 )

	

END
GO
