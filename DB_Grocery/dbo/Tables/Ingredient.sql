CREATE TABLE [dbo].[Ingredient] (
    [Id]                   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]                 VARCHAR (50) NULL,
    [IngredientTypeId]     BIGINT       NULL,
    [IngredientCategoryId] BIGINT       NULL,
    [DefaultUnitId]        BIGINT       NULL,
    [GmConversion]         FLOAT (53)   NULL,
    CONSTRAINT [PK_Ingredient] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Ingredient_Ingredient] FOREIGN KEY ([IngredientTypeId]) REFERENCES [dbo].[IngredientTypeLu] ([Id]),
    CONSTRAINT [FK_Ingredient_IngredientCategoryLu] FOREIGN KEY ([IngredientCategoryId]) REFERENCES [dbo].[IngredientCategoryLu] ([Id]),
    CONSTRAINT [FK_Ingredient_IngredientUnitLu] FOREIGN KEY ([DefaultUnitId]) REFERENCES [dbo].[IngredientUnitLu] ([Id])
);

