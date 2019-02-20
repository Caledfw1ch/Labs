namespace KPP
{
	class Car : Vehicle
	{
		public override int Speed
		{
			get { return _random.Next(100, 141); }
		}

		public Car(VehicleColor color, string licensePlateNumber, bool hasPassenger)
			: base(color, licensePlateNumber, hasPassenger)
		{
			BodyType = VehicleBodyType.Car;
		}
	}
}
