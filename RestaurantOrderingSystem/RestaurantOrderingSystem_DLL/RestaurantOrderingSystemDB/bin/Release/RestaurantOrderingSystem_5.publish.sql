﻿/*
Deployment script for RestaurantOrderingSystemDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "RestaurantOrderingSystemDB"
:setvar DefaultFilePrefix "RestaurantOrderingSystemDB"
:setvar DefaultDataPath "C:\Users\Milica\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\Milica\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'The following operation was generated from a refactoring log file a0af6c68-6bf8-40ad-9f8f-10318f203f4e';

PRINT N'Rename [dbo].[Food].[Description] to FoodDescription';


GO
EXECUTE sp_rename @objname = N'[dbo].[Food].[Description]', @newname = N'FoodDescription', @objtype = N'COLUMN';


GO
PRINT N'Altering [dbo].[spFood_All]...';


GO
ALTER PROCEDURE [dbo].[spFood_All]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Id], [FoodName], [FoodDescription], [Price], [RestaurantId]
	FROM dbo.[Food];
END
GO
PRINT N'Altering [dbo].[spFood_GetById]...';


GO
ALTER PROCEDURE [dbo].[spFood_GetById]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Id], [FoodName], [FoodDescription], [Price], [RestaurantId]
	FROM dbo.[Food]
	WHERE Id = @Id
END
GO
PRINT N'Altering [dbo].[spFood_Insert]...';


GO
ALTER PROCEDURE [dbo].[spFood_Insert]
	@FoodName nvarchar(50),
	@FoodDescription nvarchar(50),
	@Price money,
	@RestaurantId int, 
	@Id int output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.[Food](FoodName, FoodDescription, Price, RestaurantId)
	VALUES(@FoodName, @FoodDescription, @Price, @RestaurantId)

	SET @Id = SCOPE_IDENTITY();
END
GO
PRINT N'Altering [dbo].[spFood_Update]...';


GO
ALTER PROCEDURE [dbo].[spFood_Update]
	@FoodName nvarchar(50),
	@FoodDescription nvarchar(50),
	@Price money,
	@Id int 
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.[Food]
	SET FoodName = @FoodName, FoodDescription = @FoodDescription, Price = @Price
	WHERE Id = @Id
END
GO
-- Refactoring step to update target server with deployed transaction logs
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'a0af6c68-6bf8-40ad-9f8f-10318f203f4e')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('a0af6c68-6bf8-40ad-9f8f-10318f203f4e')

GO

GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists(select * from dbo.Category)
begin
    insert into dbo.Category(CategoryName)
    values('Serbian Food'),('Italian Food'),('Japanese Food'),('Turkish Food'),('Mexican Food'),('French Food'), ('American Food'), ('Chinese Food'), ('Drinks'), ('International Food'), ('Vegan Food');
end

GO

GO
PRINT N'Update complete.';


GO
