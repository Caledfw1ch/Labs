using System;
using System.Collections.Generic;

namespace KPP
{
	class CheckPoint
	{
		private const int SpeedLimit = 110;

		private List<string> _stolenNumbers;
		private CheckPointStatistics _statistics;
		protected readonly Random random;

		public CheckPointStatistics Statistics
		{
			get { return new CheckPointStatistics(_statistics); }
		}

		public CheckPoint()
		{
			_stolenNumbers = new List<string>();
			_statistics = new CheckPointStatistics();
			random = new Random();

			do
			{
				_stolenNumbers.Add(random.Next(100, 1000).ToString());
			}
			while (_stolenNumbers.Count != 100);
		}

		public void RegisterCar(Vehicle v)
		{
			if (v.BodyType == VehicleBodyType.Bus)
				_statistics.BusesCount++;
			else if (v.BodyType == VehicleBodyType.Car)
				_statistics.CarsCount++;
			else if (v.BodyType == VehicleBodyType.Truck)
				_statistics.TrucksCount++;

			var speed = v.Speed;

			Console.WriteLine(" Номер машины: " + v.LicensePlateNumber + " Кузов: " + v.BodyType + " Цвет: " + v.Color +  " Скорость: " + v.Speed);

			if (speed > SpeedLimit) // v._vmt[0]()
			{
				Console.WriteLine("Превышение скорости!");

				_statistics.SpeedLimitBreakerCount++;
			}

			_statistics.SpeedSum += speed;

			Console.WriteLine(v.HasPassenger ? "С пассажиром" : "Без пассажира");


			//for (int i = 0; i < _stolenNumbers.Count; i++)
			foreach (var item in _stolenNumbers)
			{
				//if (v.LicensePlateNumber == _stolenNumbers[i])
				if (v.LicensePlateNumber == item)
				{
					Console.WriteLine("Перехват!");

					_statistics.CarJackersCount++;

					break;
				}
			}
			 // TODO: доделать вывод информации
		}
	}
}
