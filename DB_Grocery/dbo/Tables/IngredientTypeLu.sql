﻿CREATE TABLE [dbo].[IngredientTypeLu] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    CONSTRAINT [PK_IngredientType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

