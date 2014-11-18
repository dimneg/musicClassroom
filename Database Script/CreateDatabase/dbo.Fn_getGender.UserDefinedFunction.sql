USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_getGender]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_getGender]
(
	@gender bit
)
RETURNS varchar(50)
AS
BEGIN
	
	DECLARE @genderDescr varchar(50)

	set @genderDescr=
	(
	case @gender
	when 'False' then 'Ανδρας'
	when 'True' then 'Γυναίκα'
	end
	)
	RETURN @genderDescr

END
GO
