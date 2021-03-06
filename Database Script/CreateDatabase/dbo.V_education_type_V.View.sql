USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  View [dbo].[V_education_type_V]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[V_education_type_V] as
  select distinct   Education_type, round(sum (V1_ImageSee + V2_NoteRead + V3_SongScore)/count(*),2) as V,count(*) as num from  Pl01_Poll
  where education_type in (select [Us05_Education_type] from Us05_User_Education_Type)
  group by Education_type-- order by A desc
  union all
  /*select   Education_type , round(sum (A1_SoundHear+A2_SongPlay+A3_Dicte)/count(*),2) as A,count(*) as num from  Pl01_Poll
  where education_type  not in (select [Us05_Education_type] from Us05_User_Education_Type)
  group by Education_type --order by A desc
  union all */
  select distinct 'Περιορισμένη'  , round(sum (V1_ImageSee + V2_NoteRead + V3_SongScore)/count(*),2) as V,count(*) as num from  Pl01_Poll
  where education_type  not in (select [Us05_Education_type] from Us05_User_Education_Type)
  and education_type in
  ('DIY','αυτοδίδακτος','Αυτοδίδακτος / Προσαρμοσμένη στις "ανάγκες" μου ως μουσικός/ερμηνευτής','ΑΥΤΟΔΙΔΑΚΤΟΣ+ΚΑΠΟΙΑ ΜΑΘΗΜΑΤΑ',
  'Δεν έχω εκπαιδευτεί','Δεν έχω λάβει εκπαίδευση','καθολου','Καμμία εκπαίδευση','Λίγη θεωρία')
  union all
  select distinct 'Συνδυασμός Κλασσικής με άλλο'  , round(sum (V1_ImageSee + V2_NoteRead + V3_SongScore)/count(*),2) as V,count(*) as num from  Pl01_Poll
  where education_type  not in (select [Us05_Education_type] from Us05_User_Education_Type)
  and education_type in
  ('βυζαντινη και κλασσικη','Classic and Modern','κυρίως κλασσική αλλα και Jazz','Κλασσική αλλα έχω διδακτορικό στην κλασσική σύνθεση...',
  'kai t duo')
  Union all
  select distinct 'Άλλη'  , round(sum (V1_ImageSee + V2_NoteRead + V3_SongScore)/count(*),2) as V,count(*) as num from  Pl01_Poll
  where education_type  not in (select [Us05_Education_type] from Us05_User_Education_Type)
  and education_type in
  ('Έντεχνη, Blues','Παραδοσιακή','Alternative rock','ελεύθερη')
GO
