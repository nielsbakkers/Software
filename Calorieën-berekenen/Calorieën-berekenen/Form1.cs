using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorieën_berekenen
{
    public partial class Form1 : Form
    {
        private int geslacht;
        private int levensstijl;
        private int leeftijd;
        private int calo;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                geslacht = 2500;
            }
            else if (radioButton2.Checked)
            {
                geslacht = 2000;
            };
            if (radioButton3.Checked)
            {
                levensstijl = 100;
            } else if (radioButton4.Checked)
            {
                levensstijl = 90;
            };
            leeftijd = Convert.ToInt32(textBox1.Text);
            if(leeftijd > 50)
            {
                calo = geslacht - 500;
            }else if (leeftijd < 12)
            {
                calo = geslacht - 180;
            }
            else
            {
                calo = geslacht;
            }
            int uitkomst = calo / 100 * levensstijl;

            label3.Text = uitkomst.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
