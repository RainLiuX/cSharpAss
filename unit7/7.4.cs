using System;
namespace Assignments {
	class Time {
		private int hour, minute, second;
		public void SetTime (int h, int m, int s) {
			hour = ((h >= 0 && h < 24) ? h : 0);
			minute = ((m >= 0 && m < 60) ? m : 0);
			second = ((s >= 0 && s < 60) ? s : 0);
		}
		public string ToUnvearsalString() {
			return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
		}
		public override string ToString() {
			return string.Format("{0:D2}:{1:D2}:{2:D2} {3}",
				((hour == 12) ? 12 : hour % 12), minute, second, (hour <= 12 ? "AM" : "PM"));
		}
		public void Tick() {
			if (second == 59) {
				second = 0;
				IncreaseMinute();
			} else second++;                      
		}
		public void IncreaseMinute() {
			if (minute == 59) {
				minute = 0;
				IncreaseHour();
			} else minute++;
		}
		public void IncreaseHour() {
			hour = (hour == 23) ? 0 : hour + 1;
		}
	}
	class Program {
		public static void Main() {
			Console.Write("请输入时间: 时 分 秒 ");
			string s = Console.ReadLine();
			string[] ss = s.Split(' ');
			Time t = new Time();
			t.SetTime(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]), Convert.ToInt32(ss[2]));
			Console.WriteLine("Original 24小时制: {0} 12小时制: {1}", t.ToUnvearsalString(), t);
			t.Tick();
			Console.WriteLine("+1s 24小时制: {0} 12小时制: {1}", t.ToUnvearsalString(), t);
			t.IncreaseMinute();
			Console.WriteLine("+1m 24小时制: {0} 12小时制: {1}", t.ToUnvearsalString(), t);
			t.IncreaseHour();
			Console.WriteLine("+1h 24小时制: {0} 12小时制: {1}", t.ToUnvearsalString(), t);
		}
	}
}