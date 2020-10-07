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

