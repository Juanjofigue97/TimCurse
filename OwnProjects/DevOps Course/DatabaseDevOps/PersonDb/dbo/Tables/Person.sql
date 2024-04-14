﻿CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL,
    [LastName] NVARCHAR(50) NOT NULL,
    [DateOfBirth] DATETIME2 NOT NULL, 
    [EmailAddress] NVARCHAR(100) NULL 
)
