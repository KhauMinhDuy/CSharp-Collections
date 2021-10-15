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

        public BusRoute(int number, string origin, string description)
        {
            Number = number;
            Origin = origin;
            Description = description;
        }

        public override string ToString() => $"{Number} : {Origin} -> {Description}";
    }
}
