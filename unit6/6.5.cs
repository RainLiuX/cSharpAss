using System;
namespace Assignments {
	class Program {
		private static double power(double baseNum, int expoent) {
			return expoent == 1 ? baseNum : baseNum * power(baseNum, expoent - 1);
		}
		public static void Main() {
			Console.Write("请输入底数，指数: ");
			string s = Console.ReadLine();
			string[] ss = s.Split(' ');
			Console.WriteLine("幂为: {0:F3}",
				power(Convert.ToDouble(ss[0]), Convert.ToInt32(ss[1])));
		}
	}
}