using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class BusRoute
    {

        public int Number { get; }
        public string Origin { get; }
        public string Description { get; }

        public string[] PlacesServed { get; }

        public BusRoute(int number, string[] placesServed)
        {
            this.Number = number;
            this.PlacesServed = placesServed;
        }

        public override string ToString() => $"{Number} : {Origin} -> {Description}";

        public bool Serves(string destination)
        {
            return Array.Exists(PlacesServed, place => place == destination);
        }
    }
}
