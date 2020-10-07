CREATE PROCEDURE [dbo].[spFood_Update]
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

