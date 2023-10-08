using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TransportLibrary;

namespace SysProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load(AssemblyName.GetAssemblyName("TransportLibrary.dll"));
            Module module = assembly.GetModule("TransportLibrary.dll");

            Console.WriteLine("Types in module: ");
            
            foreach (Type type in module.GetTypes())
                Console.WriteLine(type);

            Console.WriteLine("\n");


            Type Car = module.GetType("TransportLibrary.Car");
            Type Boat = module.GetType("TransportLibrary.Boat");
            Type Airplane = module.GetType("TransportLibrary.Airplane");

            string descriptionCar = "Brand - Volvo  | Model - XC 90 | Year of release - 2017 | Body type SUV | Black color | Engine | 3.2 l / 416 hp / plug-in hybrid | Mileage | 96,000 km | Transmission Machine Drive unit Full | New|No|State|Not beaten, not painted\r\nMarket version\r\nOfficial dealer";
            string descriptionBoat = "the layout of boats and boats, in which the bow of the boat is closed by a high deck with a small cabin below it";
            string descriptionAirplane = "a Soviet piston-engined single-engine biplane capable of taking on board up to 12 passengers and transporting them to a distance of up to 990 km";

            object car = Activator.CreateInstance(Car, new object[] { "Volvo", descriptionCar });
            object boat = Activator.CreateInstance(Boat, new object[] { "Cuddy Cabin", descriptionBoat });
            object airplane = Activator.CreateInstance(Airplane, new object[] { "Cornhusker", descriptionAirplane });


            Car.GetMethod("GetInfoTransport").Invoke(car, null);
            Console.WriteLine();
            Boat.GetMethod("GetInfoTransport").Invoke(boat, null);
            Console.WriteLine();
            Airplane.GetMethod("GetInfoTransport").Invoke(airplane, null);
        }
    }
}