using System;
using System.Collections.Generic;
using System.Text;

namespace KPP
{
	class CheckPointStatistics
	{
		public int CarsCount;
		public int TrucksCount;
		public int BusesCount;
		public int SpeedLimitBreakerCount;
		public int CarJackersCount;
		public int AverageSpeed;

		public CheckPointStatistics() { }

		/// <summary>
		/// Конструктор копирования.
		/// </summary>
		/// <param name="source">Образец, по которому создаётся новый экземпляр.</param>
		public CheckPointStatistics(CheckPointStatistics source)
		{
			CarsCount = source.CarsCount;
			TrucksCount = source.TrucksCount;
			BusesCount = source.BusesCount;
			SpeedLimitBreakerCount = source.SpeedLimitBreakerCount;
			CarJackersCount = source.CarJackersCount;
			AverageSpeed = source.AverageSpeed;
		}
	}
}
