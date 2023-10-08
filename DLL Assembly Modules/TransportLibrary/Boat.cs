using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public class Boat : Transport
    {
        public Boat() { }
        public Boat(string model, string description)
            : base(TransportEnum.Boat, new List<TypeOfRide> { TypeOfRide.Water }, model, description) { }

        public override void GetInfoTransport() { base.GetInfoTransport(); }
    }
}
