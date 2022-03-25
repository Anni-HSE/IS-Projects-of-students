CREATE TABLE [dbo].[Students]
(
	[IdStudent] INT NOT NULL PRIMARY KEY, 
    [Login] NVARCHAR(20) NOT NULL, 
    [Password] NVARCHAR(20) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [SecondName] NVARCHAR(50) NOT NULL, 
    [FatherName] NVARCHAR(50) NULL, 
    [DataOfBirthday] DATETIME NOT NULL, 
    [DataOfRegistration] DATETIME NOT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Gender] NVARCHAR(8) NOT NULL, 
    [Group] INT NOT NULL
)
