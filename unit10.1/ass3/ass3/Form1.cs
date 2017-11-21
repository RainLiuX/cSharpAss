using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            time = 0;
        }
        private int time;
        private void timer1_Tick(object sender, EventArgs e) {
            time++;
            int hour = time / 3600;
            int minute = (time % 3600) / 60;
            int second = time % 60;
            String str = string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
            label2.Text = str;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (timer1.Enabled == false)
                timer1.Start();
            else
                timer1.Stop();
        }
    }
}
