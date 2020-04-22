CREATE TABLE [dbo].[IngredientSource] (
    [Id]               BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (75) NULL,
    [IsLocal]          BIT          CONSTRAINT [DF_IngredientSource_IsLocal] DEFAULT ((0)) NOT NULL,
    [IsRegional]       BIT          CONSTRAINT [DF_IngredientSource_IsRegional] DEFAULT ((0)) NOT NULL,
    [IsOnline]         BIT          CONSTRAINT [DF_IngredientSource_IsOnline] DEFAULT ((0)) NOT NULL,
    [LocalAddress1]    VARCHAR (50) NULL,
    [LocalAddress2]    VARCHAR (50) NULL,
    [LocalCity]        VARCHAR (50) NULL,
    [LocalState]       VARCHAR (50) NULL,
    [LocalEmail]       VARCHAR (50) NULL,
    [LocalPhone]       VARCHAR (15) NULL,
    [RegionalAddress1] VARCHAR (50) NULL,
    [RegionalAddress2] VARCHAR (50) NULL,
    [RegionalCity]     VARCHAR (50) NULL,
    [RegionalState]    VARCHAR (50) NULL,
    [RegionalEmail]    VARCHAR (50) NULL,
    [RegionalPhone]    VARCHAR (15) NULL,
    [OnlineAddress1]   VARCHAR (75) NULL,
    CONSTRAINT [PK_IngredientSource] PRIMARY KEY CLUSTERED ([Id] ASC)
);

