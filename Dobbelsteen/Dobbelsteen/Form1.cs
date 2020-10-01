using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dobbelsteen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Wanneer de applicatie wordt gestart worden de dobbelstenen op niet zichtbaar gezet
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Wanneer er op de button wordt geklikt worden eerste alle dobbelstenen op ontzichtbaar gezet
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            
            //De random class wordt geimporteerd
            Random rnd = new Random();
            //Er wordt een random nummer tussen 1 en 7 gekozen
            int number = rnd.Next(1, 7);
            //in de switch wordt het random nummer meegenomen
            switch (number)
            {
                //Wanneer het random nummer 1 is wordt dobbelsteen 1 weergegeven
                case 1:
                    pictureBox1.Visible = true;
                    break;
                //Wanneer het random nummer 2 is wordt dobbelsteen 2 weergegeven
                case 2:
                    pictureBox2.Visible = true;
                    break;
                //Wanneer het random nummer 3 is wordt dobbelsteen 3 weergegeven
                case 3:
                    pictureBox3.Visible = true;
                    break;
                //Wanneer het random nummer 4 is wordt dobbelsteen 4 weergegeven
                case 4:
                    pictureBox4.Visible = true;
                    break;
                //Wanneer het random nummer 5 is wordt dobbelsteen 5 weergegeven
                case 5:
                    pictureBox5.Visible = true;
                    break;
                //Wanneer het random nummer 6 is wordt dobbelsteen 6 weergegeven
                case 6:
                    pictureBox6.Visible = true;
                    break;
            }
        }
    }
}
