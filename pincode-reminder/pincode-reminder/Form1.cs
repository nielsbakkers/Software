using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pincode_reminder
{
    public partial class Form1 : Form
    {
        private string gebruikersnaam;
        private string wachtwoord;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelFout.Visible = false;
            labelGoed.Visible = false;
            gebruikersnaam = textBoxGebruikersnaam.Text;
            wachtwoord = textBoxWachtwoord.Text;

            if(gebruikersnaam == "niels")
            {
                if(wachtwoord == "Doemaarwat1")
                {
                    labelGoed.Visible = true;
                }
                else
                {
                    labelFout.Visible = true;
                }
            }
            else
            {
                labelFout.Visible = true;
            }
        }

        private void textBoxWachtwoord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
