CREATE TABLE [dbo].[Achievement] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Наименование] NVARCHAR (50)  NOT NULL,
    [Описание]     NVARCHAR (MAX) NULL,
    [Кол-во очков] INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

