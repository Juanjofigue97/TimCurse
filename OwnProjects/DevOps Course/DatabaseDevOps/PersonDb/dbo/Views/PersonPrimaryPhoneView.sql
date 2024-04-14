CREATE VIEW [dbo].[PersonPrimaryPhoneView]
AS 
SELECT [p].[FirstName], [p].[LastName], [p].[DateOfBirth], [p].[EmailAddress], ph.PhoneNumber
FROM dbo.[People] p
left join dbo.PhoneNumber ph 
on p.Id = ph.PersonId and ph.PrumaryNumber = 1
