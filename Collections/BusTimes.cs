using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class BusTimes
    {
		public string[][] Times { get; }
		public BusRoute Route { get; }
		public BusTimes(BusRoute route, string[][] times)
		{
			this.Route = route;
			this.Times = times;
		}
	}
}
