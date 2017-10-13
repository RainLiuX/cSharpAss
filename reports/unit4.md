# 第四章 控制结构 

## 目录

1. 第四章 习题2
2. 第四章 习题3
3. 第四章 习题4
4. 第四章 习题5
5. 第四章 习题6

## 习题2

### 程序实现

```cs
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
```

### 运行结果

![4.2result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit4/4.2.png "runtime results")

## 习题3

### 程序实现

```cs
using System;
namespace Assignments {
	class Program {
		public static void Main() {
			Console.Write("计算sin(x)的值, 请输入x: ");
			string s = Console.ReadLine();
			double x = Convert.ToDouble(s);
			double r = 0.0, u = x;
			int i = 1;
			while (Math.Abs(u) >= 1E-7) {
				r += u;
				u = (-1) * x * x / (2 * i) / (2 * i + 1) * u;
				i++;
			}
			Console.WriteLine("sin(x) = {0}", r);
		}
	}
}
```

### 运行结果

![4.3result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit4/4.3.png "runtime results")

## 习题4

### 程序实现

```cs
using System;
namespace Assignments {
	public class program {
		public static void Main() {
			double r = 0.0, u = 1.0;
			int n = -1;
			while (Math.Abs(u) > 1E-9)
				r += u *= (-1.0) * n / (n += 2);
			Console.WriteLine("The approximaty of PI: {0:f8}", 4 * r);
		}
	}
}
```

### 运行结果

![4.4result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit4/4.4.png "runtime results")

## 习题5

### 程序实现

```cs
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
```

### 运行结果

![4.5result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit4/4.5.png "runtime results")

## 习题6

### 程序实现

```cs
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
```

### 运行结果

![4.6result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit4/4.6.png "runtime results")
