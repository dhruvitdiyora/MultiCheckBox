USE [ListBox]
GO
/****** Object:  Table [dbo].[ListBoxData]    Script Date: 04-04-2024 02:20:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'ListBox')
  BEGIN
    CREATE DATABASE ListBox
    
    USE ListBox
    
    CREATE TABLE [dbo].[ListBoxData](
	[ListBoxData_Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](50) NULL
) ON [PRIMARY]


  END

INSERT INTO ListBoxData
	VALUES ('itemA'), ('itemB'), ('itemC'), ('itemD')

GO