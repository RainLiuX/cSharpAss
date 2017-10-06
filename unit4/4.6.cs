using System;
public class Program {
	public static void Main() {
		Console.Write("Please enter a & n: ");
		string s = Console.ReadLine();
		string[] ss = s.Split(' ');
		int a = Convert.ToInt32(ss[0]), n = Convert.ToInt32(ss[1]), r = 0, u = a;
		while(Convert.ToBoolean(n--)) {
			r += u;
			u = u * 10 + a;
		}
		Console.WriteLine("output: {0}", r);
	}
}