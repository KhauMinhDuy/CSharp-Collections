using System;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BusRoute[] routes = BusRouteRepository.InitializeRoutes();

			foreach(BusRoute route in routes)
            {
				Console.WriteLine(route);
            }

            BusRoute busRoute = routes[0];
			Console.WriteLine($"The first route is {busRoute}");
			Console.WriteLine($"The third route is {routes[2]}");
			Console.WriteLine($"The last route is {routes[routes.Length - 1]}");
			Console.WriteLine($"The last route is {routes[^1]}");
		}

		public static BusRoute FindBusTo(BusRoute[] routes, string location)
        {
			foreach(BusRoute route in routes)
            {
				if(route.Origin == location || route.Destination == location)
                {
					return route;
                }
            }
			return null;
        }

    }


}
