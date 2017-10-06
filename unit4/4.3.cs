using System;
namespace Assignments {
	class Program {
		public static void Main() {
			Console.Write("计算sin(x)的值, 请输入x: ");
			string s = Console.ReadLine();
			double x = Convert.ToDouble(s);
			double r = 0.0, u = x;
			int i = 1;
			while (Math.Abs(u) >= 1E-7) {
				r += u;
				u = (-1) * x * x / (2 * i) / (2 * i + 1) * u;
				i++;
			}
			Console.WriteLine("sin(x) = {0}", r);
		}
	}
}