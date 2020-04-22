CREATE TABLE [dbo].[MealTypeLu] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    CONSTRAINT [PK_MealType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

