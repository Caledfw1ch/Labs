namespace KPP
{
	class Bus : Vehicle
	{
		public override int Speed
		{
			get { return _random.Next(60, 91); }
		}

		public Bus(VehicleColor color, string licensePlateNumber, bool hasPassenger)
			: base(color, licensePlateNumber, hasPassenger)
		{
			BodyType = VehicleBodyType.Bus;
		}
	}
}
