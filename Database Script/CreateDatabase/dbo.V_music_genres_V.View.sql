USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  View [dbo].[V_music_genres_V]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[V_music_genres_V] as
  select top 100 gu.Pl04_Pl03_id, 
  g.Pl03_genre,
  round(sum(p.v1_imagesee+p.v2_noteread+p.v3_songscore)/count(*),2) as V,count(*) as num
  from Pl04_Poll_User_M_Genres gu 
  inner join  Pl01_Poll p
  on  gu.Pl04_Pl01_timestamp  =p.timestamp 
  inner join Pl03_Poll_MusicGenres g
  on gu.Pl04_Pl03_id=g.Pl03_id
  group by gu.Pl04_Pl03_id,g.Pl03_genre
  order by V desc
GO
