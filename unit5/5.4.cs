using System;
namespace Assignment {
	public class Program {
		public static void Main() {
			const int TOTAL = 3600;
			int[] times = new int[13];
			Random dice = new Random();
			for (int i = 0; i < TOTAL; i++)
				times[(dice.Next() % 6 + 1) + (dice.Next() % 6 + 1)]++;
			double[] fre = new double[13];
			for (int i = 2; i < 13; i++)
				fre[i] = Convert.ToDouble(times[i]) / TOTAL;
			double[] pos = new double[13];
			for (int i = 1; i < 7; i++)
				pos[i + 1] = pos[13 -i] = i / 36.0;
			// output
			printHr();
			Console.Write("概率:\t");
			for (int i = 2; i < 13; i++)
				Console.Write("{0:f3}\t|", pos[i]);
			printHr();
			Console.Write("频率:\t");
			for (int i = 2; i < 13; i++)
				Console.Write("{0:f3}\t|", fre[i]);
			printHr();
			Console.Write("差值:\t");
			for (int i = 2; i < 13; i++)
				Console.Write("{0:f3}\t|", pos[i] - fre[i]);
			printHr();
		}
		public static void printHr() {
			Console.WriteLine();
			for (int i = 0; i < 12; i++)
				Console.Write("--------");
			Console.WriteLine();
		}
	}
}