# 第八章 继承

## 目录

1. 第八章 习题4
2. 第八章 习题5
3. 第八章 习题8

## 习题4

### 程序实现

```cs
using System;
namespace Assignments {
	class Vehicle {
		protected int wheels;
		protected double weight;
		public Vehicle(int w, double m) {
			wheels = w; weight = m;
		}
		public override string ToString() {
			return string.Format("A Vehicle\nwheels: {0}, weight: {1:F3}t\n", wheels, weight);
		}
	}
	class Car: Vehicle {
		private int passenger_load;
		public Car(int w, double m, int p): base(w, m) {
			passenger_load = p;
		}
		public override string ToString() {
			return string.Format("A Car\nwheels: {0}, weight: {1:F3}t, " +
				"passenger_load: {2}\n", wheels, weight, passenger_load);
		}
	}
	class Truck: Vehicle {
		private int passenger_load;
		private double payload;
		public Truck(int w, double m, int p, double l): base(w, m) {
			passenger_load = p;
			payload = l;
		}
		public override string ToString() {
			return string.Format("A Truck\nwheels: {0}, weight: {1:F3}t, " +
				"passenger_load: {2}, payload: {3:F3}t\n", wheels, weight, passenger_load, payload);
		}
	}
	class Program {
		public static void Main() {
			Car c = new Car(4, 1.5, 6);
			Truck t = new Truck(6, 3.4, 3, 5.0);
			Console.Write("{0}{1}", c, t);
		}
	}
}
```

### 运行结果

![8.4result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit8/8.4.png "runtime results")

## 习题5

### 程序实现

```cs
using System;
namespace Assignments {
	abstract class Shape {
		public abstract double Area();
	}
	class Ellipse: Shape {
		private double a, b;
		public Ellipse(double _a, double _b) {
			a = _a; b = _b;
		}
		public override double Area() {
			return Math.PI * a * b;
		}
	}
	class Program {
		public static void Main() {
			Ellipse e = new Ellipse(3.4, 5.6);
			Console.WriteLine("椭圆面积为: {0:F3}", e.Area());
		}
	}
}
```

### 运行结果

![8.5result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit8/8.5.png "runtime results")

## 习题8

### 程序实现

```cs
using System;
namespace Assignments {
	abstract class Base {
		public string Name{get; set;}
		public string Occupation{get; set;}
		public Base(string n, string o) {
			Name = n; Occupation = o;
		}
		public abstract bool IsGood();
	}
	class Student: Base {
		private double grade;
		public Student(string n, string o, double g): base(n, o) {
			grade = g;
		}
		public override bool IsGood() {
			return grade > 90;
		}
	}
	class Teacher: Base {
		private int paper;
		public Teacher(string n, string o, int p): base(n, o) {
			paper = p;
		}
		public override bool IsGood() {
			return paper > 3;
		}
	}
	class Program {
		public static void Main() {
			Base[] b = new Base[5];
			b[0] = new Student("Mark", "student", 89);
			b[1] = new Student("James", "student", 99);
			b[2] = new Teacher("Zuckerberg", "teacher", 10);
			b[3] = new Student("Tom", "student", 76);
			b[4] = new Teacher("Jiang", "teacher", 3);
			for (int i = 0; i < 5; i++)
				Console.WriteLine("{0}{1}优秀学生/教师", b[i].Name, b[i].IsGood() ? "获得" : "未获得");
		}
	}
}
```

### 运行结果

![8.8result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit8/8.8.png "runtime results")
