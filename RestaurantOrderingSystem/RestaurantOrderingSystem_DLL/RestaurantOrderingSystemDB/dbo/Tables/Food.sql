CREATE TABLE [dbo].[Food]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[FoodName] NVARCHAR(50) NOT NULL, 
	[FoodDescription] NVARCHAR(50) NULL, 
	[Price] MONEY NOT NULL, 
	[RestaurantId] INT NOT NULL
)
