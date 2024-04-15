CREATE PROCEDURE [dbo].[spLocation_PeopleVisited]
	@LocationId int
AS
begin

	set nocount on;

	select [p].[FirstName], [p].[LastName], [p].[EmailAddress]
	from dbo.[Location] l
	inner join dbo.LocationVisit v on l.Id = v.LocationId
	inner join dbo.Person p on p.Id = v.PersonId
	where l.Id = @LocationId;

end
