CREATE TABLE [dbo].[vehicle] (
    [VehicleId]          INT          IDENTITY (1, 1) NOT NULL,
    [VehicleType]        INT          NULL,
    [VehicleName]        VARCHAR (50) NULL,
    [VehicleModel]       VARCHAR (50) NULL,
    [VehiclePrice]       INT          NULL,
    [KickStart]          VARCHAR (10) NULL,
    [PowerSteering]      VARCHAR (10) NULL,
    [AirBags]            INT          NULL,
    [EngineDisplacement] INT          NULL,
    CONSTRAINT [PK_vehicle] PRIMARY KEY CLUSTERED ([VehicleId] ASC)
);

