CREATE PROCEDURE [dbo].[spFood_Insert]
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
