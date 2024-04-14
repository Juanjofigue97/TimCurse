CREATE TABLE [dbo].[Purchase] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [ItemName]       VARCHAR (50) NOT NULL,
    [Price]          MONEY        NOT NULL,
    [PurchasedForId] INT          NOT NULL,
    [PurchasedOn] DATETIME2 NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC), 
    CONSTRAINT [FK_Purchase_Person] FOREIGN KEY (PurchasedForId) REFERENCES dbo.Person(Id)
);

