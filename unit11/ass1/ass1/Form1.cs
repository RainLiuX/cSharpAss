using System;
using System.Drawing;
using System.Windows.Forms;

namespace ass1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Size = new Size(340, 295);
            this.sunWidth = 15;
            this.DoubleBuffered = true;
        }

        private float sunWidth;

        private void Form1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            SolidBrush gb = new SolidBrush(Color.FromArgb(0, 255, 0));
            SolidBrush bb = new SolidBrush(Color.Blue);
            Pen bp = new Pen(Color.Black, 2.5f);
            g.FillRectangle(bb, 0, 0, 340, 196);
            g.FillRectangle(new SolidBrush(Color.White), 80, 161, 70, 35);
            g.DrawRectangle(bp, 80, 161, 70, 35);
            g.FillRectangle(new SolidBrush(Color.FromArgb(87, 86, 94)), 87.5f, 168, 14, 28);
            g.DrawRectangle(bp, 121, 169, 8, 8);
            g.DrawRectangle(bp, 121 + 8, 169, 8, 8);
            g.DrawRectangle(bp, 121, 169 + 8, 8, 8);
            g.DrawRectangle(bp, 121 + 8, 169 + 8, 8, 8);
            g.FillRectangle(gb, 0, 196, 340, 99);
            // draw sun
            g.FillEllipse(new SolidBrush(Color.Red), sunWidth, 24, 70, 70);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (sunWidth < 250)
                sunWidth = sunWidth + 10;
            this.Invalidate();
        }

        private void Form1_Click(object sender, EventArgs e) {
            timer1.Start();
        }
    }
}
