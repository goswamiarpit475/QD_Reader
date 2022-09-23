USE [testDb]
GO
/****** Object:  StoredProcedure [dbo].[sp_saveDataToParcelReceiving]    Script Date: 9/22/2022 9:28:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_saveDataToParcelReceiving]   
    @awb nvarchar(50),   
    @courier nvarchar(50),
	@job nvarchar(50),
	@store nvarchar(50),   
	@note nvarchar(50),
	@lastUpdatedUser nvarchar(50)
AS   

    SET NOCOUNT ON;  
	insert into  [dbo].[ParcelReceiving](AirWayBill,Courier,StoreNumber,JobNumber,Notes,LastUpdatedUser)
	values(@awb,@courier,@store,@job,@note,@lastUpdatedUser);
