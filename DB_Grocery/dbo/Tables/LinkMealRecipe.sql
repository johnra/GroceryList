CREATE TABLE [dbo].[LinkMealRecipe] (
    [Id]       BIGINT           IDENTITY (1, 1) NOT NULL,
    [MealId]   BIGINT           NULL,
    [RecipeId] UNIQUEIDENTIFIER NULL,
    [Name]     VARCHAR (50)     NULL,
    CONSTRAINT [PK_MealRecipe] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LinkMealRecipe_Meal] FOREIGN KEY ([MealId]) REFERENCES [dbo].[Meal] ([Id]),
    CONSTRAINT [FK_LinkMealRecipe_Recipe] FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipe] ([Id])
);

