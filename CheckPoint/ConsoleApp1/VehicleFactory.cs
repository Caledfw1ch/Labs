using System;

namespace KPP
{
	/// <summary>
	/// Фабричный класс. Используется для создания экземпляров автомобилей.
	/// </summary>
	static class VehicleFactory
	{
		private static readonly Random _random = new Random();

		public static Vehicle CreateVehicle(VehicleBodyType bodyType)
		{
			var colorIndex = _random.Next((int) VehicleColor.NoColor);
			var color = (VehicleColor) colorIndex;
			var licensePlateNumber = _random.Next(100, 1000);
			var hasPassenger = _random.Next(2) == 1;

			if (bodyType == VehicleBodyType.Bus)
				return new Bus(color, licensePlateNumber.ToString(), hasPassenger);
			if (bodyType == VehicleBodyType.Car)
				return new Car(color, licensePlateNumber.ToString(), hasPassenger);
			if (bodyType == VehicleBodyType.Truck)
				return new Truck(color, licensePlateNumber.ToString(), hasPassenger);

			throw new ArgumentException("Такой тип автомобиля не производится");
		}
	}
}
