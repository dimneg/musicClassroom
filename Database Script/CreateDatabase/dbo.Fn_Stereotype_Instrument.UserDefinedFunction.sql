USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Stereotype_Instrument]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_Stereotype_Instrument]
(
	@In01_id int,
	@Abil int
)
RETURNS numeric (5,2)
AS
BEGIN
	
	DECLARE @Instrument_Factor numeric(5,2)

	set @Instrument_Factor =
	(
	 case @Abil  
		when 1 then
		(
	 	 select V / 30
		 from V_instruments_V 
		 where   ltrim(rtrim([Pl02_In01_id]))=@In01_id
		 
		 )
		when 2 then
		(
	 	 select A / 30
		 from V_instruments_A 
		 where  ltrim(rtrim([Pl02_In01_id]))=@In01_id 
		
		 )
    end
    )
    return @Instrument_Factor 
END

/*select V / 30
		 from V_instruments_V 
		 where   ltrim(rtrim([Pl02_In01_id]))=3
		  */
GO
