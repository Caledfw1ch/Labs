using System;
using System.Runtime.CompilerServices;

namespace SqEqSolver
{
	public class Point
	{
		private double _x;

		public double X
		{
			get { return _x; }
			set
			{
				if (value == 13)
					throw new ArgumentException();

				_x = value;
			}
		}

		public double Y { get; set; }

		/// <summary>
		/// Конструктор с параметрами по умолчанию.
		/// </summary>
		public Point(double x = 0, double y = 0)
		{
			X = x;
			Y = y;
		}

		public double GetDistanceTo(Point p)
		{
			return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
		}

		public override string ToString()
		{
			//return "x=" + X + ", y=" + Y;
			//return string.Format("x={0}, y={1}", X, Y);
			return $"x={X:0.00}, y={Y:0.00}";
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				//ShowPointExample();
				//ShowSqEqSolutionExample();
				ShowSqEqSolutionOopExample();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			Console.ReadKey();
		}

		private static void ShowPointExample()
		{
			var p1 = new Point(1, 10);
			var p2 = new Point();

			p1.X = 13; // p1._setX(13);

			Console.WriteLine(p1.GetDistanceTo(p2));
			Console.WriteLine(p1);
		}

		private static void ShowSqEqSolutionExample()
		{
			double x1 = 0, x2 = x1;
			var res = SolveSqareEquation(1, 4, 1, ref x1, ref x2);

			if (res == 0)
				Console.WriteLine("Корней нет");
			else if (res == 1)
				Console.WriteLine($"x1={x1}");
			else
			{
				Console.WriteLine($"x1={x1}");
				Console.WriteLine($"x2={x2}");
			}
		}

		private static void ReadCoefficient(string coefficientName, out double value)
		{
			do
				Console.WriteLine($"Введите {coefficientName}: ");
			while (!double.TryParse(Console.ReadLine(), out value));
		}

		private static void ShowSqEqSolutionOopExample()
		{
			double a, b, c;

			ReadCoefficient("a", out a);
			ReadCoefficient("b", out b);
			ReadCoefficient("c", out c);

			var task = new Task(a, b, c);
			var solver = new Solver();
			var solution = solver.Solve(task);

			if (solution.Type == SolutionType.NoRoots)
				Console.WriteLine("Решений нет");
			else if (solution.Type == SolutionType.SingleRoot)
				Console.WriteLine($"x1={solution.X1}");
			else
				Console.WriteLine($"x1={solution.X1}\nx2={solution.X2}");
		}

		private static double CalculateDiscriminator(double a, double b, double c)
		{
			return b * b - 4 * a * c;
		}

		private static int SolveSqareEquation(double a, double b,
			double c, ref double x1, ref double x2)
		{
			double d = CalculateDiscriminator(a, b, c);

			if (d < 0) return 0;
			else if (d == 0 || d == 1)
			{
				x1 = x2 = b / 2 * a;
				return 1;
			}
			else
			{
				x1 = (b + Math.Sqrt(d)) / (2 * a);
				x2 = (b - Math.Sqrt(d)) / (2 * a);
				return 2;
			}
		}
	}
}
