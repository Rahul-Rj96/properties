using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Vehicle.Models;

namespace ConsoleApplication2
{

   public class Vehicle
    {
        private static List<Car> carsViewList = new List<Car>();
        private static List<Bike> bikesViewList = new List<Bike>();

        static void Main(string[] args)
        {
            int option = 0;
            
    
            while (option != 5)
            {

                Console.WriteLine("1.add new car \n2.add new bike \n3.view cars \n4.view bikes \n5.exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Car cars = _ReadCarFromconsole();
                        Connection.WriteDataTable(cars);
                        break;

                    case 2:
                        Bike bikes = _ReadBikeFromConsole();
                        Connection.WriteDataTable(bikes);
                        break;

                    case 3:
                        carsViewList.Clear();
                        carsViewList.AddRange(Connection.ConnectionForReadingCar());
                        _DisplayCarOnConsole(carsViewList);

                        break;

                    case 4:
                        bikesViewList.Clear();
                        bikesViewList.AddRange(Connection.ConnectionForReadingBike());
                        _DisplayBikeOnConsole(bikesViewList);

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
            int type = 0;
            Console.WriteLine("enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\n enter model: ");
            string model = Console.ReadLine();
            Console.WriteLine("\n enter price: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("\n kick start true or false: ");
            Boolean kickStart = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("\n engine displacement: ");
            int engineDisplacement = int.Parse(Console.ReadLine());
            Bike bike = new Bike(type, name, model, price, kickStart, engineDisplacement);
            return bike;
        }

        private static Car _ReadCarFromconsole()
        {
            int type = 1;
            Console.WriteLine("enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\n enter model: ");
            string model = Console.ReadLine();
            Console.WriteLine("\n enter no of airbags:");
            int airBags = int.Parse(Console.ReadLine());
            Console.WriteLine("\n enter price: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("\n power steering true or false: ");
            Boolean powerSteering = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("\n engine displacement: ");
            int engineDisplacement = int.Parse(Console.ReadLine());
            Car cars = new Car(type, name, model, airBags, price, powerSteering, engineDisplacement);
            return cars;
        }

        private static void _DisplayCarOnConsole(List<Car> carsList)
        {
            foreach (Car c in carsList)
            {
                Console.WriteLine("name:{0} \n", c.Name);
                Console.WriteLine("model:{0} \n", c.Model);
                Console.WriteLine("price:{0} \n", c.Price);
                Console.WriteLine("airbags:{0} \n", c.AirBags);
                Console.WriteLine("power_steering:{0} \n", c.PowerSteering);
                Console.WriteLine("engine_diplacement:{0} \n", c.EngineDisplacement);
            }
        }
        private static void _DisplayBikeOnConsole(List<Bike> bikesList)
        {
            foreach (Bike b in bikesList)
            {
                Console.WriteLine("name:{0} \n", b.Name);
                Console.WriteLine("model:{0} \n", b.Model);
                Console.WriteLine("price:{0} \n", b.Price);
                Console.WriteLine("kick_start:{0} \n", b.KickStart);
                Console.WriteLine("engine_diplacement:{0} \n", b.EngineDisplacement);
            }
        }

    }
}
