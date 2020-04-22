CREATE TABLE [dbo].[Recipe] (
    [Id]               UNIQUEIDENTIFIER CONSTRAINT [DF_Recipe_Id] DEFAULT (newsequentialid()) NOT NULL,
    [Name]             VARCHAR (250)    NULL,
    [ServingsMin]      INT              NULL,
    [ServingsMax]      INT              NULL,
    [PrepTime]         INT              NULL,
    [CookTime]         INT              NULL,
    [Stars]            INT              NULL,
    [Reference]        VARCHAR (250)    NULL,
    [Link]             VARCHAR (500)    NULL,
    [Description]      VARCHAR (2500)   NULL,
    [Image]            IMAGE            NULL,
    [ChefId]           BIGINT           NULL,
    [RecipeCategoryId] BIGINT           NULL,
    [RecipeTypeId]     BIGINT           NULL,
    CONSTRAINT [PK_Recipe] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Recipe_RecipeCategoryLu] FOREIGN KEY ([RecipeCategoryId]) REFERENCES [dbo].[RecipeCategoryLu] ([Id]),
    CONSTRAINT [FK_Recipe_RecipeTypeLu] FOREIGN KEY ([RecipeTypeId]) REFERENCES [dbo].[RecipeTypeLu] ([Id])
);

