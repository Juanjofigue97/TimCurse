CREATE PROCEDURE [dbo].[spPeople_Delete]
	@Id int
AS
BEGIN
	set nocount on;

	delete from dbo.People
	where Id = @Id

END
