CREATE TABLE [dbo].[tblBookL]
(
	[BookIDL] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Code] NVARCHAR(50) NOT NULL, 
    [Duration] NVARCHAR(50) NOT NULL, 
    [DayofWeek] NVARCHAR(50) NOT NULL, 
    [Instructor] NVARCHAR(50) NOT NULL, 
    [Time] NVARCHAR(50) NOT NULL, 
    [RegID] INT NOT NULL, 
    CONSTRAINT [FK_tblBookL_tblcDetails] FOREIGN KEY ([RegID]) REFERENCES [tblcdetails]([RegID])
)
