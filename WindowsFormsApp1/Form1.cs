using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = int.Parse(textBox1.Text);
            double b = int.Parse(textBox2.Text);

            double soucet = a + b;
            double rozdil = a - b;
            double soucin = a * b;
            





            MessageBox.Show("Vysledek je " + soucet);
            MessageBox.Show("Vysledek je " + rozdil);
            MessageBox.Show("Vysledek je " + soucin);

        }
    }
}
