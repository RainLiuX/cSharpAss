using System;
namespace Assignments {
	public class program {
		public static void Main() {
			double r = 0.0, u = 1.0;
			int n = -1;
			while (Math.Abs(u) > 1E-9)
				r += u *= (-1.0) * n / (n += 2);
			Console.WriteLine("The approximaty of PI: {0:f8}", 4 * r);
		}
	}
}