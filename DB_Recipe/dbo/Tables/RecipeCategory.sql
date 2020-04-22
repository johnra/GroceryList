CREATE TABLE [dbo].[RecipeCategory] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    CONSTRAINT [PK_RecipeCategory] PRIMARY KEY CLUSTERED ([Id] ASC)
);

