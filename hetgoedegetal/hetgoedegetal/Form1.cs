using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hetgoedegetal
{
    public partial class Raadhetgetal : Form
    {
        public Raadhetgetal()
        {
            InitializeComponent();
        }


        private void btnRaad_Click(object sender, EventArgs e)
        {
            //decimal variable called input contains the input value
            decimal input = intInput.Value;

            //create random integer and store in variable rdm
            Random rdm = new Random();
            //get random integer between 0 and 11
            int guess = rdm.Next(0, 11);

            //check if guess is equal to input
            if (guess == input)
            {
                //if guess is equal to input
                //add the guess integer to the list and give message
                getallenList.Items.Add(guess + "Het goede getal is gevonden!");
                //disable the guess button
                btnRaad.Enabled = false;
                return;
            }
            else
            {
                //if guess is not equal to the input
                //add the guess integer to the list
                getallenList.Items.Add(guess);
                return;
            }
        }

        private void input_Changed(object sender, EventArgs e)
        {
            //when the input field has been clicked
            //enable the button
            btnRaad.Enabled = true;
            //clear the list
            getallenList.Items.Clear();
        }
    }
}
