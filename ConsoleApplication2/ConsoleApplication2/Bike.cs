using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ConsoleApplication2
{
    public class Bike : Vehicles
    {
        public Boolean KickStart
        {
            get;
            private set;
        }
        public Bike(int type,string name, string model, int price, Boolean kickStart, int engineDisplacement) : base(type,name, model, price, engineDisplacement)
        {
            this.KickStart = kickStart;
        }
    }
}
