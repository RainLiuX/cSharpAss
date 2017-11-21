using System;
using System.Windows.Forms;

namespace ass2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            paraLeft = 0.0; paraRight = 0.0; result = 0.0;
            sign = true;
        }

        private double paraLeft;
        private double paraRight;
        private double result;
        private bool sign;

        private void button_Click(object sender, EventArgs e) {
            labelTop.Text = labelTop.Text + ((Button)sender).Text;
        }

        private void sign_Click(object sender, EventArgs e) {
            try {
                paraLeft = Convert.ToDouble(labelTop.Text);
                labelTop.Text = "";
                labelBottom.Text = paraLeft.ToString();
                sign = ((Button)sender).Text[0] == '+';
                labelBottom.Text = labelBottom.Text + (sign ? "+" : "*");
            } catch (FormatException) {
                labelTop.Text = "";
                paraLeft = 0.0;
            }
        }

        private void button15_Click(object sender, EventArgs e) {
            try {
                paraRight = Convert.ToDouble(labelTop.Text);
                labelTop.Text = "";
                labelBottom.Text = labelBottom.Text + paraRight.ToString();
                result = sign ? paraLeft + paraRight : paraLeft * paraRight;
                labelBottom.Text = labelBottom.Text + "=" + result.ToString();
            } catch (FormatException) {
                labelTop.Text = "";
                paraRight = 0.0;
            }
        }

        private void button14_Click(object sender, EventArgs e) {
            labelTop.Text = labelBottom.Text = "";
            paraLeft = paraRight = result = 0.0;
            sign = true;
        }
    }
}
