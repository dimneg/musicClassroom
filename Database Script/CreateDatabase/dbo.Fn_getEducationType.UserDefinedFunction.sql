USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_getEducationType]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_getEducationType]
(
	@edu_type int --τύπος εκπαίδευσης του χρήστη
)
RETURNS varchar(50)
AS
BEGIN
	
	DECLARE @education_type varchar(50)

	set @education_type=
	   (
	   select Us05_Education_type
	   from Us05_User_Education_Type
	   where Us05_id=@edu_type
	   )
	
	return @education_type
	

END
GO
