using System;
namespace Assignments {
	abstract class Shape {
		public abstract double Area();
	}
	class Ellipse: Shape {
		private double a, b;
		private double x, y;
		public Ellipse(double _a, double _b, double _x, double _y) {
			a = _a; b = _b;
			x = _x; y = _y;
		}
		public override double Area() {
			return Math.PI * a * b;
		}
	}
	class Program {
		public static void Main() {
			Ellipse e = new Ellipse(3.4, 5.6, 0.0, 0.0);
			Console.WriteLine("椭圆面积为: {0:F3}", e.Area());
		}
	}
}