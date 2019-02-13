using System;

namespace SqEqSolver
{
	class Solver
	{
		public Solution Solve(Task t)
		{
			var d = CalculateDiscriminator(t);

			if (d == 0)
				return new Solution
				{
					Type = SolutionType.SingleRoot,
					X1 = -t.B / (2 * t.A)
				};
			else if (d < 0)
				return new Solution
				{
					Type = SolutionType.NoRoots
				};
			else
				return new Solution
				{
					Type = SolutionType.TwoRoots,
					X1 = (-t.B + Math.Sqrt(d)) / (2 * t.A),
					X2 = (-t.B - Math.Sqrt(d)) / (2 * t.A)
				};
		}

		private double CalculateDiscriminator(Task t)
		{
			return t.B * t.B - 4 * t.A * t.C;
		}
	}
}
