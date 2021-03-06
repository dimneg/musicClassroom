USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Calculate_Level_Sp_Ab]    Script Date: 10/09/2013 21:47:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Usp_Calculate_Level_Sp_Ab]
	(@user_id int,@abil int)
AS
BEGIN

	
	SET NOCOUNT ON;
	declare @levelFinal numeric (5,2)
	---vathmos test--  trigger sta user_tests
	declare @levelTest numeric (5,2)
	set  @levelTest = dbo.Fn_Test_Sp_Ab(@user_id,@abil) 
	
	
	update Sp05_Tree2_Users  --level2--
	set Sp05_Lvl=@levelTest 
	where Sp05_Us01_id=@user_id
	and Sp05_Sp01_id=@abil 
	and Sp05_Sp04_id=11
				
	exec [dbo].[Usp_Update_Level1] @user_id,4,@abil --level 1 (4)
	exec [dbo].Usp_Update_Level1_W 4,@user_id,@abil    --level1 weighted--
	
	
	--print @levelTest
	--vathmos test--
	
	
	--vathmos reading--- --trigger sto uservisits
	declare @levelReadingTotal numeric (5,2)
	declare @levelReadingVisits numeric (5,2)
	declare @levelReadingTime numeric (5,2)
	declare @levelReadingPerVisit numeric (5,2)
	declare @timePerVisit numeric (5,2)
								--visits---
								declare @maxVisits numeric (5,2)
	
								SELECT [Tr03_Us01_Id] ,COUNT([Tr03_Id]) AS VISITS
								INTO #VISITS
								FROM [Tr03_Theory_Visits]
								GROUP BY   [Tr03_Us01_Id]
								
								set @maxVisits=(SELECT MAX(VISITS) FROM #VISITS)
	
	
								
								set @levelReadingVisits= dbo.Fn_Theory_Visits_Count (@user_id,0) 
																		/
														@maxVisits
														
								update Sp05_Tree2_Users
								set Sp05_Lvl=
							   (case @abil
							    when 1 then
								dbo.fn_inlineMin(@levelReadingVisits * 10 *
								(
							     select  Set01_Value
							     from   Set01_Settings
							     where Set01_Setting='Usp_A_V_1_F'
							     ),10)
								when 2  then
								@levelReadingVisits * 10
								end)
								where Sp05_Us01_id=@user_id
								and Sp05_Sp01_id=@abil
								and Sp05_Sp04_id=8
								
								
								--visits--	
													
								--time per visit--	
								declare @maxTimePerVisit numeric (5,2)
								
								SELECT 	[Tr03_Us01_Id] AS USER_ID,SUM(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time )	) AS DUR, count(*)  AS NUM,
								SUM(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time )	)/  count(*) AS TperV
								into #TimePerVisit
								FROM
								Tr03_Theory_Visits GROUP BY [Tr03_Us01_Id]
														
								SET @maxTimePerVisit= (select max(TperV) from #TimePerVisit)				
			
								set  @levelReadingPerVisit=
							    (dbo.fn_Theory_Time_Count (@user_id,0) 
										/
							    dbo.Fn_Theory_Visits_Count (@user_id,0))
							           /  
							    @maxTimePerVisit
							    
							    
							    
							    update Sp05_Tree2_Users
							    set Sp05_Lvl=
							    (case @abil
							    when 1 then
							    dbo.fn_inlinemin(@levelReadingPerVisit * 10* 
							    (
							     select  Set01_Value
							     from   Set01_Settings
							     where Set01_Setting='Usp_A_V_1_F'
							     ),10)
							    when 2 then 
							    @levelReadingPerVisit * 10
							    end)
							    where Sp05_Us01_id=@user_id
							    and Sp05_Sp01_id=@abil
							    and Sp05_Sp04_id=13
							    
							    

							    
							    
							    
							    --time per visit--
							    
							    --visit total time--
							    							    
							    SELECT 	[Tr03_Us01_Id] AS USER_ID,SUM(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time )	) AS DUR
							    into #VisitTime 
								FROM
								Tr03_Theory_Visits GROUP BY [Tr03_Us01_Id]
								
							    declare @maxVisitTime numeric (5,2)
							    
							    set @maxVisitTime=(select max(dur) from #VisitTime )
							    
							    set	@levelReadingTime=
							    (dbo.fn_Theory_Time_Count (@user_id,0) )
							                  /
							              @maxVisitTime
							              
							              
							    update Sp05_Tree2_Users
							    set Sp05_Lvl=
							    (case @abil
							    when 1 then
							    dbo.fn_inlineMin(@levelReadingTime * 10 *
							    (
							     select  Set01_Value
							     from   Set01_Settings
							     where Set01_Setting='Usp_A_V_1_F'
							     ),10)
							     else
							    @levelReadingTime * 10
							    end)   
							    where Sp05_Us01_id=@user_id
							    and Sp05_Sp01_id=@abil
							    and Sp05_Sp04_id=12
							    
							    
							    --visit total time--
	                        
	/*set @levelReadingTotal =
	     (
	     @levelReadingVisits *10
	    +@levelReadingTime *10
	    +@levelReadingPerVisit *10
	     )
	    / 
	    (
	    select count (*) from Sp04_Tree2_L2
	    where Sp04_Sp02_id=2
	    ) */
	    
	   exec [dbo].[Usp_Update_Level1] @user_id,2,@abil --level 1 (2)
	   exec [dbo].Usp_Update_Level1_W 2,@user_id,@abil --level 1 weighted
	   
	--vathmos reading--
	
	--vathmos access objects  trigger στο Tr04_Access_Object
	declare @levelAccessObjects numeric (5,2)
	declare @levelTimeAccess numeric (5,2)
	declare @levelCounterAccess numeric (5,2)
						
						--object counter--
						declare @maxAccessObjects numeric (5,2)
						
						select tr03_us01_id as user_id, count(tr04_id) as num
						into #maxAccessCounter
						from Tr04_Access_Object Tr04
						inner join Tr03_Theory_Visits Tr03
						on Tr03.Tr03_id=TR04.Tr04_Tr03_id
						where Tr04_Tr01_Id=@abil
						group by tr03_us01_id
						
						set @maxAccessObjects =(select max(num) from #maxAccessCounter)
						
						set	@levelCounterAccess=
							    (dbo.Fn_Access_Object_Count (@user_id,@abil) )
							                  /
							              @maxAccessObjects
							              
							              
						 update Sp05_Tree2_Users
						 set Sp05_Lvl=@levelCounterAccess * 10  --leipei parametros kai ermhneia
						 where Sp05_Us01_id=@user_id
						 and Sp05_Sp01_id=@abil
						 and Sp05_Sp04_id=10
						 
						--object counter--
						
						--time counter--
						declare @maxAccessObjectsTime numeric (5,2)
						
						select tr03_us01_id as user_id, 
						SUM(DATEDIFF(SECOND, tr04_start_time,Tr04_Finish_Time )	) AS DUR
						into #maxAccessObjectsTime
						from Tr04_Access_Object Tr04
						inner join Tr03_Theory_Visits Tr03
						on Tr03.Tr03_id=TR04.Tr04_Tr03_id
						where Tr04_Tr01_Id=@abil
						group by tr03_us01_id
						
						set @maxAccessObjectsTime =(select max(dur) from #maxAccessObjectsTime)
						
						set @levelTimeAccess = (dbo.Fn_Access_Object_Time_Count(@user_id,@abil) )
							                  /
							              @maxAccessObjectsTime
							              
						
						update Sp05_Tree2_Users
						set Sp05_Lvl=@levelTimeAccess * 10  --leipei parametros kai ermhneia
						where Sp05_Us01_id=@user_id
						and Sp05_Sp01_id=@abil
						and Sp05_Sp04_id=9
						
						
						--time counter--
						--view image per theorytime
						declare @levelAccessTimePerVisitTime numeric (5,2)
						--declare @maxAccessTimePerVisitTime numeric (5,2)
						
						/*select tr03_us01_id as user_id, Tr04_Tr01_Id,
						cast(SUM(DATEDIFF(SECOND, tr04_start_time,Tr04_Finish_Time )	)*1.00 as numeric(5,2)) AS DurObj,
						cast (sum(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time ))*1.00 as numeric(5,2)) as DurTh,
						cast(SUM(DATEDIFF(SECOND, tr04_start_time,Tr04_Finish_Time )*1.00	)
						                     /
						sum(DATEDIFF(SECOND, tr03_start_time,tr03_finish_time ))*1.00 as numeric(5,2)) as AccPerVisit
						into #maxAcessTimePerVisitTime 
						
						from Tr04_Access_Object Tr04
						right join Tr03_Theory_Visits Tr03
						on Tr03.Tr03_id=TR04.Tr04_Tr03_id
						group by tr03_us01_id,Tr04_Tr01_Id 
						
						set @maxAccessTimePerVisitTime =(select max (AccPerVisit) from #maxAcessTimePerVisitTime
													    where Tr04_Tr01_Id=@abil		) */
													    
						                         
						--print @maxAccessTimePerVisitTime
						set @levelAccessTimePerVisitTime=[dbo].[Fn_Access_Object_Time_Count](@user_id,@abil)
																					/
															([dbo].[fn_Theory_Time_Count] (@user_id,0)
																					*
															(select Set01_Value from Set01_Settings
															 where Set01_Setting='Usp_A_V_2_F')  )
															 
						        
						--print @levelAccessTimePerVisitTime 
						
						update Sp05_Tree2_Users
						set Sp05_Lvl=dbo.fn_inlineMin(@levelAccessTimePerVisitTime * 10,10)  --leipei parametros kai ermhneia
						where Sp05_Us01_id=@user_id
						and Sp05_Sp01_id=@abil
						and Sp05_Sp04_id=14
						
						--hear sound per theory time
	/*set @levelAccessObjects =
	 (
	 @levelTimeAccess *10
	+@levelCounterAccess *10
	 )
				 /
	(
	select count (*) from Sp04_Tree2_L2
	where Sp04_Sp02_id=3
	) */
	exec [dbo].[Usp_Update_Level1] @user_id,3,@abil --level 1 (3)
	exec [dbo].Usp_Update_Level1_W 3,@user_id,@abil --level 1 weighted
	
	
	
	--vathmos access objects
	
	
	--vathmos stereotype--
	declare @levelStereotype  numeric (5,2)
	                  --age-- trigger sto users
	                  declare @levelAge numeric (5,2)
	                  declare @age int
	                  set @age= (
	                             select US01_Age from US01_Users
	                             where  US01_Id=@user_id 
	                             )
	                             
	                  
	                  set @levelAge=dbo.Fn_Stereotype_Age (@age,@abil)
	                  
							update Sp05_Tree2_Users
							set Sp05_Lvl=@levelAge *10
							where Sp05_Us01_id=@user_id
							and Sp05_Sp01_id=@abil 
							and Sp05_Sp04_id=4    
							                                      
	                  
	                  
	                  --age
	                  
	                  --education type trigger sto users
	                  declare @levelEducationType numeric (5,2)
	                  declare @edu_type int
	                  set @edu_type=(
								     select Us01_EducationType_Us05_id
								     from  US01_Users
								     where  US01_Id=@user_id 
								     )
								     
	                  
	                  set @levelEducationType=dbo.Fn_Stereotype_Edu_type (@edu_type,@abil)
	                  
							update Sp05_Tree2_Users
							set Sp05_Lvl=@levelEducationType *10
							where Sp05_Us01_id=@user_id
							and Sp05_Sp01_id=@abil 
							and Sp05_Sp04_id=2
							
	                  
	                  --education type
	                  
	                  
	                  --gender--
	                  declare @levelGender numeric (5,2)
	                  declare @gender bit
	                  
	                  set @gender=(
								   Select US01_Gender
								   from  US01_Users
								   where  US01_Id=@user_id 
								   )
								   
					  set @levelGender=dbo.Fn_Stereotype_Gender (@gender,@abil)
					  
							update Sp05_Tree2_Users
							set Sp05_Lvl=@levelGender *10
							where Sp05_Us01_id=@user_id
							and Sp05_Sp01_id=@abil 
							and Sp05_Sp04_id=1
							
	                  
	                  --gender--
	                  --instrument  --trigger user_instruments
	                   declare @levelInstrument numeric (5,2)
	                   declare @counterInstrument int
	                   declare @In01_id int
	                   
	                   set @levelInstrument=0
	                   set @counterInstrument=0
	                   
	                   
	                   declare instrumentsCursor cursor global for
	                   select distinct (US03_IN01_id)
					   FROM    Us03_Users_Instruments
					   where  Us03_US01_id=@user_id
					   
					   
					   open instrumentsCursor
					   
					   fetch next from instrumentsCursor into @In01_id
	                   
	                        WHILE @@FETCH_STATUS = 0
							BEGIN
								--print @levelInstrument
								set @levelInstrument= @levelInstrument + dbo.Fn_Stereotype_Instrument (@In01_id,@Abil)
								set @counterInstrument= @counterInstrument+1
								
								--print @levelInstrument
								
								FETCH NEXT FROM instrumentsCursor  into @In01_id
							end;
					   CLOSE instrumentsCursor
					   DEALLOCATE instrumentsCursor
					   if @counterInstrument>0
					   begin
					   
					   set @levelInstrument=@levelInstrument / @counterInstrument
					   
						    update Sp05_Tree2_Users
							set Sp05_Lvl=@levelInstrument *10
							where Sp05_Us01_id=@user_id
							and Sp05_Sp01_id=@abil 
							and Sp05_Sp04_id=6 
							
					   end
					   else
					   set @levelInstrument=0
							
							

	                   
	                   --instrument
	                   
	                   
	                   --music genre  -trigger sto Us06_User_Music_Genres
	                   declare @levelMusicGenre numeric (5,2)
	                   declare @MusicGenre int   --παει σε πολλά προς πολλά
	                   declare @counterGenre int
	                   
	                   set @levelMusicGenre =0
	                   set @counterGenre=0
	                   
	                   declare musicGenresCursor cursor global for
	                   select distinct (Us06_Pl03_id)
					   FROM    Us06_User_Music_Genres
					   where   Us06_Us01_id=@user_id
					   
					   
					   open musicGenresCursor
					   
					   fetch next from musicGenresCursor into @MusicGenre
					   
					    WHILE @@FETCH_STATUS = 0
							BEGIN
								--print @levelMusicGenre
								set @levelMusicGenre= @levelMusicGenre + dbo.Fn_Stereotype_MusicGenre (@MusicGenre,@Abil) 
								set @counterGenre= @counterGenre+1
								
								--print @levelMusicGenre
								
								FETCH NEXT FROM musicGenresCursor  into @MusicGenre
							end;
					   CLOSE musicGenresCursor
					   DEALLOCATE musicGenresCursor
					   if @counterGenre>0
					   begin
					   
					   set @levelMusicGenre=@levelMusicGenre / @counterGenre
					   
					   update Sp05_Tree2_Users
					   set Sp05_Lvl=@levelMusicGenre *10
					   where Sp05_Us01_id=@user_id
					   and Sp05_Sp01_id=@abil 
					   and Sp05_Sp04_id=7
					   end
					   else
					   set @levelMusicGenre=0
	                   
	                  
	                   --music genre
	                   
	                   --total training
	                   declare @levelTotalTraining numeric (5,2)
	                   declare @TotalTraining varchar (50)
	                   
	                   set @TotalTraining = (
											select Us01_TotalTraining from US01_Users
											where  US01_Id=@user_id 	
											)
												
	                   set @levelTotalTraining = dbo.Fn_Stereotype_TotalTraining (@TotalTraining,@Abil)
	                   
					   update Sp05_Tree2_Users
					   set Sp05_Lvl=@levelTotalTraining * 10
					   where Sp05_Us01_id=@user_id
					   and Sp05_Sp01_id=@abil 
					   and Sp05_Sp04_id=3
					   
	                  	
	                   	                   
	                   --total training
	                   
	                   --total music years
	                   declare @levelTotalMusicYears numeric (5,2)
	                   declare @tmy int
					   set @tmy= (
	                             select Us01_TotalMusicYears from US01_Users
	                             where  US01_Id=@user_id 
	                             )
	                  
	                  set @levelTotalMusicYears=dbo.Fn_Stereotype_TotalMusicYears(@tmy,@abil) 
	               
					  update Sp05_Tree2_Users
					  set Sp05_Lvl=@levelTotalMusicYears * 10
					  where Sp05_Us01_id=@user_id
					  and Sp05_Sp01_id=@abil 
					  and Sp05_Sp04_id=5
					  
	                   --total music years
	                  
	                  
	
/*	set @levelStereotype= isnull(@levelAge*10,0)
	                    + isnull(@levelEducationType*10,0)
	                    + isnull(@levelGender*10,0)
	                    + isnull(@levelInstrument*10,0)
	                    + isnull(@levelMusicGenre*10,0)
	                    + isnull(@levelTotalTraining*10,0)
	                    + isnull(@levelTotalMusicYears*10,0)
	                                 /
	                    ( 
	                     select count (*) from Sp04_Tree2_L2
						 where Sp04_Sp02_id=1
						 )*/
						 
	exec [dbo].[Usp_Update_Level1] @user_id,1,@abil --level 1 (1)
	exec [dbo].Usp_Update_Level1_W 1,@user_id,@abil --level 1 weighted
	--vathmos stereotype--
	
	
	
	
	
	/*set @levelFinal = 	isnull(@levelTest,0)	-- syn tous syntelestes
	                +   isnull(@levelStereotype,0)	
	                +   isnull(@levelReadingTotal,0) 	
	                +   isnull(@levelAccessObjects,0)
	                            /
	                (
	                 select count (*)  from Sp02_Tree_L1
	                )        */  
	                	
	
								
--update η insert αν ο χρήστης έχει εγγραφή ή όχι								
/*if 
		isnull(select * from  Us05_Users_Abilities_Levels
	     where Us05_Us01_id=@user_id )
then 
		insert into  Us05_Users_Abilities_Levels (Us05_Us01_id,
		select 
		
else */ 

/*update Us05_Users_Abilities_Levels
set Us05_level=@levelFinal
where Us05_Us01_id=@user_id
and @abil=Us05_Sp01_id */
exec [dbo].[Usp_Update_user_Abilities] @user_id,@abil
exec [dbo].[Usp_Update_User_abilities_W] @user_id,@abil

    
END
--exec [dbo].[Usp_Calculate_Level_Sp_Ab] -1,1
--exec [dbo].[Usp_Calculate_Level_Sp_Ab] -1,2
/*select dbo.Fn_Stereotype_Instrument (4,1)
select dbo.Fn_Stereotype_Instrument (4,2) 
SELECT     TOP (200) Sp05_id, Sp05_Us01_id, Sp05_Sp04_id, Sp05_Lvl, Sp05_Sp01_id
FROM         Sp05_Tree2_Users
WHERE     (Sp05_Sp04_id = 6)*/

--exec [dbo].[Usp_Calculate_Level_Sp_Ab] 3,2
--exec [dbo].[Usp_Calculate_Level_Sp_Ab] 6,2
/*
select dbo.Fn_Stereotype_Instrument (5,2) 
select dbo.Fn_Stereotype_Instrument (4,2)
select dbo.Fn_Stereotype_Instrument (4,1)
select dbo.Fn_Stereotype_Instrument (5,1)
SELECT     TOP (200) Sp05_id, Sp05_Us01_id, Sp05_Sp04_id, Sp05_Lvl, Sp05_Sp01_id
FROM         Sp05_Tree2_Users
WHERE     (Sp05_Sp04_id = 6)*/
GO
