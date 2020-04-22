CREATE TABLE [dbo].[LinkRecipeAttribute] (
    [Id]          BIGINT           IDENTITY (1, 1) NOT NULL,
    [RecipeId]    UNIQUEIDENTIFIER NULL,
    [AttributeId] BIGINT           NULL,
    CONSTRAINT [PK_LinkRecipeAttribute] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LinkRecipeAttribute_Recipe] FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipe] ([Id]),
    CONSTRAINT [FK_LinkRecipeAttribute_RecipeAttributeLu] FOREIGN KEY ([AttributeId]) REFERENCES [dbo].[RecipeAttributeLu] ([Id])
);

