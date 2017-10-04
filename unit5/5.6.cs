using System;
namespace Assignments {
	public class Program {
		public static void Main() {
			// Initiate memory
			const int EMPLOYEE = 4, PRODUCT = 5, DAY = 30;
			int[,,] input = new int[DAY, PRODUCT, EMPLOYEE];
			int[,] output = new int[PRODUCT + 1, EMPLOYEE + 1];
			// Generate input
			Random r = new Random();
			for (int i = 0; i < DAY; i++)
				for (int j = 0; j < PRODUCT; j++)
					for (int k = 0; k < EMPLOYEE; k++)
						// Each employee sell 1-20 each product per day
						input[i, j, k] = r.Next() % 21;
			for (int i = 0; i < DAY; i++) {
				Console.WriteLine("Day {0}", i + 1);
				Console.WriteLine("\t\t1\t2\t3\t4");
				for (int j = 0; j < PRODUCT; j++) {
					Console.Write("product{0}\t", j + 1);
					for (int k = 0; k < EMPLOYEE; k++)
						Console.Write("{0}\t", input[i, j, k]);
					Console.WriteLine();
				}
				Console.WriteLine();
			}
			// Sum up
			for (int i = 0; i < DAY; i++)
				for (int j = 0; j < PRODUCT; j++)
					for (int k = 0; k < EMPLOYEE; k++)
						output[j,k] += input[i,j,k];
			for (int i =0; i < PRODUCT; i++)
				for (int j = 0; j < EMPLOYEE; j++)
					output[i, EMPLOYEE] += output[i,j];
			for (int i =0; i < EMPLOYEE; i++)
				for (int j = 0; j < PRODUCT; j++)
					output[PRODUCT, j] += output[i,j];
			Console.WriteLine("Total:");
			Console.WriteLine("\t\t1\t2\t3\t4\ttotal");
			for (int j = 0; j < PRODUCT; j++) {
				Console.Write("product{0}\t", j + 1);
				for (int k = 0; k < EMPLOYEE + 1; k++)
					Console.Write("{0}\t", output[j, k]);
				Console.WriteLine();
			}
			Console.Write("Total\t\t");
			for (int k = 0; k < EMPLOYEE; k++)
				Console.Write("{0}\t", output[PRODUCT, k]);
		}
	}
}