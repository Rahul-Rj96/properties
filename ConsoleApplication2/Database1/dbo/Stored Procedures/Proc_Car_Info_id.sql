CREATE PROCEDURE [dbo].[Proc_Car_Info_id]
@id int
AS 
BEGIN
SELECT e.VehicleType,e.VehicleName,e.VehicleModel,e.VehiclePrice,e.PowerSteering,e.AirBags,e.EngineDisplacement 
FROM vehicle e 
WHERE e.VehicleId=@id
END