using System;
namespace Assignments {
	class Rational {
		private int numerator, denomenator;
		private bool sign; //positive false, negtive true
		private void reduction() {
			int tmp = gcd(numerator, denomenator);
			numerator /= tmp; denomenator /= tmp;
		}
		private static int gcd(int a, int b) {
			return b == 0 ? a : gcd(b, a % b);
		}
		public Rational Negtive() {
			Rational t = new Rational(numerator, denomenator);
			t.sign = !sign;
			return t;
		}
		public Rational Inverse() {
			Rational t = new Rational(denomenator, numerator);
			t.sign = sign;
			return t;
		}
		public Rational() {
			numerator = 0;
			denomenator = 1;
			sign = false;
		}
		public Rational(int n, int d = 1) {
			numerator = n;
			denomenator = d;
			sign = numerator * denomenator >= 0;
			numerator = Math.Abs(numerator);
			denomenator = Math.Abs(denomenator);
			reduction();
		}
		public Rational Plus(Rational r) {
			Rational t = new Rational();
			t.numerator = (sign == true ? -1 : 1) * numerator * r.denomenator +
				(r.sign == true ? -1 : 1) * r.numerator * denomenator;
			t.denomenator = denomenator * r.denomenator;
			t.sign = t.numerator >= 0;
			t.numerator = Math.Abs(t.numerator);
			t.reduction();
			return t;
		}
		public Rational Minus(Rational r) {
			return Plus(r.Negtive());
		}
		public Rational Multiply(Rational r) {
			Rational t = new Rational();
			t.numerator = numerator * r.numerator;
			t.denomenator = denomenator * r.denomenator;
			t.sign = sign ^ r.sign;
			t.reduction();
			return t;
		}
		public Rational Divide(Rational r) {
			return Multiply(r.Inverse());
		}
		public override string ToString() {
			return string.Format("{0}{1}/{2}", sign == false ? "" : "-", numerator, denomenator);
		}
		public string ToNumericString() {
			return string.Format("{0:F3}", (sign == false ? 1.0 : -1.0) * numerator / denomenator);
		}
	}
	class Program {
		public static void Main() {
			Console.Write("请输入两个分数形如 a/b: ");
			string s = Console.ReadLine();
			string[] ss = s.Split(' ');
			Rational r1, r2;
			string[] rr1 = ss[0].Split('/');
			r1 = new Rational(Convert.ToInt32(rr1[0]), Convert.ToInt32(rr1[1]));
			string[] rr2 = ss[1].Split('/');
			r2 = new Rational(Convert.ToInt32(rr2[0]), Convert.ToInt32(rr2[1]));
			Console.WriteLine("输入的两个分数为: {0}({2}), {1}({3})", r1, r2, r1.ToNumericString(), r2.ToNumericString());
			Console.WriteLine("和为: {0}({1})", r1.Plus(r2), r1.Plus(r2).ToNumericString());
			Console.WriteLine("差为: {0}({1})", r1.Minus(r2), r1.Minus(r2).ToNumericString());
			Console.WriteLine("积为: {0}({1})", r1.Multiply(r2), r1.Multiply(r2).ToNumericString());
			Console.WriteLine("商为: {0}({1})", r1.Divide(r2), r1.Divide(r2).ToNumericString());
		}
	}
}