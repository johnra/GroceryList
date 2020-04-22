CREATE TABLE [dbo].[Meal] (
    [Id]             BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (50) NULL,
    [MealTypeId]     BIGINT       NULL,
    [MealCategoryId] BIGINT       NULL,
    CONSTRAINT [PK_Meal] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Meal_MealCategoryLu] FOREIGN KEY ([MealCategoryId]) REFERENCES [dbo].[MealCategoryLu] ([Id]),
    CONSTRAINT [FK_Meal_MealTypeLu] FOREIGN KEY ([MealTypeId]) REFERENCES [dbo].[MealTypeLu] ([Id])
);

