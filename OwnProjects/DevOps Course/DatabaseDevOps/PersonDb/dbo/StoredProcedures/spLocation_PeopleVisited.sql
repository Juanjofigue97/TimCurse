CREATE PROCEDURE [dbo].[spLocation_PeopleVisited]
	@LocationId int
AS
begin
	set nocount on;

	select [p].[FirstName], [p].[LastName], [p].[EmailAddress]
	from dbo.[Locations] l
	inner join dbo.[LocationsVisit] v on l.Id = v.LocationId
	inner join dbo.[People] p on p.Id = v.PersonId
	where l.Id = @LocationId
end