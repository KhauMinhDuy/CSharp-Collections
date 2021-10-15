using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            BusRoute[] allRoutes = BusRouteRepository.InitBusRoutes();

            Console.WriteLine("Where do you want to go to?");
            string location = Console.ReadLine();

            BusRoute[] routes = findBusesTo(allRoutes, location);

            if (routes != null)
            {
                foreach(var route in routes)
                {
                    Console.WriteLine($"You can use route {route}");
                }
            }
            else
            {
                Console.WriteLine($"No routes go to {location}");
            }
        }

        private static BusRoute FindBusTo(BusRoute[] routes, string location)
        {
            return Array.Find(routes, route => route.Origin == location || route.Description == location);   
        }

        private static BusRoute[] findBusesTo(BusRoute[] routes, string location)
        {
            return Array.FindAll(routes, route => route.Serves(location));
        }

    }
}
