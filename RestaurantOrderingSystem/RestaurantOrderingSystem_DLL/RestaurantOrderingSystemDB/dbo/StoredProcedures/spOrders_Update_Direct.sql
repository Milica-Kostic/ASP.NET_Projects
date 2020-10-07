CREATE PROCEDURE [dbo].[spOrders_Update_Direct]
	@OrderName nvarchar(50),
	@Quantity int,
	@Total money,
	@Id int 
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.[Order]
	SET OrderName = @OrderName, Quantity = @Quantity, Total = @Total
	WHERE Id = @Id
END