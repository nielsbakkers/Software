using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worpengenerator
{
    public partial class worpengenerator : Form
    {
        public worpengenerator()
        {
            InitializeComponent();
            rb.Items.Clear();
        }

        int hoogst = 0;
        int laagst = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //Clear the item in the list
            rb.Items.Clear();

            //get the value from the worpen input and put in variable
            decimal worpenA = worpen.Value;
            //get the value from the ogen input and put in variable
            decimal ogenA = ogen.Value;

            //generate random int
            Random random = new Random();

            //set int totaal as 0
            int totaal = 0;

            //for loop to loop as often as the worpenA variable is
            for(int i = 0; i < worpenA; i++)
            {
                //generate random number from 1 to ogenA
                int rndm = random.Next(1, Convert.ToInt32(ogenA) + 1);
                //add the random number to the list
                rb.Items.Add(rndm);
                //add the random number to the totaal variable
                totaal += rndm;
            }

            //check if variable hoogst is 0
            if(hoogst == 0)
            {
                //assign totaal to the variable laagst
                laagst = totaal;
            }

            //convert the totaal to a string and put the totaal on the aantal label
            aantal.Text = totaal.ToString();

            //check if the totaal is greater than hoogst
            if (totaal > hoogst)
            {
                //the variable hoogst is equal to totaal
                hoogst = totaal;
                //place the totaal in the hoogst label
                lblHoogst.Text = totaal.ToString();
            }
            //check if totaal is smaller than laagst
            if (totaal < laagst)
            {
                //the varaible laagst is equal to totaal
                laagst = totaal;
                //place the totaal in the laagst label
                lblLaagst.Text = totaal.ToString();
            }
        }
    }
}
