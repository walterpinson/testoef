-- =========================================
-- Create table template Windows Azure SQL Database 
-- =========================================

IF OBJECT_ID('dbo.Registration', 'U') IS NOT NULL
  DROP TABLE dbo.Registration
GO

CREATE TABLE dbo.Registration
(
	Id uniqueidentifier NOT NULL default newid(), 
	RespondedOn datetime2(7) NOT NULL, 
	FirstName nvarchar(50) NOT NULL, 
	LastName nvarchar(50) NOT NULL, 
	Message nvarchar(250) NULL, 
    CONSTRAINT PK_Registration PRIMARY KEY (Id)
)
GO
