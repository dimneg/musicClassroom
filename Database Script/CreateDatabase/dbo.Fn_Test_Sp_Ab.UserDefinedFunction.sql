USE [C:\PROJECTS\MUSICCLASSROOM\MUSICCLASSROOM\MUSICCLASSROOMUX\BIN\DEBUG\MUSICPROJECTNEGKAS.MDF]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Test_Sp_Ab]    Script Date: 10/09/2013 21:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Fn_Test_Sp_Ab]
(
  @user_Id int,
  @abil int
  
)
RETURNS numeric(5,2)
AS
BEGIN
	declare @levelSp	 numeric (5,2)
	set @levelSp =  (select		ISNULL(SUM(US02_Grade * QS06_Weight) / COUNT(US02_Grade), 0)
					from		US02_UserTests
					inner join  QS03_Tests
					on			QS03_Id = US02_QS03_Id
					inner join  QS06_TestLevels
					on			QS03_QS06_Id = QS06_id
					where       US02_US01_Id = @user_Id
					and         QS03_Sp01_id =@abil
					)
				return @levelSp
END
GO
