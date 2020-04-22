CREATE TABLE [dbo].[RecipeChef] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    CONSTRAINT [PK_RecipeChef] PRIMARY KEY CLUSTERED ([Id] ASC)
);

