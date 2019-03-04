using System;
using System.Threading;
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
				Thread.Sleep(random.Next(500, 5001));

				Console.WriteLine();

				var vehicleIndex = random.Next((int)VehicleBodyType.NoVehicle);
				var bodyType = (VehicleBodyType)vehicleIndex;

				vehicle = VehicleFactory.CreateVehicle(bodyType);

				checkPoint.RegisterCar(vehicle);

				//cp.Statistics.BusesCount = -123;
			} while (!Console.KeyAvailable);

			var statistics = checkPoint.Statistics;

			Console.WriteLine($"Машин проехало: {checkPoint.Statistics.CarsCount}");
			Console.WriteLine(($"Грузовиков проехало: {statistics.TrucksCount}"));
			Console.WriteLine(($"Автобусов проехало: {statistics.BusesCount}"));
			Console.WriteLine(($"Нарушителей скоростного режима: {statistics.SpeedLimitBreakerCount}"));
			Console.WriteLine(($"Машин в угоне: {statistics.CarJackersCount}"));
			Console.WriteLine(($"Средняя скорость: {statistics.AverageSpeed}"));
			Console.ReadKey();
		}
	}
}
