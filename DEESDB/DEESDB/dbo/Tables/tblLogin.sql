CREATE TABLE [dbo].[tblLogin]
(
	[EmailAddress] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Password] NVARCHAR(50) NOT NULL, 
    [ActivationCode] NVARCHAR(50) NOT NULL
)
