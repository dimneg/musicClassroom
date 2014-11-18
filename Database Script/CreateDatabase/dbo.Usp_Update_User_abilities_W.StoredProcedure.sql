USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Update_User_abilities_W]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Usp_Update_User_abilities_W]
	(@user_id int, @abil int)
AS
BEGIN
		SET NOCOUNT ON;
		
		
  update Us05_Users_Abilities_Levels
  set Us05_Level_W=(select sum (Sp03_Lvl*Sp02_Weight)
				  from V_Tree1_Level_Weights v 
				  where  Sp03_Us01_id=@user_id
	              and sp03_sp01_id=@abil)
	              
  where Us05_Us01_id=@user_id
  and Us05_Sp01_id=@abil
    /*select Sp03_lvl_W from Sp03_Tree1_users
    where Sp03_Us01_id=3
  and Sp03_Tree1=4
  and Sp03_Sp01_id=1 */
    /*select 
    --sum (Sp05_Lvl*Sp04_Weight),
    Sp05_Lvl,Sp04_Weight
				  from V_Tree2_Level_Weights v 
				  where Sp04_Sp02_id=4
				  and Sp05_Us01_id=3
	              and Sp05_Sp01_id=1*/
    
END
GO
