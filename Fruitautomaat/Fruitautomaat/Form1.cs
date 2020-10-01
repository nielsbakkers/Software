using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruitautomaat
{
    public partial class Ffruitautomaat : Form
    {
        public Ffruitautomaat()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //make array fruit with multiple fruits
            string[] fruit = { "appel", "peer", "banaan", "kiwi", "meloen", "sinaasappel" };

            //string pictureOne to store the fruitImage
            string pictureOne = "";
            //string pictureTwo to store the fruitImage
            string pictureTwo = "";
            //string pictureThree to store the fruitImage
            string pictureThree = "";

            //make random called random
            Random random = new Random();

            //loop until each picturebox has an image
            for (int i = 0; i < 4; i++)
            {
                //count the images in the directory minus one
                int aantalImage = Directory.GetFiles(@".\images").Length - 1;
                //get random number from 0 to aantalImage and put in the variable rdm
                int rdm = random.Next(0, aantalImage);
                //get a fruitImage from the array fruit using the rdm number
                string fruitImage = fruit[rdm];
                //check if variable i is 1
                if (i == 1)
                {
                    //if so put the fruitImage in the string pictureOne
                    pictureOne = fruitImage;
                    //and place the image in the picturebox
                    pbOne.ImageLocation = @"images\" + fruitImage + ".jpg";
                }
                //check if variable i is 2
                else if (i == 2)
                {
                    //if so put the fruitImage in the string pictureTwo
                    pictureTwo = fruitImage;
                    //and place the image in the picturebox
                    pbTwo.ImageLocation = @"images\" + fruitImage + ".jpg";
                }
                //check if variable i is 3
                else if (i == 3)
                {
                    //if so put the fruitImage in the string pictureThree
                    pictureThree = fruitImage;
                    //and place the image in the picturebox
                    pbThree.ImageLocation = @"images\" + fruitImage + ".jpg";
                }

            }
            //check if all the fruitImages are the same
            if (pictureOne == pictureTwo && pictureTwo == pictureThree && pictureThree == pictureOne)
            {
                //if so make the lblWinner visible
                lblWinner.Visible = true;
                //change the button color to YellowGreen
                btnGenerate.BackColor = Color.YellowGreen;
            }
            else
            {
                //if not the same make lblWinner not visible
                lblWinner.Visible = false;
                //change the button color to Control
                btnGenerate.BackColor = SystemColors.Control;
            }
        }
    }
}
