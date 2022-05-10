CREATE TABLE [dbo].[People]
(
	[ContactID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Company] NVARCHAR(100) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [Telephone] NVARCHAR(100) NULL, 
    [IsCustomer] BIT NULL, 
    [LastCall] DATETIME NULL 
)
