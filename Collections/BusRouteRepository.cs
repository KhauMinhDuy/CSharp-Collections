using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class BusRouteRepository
    {
        public static BusRoute[] InitializeRoutes()
        {
            return new BusRoute[]
            {
                route40,
                route42,
                new BusRoute(100, "University", "Morecambe"),
                new BusRoute(555, "Lancaster", "Keswick")
            };
        }
    }
}
