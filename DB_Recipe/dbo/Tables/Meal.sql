CREATE TABLE [dbo].[Meal] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    CONSTRAINT [PK_Meal] PRIMARY KEY CLUSTERED ([Id] ASC)
);

