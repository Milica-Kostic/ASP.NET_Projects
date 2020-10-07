CREATE PROCEDURE [dbo].[SpRestaurant_Insert]
	@RestName nvarchar(50),
	@City nvarchar(50),
	@CategoryId int,
	@RestDescription nvarchar(50),
	@Id int output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Restaurant(RestName, City, CategoryId, RestDescription)
	VALUES (@RestName, @City, @CategoryId, @RestDescription)

	SET @Id = SCOPE_IDENTITY();
END
