using System;
namespace Assignment {
	class Program {
		public static void Main() {
			Console.Write("计算斐波那契数列的第n项: ");
			string s = Console.ReadLine();
			int n = Convert.ToInt32(s);
			int[] a = new int[n + 1];
			a[1] = a[2] = 1;
			int sum = 2;
			for (int i = 3; i <= n; i++) {
				a[i] = a[i - 1] + a[i - 2];
				sum += a[i];
			}
			Console.WriteLine("斐波那契数列的第n项为: {0}, 和为{1}", a[n], sum);
		}
	}
}