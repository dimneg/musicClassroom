USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  View [dbo].[V_agegroup_V]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[V_agegroup_V] as
  select top 100 agegroup, round(sum(v1_imagesee+v2_noteread+v3_songscore)/count(*),2) as V,count(*) as num from  Pl01_Poll
  group by agegroup order by V desc
GO
