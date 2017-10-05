<head>
<style>
.blank{
	text-decoration:underline;
	margin:0 30px 0 30px;
}
.date{
	margin:0 30px 0 30px;
}
#left{
	width:50%;
	float:left;
}
#right{
	width:50%;
	float:left;
}
</style>
</head>
<h1 align="center">西安交通大学实验报告</h1>

<div id="left">
<p><b>课程</b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<span class="blank">
	&nbsp&nbspC#程序设计&nbsp&nbsp
</span></p>

<p>系别&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<span class="blank">
	&nbsp&nbsp&nbsp&nbsp生命学院&nbsp&nbsp&nbsp&nbsp
</span></p>

<p>专业班号<span class="blank">
	&nbsp&nbsp&nbsp&nbsp化生61&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
</span></p>

<p>姓名&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<span class="blank">
	&nbsp&nbsp&nbsp&nbsp刘禹佳&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
</span></p>
</div>

<div id="right">
<p>实验报告日期<span class="date">
	2017年10月04日
</span></p>
<br />
<br />
<br />
<p>学号&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<span class="blank">
	&nbsp&nbsp&nbsp&nbsp2140506119&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
</span></p>
</div>

# 第五章 数组

## 习题2

### 程序实现

```csharp
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
```

### 运行结果

![5.2result](https://github.com/RainLiuX/cSharpAss/blob/master/unit5/5.2.png "runtime results")

## 习题4

### 程序实现

```csharp
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
```
### 运行结果

![5.4result](https://github.com/RainLiuX/cSharpAss/blob/master/unit5/5.4.png "runtime results")

## 习题5

### 程序实现

```csharp
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
```

### 运行结果

![5.5result](https://github.com/RainLiuX/cSharpAss/blob/master/unit5/5.5.png "runtime results")

## 习题6

### 程序实现

```csharp
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
```

### 运行结果

![5.6result](https://github.com/RainLiuX/cSharpAss/blob/master/unit5/5.6.0.png "runtime results")

![5.6result](https://github.com/RainLiuX/cSharpAss/blob/master/unit5/5.6.1.png "runtime results")
