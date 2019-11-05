CREATE PROCEDURE [dbo].[Proc_Vehicle_Insert]
(@TempVehicle as dbo.Tablevehicle readonly)
AS 
BEGIN
INSERT INTO vehicle (VehicleType,VehicleName,VehicleModel,VehiclePrice,KickStart,PowerSteering,AirBags,EngineDisplacement) 
select VehicleType,VehicleName,VehicleModel,VehiclePrice,KickStart,PowerSteering,AirBags,EngineDisplacement
from @TempVehicle
END