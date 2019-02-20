using System;
using System.Collections.Generic;
using Carwash.Model;
using AltCarWash = Carwash.BusinessLogic.CarWash;  // Псевдоним

namespace CarWasher
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Создаём экземпляр автомойки...
			var cw1 = new AltCarWash();
			// ... и несколько машин с разными типами кузова.
			var c1 = new Car(BodyType.Car);
			var c2 = new Car(BodyType.Crossover);
			var c3 = new Car(BodyType.Minivan);
			// Создаём экземпляр словаря (Dictionary) для хранения соответствия типа кузова цене.
			var priceList = new Dictionary<BodyType, int>();
			
			// Наполняем словарь.
			priceList.Add(BodyType.Car, 200);
			priceList.Add(BodyType.Crossover, 250);
			
			// Говорим автомойке цены, по которым она работает.
			cw1.Prices = priceList;

			// Моем машины.
			cw1.WashTheCar(c1);
			cw1.WashTheCar(c2);
			cw1.WashTheCar(c3);
			
			Console.WriteLine($"Машин помыто: {cw1.CarCounter}");
			Console.WriteLine($"Выручка: {cw1.Profit}");
			Console.ReadKey();
		}
	}
}
