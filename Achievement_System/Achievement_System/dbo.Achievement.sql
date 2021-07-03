CREATE TABLE [dbo].[Achievement]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Наименование] NVARCHAR(50) NOT NULL, 
    [Описание] NVARCHAR(MAX) NULL, 
    [Кол-во очков] INT NULL
)
