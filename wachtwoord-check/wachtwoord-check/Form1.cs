using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wachtwoord_check
{
    public partial class WachtwoordChecker : Form
    {
        private string wachtwoord;
        private int wachtwoordLenght;

        public WachtwoordChecker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wachtwoord = boxWachtwoord.Text;
            wachtwoordLenght = wachtwoord.Length;
            String count = wachtwoord.Count(Char.IsDigit).ToString();
            //Check if password is longer than three characters
            if (wachtwoordLenght >= 3)
            {
                //Check if password contains 1
                if (wachtwoord.Contains("1") == true && wachtwoord.Contains("2") == true && wachtwoord.Contains("3") == true)
                {
                    panelSterkte.Visible = true;
                    labelSterkte.Visible = true;
                    panelSterkte.BackColor = Color.Green;
                }
                else if(wachtwoord.Contains("1") == false && wachtwoord.Contains("2") == false && wachtwoord.Contains("3") == false)
                {
                    panelSterkte.Visible = true;
                    labelSterkte.Visible = true;
                    panelSterkte.BackColor = Color.Red;
                }
                else
                {
                    panelSterkte.Visible = true;
                    labelSterkte.Visible = true;
                    panelSterkte.BackColor = Color.Yellow;
                }

            }
            else if (wachtwoordLenght < 3)
            {
                panelSterkte.Visible = true;
                labelSterkte.Visible = true;
                panelSterkte.BackColor = Color.Black;
            }
        }

    }
}
