CREATE PROCEDURE [dbo].[spFood_All]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Id], [FoodName], [FoodDescription], [Price], [RestaurantId]
	FROM dbo.[Food];
END
