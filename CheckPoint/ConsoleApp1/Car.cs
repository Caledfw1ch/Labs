using System;
using System.Collections.Generic;
using System.Text;

namespace KPP
{
	class Car : Vehicle
	{
		public Car(VehicleColor color) : base(color)
		{
			BodyType = VehicleBodyType.Car;
		}
	}
}
