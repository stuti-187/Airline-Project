CREATE TABLE [dbo].[Customer] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50)  NULL,
    [Birthday] DATETIME       NULL,
    [Email]    NVARCHAR (50)  NULL,
    [Phone ]   NVARCHAR (50)  NULL,
    [Address]  NVARCHAR (MAX) NULL,
    [username] NVARCHAR (50)  NULL,
    [password] NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

