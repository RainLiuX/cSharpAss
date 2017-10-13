# 第七章 面向对象的编程2

## 目录

1. 第七章 习题1
2. 第七章 习题4
3. 第七章 习题6

## 习题1

### 程序实现

```cs
using System;
namespace Assignments {
	class Rectangle {
		private double length, width;
		public double Length {
			get {
				return length;
			}
			set {
				length = (value > 0.0 && value < 20.0) ? value : 1.0;
			}
		}
		public double Width {
			get {
				return width;
			}
			set {
				width = (value > 0.0 && value < 20.0) ? value : 1.0;
			}
		}
		public double Perimeter {
			get {
				return 2 * (width + length);
			}
		}
		public double Area {
			get {
				return width * length;
			}
		}
	}
	class Program {
		public static void Main() {
			Console.Write("请输入长方形的长和宽: ");
			string s = Console.ReadLine();
			string[] ss = s.Split(' ');
			double w = Convert.ToDouble(ss[0]), l = Convert.ToDouble(ss[1]);
			Rectangle rec = new Rectangle();
			rec.Width = w; rec.Length = l;
			Console.Write("周长: {0}, 面积: {1}", rec.Perimeter, rec.Area);
		}
	}
}
```

### 运行结果

![7.1result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit7/7.1.png "runtime results")

## 习题4

### 程序实现

```cs
using System;
namespace Assignments {
	class Time {
		private int hour, minute, second;
		public void SetTime (int h, int m, int s) {
			hour = ((h >= 0 && h < 24) ? h : 0);
			minute = ((m >= 0 && m < 60) ? m : 0);
			second = ((s >= 0 && s < 60) ? s : 0);
		}
		public string ToUnvearsalString() {
			return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
		}
		public override string ToString() {
			return string.Format("{0:D2}:{1:D2}:{2:D2} {3}",
				((hour == 12) ? 12 : hour % 12), minute, second, (hour <= 12 ? "AM" : "PM"));
		}
		public void Tick() {
			if (second == 59) {
				second = 0;
				IncreaseMinute();
			} else second++;                      
		}
		public void IncreaseMinute() {
			if (minute == 59) {
				minute = 0;
				IncreaseHour();
			} else minute++;
		}
		public void IncreaseHour() {
			hour = (hour == 23) ? 0 : hour + 1;
		}
	}
	class Program {
		public static void Main() {
			Console.Write("请输入时间: 时 分 秒 ");
			string s = Console.ReadLine();
			string[] ss = s.Split(' ');
			Time t = new Time();
			t.SetTime(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]), Convert.ToInt32(ss[2]));
			Console.WriteLine("Original 24小时制: {0} 12小时制: {1}", t.ToUnvearsalString(), t);
			t.Tick();
			Console.WriteLine("+1s 24小时制: {0} 12小时制: {1}", t.ToUnvearsalString(), t);
			t.IncreaseMinute();
			Console.WriteLine("+1m 24小时制: {0} 12小时制: {1}", t.ToUnvearsalString(), t);
			t.IncreaseHour();
			Console.WriteLine("+1h 24小时制: {0} 12小时制: {1}", t.ToUnvearsalString(), t);
		}
	}
}
```

### 运行结果

![7.4result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit7/7.4.png "runtime results")

## 习题6

### 程序实现

```cs
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
```

### 运行结果

![7.6result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit7/7.6.png "runtime results")
