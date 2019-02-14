using System;
using System.Collections.Generic;
using System.Text;

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

			if (v.Speed > SpeedLimit)
			{
				Console.WriteLine("Превышение скорости!");
			}

			// TODO: доделать проверки, проверить на угон.
		}
	}
}
