using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{

    class Vehicle
    {
        static void Main(string[] args)
        {
            int option = 0;
            //bike bikes = new bike();
            List<Car> carsList = new List<Car>();
            List<Bike> bikesList = new List<Bike>();
            while (option != 5)
            {

                Console.WriteLine("1.add new car \n2.add new bike \n3.view cars \n4.view bikes \n5.exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Car cars = _ReadCarFromconsole();//new Car(/*"Maruti", "2000"*/);
                        carsList.Add(cars);
                        //cars.model = "";
                        break;

                    case 2:
                        Bike bikes = _ReadBikeFromConsole();
                        bikesList.Add(bikes);
                        break;

                    case 3:
                        foreach (Car car in carsList)
                        {
                            _DisplayCarOnConsole(car);
                        }
                        break;

                    case 4:
                        foreach (Bike bike in bikesList)
                        {
                            _DisplayBikeOnConsole(bike);
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

        private static Bike _ReadBikeFromConsole()
        {
            Bike bike = new Bike();
            Console.WriteLine("enter name: ");
            bike.Name = Console.ReadLine();
            Console.WriteLine("\n enter model: ");
            bike.Model = Console.ReadLine();
            Console.WriteLine("\n enter price: ");
            bike.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("\n kick start true or false: ");
            bike.KickStart = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("\n engine displacement: ");
            bike.EngineDisplacement = int.Parse(Console.ReadLine());
            return bike;
        }

        private static Car _ReadCarFromconsole()
        {
            //Car myCar = new Car("Maruti", "2000");
            //Console.WriteLine(myCar.Name);
            //myCar.MyMethod();

            Car cars = new Car();
            Console.WriteLine("enter name: ");
            cars.Name = Console.ReadLine();
            Console.WriteLine("\n enter model: ");
            cars.Model = Console.ReadLine();
            Console.WriteLine("\n enter no of airbags:");
            cars.AirBags = int.Parse(Console.ReadLine());
            Console.WriteLine("\n enter price: ");
            cars.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("\n power steering true or false: ");
            cars.PowerSteering = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("\n engine displacement: ");
            cars.EngineDisplacement = int.Parse(Console.ReadLine());
            return cars;
        }

        private static void _DisplayCarOnConsole(Car c)
        {
            Console.WriteLine("name:{0} \n", c.Name);
            Console.WriteLine("model:{0} \n", c.Model);
            Console.WriteLine("price:{0} \n", c.Price);
            Console.WriteLine("airbags:{0} \n", c.AirBags);
            Console.WriteLine("power_steering:{0} \n", c.PowerSteering);
            Console.WriteLine("engine_diplacement:{0} \n", c.EngineDisplacement);
        }
        private static void _DisplayBikeOnConsole(Bike b)
        {
            Console.WriteLine("name:{0} \n", b.Name);
            Console.WriteLine("model:{0} \n", b.Model);
            Console.WriteLine("price:{0} \n", b.Price);
            Console.WriteLine("kick_start:{0} \n", b.KickStart);
            Console.WriteLine("engine_diplacement:{0} \n", b.EngineDisplacement);
        }

    }
}
