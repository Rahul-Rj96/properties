CREATE PROCEDURE [dbo].[Proc_Car_Vehicle_Insert]
@type int,
@name varchar(50),
@model varchar(50),
@price int,
@powerSteering varchar(10),
@airbags int,
@engineDisplacement int
AS 
BEGIN
INSERT INTO vehicle (VehicleType,VehicleName,VehicleModel,VehiclePrice,KickStart,PowerSteering,AirBags,EngineDisplacement) values (@type,@name,@model,@price,null,@powerSteering,@airbags,@engineDisplacement)
END