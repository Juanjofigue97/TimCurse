CREATE TABLE [dbo].[Person] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50) NOT NULL,
    [LastName]     VARCHAR (50) NOT NULL,
    [BudgetAmount] MONEY        DEFAULT ((0)) NOT NULL,
    [AddressId]    INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

