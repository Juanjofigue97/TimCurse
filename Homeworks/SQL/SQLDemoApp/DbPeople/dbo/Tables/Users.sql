﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Login] NVARCHAR(50) NULL, 
    [email] NVARCHAR(50) NULL, 
    [password] NVARCHAR(50) NULL
)
