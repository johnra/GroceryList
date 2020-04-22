CREATE TABLE [dbo].[RecipeIngredient] (
    [Id]           BIGINT        NULL,
    [RecipeId]     BIGINT        NULL,
    [IngredientId] BIGINT        NULL,
    [Size]         VARCHAR (50)  NULL,
    [Quantity]     FLOAT (53)    CONSTRAINT [DF_RecipeIngredient_Quantity] DEFAULT ((0)) NOT NULL,
    [Unit]         NVARCHAR (50) NULL,
    CONSTRAINT [FK_RecipeIngredient_Ingredient] FOREIGN KEY ([IngredientId]) REFERENCES [dbo].[Ingredient] ([Id]),
    CONSTRAINT [FK_RecipeIngredient_Recipe] FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipe] ([Id])
);

