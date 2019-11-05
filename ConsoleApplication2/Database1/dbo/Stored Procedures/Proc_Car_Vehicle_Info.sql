
CREATE PROCEDURE [dbo].[Proc_Car_Vehicle_Info]
AS 
BEGIN
SELECT e.VehicleType,e.VehicleName,e.VehicleModel,e.VehiclePrice,e.PowerSteering,e.AirBags,e.EngineDisplacement 
FROM vehicle e 
WHERE e.VehicleType=1
END