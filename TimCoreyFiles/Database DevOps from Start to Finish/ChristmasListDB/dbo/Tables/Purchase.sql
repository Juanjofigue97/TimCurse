CREATE TABLE [dbo].[Purchase] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [ItemName]       VARCHAR (50) NOT NULL,
    [Price]          MONEY        NOT NULL,
    [PurchasedForId] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

