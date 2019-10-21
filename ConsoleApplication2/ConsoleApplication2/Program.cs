using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    
        class Car
        {
            public string name;
            public string model;
            public int airbags;
            public int price;
            public Boolean power_steering;
            public int engine_diplacement;
        public static void insert(Car cars)
        {
            Console.WriteLine("enter name: ");
            cars.name = Console.ReadLine();
            Console.WriteLine("\n enter model: ");
            cars.model = Console.ReadLine();
            Console.WriteLine("\n enter no of airbags:");
            cars.airbags = int.Parse(Console.ReadLine());
            Console.WriteLine("\n enter price: ");
            cars.price = int.Parse(Console.ReadLine());
            Console.WriteLine("\n power steering true or false: ");
            cars.power_steering = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("\n engine displacement: ");
            cars.engine_diplacement = int.Parse(Console.ReadLine());
           
        }
        public static void disp(Car c)
        {
            Console.WriteLine("name:{0} \n", c.name);
            Console.WriteLine("model:{0} \n", c.model);
            Console.WriteLine("price:{0} \n", c.price);
            Console.WriteLine("airbags:{0} \n", c.airbags);
            Console.WriteLine("power_steering:{0} \n", c.power_steering);
            Console.WriteLine("engine_diplacement:{0} \n", c.engine_diplacement);
        }


        }
        class Bike
        {
            
            public string name;
            public string model;
           // public int airbags;
            public int price;
            public Boolean kick_start;
            public int engine_diplacement;
         public static void insert(Bike bikes)
        {
            Console.WriteLine("enter name: ");
            bikes.name = Console.ReadLine();
            Console.WriteLine("\n enter model: ");
            bikes.model = Console.ReadLine();
            //Console.WriteLine("\n enter no of airbags:");
            //bikes.airbags = int.Parse(Console.ReadLine());
            Console.WriteLine("\n enter price: ");
            bikes.price = int.Parse(Console.ReadLine());
            Console.WriteLine("\n kick start true or false: ");
            bikes.kick_start = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("\n engine displacement: ");
            bikes.engine_diplacement = int.Parse(Console.ReadLine());
        }
        public static void disp(Bike b)
        {
            Console.WriteLine("name:{0} \n", b.name);
            Console.WriteLine("model:{0} \n", b.model);
            Console.WriteLine("price:{0} \n", b.price);
            // Console.WriteLine("airbags:{0} \n", b.airbags);
            Console.WriteLine("kick_start:{0} \n", b.kick_start);
            Console.WriteLine("engine_diplacement:{0} \n", b.engine_diplacement);
        }
        }
    class Vehicle
    {
        static void Main(string[] args)
        {
            int option = 0;
            //bike bikes = new bike();
            List<Car> carsl = new List<Car>();
            List<Bike> bikesl = new List<Bike>();
            while (option != 5)
            {

                Console.WriteLine("1.add new car \n2.add new bike \n3.view cars \n4.view bikes \n5.exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Car cars = new Car();
                        Car.insert(cars);
                        carsl.Add(cars);
                        break;

                    case 2:
                        Bike bikes = new Bike();
                        Bike.insert(bikes);
                        bikesl.Add(bikes);
                        break;

                    case 3:
                        foreach(Car c in carsl)
                        {
                            Car.disp(c);
                           
                        }

                        break;

                    case 4:
                        foreach (Bike b in bikesl)
                        {
                            Bike.disp(b);
                        }
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("invalid choice!");
                        break;
                }
            }
        }
        
    }
}
