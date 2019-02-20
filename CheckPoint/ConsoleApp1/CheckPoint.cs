using System;
using System.Collections.Generic;

namespace KPP
{
	class CheckPoint
	{
		private const int SpeedLimit = 110;

		private List<string> _stolenNumbers;
		private CheckPointStatistics _statistics;

		public CheckPointStatistics Statistics
		{
			get { return new CheckPointStatistics(_statistics); }
		}

		public CheckPoint()
		{
			_stolenNumbers = new List<string>();
			_statistics = new CheckPointStatistics();

			// TODO: заполнить реестр угнанных номеров.
		}

		public void RegisterCar(Vehicle v)
		{
			if (v.BodyType == VehicleBodyType.Bus)
				_statistics.BusesCount++;
			else if (v.BodyType == VehicleBodyType.Car)
				_statistics.CarsCount++;
			else if (v.BodyType == VehicleBodyType.Truck)
				_statistics.TrucksCount++;

			if (v.Speed > SpeedLimit) // v._vmt[0]()
			{
				Console.WriteLine("Превышение скорости!");

				_statistics.SpeedLimitBreakerCount++;
			}

			// TODO: доделать проверки, проверить на угон.
		}
	}
}
