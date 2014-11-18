USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Insert_ability_tables]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usp_Insert_ability_tables]
    (@user_id int,@abil int)
as
Begin
insert into Us05_Users_Abilities_Levels 
(Us05_Us01_id,Us05_Sp01_id,Us05_Level,Us05_Level_W)
select 
@user_id,@abil,0,0

insert into Sp03_Tree1_users
(Sp03_Us01_id ,Sp03_Tree1,Sp03_Sp01_id,Sp03_lvl,Sp03_lvl_W)
select
@user_id,1,@abil,0,0
insert into Sp03_Tree1_users
(Sp03_Us01_id ,Sp03_Tree1,Sp03_Sp01_id,Sp03_lvl,Sp03_lvl_W)
select
@user_id,2,@abil,0,0
insert into Sp03_Tree1_users
(Sp03_Us01_id ,Sp03_Tree1,Sp03_Sp01_id,Sp03_lvl,Sp03_lvl_W)
select
@user_id,3,@abil,0,0
insert into Sp03_Tree1_users
(Sp03_Us01_id ,Sp03_Tree1,Sp03_Sp01_id,Sp03_lvl,Sp03_lvl_W)
select
@user_id,4,@abil,0,0

insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,1,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,2,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,3,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,4,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,5,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,6,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,7,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,8,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,9,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,10,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,11,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,12,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,13,0,@abil
insert into Sp05_Tree2_Users
(Sp05_Us01_id,Sp05_Sp04_id,Sp05_Lvl,Sp05_Sp01_id)
select 
@user_id,14,0,@abil

/*insert into US02_UserTests
(US02_US01_Id,US02_QS03_Id,US02_Grade,US02_DateTaken)
select
@user_id,3,1,getdate()

insert into Tr03_Theory_Visits
(Tr03_Us01_Id ,Tr03_Qs02_id,Tr03_Start_Time,Tr03_Finish_Time)
select
@user_id,3,getdate(),getdate()

insert into Tr04_Access_Object
(Tr04_Tr03_Id,Tr04_Tr01_Id,Tr04_Start_Time,Tr04_Finish_Time)
select
(select max (tr03_id) from Tr03_Theory_Visits),@abil,getdate(),getdate() */



end
GO
