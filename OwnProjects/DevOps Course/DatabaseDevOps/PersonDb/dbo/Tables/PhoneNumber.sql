CREATE TABLE [dbo].[PhoneNumber]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PhoneNumber] NVARCHAR(50) NOT NULL, 
    [PersonId] INT NULL, 
    [PrumaryNumber] BIT NULL, 
    CONSTRAINT [FK_PhoneNumber_Person] FOREIGN KEY (PersonId) REFERENCES [People](Id)
)
