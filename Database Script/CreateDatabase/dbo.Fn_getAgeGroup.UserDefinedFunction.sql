USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_getAgeGroup]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION  [dbo].[Fn_getAgeGroup]
(
@age int
)
returns varchar(50)
as
begin
declare @agegroup varchar(50)
	
	set @agegroup =
	(
	case 
	when       (@age<=17) 		 then '12-17'
	when (@age<=24 and @age>=18) then '18-24'
	when (@age<=30 and @age>=25) then '25-30'
	when (@age<=35 and @age>=31) then '31-35'
	when (@age<=40 and @age>=36) then '36-40'
	when (@age<=45 and @age>=41) then '41-45'
	when (@age<=50 and @age>=46) then '45-50'
	when (@age<=60 and @age>=51) then '51-60'
	when (@age<=70 and @age>=61) then '61-70'
	when      (@age>70)          then '71+'
	
	else
	'other'
	end)
	
 return @agegroup 
end
--select [dbo].[Fn_getAgeGroup] (47)
GO
