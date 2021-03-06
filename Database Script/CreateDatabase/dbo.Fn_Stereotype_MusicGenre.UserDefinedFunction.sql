USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Stereotype_MusicGenre]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_Stereotype_MusicGenre]
(
	@MusicGenre int,
	@Abil int
)
RETURNS numeric (5,2)
AS
BEGIN
	
	DECLARE @MusicGenre_Factor numeric(5,2)

	set @MusicGenre_Factor  =
	(
	 case @Abil  
		when 1 then
		(
	 	 select V / 30
		 from V_music_genres_V
		 where @MusicGenre  = ltrim(rtrim([Pl04_Pl03_id]))
		 
		 )
		when 2 then
		(
	 	 select A / 30
		 from V_music_genres_A
		 where @MusicGenre = ltrim(rtrim([Pl04_Pl03_id]))
		 
		 )
    end
    )
    return @MusicGenre_Factor 
END
--select [dbo].[Fn_Stereotype_MusicGenre] (2,1)
GO
