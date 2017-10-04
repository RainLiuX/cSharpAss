using System;
namespace Assignments {
	public class Program {
		public static void Main() {
			Console.Write("Input: ");
			string str = Console.ReadLine();
			string[] ss = str.Split(' ');
			double[] legal = new double[ss.Length + 1];
			int n = 0;
			for (int i = 0; i < ss.Length; i++) {
				int j = 1;
				if (Convert.ToDouble(ss[i]) > 100 || Convert.ToDouble(ss[i]) < 10)
					continue;
				for (; j <= n; j++)
					if (Convert.ToDouble(ss[i]) == legal[j]) break;
				if (j == n + 1)
					legal[++n] = Convert.ToDouble(ss[i]);
			}
			Console.Write("Output: ");
			for (int i = 1; i <= n; i++)
				Console.Write("{0}\t", legal[i]);
		}
	}
}