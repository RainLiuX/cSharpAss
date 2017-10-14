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