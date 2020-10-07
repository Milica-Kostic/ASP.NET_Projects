CREATE TABLE [dbo].[Restaurant]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[RestName] NVARCHAR(50) NOT NULL, 
	[City] NVARCHAR(50) NOT NULL, 
	[CategoryId] INT NOT NULL, 
	[RestDescription] NVARCHAR(50) NULL 
)
