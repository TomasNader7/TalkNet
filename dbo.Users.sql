CREATE TABLE [dbo].[Users] (
    [Id]           INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    [email]     NVARCHAR (MAX) NULL,
	[username] VARCHAR(MAX) NULL,
    [password] NVARCHAR (MAX) NULL,
	[date_created] DATE NULL
);
