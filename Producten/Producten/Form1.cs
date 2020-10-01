using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producten
{
    public partial class Fproducten : Form
    {
        public Fproducten()
        {
            InitializeComponent();
            berekenTotaal();            
        }

        List<string> naam = new List<string>();
        List<double> prijs = new List<double>();

        private void listItems()
        {
            for (int i = 0; i < prijs.Count; i++)
            {
                lbOverzicht.Items.Add(naam[i] + "  " + prijs[i]);
            }
        }

        private void checkForDouble()
        {
            double d;
            if (double.TryParse(txtPrijs.Text, out d))
            {
                string inputNaam = txtNaam.Text;
                double inputPrijs = Convert.ToDouble(txtPrijs.Text);
                naam.Add(inputNaam);
                prijs.Add(inputPrijs);
                lbOverzicht.Items.Clear();
                listItems();
            }
            else
            {
                MessageBox.Show("Voer een komma getal in!");
                return;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkForDouble();

        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            berekenTotaal();
        }

        private void berekenTotaal()
        {
            double totaal = 0;
            for (int i = 0; i < prijs.Count; i++)
            {
                totaal += prijs[i];
            }
            lblTotaal.Text = Convert.ToString(totaal);
        }


        //string[] naam = new string[20];
        //double[] prijs = new double[20];

        //public void listItems()
        //{

        //    //int arrayLenght = naam.Length;
        //    for (int i = 0; i < prijs.Length; i++)
        //    {
        //        lbOverzicht.Items.Add(naam[i] + "  " +  prijs[i]);
        //    }

        //}

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    string inputNaam = txtNaam.Text;
        //    double inputPrijs = Convert.ToDouble(txtPrijs.Text);

        //    int lengte = prijs.Length -1;
        //    Console.WriteLine(lengte);
        //    naam[lengte] = inputNaam;
        //    prijs[lengte] = inputPrijs;
        //    lbOverzicht.Items.Clear();
        //    listItems();
        //}
    }
}
