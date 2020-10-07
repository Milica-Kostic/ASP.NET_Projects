CREATE PROCEDURE [dbo].[spFood_Delete]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE
	FROM dbo.[Food]
	WHERE Id = @Id
END
