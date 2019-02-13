using System.Collections.Generic;
using Carwash.Model;

namespace Carwash.BusinessLogic
{
	/// <summary>
	/// Класс "Автомойка". Ведёт учёт количества помытых машин и выручки от выполненной работы.
	/// Работает на основе перечня цен, который определяется извне через свойство Prices.
	/// </summary>
	public class CarWash
	{
		public Dictionary<BodyType, int> Prices { get; set; }
		// Счётчик машин. Можем читать снаружи, но записывать только из методов этого класса.
		public int CarCounter { get; private set; }
		// Счётчик выручки. Те же правила доступа.
		public int Profit { get; private set; }

		public void WashTheCar(Car car)
		{
			if (Prices == null || Prices.Count == 0)
				return;

			// Читается так: словарь, попытайся дать значение для ключа car.BodyType и, если такой ключ есть, то помести
			// значение в переменную price. Если удачно, то выражение в круглых скобках вернёт true и условный оператор сработает,
			// если же нет (т.е. такого ключа нет в словаре), то и счётчики не поменяются.
			if (Prices.TryGetValue(car.BodyType, out var price))
			{
				Profit += price;

				CarCounter++;
			}

			// Так код выглядел бы, если цены жёстко определены внутри автомойки.
			// В таком варианте теряется возможность менять цены без перепрограммирования кода автомойки.
			//switch (car.BodyType)
			//{
			//	case BodyType.Car:
			//		Profit += 200;
			//		break;
			//	case BodyType.Crossover:
			//		Profit += 250;
			//		break;
			//}
		}
	}
}
