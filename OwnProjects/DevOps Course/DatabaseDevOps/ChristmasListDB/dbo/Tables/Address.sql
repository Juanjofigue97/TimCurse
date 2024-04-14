CREATE TABLE [dbo].[Address] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [StreetAddress] VARCHAR (50) NOT NULL,
    [City]          VARCHAR (50) NOT NULL,
    [State]         VARCHAR (2)  NOT NULL,
    [ZipCode]       VARCHAR (10) NOT NULL,
    [Country]       VARCHAR (50) NOT NULL,
    CONSTRAINT [PK__Address__3214EC07E8A57CFB] PRIMARY KEY CLUSTERED ([Id] ASC)
);



