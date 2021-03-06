USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Theory_Visits_Count]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_Theory_Visits_Count]
	(
	 @US01_Id int, --user
	 @QS02_Id int --theory type eg scales,chords,general
	)
	returns numeric(5,2)
AS
begin
	declare @theoryVisitsCounter numeric(5,2)
	if @QS02_Id = 0
	SET @theoryVisitsCounter =
              (
               select count(*) from Tr03_Theory_Visits
               where Tr03_Us01_Id=@US01_Id
               )
    else
    SET @theoryVisitsCounter =
              (
               select count(*)
               from Tr03_Theory_Visits
               where Tr03_Us01_Id=@US01_Id 
               and Tr03_Qs02_id=@QS02_Id
               )
    
    return @theoryVisitsCounter 
end
--SELECT [dbo].[Fn_Theory_Visits_Count](1, 0)
GO
