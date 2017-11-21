using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            char[] cstr = textBox1.Text.ToCharArray();
            for (int i = 0; i < cstr.Length; i++) {
                if (cstr[i] >= 'a' && cstr[i] <= 'z')
                    cstr[i] = (char)(cstr[i] - 'a' + 'A');
                else if (cstr[i] >= 'A' && cstr[i] <= 'Z')
                    cstr[i] = (char)(cstr[i] - 'A' + 'a');
            }
            textBox2.Text = new String(cstr);
        }
    }
}
