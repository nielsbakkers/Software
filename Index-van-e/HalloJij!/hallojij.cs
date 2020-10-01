using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloJij_
{
    public partial class hallojij : Form
    {
        public hallojij()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string naam = txtNaam.Text;
            string test = naam.Substring(naam.IndexOf(" "));
            string groet;
            if(rbMan.Checked == true)
            {
                groet = "Hallo mijnheer";
            }
            else
            {
                groet = "Hallo mejuffrouw";
            }


            MessageBox.Show(groet + test);
        }
    }
}
