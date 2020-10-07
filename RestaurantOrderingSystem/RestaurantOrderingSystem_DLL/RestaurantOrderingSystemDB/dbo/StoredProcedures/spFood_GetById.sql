CREATE PROCEDURE [dbo].[spFood_GetById]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Id], [FoodName], [FoodDescription], [Price], [RestaurantId]
	FROM dbo.[Food]
	WHERE Id = @Id
END
