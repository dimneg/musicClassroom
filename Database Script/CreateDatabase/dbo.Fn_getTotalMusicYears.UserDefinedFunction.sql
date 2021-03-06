USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_getTotalMusicYears]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE  FUNCTION [dbo].[Fn_getTotalMusicYears]
(
	@tmy int--user 's total years involvement
	--@Abil int	   --visual,Audio
)
RETURNS varchar(50)
AS
BEGIN
	DECLARE @tmyGroup varchar(50)
	
	set @tmyGroup =(
	case 
	when       (@tmy<=3) 		 then '1-3'
	when (@tmy<=6 and @tmy>=4)   then '4-6'
	when (@tmy<=10 and @tmy>=7)  then '7-10'
	when (@tmy<=15 and @tmy>=11) then '11-15'
	when (@tmy<=20 and @tmy>=16) then '16-20'
	when (@tmy<=30 and @tmy>=21) then '21-30'
	when      (@tmy>30)          then '31+'
	
	else
	'other'
	end)
	
	RETURN  @tmyGroup

END
GO
