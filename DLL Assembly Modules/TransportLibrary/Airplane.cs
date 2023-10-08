using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportLibrary
{
    public class Airplane : Transport
    {
        public Airplane() { }
        public Airplane(string model, string description)
            : base(TransportEnum.Airplane, new List<TypeOfRide> { TypeOfRide.Earth, TypeOfRide.Air }, model, description) { }

        public override void GetInfoTransport() { base.GetInfoTransport(); }
    }
}
