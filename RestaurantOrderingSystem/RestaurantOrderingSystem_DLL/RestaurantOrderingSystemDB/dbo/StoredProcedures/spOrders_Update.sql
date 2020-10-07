CREATE PROCEDURE [dbo].[spOrders_Update]
	@OrderName nvarchar(50),
	@FoodId int,
	@Quantity int,
	@Total money,
	@Id int 
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.[Order]
	SET OrderName = @OrderName, FoodId = @FoodId, Quantity = @Quantity, Total = @Total
	WHERE Id = @Id
END