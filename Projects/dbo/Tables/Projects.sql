CREATE TABLE [dbo].[Projects]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL, 
    [ProjectSize] NVARCHAR(50) NOT NULL,

)
