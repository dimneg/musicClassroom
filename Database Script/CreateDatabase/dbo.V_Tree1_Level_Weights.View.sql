USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  View [dbo].[V_Tree1_Level_Weights]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_Tree1_Level_Weights]
as
select sp03_tree1,sp03_sp01_id,sp03_lvl,sp02_weight,Sp03_Us01_id
from
dbo.Sp03_Tree1_users sp03 inner join Sp02_Tree_L1 sp02
on sp03.Sp03_Tree1=sp02.sp02_id
GO
