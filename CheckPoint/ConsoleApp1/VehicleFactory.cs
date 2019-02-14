using System;
using System.Collections.Generic;
using System.Text;

namespace KPP
{
	static class VehicleFactory
	{
		public static Vehicle CreateVehicle(VehicleBodyType bt)
		{
			// TODO: сгенерировать значения свойств машины, передать их через параметры конструктора.
			var color = VehicleColor.Green; // Сгенерировать!

			if (bt == VehicleBodyType.Bus)
				return new Bus(color);
			else if (bt == VehicleBodyType.Car)
				return new Car(color);
			else if (bt == VehicleBodyType.Truck)
				return new Truck(color);
			else
				throw new ArgumentException("Такой тип автомобиля не производится");
		}
	}
}
