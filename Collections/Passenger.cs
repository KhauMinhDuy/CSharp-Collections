using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Passenger
    {
        public string Name { get; set; }
        public string Destination { get; set; }
        public Passenger(string name, string destination)
        {
            this.Name = name;
            this.Destination = destination;
        }
        public override string ToString() => $"{Name} to {Destination}";
    }
}
