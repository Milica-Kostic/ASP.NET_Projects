CREATE PROCEDURE [dbo].[spRestaurant_Delete]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE
	FROM dbo.[Restaurant]
	WHERE Id = @Id
END