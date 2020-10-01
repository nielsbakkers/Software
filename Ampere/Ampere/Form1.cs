using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ampere
{
    public partial class Ampere : Form
    {
        public Ampere()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //get the volt input
            decimal volt = nmrV.Value;
            //get the ampere input
            decimal ampere = nmrA.Value;

            //get the weerstand result
            decimal result = Weerstand(volt, ampere);
            //place the result in the lblAntwoord
            lblAntwoord.Text = "De weerstand is " + Convert.ToString(Math.Round(result, 2)) + " ohm";
        }

        decimal Weerstand(decimal volt, decimal ampere)
        {
            //devide volt by ampere and put in the result 
            decimal result = volt / ampere;
            return result;
        }

    }
}
