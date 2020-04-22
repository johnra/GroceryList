CREATE TABLE [dbo].[LinkRecipeIngredient] (
    [Id]           BIGINT           IDENTITY (1, 1) NOT NULL,
    [RecipeId]     UNIQUEIDENTIFIER NULL,
    [IngredientId] BIGINT           NULL,
    [Size]         VARCHAR (50)     NULL,
    [Quantity]     FLOAT (53)       NULL,
    [Unit]         VARCHAR (50)     NULL,
    [UnitId]       BIGINT           NULL,
    CONSTRAINT [PK_RecipeIngredient] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LinkRecipeIngredient_Ingredient] FOREIGN KEY ([IngredientId]) REFERENCES [dbo].[Ingredient] ([Id]),
    CONSTRAINT [FK_LinkRecipeIngredient_IngredientUnitLu] FOREIGN KEY ([UnitId]) REFERENCES [dbo].[IngredientUnitLu] ([Id]),
    CONSTRAINT [FK_LinkRecipeIngredient_Recipe] FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipe] ([Id])
);

