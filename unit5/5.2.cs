using System;
public class Program {
	public static void Main() {
		int[] a = new int[99];
		Random r = new Random();
		for (int i = 0; i < 99; i++)
			a[i] = r.Next();
		int min = a[0], max = 0, p = 0, q = 0;
		// 生成随机数在 [0, 2^31-1] 区间内
		for (int i = 0; i < 99; i++)
			if (a[i] < min) {
				min = a[i];
				p = i;
			} else if (a[i] > max) {
				max = a[i];
				q = i;
			}
		Console.WriteLine("max = {0}\tmin = {1}", max, min);
		Console.WriteLine("maxIndex={0}\tminIndex={1}", q, p);
	}
}