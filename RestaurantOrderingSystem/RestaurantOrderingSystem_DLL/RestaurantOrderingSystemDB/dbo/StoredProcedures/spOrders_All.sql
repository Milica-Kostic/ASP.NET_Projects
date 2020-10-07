CREATE PROCEDURE [dbo].[spOrders_All]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Id], [OrderName], [OrderDate], [FoodId], [Quantity], [Total]
	FROM dbo.[Order];
END
