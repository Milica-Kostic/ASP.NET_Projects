CREATE PROCEDURE [dbo].[spRestaurant_All]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Id], [RestName], [City], [CategoryId], [RestDescription]
	FROM dbo.[Restaurant];
END