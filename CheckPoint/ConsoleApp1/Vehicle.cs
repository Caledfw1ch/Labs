using System;

namespace KPP
{
	class Vehicle
	{
		protected readonly Random _random;

		public VehicleColor Color { get; protected set; }
		public VehicleBodyType BodyType { get; protected set; }
		public string LicensePlateNumber { get; protected set; }

		public virtual int Speed
		{
			get { return -1; }
		}

		public bool HasPassenger { get; protected set; }

		public Vehicle(VehicleColor color, string licensePlateNumber, bool hasPassenger)
		{
			_random = new Random();
			Color = color;
			LicensePlateNumber = licensePlateNumber;
			HasPassenger = hasPassenger;
		}
	}
}
