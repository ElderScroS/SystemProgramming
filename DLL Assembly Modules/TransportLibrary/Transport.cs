using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public enum TransportEnum
    {
        None,
        Car,
        Boat,
        Airplane
    }
    public enum TypeOfRide
    {
        None,
        Earth,
        Air,
        Water
    }

    public class Transport
    {
        TransportEnum TransportEnum;
        List<TypeOfRide> TypesOfRide { get; set; }
        public string Model { get; set; } = "Not specified";
        public string Description { get; set; } = "There is no description";

        public Transport()
        {
            this.TransportEnum = TransportEnum.None;
            this.TypesOfRide = new List<TypeOfRide>();
        }
        public Transport(TransportEnum transportEnum, List<TypeOfRide> types, string model, string description)
        {
            this.TransportEnum = transportEnum;
            this.TypesOfRide = types;
            this.Model = model;
            this.Description = description;
        }

        public virtual void GetInfoTransport()
        {
            Console.WriteLine($"Transport type: {this.TransportEnum}");

            Console.Write($"Types of Ride: ");
            foreach (TypeOfRide type in this.TypesOfRide)
                Console.Write($"{type} |");

            Console.WriteLine($"\nModel: {this.Model}\nDescription: {this.Description}\n\n");
        }
    }
}
