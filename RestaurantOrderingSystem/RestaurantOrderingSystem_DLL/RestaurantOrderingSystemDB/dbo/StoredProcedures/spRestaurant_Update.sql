CREATE PROCEDURE [dbo].[spRestaurant_Update]
	@RestName nvarchar(50),
	@RestDescription nvarchar(50),
	@City nvarchar(50),
	@Id int 
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE dbo.[Restaurant]
	SET RestName = @RestName, City = @City, RestDescription = @RestDescription
	WHERE Id = @Id
END