CREATE TABLE [dbo].[RecipeCategoryLu] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    CONSTRAINT [PK_RecipeCategory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

