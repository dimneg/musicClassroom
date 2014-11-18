USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Update_user_Abilities]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usp_Update_user_Abilities]
    (@user_id int,@abil int)
As
Begin
	Update Us05_Users_Abilities_Levels
	set Us05_Level=(
				  (	
				  select sum (Sp03_lvl)
				  from  Sp03_Tree1_users
				  where Sp03_Us01_id=@user_id
				  and Sp03_Sp01_id=@abil 
				  )
				  
							/		 
									 	 
	               (
	               select count (*) from Sp03_Tree1_users
				   where Sp03_Sp01_id=@abil
				   and   Sp03_Us01_id=@user_id
				   )
				   )
				   
	where Us05_Us01_id=@user_id
	and Us05_Sp01_id=@abil 
	
END

---exec [dbo].[Usp_Update_user_Abilities] 3,1
GO
