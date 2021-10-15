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
        public string Origin => PlacesServed[0];
        public string Description => PlacesServed[^1];

        public string[] PlacesServed { get; }

        public BusRoute(int number, string[] placesServed)
        {
            Number = number;
            PlacesServed = placesServed;
        }

        public override string ToString() => $"{Number} : {Origin} -> {Description}";

        public bool Serves(string description)
        {
            return Array.Exists(PlacesServed, placesServed => placesServed == description);
        }
    }
}
