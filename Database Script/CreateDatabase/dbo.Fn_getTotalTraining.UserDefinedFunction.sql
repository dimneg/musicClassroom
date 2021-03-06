USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_getTotalTraining]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_getTotalTraining]
(
	@tt varchar(50)--user 's total training, theory+ instruments
	--@Abil int	   --visual,Audio
)
RETURNS varchar(50)
AS
BEGIN
	DECLARE @ttGroup varchar(50)
	
	set @ttGroup=(
	case 
	when (@tt='1-2 χρόνια')							 then '1-2 χρόνια'
	when (@tt='3-5 χρόνια' )						 then '3-5 χρόνια'
	when (@tt='6-9 χρόνια' )						 then '6-9 χρόνια'
	when (@tt='10+ χρόνια' )						 then '10+ χρόνια'
	when (@tt='Είμαι πτυχιούχος κάποιου οργάνου' )   then 'Είμαι πτυχιούχος κάποιου οργάνου'
	
	else
	'other' --problem, δεν παιρνει το είμαι πτυχιούχος
	end)
	
	RETURN  @ttGroup 

END
GO
