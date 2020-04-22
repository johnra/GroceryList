CREATE TABLE [dbo].[MealCategoryLu] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    CONSTRAINT [PK_MealCategory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

