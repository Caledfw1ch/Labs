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
            while (_stolenNumbers.Count != 15);
            // TODO: заполнить реестр угнанных номеров. почему-то срабатывает превышение скорости
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

            if (v.HasPassenger = false)      // не могу получить, почему?
            {
                Console.WriteLine("Перехват!");
            
                _statistics.CarJackersCount++;
            }
			// TODO: доделать проверки, проверить на угон.
		}
	}
}
