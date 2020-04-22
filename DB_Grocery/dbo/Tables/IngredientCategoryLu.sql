CREATE TABLE [dbo].[IngredientCategoryLu] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    CONSTRAINT [PK_IngredientCategory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

