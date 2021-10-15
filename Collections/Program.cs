using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var allRoutes = BusRouteRepository.InitializeRoutes();

            foreach (BusRoute route in allRoutes.Values)
            {
                Console.WriteLine(route);
            }
        }

    }
}
