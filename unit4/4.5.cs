using System;
namespace Assignments {
	public class Program {
		public static void Main() {
			int r = 1, n = 9;
			while (Convert.ToBoolean(n--))
				r = (r + 1) * 2;
			Console.WriteLine("第一天猴子吃的桃子数为: {0}", r + 2);
		}
	}
}