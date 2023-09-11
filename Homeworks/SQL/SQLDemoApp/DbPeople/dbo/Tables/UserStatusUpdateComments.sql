CREATE TABLE [dbo].[UserStatusUpdateComments]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Body] NCHAR(10) NULL, 
    [Date] DATETIME NULL, 
    [UserId] NCHAR(10) NULL, 
    [UserStatusUpdateId] INT NULL
)
