USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  View [dbo].[V_totalmusicyears_A]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[V_totalmusicyears_A] as
  select top 100 totalmusicyears, round(sum (A1_SoundHear+A2_SongPlay+A3_Dicte)/count(*),2) as A,count(*) as num  from  Pl01_Poll
  group by totalmusicyears order by A desc
GO
