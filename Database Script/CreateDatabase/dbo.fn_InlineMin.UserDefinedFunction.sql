USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_InlineMin]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[fn_InlineMin](@val1 numeric(5,2), @val2 numeric(5,2)) 
--για να μην ξεπερνάει το 10--
returns numeric(5,2)
as
begin
  declare @minval numeric (5,2)
  if @val1 < @val2 
  set @minval =@val1
  else set @minval=@val2
   
  return @minval
end
--select  dbo.fn_InlineMin (10,9)
GO
