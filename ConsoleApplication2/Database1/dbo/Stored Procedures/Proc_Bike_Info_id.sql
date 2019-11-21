CREATE PROCEDURE [dbo].[Proc_Bike_Info_id]
@id int
AS 
BEGIN
SELECT e.VehicleType,e.VehicleName,e.VehicleModel,e.VehiclePrice,e.KickStart,e.EngineDisplacement 
FROM vehicle e 
WHERE e.VehicleId=@id
END