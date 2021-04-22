CREATE TABLE [dbo].[Flight_Details] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Flight_Name]    NVARCHAR (50) NULL,
    [Source]         NVARCHAR (50) NULL,
    [Destination]    NVARCHAR (50) NULL,
    [Arrival_Time]   NVARCHAR (50) NULL,
    [Departure_Time] NVARCHAR (50) NULL,
    [Flight_Class]   NVARCHAR (50) NULL,
    [Cost]           DECIMAL (18)  NULL,
    [Seats]          INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

