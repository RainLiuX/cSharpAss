# 第六章 方法

## 目录

1. 第六章 习题4
2. 第六章 习题5

## 习题4

### 程序实现

```cs
using System;
namespace Assignments {
	public class Complex {
		public double Real {get; set;}
		public double Imagine{get; set;}
		public Complex() {
			Real = Imagine = 0.0;
		}
		public Complex(double r, double i = 0.0) {
			Real = r;
			Imagine = i;
		}
		public override string ToString() {
			if (Math.Abs(Imagine) < 1e-7)
				return Real.ToString("F3");
			else if (Math.Abs(Imagine) > 1e-7 && Math.Abs(Real) < 1e-7)
				return Imagine.ToString("F3") + "i";
			else return Imagine > 0 ? Real.ToString("F3") + "+" + Imagine.ToString("F3") + "i" :
				Real.ToString("F3") + "-" + (-Imagine).ToString("F3") + "i";
		}
	}
	public class Equation {
		private double a, b, c;
		// a*x^2+b*x+c=0
		public Equation(double _a, double _b, double _c) {
			a = _a; b = _b; c = _c;
		}
		public void Solve(out Complex ret1, out Complex ret2) {
			double delta = b * b - 4 * a * c;
			ret1 = new Complex(); ret2 = new Complex();
			if (delta > -1e-7) {
				ret1.Real = (-b + Math.Sqrt(delta)) / (2 * a);
				ret2.Real = (-b - Math.Sqrt(delta)) / (2 * a);
			} else {
				ret1.Imagine = Math.Sqrt(-delta) / (2 * a);
				ret2.Imagine = -Math.Sqrt(-delta) / (2 * a);
				ret1.Real = ret2.Real = -b / (2 * a);
			}
		}
	}
	public class Program {
		public static void Main() {
			Console.Write("输入a,b,c (一元二次方程形如ax^2+bx+c=0): ");
			string s = Console.ReadLine();
			string[] ss = s.Split(' ');
			double a = Convert.ToDouble(ss[0]);
			double b = Convert.ToDouble(ss[1]);
			double c = Convert.ToDouble(ss[2]);
			Equation e = new Equation(a, b, c);
			Complex ret1, ret2;
			e.Solve(out ret1, out ret2);
			Console.Write("其解为: ");
			Console.Write("{0} {1}", ret1, ret2);
		}
	}
}
```

### 运行结果

![6.4result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit6/6.4.png "runtime results")

## 习题5

### 程序实现

```cs
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
```

### 运行结果

![6.5result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit6/6.5.png "runtime results")
