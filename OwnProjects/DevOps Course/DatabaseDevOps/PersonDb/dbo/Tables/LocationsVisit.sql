CREATE TABLE [dbo].[LocationsVisit]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [LocationId] INT NOT NULL, 
    [VisitDate] DATETIME2 NOT NULL, 
    CONSTRAINT [FK_LocationVisit_Person] FOREIGN KEY (PersonId) REFERENCES [People](Id),
    CONSTRAINT [FK_LocationVisit_Location] FOREIGN KEY (LocationId) REFERENCES [Locations](Id)
)
