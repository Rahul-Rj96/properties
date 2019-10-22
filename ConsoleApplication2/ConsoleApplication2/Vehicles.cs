namespace ConsoleApplication2
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
            

            set
            {
                name = value;
            }
           
          
            
        }
        public string Model
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
        public int EngineDisplacement
        {
            get;
            set;
        }


    }
}
