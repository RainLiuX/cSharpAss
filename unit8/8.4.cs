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