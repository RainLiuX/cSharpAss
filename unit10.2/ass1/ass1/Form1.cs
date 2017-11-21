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
        public Form1() {
            InitializeComponent();
            data = new Data();
        }

        private Data data;

        private void button1_Click(object sender, EventArgs e) {
            bool ok = true;
            ok = ok && (nameText.Text.Length > 0);  data.Name = nameText.Text;
            ok = ok && (ageText.Text.Length > 0);
            try {
                data.Age = Convert.ToInt32(ageText.Text);
            } catch (FormatException) {
                ok = false;
            }
            ok = ok && (maleRadio.Checked || feRadio.Checked);
            if (maleRadio.Checked) data.Gender = true;
            else data.Gender = false;
            if (ok = ok && (degreeCombo.SelectedIndex >= 0))
                data.Degree = degreeCombo.SelectedItem.ToString();
            if (ok = ok && (departList.SelectedIndex >= 0))
                data.Depart = departList.SelectedItem.ToString();
            if (ok) showList.Items.Add(data.ToString());
        }

        private void button2_Click(object sender, EventArgs e) {
            if (showList.SelectedIndex >= 0) {
                showList.Items.Remove(showList.SelectedItem);
            }
        }
    }
    public class Data: Object {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }    // true male, false female
        public string Degree { get; set; }
        public string Depart { get; set; }
        public override string ToString() {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}", Name, Age, Gender ? "男" : "女", Degree, Depart);
        }
    }
}
