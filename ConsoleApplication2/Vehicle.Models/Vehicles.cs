using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Models
{
    public abstract class Vehicles
    {
        private string name;
        public string Name
        {

            get
            {
                return name.ToUpper();
            }

            protected set
            {
                name = value;
            }
        }
        public int Type
        {
            get;
            protected set;
        }
        public string Model
        {
            get;
            protected set;
        }
        public int Price
        {
            get;
            protected set;
        }
        public int EngineDisplacement
        {
            get;
            protected set;
        }
        public Vehicles(int type, string name, string model, int price, int engineDisplacement)
        {
            this.Name = name;
            this.Type = type;
            this.Model = model;
            this.Price = price;
            this.EngineDisplacement = engineDisplacement;

        }
        public static DataTable CreateTable<T>(T vehicle)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("VehicleType", typeof(Int32));
            dt.Columns.Add("VehicleName", typeof(string));
            dt.Columns.Add("VehicleModel", typeof(string));
            dt.Columns.Add("VehiclePrice", typeof(Int32));
            dt.Columns.Add("KickStart", typeof(string));
            dt.Columns.Add("PowerSteering", typeof(string));
            dt.Columns.Add("AirBags", typeof(Int32));
            dt.Columns.Add("EngineDisplacement", typeof(Int32));

            if (vehicle is Car)
            {
                Car car = vehicle as Car;
                dt.Rows.Add(car.Type, car.Name, car.Model, car.Price, null, car.PowerSteering, car.AirBags, car.EngineDisplacement);
            }
            else if (vehicle is Bike)
            {
                Bike bike = vehicle as Bike;
                dt.Rows.Add(bike.Type, bike.Name, bike.Model, bike.Price, bike.KickStart, null, null, bike.EngineDisplacement);
            }
            return dt;
        }
    }
}
