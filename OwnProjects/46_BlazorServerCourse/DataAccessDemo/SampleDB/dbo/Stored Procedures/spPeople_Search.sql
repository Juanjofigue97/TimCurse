CREATE PROCEDURE [dbo].[spPeople_Search]
	@SearchTerm nvarchar(50)
AS
begin
	select *
	from dbo.People
	where FirstName like '%'+@SearchTerm+'%'
	   or LastName like '%'+@SearchTerm+'%';
end
