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