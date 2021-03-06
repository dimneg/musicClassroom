USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Access_Object_Count]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_Access_Object_Count]
	(
	@US01_Id int,  --user
	@Tr01_id int   -- ειδος κίνησης π.χ. ανοιγμα εικόνας
	)
returns numeric(5,2)
AS
begin
	 DECLARE @accessObjectCounter numeric(5,2)
	 
	 if @Tr01_id=0
	 	 
	 set  @accessObjectCounter=
            (
             select count(*) from Tr04_Access_Object Tr04
             inner join Tr03_Theory_Visits Tr03
             on Tr03.Tr03_id=TR04.Tr04_Tr03_id
             where Tr03.Tr03_Us01_id=@US01_Id
            )
     else
     set  @accessObjectCounter=
     (
             select count(*) 
             from Tr04_Access_Object Tr04
             inner join Tr03_Theory_Visits Tr03
             on Tr03.Tr03_id=TR04.Tr04_Tr03_id
             where Tr03.Tr03_Us01_id=@US01_Id
             and tr04.tr04_tr01_id=@Tr01_id
            )
	 
return @accessObjectCounter 
end
--select [dbo].[Fn_Access_Object_Count] (1,3)
GO
