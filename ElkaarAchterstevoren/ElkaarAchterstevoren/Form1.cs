using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkaarAchterstevoren
{
    public partial class FormElkaarAchterstevoren : Form
    {
        public FormElkaarAchterstevoren()
        {
            InitializeComponent();
        }

        //make string named result
        string result;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //get the text input and assign it to the string input
            string input = txtInput.Text;
            //reverse the input and assign to new variable result
            result = new string(input.ToCharArray().Reverse().ToArray());

            //check if the input is empty
            if (input == "")
            {
                //give message that the input is empty
                MessageBox.Show("Please insert a value before checking");
            }
            else
            {
                //check if input is same as result
                if (ElkaarAchterstevoren(input, result))
                {
                    //place true in the label
                    lblAntwoord.Text = "true";
                    //change text color to green
                    lblAntwoord.ForeColor = Color.Green;

                }
                else
                {
                    //place false in the label
                    lblAntwoord.Text = "false";
                    //change text color to red
                    lblAntwoord.ForeColor = Color.Red;
                }
            }
        }

        private bool ElkaarAchterstevoren(String input, String result)
        {
            //check if the input is the same as result
            if(input == result)
            {
                //return bool true is the same
                return true;
            }
            else
            {
                //return bool false is not the same
                return false;
            }
        }

    }
}
