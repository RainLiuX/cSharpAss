using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass1 {
    public partial class Form1 : Form {
        private Bitmap[] array;
        private int n, cur;
        public Form1() {
            InitializeComponent();
            array = new Bitmap[5];
            array[0] = Properties.Resources.Chrysanthemum;
            array[2] = Properties.Resources.Desert;
            array[3] = Properties.Resources.Hydrangeas;
            array[4] = Properties.Resources.Jellyfish;
            array[1] = Properties.Resources.Koala;
            n = 5; cur = 0;
            timer1.Start();
        }

        private Bitmap NextPic() {
            return array[cur == n - 1 ? cur = 0 : ++cur];
        }
        private void button1_Click(object sender, EventArgs e) {
            if (timer1.Enabled == true)
                timer1.Stop();
            else
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.pictureBox1.Image = NextPic();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            try {
                int tmp = Convert.ToInt32(this.textBox1.Text);
                this.n = tmp >= 0 && tmp <= 5 ? tmp : n;
                this.cur = 0;
            } catch (FormatException) {
                // then don't change n
                this.cur = 0;
            }
        }

    }
}
