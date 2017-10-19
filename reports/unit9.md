# 第九章 多态、接口和运算符重载

## 目录

1. 第九章 习题6

## 习题6

### 程序实现

```cs
using System;
namespace Assignments {
	public abstract class Employee {
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string SocialSecurityNumber { get; private set;}
		public Employee(string first, string last, string ssn) {
			FirstName = first;
			LastName = last;
			SocialSecurityNumber = ssn;
		}
		public override string ToString() {
			return string.Format("{0} {1}\nSocial security number: {2}",
				FirstName, LastName, SocialSecurityNumber);
		}
		public abstract decimal Earning();
	}
	public class SalariedEmployee: Employee {
		private decimal weeklySalary;
		public decimal WeeklySalary {
			get { return weeklySalary; }
			set { weeklySalary = (value >= 0 ? value : 0); }
		}
		public SalariedEmployee(string first, string last, string ssn, decimal salary)
			: base(first, last, ssn) {
			weeklySalary = salary;
		}
		public override decimal Earning() {
			return weeklySalary;
		}
		public override string ToString() {
			return string.Format("Salaried Employee:{0}\n{1}:{2:C}", base.ToString(), "Weekly salary", weeklySalary);
		}
	}
	public class HourlyEmplyee: Employee {
		private decimal Wage;
		private decimal Hours;
		public HourlyEmplyee(string first, string last, string ssn, decimal HourlyWage, decimal hoursWorked)
			:base(first, last, ssn) {
			Wage = HourlyWage;
			Hours = hoursWorked;
		}
		public decimal wage {
			get { return Wage;}
			set { Wage = (value >= 0) ? value : 0; }
		}
		public decimal hours {
			get { return Hours; }
			set { Hours = ((value >= 0) && (value <= 168)) ? value : 0; }
		}
		public override decimal Earning() {
			if (Hours <= 40) return Wage * Hours;
			else return (40 * Wage) + ((Hours - 40) * Wage * 1.5m);
		}
		public override string ToString() {
			return string.Format("HourlyEmplyee Employee:{0}\n{1}:{2:C}\n{3}:{4:F2}",
				base.ToString(), "Hourly Wage", Wage, "hours Worked", Hours);
		}
	}
	public class CommissionEmployee: Employee {
		private decimal GrossSales;
		private decimal CommissionRate;
		public CommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate)
			:base(first, last, ssn) {
			GrossSales = sales;
			CommissionRate = rate;
		}
		public decimal commissionrate {
			get { return commissionrate; }
			set { CommissionRate = (value > 0 && value < 1) ? value : 0; }
		}
		public decimal grosssales {
			get { return GrossSales; }
			set {GrossSales = (value >= 0) ? value : 0; }
		}
		public override decimal Earning() {
			return CommissionRate * GrossSales;
		}
		public override string ToString() {
			return string.Format("{0}:{1}\n{2}:{3:C}\n{4}:{5:F2}",
				"CommissionEmployee", base.ToString(), "GrossSales", GrossSales, "CommissionRate", CommissionRate);
		}
	}
	public class BasePlusCommissionEmployee: CommissionEmployee {
		public decimal BaseSalary;
		public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
			:base(first, last, ssn, sales, rate) {
			BaseSalary = salary;
		}
		public decimal baseSalary {
			get { return BaseSalary; }
			set { BaseSalary = (value >= 0) ? value : 0; }
		}
		public override decimal Earning() {
			return base.Earning() + BaseSalary;
		}
		public override string ToString() {
			return string.Format("Base-Salaried:{0}\nBase salary:{1:C}", base.ToString(), BaseSalary);
		}
	}
	public class PieceWorker: Employee {
		private decimal Wage;
		private int Pieces;
		public decimal wage {
			get { return Wage; }
			set { Wage = (value >= 0) ? value : 0; }
		}
		public int pieces {
			get { return Pieces; }
			set { Pieces = (value >= 0) ? value : 0; }
		}
		public PieceWorker(string first, string last, string ssn, decimal w, int p)
			:base(first, last, ssn) {
			Wage = w;
			Pieces = p;
		}
		public override decimal Earning() {
			return Wage * Pieces;
		}
		public override string ToString() {
			return string.Format("{0}:{1}\n{2:C}:{3:F2}\n{4}:{5}",
				"Piece worker", base.ToString(), "Wage", Wage, "Pieces", Pieces);
		}
	}
	public class Program {
		public static void Main() {
			Employee[] employee = new Employee[5];
			employee[0] = new SalariedEmployee("Frodo", "Baggins", "111-11-111", 250.00m);
			employee[1] = new HourlyEmplyee("Gandalf", "TheGrey", "222-22-222", 4.30m, 20.00m);
			employee[2] = new CommissionEmployee("Saruman", "TheWhite", "333-33-333", 10000.0m, .50m);
			employee[3] = new BasePlusCommissionEmployee("Bilbo", "Baggins", "444-44-444", 6666.0m, .70m, 1000.0m);
			employee[4] = new PieceWorker("Legolas", "GreenLeaf", "555-55-555", 78.0m, 300);
			foreach (var cur in employee) {
				if (cur is HourlyEmplyee) {
					HourlyEmplyee curHourlyEmployee = (HourlyEmplyee)cur;
					curHourlyEmployee.wage += curHourlyEmployee.wage * 0.20m;
					Console.WriteLine("Give 20% bonus to HourlyEmplyee's wage");
					Console.WriteLine("{0}\nEarning:{1:C}\n", curHourlyEmployee, curHourlyEmployee.Earning());
				} else
					Console.WriteLine("{0}\nEarning:{1:C}\n", cur, cur.Earning());
			}
 		}
	}
}
```

### 运行结果

![9.6result](https://raw.githubusercontent.com/RainLiuX/cSharpAss/master/unit9/9.6.png "runtime results")
