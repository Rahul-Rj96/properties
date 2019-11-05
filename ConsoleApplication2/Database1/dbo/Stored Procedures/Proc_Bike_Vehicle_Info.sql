CREATE PROCEDURE [dbo].[Proc_Bike_Vehicle_Info]
AS 
BEGIN
SELECT e.VehicleType,e.VehicleName,e.VehicleModel,e.VehiclePrice,e.KickStart,e.EngineDisplacement 
FROM vehicle e 
WHERE e.VehicleType=0
END