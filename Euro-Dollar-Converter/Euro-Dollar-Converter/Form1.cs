using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euro_Dollar_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal Euro = Convert.ToDecimal(textBox1.Text);
            decimal Koers = numericUpDown1.Value;

            decimal Dollar = Euro * Koers;

            textBox2.Text = Dollar.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Dollar = Convert.ToDecimal(textBox2.Text);
            decimal Koers = numericUpDown1.Value;

            decimal Euro = Dollar / Koers;

            textBox1.Text = Euro.ToString();
        }
    }
}
