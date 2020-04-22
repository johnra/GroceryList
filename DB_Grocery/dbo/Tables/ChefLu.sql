CREATE TABLE [dbo].[ChefLu] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (250) NULL,
    [Reference] VARCHAR (350) NULL,
    CONSTRAINT [PK_Chef] PRIMARY KEY CLUSTERED ([Id] ASC)
);

