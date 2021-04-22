CREATE TABLE [dbo].[FlightSeatDetils] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [FlightName]   NVARCHAR (50) NULL,
    [FlightNumber] INT           NULL,
    [FlightDate]   NVARCHAR (50) NULL,
    [SeatNumber]   NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

