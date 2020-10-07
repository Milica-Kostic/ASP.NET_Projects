CREATE PROCEDURE [dbo].[spCategory_All]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Id], [CategoryName]
	FROM dbo.[Category];
END