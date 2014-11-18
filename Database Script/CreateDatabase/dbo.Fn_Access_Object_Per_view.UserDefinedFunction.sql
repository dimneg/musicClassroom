USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Access_Object_Per_view]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_Access_Object_Per_view]
  (
   @US01_Id int, --user
   @Tr01_Id int,  --transaction type 1.See Image 2.Hear Sound --πλέον απο Special Abilities
   @Qs02_id int 
  )
    RETURNS numeric(5,2)
AS

BEGIN
    
    DECLARE @accessPerView numeric(5,2)
    
  
            
  if ( [dbo].[Fn_Theory_Visits_Count](@US01_Id,@Qs02_id )  = 0 )
  
  set @accessPerView =0
   
  else
  
  set @accessPerView = [dbo].[Fn_Access_Object_Count](@US01_Id,@Tr01_Id) /  [dbo].[Fn_Theory_Visits_Count](@US01_Id,@Qs02_id )
   
  return    @accessPerView   
END
             --SELECT [dbo].[Fn_Access_Object_Times_Per_view](1,0,0)
             --select [dbo].[Fn_Access_Object_Count](1,0)
             --select[dbo].[Fn_Theory_Visits_Count](1,0)
GO
