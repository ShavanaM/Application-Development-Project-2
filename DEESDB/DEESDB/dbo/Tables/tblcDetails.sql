CREATE TABLE [dbo].[tblcDetails]
(
	[RegID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Firstname] NVARCHAR(50) NOT NULL, 
    [Lastname] NVARCHAR(50) NOT NULL, 
    [IDno] NCHAR(13) NOT NULL, 
    [Age] NVARCHAR(50) NOT NULL, 
    [DateofBirth  ] NVARCHAR(50) NOT NULL, 
    [ContactNo] NCHAR(10) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [PostalCode] NCHAR(4) NOT NULL, 
    [EmailAddress] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_tblcDetails_tblLogin] FOREIGN KEY ([EmailAddress]) REFERENCES [tblLogin]([EmailAddress])
)
