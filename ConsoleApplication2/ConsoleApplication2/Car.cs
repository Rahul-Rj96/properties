using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ConsoleApplication2
{
    class Car : Vehicles
    {

        public int AirBags
        {
            get;

            private set;

        }

        public Boolean PowerSteering
        {
            get;
            private set;

        }

        public Car(int type,string name, string model, int airBags, int price, Boolean powerSteering, int engineDisplacement) : base(type, name, model, price, engineDisplacement)
        {
            this.AirBags = airBags;
            this.PowerSteering = powerSteering;
        }
       

    }
}
