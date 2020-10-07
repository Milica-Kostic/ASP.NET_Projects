CREATE PROCEDURE [dbo].[spRestaurant_GetById]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Id], [RestName], [City], [CategoryId], [RestDescription]
	FROM dbo.[Restaurant]
	WHERE Id = @Id
END