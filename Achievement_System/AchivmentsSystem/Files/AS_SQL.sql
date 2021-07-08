﻿create table [Achievement]
(
Id UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
[Имя] nvarchar(50)NOT NULL ,
[Описание] nvarchar(200)NOT NULL ,
[Кол-во очков] int NOT NULL
)

create table [User]
(
Id UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
Id_map UNIQUEIDENTIFIER default NEWID(),
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
Id UNIQUEIDENTIFIER PRIMARY KEY default NEWID(),
Id_user UNIQUEIDENTIFIER default NEWID() NOT NULL,
Id_achievement UNIQUEIDENTIFIER default NEWID() NOT NULL
)