
create table [Achievement]
(
Id INT PRIMARY KEY IDENTITY,
[Name] nvarchar(50)NOT NULL ,
[Text] nvarchar(200)NOT NULL ,
[Points] int NOT NULL
)

INSERT INTO [Achievement] ([Name],[Text],[Points])
VALUES('Welcome to the darknet','Create an account','10');

create table [User]
(
Id INT PRIMARY KEY IDENTITY,
[Login] nvarchar(50) NOT NULL,
[Password] nvarchar(50) NOT NULL,
[Name] nvarchar(50)NOT NULL,
[Surname] nvarchar(50) NOT NULL,
[Middlename] nvarchar(50),
[Email] nvarchar(50),
[Number] int 
)

create table [Map]
(
Id INT PRIMARY KEY IDENTITY,
Id_user INT NOT NULL,CONSTRAINT FK_Map_User FOREIGN KEY (Id_user)
        REFERENCES [dbo].[User] (Id),
Id_achievement INT NOT NULL,CONSTRAINT FK_Map_Achievement FOREIGN KEY (Id_achievement)
        REFERENCES [dbo].[Map] (Id)
)