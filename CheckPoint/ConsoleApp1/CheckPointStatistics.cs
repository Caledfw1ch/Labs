namespace KPP
{
	class CheckPointStatistics
	{
		public int CarsCount;
		public int TrucksCount;
		public int BusesCount;
		public int SpeedLimitBreakerCount;
		public int CarJackersCount;
		public long SpeedSum;

		public double AverageSpeed
		{
			get
			{
				return SpeedSum / TotalVehicleCount;
			}
		}

		public int TotalVehicleCount
		{
			get
			{
				return CarsCount + BusesCount + TrucksCount;
			}
		}

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
		}
	}
}
