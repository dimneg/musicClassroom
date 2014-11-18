USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Update_Level1]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usp_Update_Level1]
    (@user_id int,@Sp02 int,@abil int)
As
Begin
	update Sp03_Tree1_users
	set Sp03_lvl=(
				  (	
				  select sum (Sp05_Lvl)
				  from  Sp05_Tree2_Users
				  where Sp05_Us01_id=@user_id
				  and Sp05_Sp01_id=@abil
				  and Sp05_Sp04_id in
									( 
									 select Sp04_id
									 from Sp04_Tree2_L2
									 where Sp04_Sp02_id=@Sp02
									 )
				  )
							/		 
									 	 
	               (
	               select count (*) from Sp04_Tree2_L2
				   where Sp04_Sp02_id=@Sp02
				   )
				   )
   
								 
    
	where Sp03_Us01_id=@user_id
	and Sp03_Sp01_id=@abil 
	and Sp03_Tree1=@Sp02
END
GO
