CREATE TABLE [dbo].[Address] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [StreetAddress] VARCHAR (50) NOT NULL,
    [City]          VARCHAR (50) NOT NULL,
    [State]         VARCHAR (2)  NOT NULL,
    [ZipCode]       VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

