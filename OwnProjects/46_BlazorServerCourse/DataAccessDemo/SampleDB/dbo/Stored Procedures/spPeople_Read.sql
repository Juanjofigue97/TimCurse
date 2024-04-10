CREATE PROCEDURE [dbo].[spPeople_Read]
AS
BEGIN
	SELECT [Id], [FirstName], [LastName], [DateOfBirth]
	from dbo.People
END
