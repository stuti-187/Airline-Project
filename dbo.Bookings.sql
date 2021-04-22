CREATE TABLE [dbo].[Bookings] (
    [Reference Number] INT            IDENTITY (1000, 1) NOT NULL,
    [Name]             NVARCHAR (50)  NULL,
    [Birth date]       DATETIME       NULL,
    [Email]            NVARCHAR (50)  NULL,
    [Phone Number]     NVARCHAR (50)  NULL,
    [Address]          NVARCHAR (MAX) NULL,
    [Date of Journey]  DATETIME       NULL,
    [Flight_Id]        INT            NULL,
    [Flight Name]      NVARCHAR (50)  NULL,
    [Seat Number]      NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Reference Number] ASC)
);

