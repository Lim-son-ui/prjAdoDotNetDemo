USE [dbDemo]
GO

/****** 物件: Table [dbo].[tCustomer] 指令碼日期: 2022/7/15 下午 05:43:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tCustomer] (
    [fid]       INT           IDENTITY (1, 1) NOT NULL,
    [fName]     NVARCHAR (50) NULL,
    [fPhone]    NVARCHAR (50) NULL,
    [fEmail]    NVARCHAR (50) NULL,
    [fAddress]  NVARCHAR (50) NULL,
    [fPassword] NVARCHAR (50) NULL

	primary key ([fName],[fPhone])
);


