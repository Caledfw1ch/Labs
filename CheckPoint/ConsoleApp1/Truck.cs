namespace KPP
{
	class Truck : Vehicle
	{
		public override int Speed
		{
			get { return _random.Next(80, 101); }
		}

		public Truck(VehicleColor color, string licensePlateNumber, bool hasPassenger)
			: base(color, licensePlateNumber, hasPassenger)
		{
			BodyType = VehicleBodyType.Truck;
		}
	}
}
