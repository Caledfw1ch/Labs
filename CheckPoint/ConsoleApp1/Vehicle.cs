namespace KPP
{
	class Vehicle
	{
		public VehicleColor Color { get; protected set; }
		public VehicleBodyType BodyType { get; protected set; }
		public string LicensePlateNumber { get; protected set; }
		public int Speed { get; protected set; }
		public bool HasPassenger { get; protected set; }

		public Vehicle(VehicleColor color)
		{
			Color = color;
		}
	}
}
