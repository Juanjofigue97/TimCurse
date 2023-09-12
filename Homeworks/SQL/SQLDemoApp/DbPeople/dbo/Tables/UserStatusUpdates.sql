CREATE TABLE [dbo].[UserStatusUpdates]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Body] NCHAR(10) NULL, 
    [date] DATETIME NULL, 
    [UserId] INT NULL
)
