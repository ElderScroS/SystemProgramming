using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public class Car : Transport
    {
        public Car() { }
        public Car(string model, string description)
            : base(TransportEnum.Car, new List<TypeOfRide> { TypeOfRide.Earth }, model, description) { }

        public override void GetInfoTransport() { base.GetInfoTransport(); }
    }
}
