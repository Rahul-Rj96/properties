using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   public class Connection
    {
        
        public static List<Car> ConnectionForReadingCar()
        {
            int vehicleType, vehiclePrice, airBags, engineDisplacement;
            string vehicleName, vehicleModel;
            bool powerSteering;
            List<Car> carsViewList = new List<Car>();
            string connString = ConfigurationManager.ConnectionStrings["firstdbConnectionString"].ConnectionString;       //read from config  
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    String spName = @"dbo.[Proc_Car_Vehicle_Info]";
                    SqlCommand cmd = new SqlCommand(spName, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            vehicleType = Convert.ToInt32(dr["VehicleType"]);
                            vehicleName = Convert.ToString(dr["VehicleName"]);
                            vehicleModel = Convert.ToString(dr["VehicleModel"]);
                            vehiclePrice = Convert.ToInt32(dr["VehiclePrice"]);
                            powerSteering = Convert.ToBoolean(dr["PowerSteering"]);
                            airBags = Convert.ToInt32(dr["AirBags"]);
                            engineDisplacement = Convert.ToInt32(dr["EngineDisplacement"]);
                            Car cars = new Car(vehicleType, vehicleName, vehicleModel, airBags, vehiclePrice, powerSteering, engineDisplacement);
                            carsViewList.Add(cars);
                        }

                    }
                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message);
            }
            return carsViewList;

        }
        public static List<Bike> ConnectionForReadingBike()
        {
            int vehicleType, vehiclePrice, engineDisplacement;
            string vehicleName, vehicleModel;
            bool kickStart;
            List<Bike> bikesViewList = new List<Bike>();
            string connString = ConfigurationManager.ConnectionStrings["firstdbConnectionString"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    String spName = @"dbo.[Proc_Bike_Vehicle_Info]";
                    SqlCommand cmd = new SqlCommand(spName, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            vehicleType = Convert.ToInt32(dr["VehicleType"]);
                            vehicleName = Convert.ToString(dr["VehicleName"]);
                            vehicleModel = Convert.ToString(dr["VehicleModel"]);
                            vehiclePrice = Convert.ToInt32(dr["VehiclePrice"]);
                            kickStart = Convert.ToBoolean(dr["KickStart"]);
                            engineDisplacement = Convert.ToInt32(dr["EngineDisplacement"]);
                            Bike bikes = new Bike(vehicleType, vehicleName, vehicleModel, vehiclePrice, kickStart, engineDisplacement);
                            bikesViewList.Add(bikes);
                        }

                    }
                    dr.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message);
            }
            return bikesViewList;

        }

        public static void GetDataTable<T>(T vehicle)
        {
            DataTable vehicleTable = Vehicles.CreateTable(vehicle);
            string connString = ConfigurationManager.ConnectionStrings["firstdbConnectionString"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    String spInsertvehicle = @"dbo.[Proc_Vehicle_Insert]";
                    SqlCommand cmd = new SqlCommand(spInsertvehicle, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (vehicleTable.Rows.Count != 0)
                    {
                        conn.Open();
                        SqlParameter vehicleParam = cmd.Parameters.AddWithValue("@TempVehicle", vehicleTable);
                        vehicleParam.SqlDbType = SqlDbType.Structured;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message);
            }
        }

    }
}
