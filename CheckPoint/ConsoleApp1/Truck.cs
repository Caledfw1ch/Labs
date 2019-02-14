using System;
using System.Collections.Generic;
using System.Text;

namespace KPP
{
	class Truck : Vehicle
	{
		public Truck(VehicleColor color) : base(color)
		{
			BodyType = VehicleBodyType.Truck;
		}
	}
}
