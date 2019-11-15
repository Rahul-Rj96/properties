using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Models
{
    public class Car : Vehicles
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

        public Car(int type, string name, string model, int airBags, int price, Boolean powerSteering, int engineDisplacement) : base(type, name, model, price, engineDisplacement)
        {
            this.AirBags = airBags;
            this.PowerSteering = powerSteering;
        }


    }
}
