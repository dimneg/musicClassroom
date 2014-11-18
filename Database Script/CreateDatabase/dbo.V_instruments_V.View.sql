USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  View [dbo].[V_instruments_V]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[V_instruments_V] as
  select top 100 i.Pl02_In01_id, 
  s.IN01_Name,
  round(sum(p.v1_imagesee+p.v2_noteread+p.v3_songscore)/count(*),2) as V,count(*) as num
  from Pl02_Poll_Instruments i 
  inner join  Pl01_Poll p
  on  i.Pl02_Pl01_timestamp  =p.timestamp 
  inner join dbo.IN01_Instruments s
  on s.IN01_Id=i.Pl02_In01_id
  group by i.Pl02_In01_id,s.IN01_Name
  order by V desc
GO
