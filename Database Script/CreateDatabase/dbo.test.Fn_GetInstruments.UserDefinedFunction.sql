USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[test.Fn_GetInstruments]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[test.Fn_GetInstruments]
(	
	@Us01_id int,
	@In01_id int
)
RETURNS TABLE 
AS

RETURN 
(
	select  US03_IN01_id from Us03_Users_Instruments
	where @Us01_id=Us03_US01_id
)
GO
