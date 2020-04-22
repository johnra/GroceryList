CREATE TABLE [dbo].[Ingredient] (
    [Id]         BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (75) NULL,
    [CategoryId] INT          NULL,
    CONSTRAINT [PK_Ingredient] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Ingredient_IngredientCategory] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[IngredientCategory] ([Id])
);

