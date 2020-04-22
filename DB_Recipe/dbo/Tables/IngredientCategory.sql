CREATE TABLE [dbo].[IngredientCategory] (
    [Id]   INT        IDENTITY (1, 1) NOT NULL,
    [Name] NCHAR (10) NULL,
    CONSTRAINT [PK_IngredientCategory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

