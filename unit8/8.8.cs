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