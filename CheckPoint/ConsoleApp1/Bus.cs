using System;
using System.Collections.Generic;
using System.Text;

namespace KPP
{
	class Bus : Vehicle
	{
		public Bus(VehicleColor color) : base(color)
		{
			BodyType = VehicleBodyType.Bus;
		}
	}
}
