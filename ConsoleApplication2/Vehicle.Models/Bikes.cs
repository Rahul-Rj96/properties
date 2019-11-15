using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.Models
{
    public class Bike : Vehicles
    {
        public Boolean KickStart
        {
            get;
            private set;
        }
        public Bike(int type, string name, string model, int price, Boolean kickStart, int engineDisplacement) : base(type, name, model, price, engineDisplacement)
        {
            this.KickStart = kickStart;
        }
    }
}
