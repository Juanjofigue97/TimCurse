﻿CREATE PROCEDURE [dbo].[spPeople_ReadOne]
	@Id int
AS
BEGIN
	SELECT [Id], [FirstName], [LastName], [DateOfBirth]
	from dbo.People
	where id = @id
END
