USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Calculate_level]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usp_Calculate_level]
	(@user_id int)
with recompile
AS
BEGIN	
	-- Calculate points from age and experience
	declare @levelf numeric (5,2)
	set @levelf = dbo.Fn_ThExp_Points(@user_id)
						 *
				  (select set01_value from Set01_Settings
				   where Set01_Setting='Usp_Calc_level_Th_F')
				   --new addition 26/12/2012 
								+
	              dbo.Fn_Age_Points(@user_id)
	                            * 
	              (select set01_value from Set01_Settings
				   where Set01_Setting='Usp_Calc_level_Age_F')
				   --new addition 26/12/2012 
	

	-- Calculate the partial grade from the tests
	declare @levelp	 numeric (5,2)
	set @levelp =  (select		ISNULL(SUM(US02_Grade * QS06_Weight) / COUNT(US02_Grade), 0)
					from		US02_UserTests
					inner join  QS03_Tests
					on			QS03_Id = US02_QS03_Id
					inner join  QS06_TestLevels
					on			QS03_QS06_Id = QS06_id
					where       US02_US01_Id = @user_Id)
	
	-- Apply adjustment factor to partial grade
   	declare @AdjustmentFactor numeric(5,2)
	set @AdjustmentFactor =
	                      (select set01_value from Set01_Settings
				           where Set01_Setting='Usp_Calc_Adj_F') --new addition 26/12/2012
							  
	set @levelp = @levelp * @AdjustmentFactor
	
	-- Compute the final level value
	declare @level numeric (5,2)
	set @level = @levelf + @levelp
			
	-- Update the user level field
	update	US01_Users 
	set		US01_CurrentLvl = @level
	where	US01_Id	= @user_id
END
GO
