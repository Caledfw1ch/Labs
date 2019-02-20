using System;

namespace Carwash.Model
{
	public class Car
	{
		private BodyType _bt;

		public BodyType BodyType
		{
			get { return _bt; }
			set
			{
				if (value == BodyType.Minivan)
					throw new ArgumentException();

				_bt = value;
			}
		}

		/// <summary>
		/// Конструктор класса "Автомобиль". С помощью параметра определяем тип кузова машины,
		/// который впоследствии уже не изменить (т.к. set имеет модификатор доступа private).
		/// </summary>
		public Car(BodyType bodyType)
		{
			BodyType = bodyType;
		}
	}
}
