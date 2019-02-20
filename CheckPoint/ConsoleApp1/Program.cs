using System;
using KPP;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();
			var checkPoint = new CheckPoint();
			Vehicle vehicle;

			do
			{
				var vehicleIndex = random.Next((int) VehicleBodyType.NoVehicle);
				var bodyType = (VehicleBodyType) vehicleIndex;

				vehicle = VehicleFactory.CreateVehicle(bodyType);

				checkPoint.RegisterCar(vehicle);

				//cp.Statistics.BusesCount = -123;
			} while (!Console.KeyAvailable);

			// TODO: показать статистику.
		}
	}
}
