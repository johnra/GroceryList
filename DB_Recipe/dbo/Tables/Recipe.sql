CREATE TABLE [dbo].[Recipe] (
    [Id]               BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (150) NULL,
    [Servings]         INT           CONSTRAINT [DF_Recipe_Servings] DEFAULT ((2)) NOT NULL,
    [PrepTime]         INT           CONSTRAINT [DF_Recipe_PrepTime] DEFAULT ((30)) NULL,
    [CookTime]         INT           NULL,
    [Stars]            INT           CONSTRAINT [DF_Recipe_Stars] DEFAULT ((3)) NULL,
    [RecipeCategoryId] INT           NULL,
    [RecipeTypeId]     INT           NULL,
    [Reference]        VARCHAR (100) NULL,
    [RecipeChefId]     INT           NULL,
    CONSTRAINT [PK_Recipe] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Recipe_RecipeCategory] FOREIGN KEY ([RecipeCategoryId]) REFERENCES [dbo].[RecipeCategory] ([Id]),
    CONSTRAINT [FK_Recipe_RecipeChef] FOREIGN KEY ([RecipeChefId]) REFERENCES [dbo].[RecipeChef] ([Id]),
    CONSTRAINT [FK_Recipe_RecipeType] FOREIGN KEY ([RecipeTypeId]) REFERENCES [dbo].[RecipeType] ([Id])
);



