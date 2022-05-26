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

            Console.WriteLine("Which route do you want to look up?");
            int number = int.Parse(Console.ReadLine());

            bool success = allRoutes.TryGetValue(number, out BusRoute busRoute);

            if(success)
            {
                Console.WriteLine($"The route you asked for is {busRoute}");
            } else
            {
                Console.WriteLine($"There is no route with number {number}");
            }
        }

    }
}
