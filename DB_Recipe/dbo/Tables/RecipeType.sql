﻿CREATE TABLE [dbo].[RecipeType] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    CONSTRAINT [PK_RecipeType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

