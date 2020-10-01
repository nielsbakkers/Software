using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bloeddruk_meten
{
    public partial class bloedDrukmeter : Form
    {
        public bloedDrukmeter()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckInputs();
            CheckForEasterEgg();
            CheckPatient();
            CheckBloeddruk();
            CheckGender();
            Info();
        }

        private void CheckInputs()
        {
            if(Leeftijd() == 0)
            {
                MessageBox.Show("Geef een leeftijd op!");
            }
            else if (rbMan.Checked == false && rbVrouw.Checked == false)
            {
                MessageBox.Show("Selecteer een geslacht!");
            }
            else if (nmrBoven.Value == 0 && nmrOnder.Value == 0)
            {
                MessageBox.Show("Voer de bloeddruk in!");
            }
            else if (txtNaam.Text == "")
            {
                MessageBox.Show("Voer een naam in!");
            }
        }

        private bool CheckGender()
        {
            bool man = rbMan.Checked;
            if (man)
            {
                colorBox.BackColor = Color.FromArgb(150, 26, 161, 240);
                return true;
            }
            else
            {
                colorBox.BackColor = Color.Pink;
                return false;
            }
        }

        private decimal Gemiddeld()
        {
            decimal bovendruk = nmrBoven.Value;
            decimal onderdruk = nmrOnder.Value;
            decimal gemiddeld = (bovendruk + onderdruk) / 2;
            return gemiddeld;
        }

        private decimal Leeftijd()
        {
            decimal leeftijd = nmrLeeftijd.Value;
            return leeftijd;
        }
        private void CheckPatient()
        {
            if (CheckGender() && Gemiddeld() > 160 && Leeftijd() >= 65)
            {
                lblWarning.Text = "patient heeft extra aandacht nodig";
            }
            else if (!CheckGender() && Gemiddeld() > 160 && Leeftijd() >= 67)
            {
                lblWarning.Text = "patient heeft extra aandacht nodig";
            }
            else
            {
                lblWarning.Text = "geen warning";
            }
        }

        private void CheckBloeddruk()
        {
            decimal gemiddeld = Gemiddeld();

            if (gemiddeld > 160)
            {
                lblUitslag.Text = "De patient heeft een hogebloekdruk";
            }
            else if (gemiddeld < 90)
            {
                lblUitslag.Text = "De patient heeft een lage bloeddruk";
            }
            else if (gemiddeld > 110 && gemiddeld < 120)
            {
                lblUitslag.Text = "De patient heeft een optimale bloeddruk";
            }
            else if (gemiddeld < 140)
            {
                lblUitslag.Text = "De patient heeft een normale bloekdruk";
            }
        }

        private void Info()
        {
            string naam = txtNaam.Text;
            decimal leeftijd = Leeftijd();

            lblLeeftijd.Text = leeftijd.ToString();
            lblNaam.Text = naam;

        }
        private void CheckForEasterEgg()
        {
            string naam = txtNaam.Text;

            if(naam == "Paashaas")
            {
                int i = 0;
                while(i < 9)
                {
                    MessageBox.Show("Happy Easter");
                    i++;
                }
            }
        }


    }
}
