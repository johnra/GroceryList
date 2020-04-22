CREATE TABLE [dbo].[User] (
    [Username] VARCHAR (150) NOT NULL,
    [Password] VARCHAR (20)  NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Username] ASC)
);

