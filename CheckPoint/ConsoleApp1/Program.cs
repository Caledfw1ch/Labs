using System;
using KPP;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var cp = new CheckPoint();
			Vehicle vehicle = null;

			do
			{
				// TODO: сгенерировать один из трёх типов автомобилей.
				vehicle = VehicleFactory.CreateVehicle(VehicleBodyType.Bus);

				cp.RegisterCar(vehicle);

				//cp.Statistics.BusesCount = -123;
			} while (!Console.KeyAvailable);

			// TODO: показать статистику.
		}
	}
}
