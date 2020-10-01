using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaalDrie
{
    public partial class FmaalDrie : Form
    {
        public FmaalDrie()
        {
            InitializeComponent();
        }

        private void btnSom_Click(object sender, EventArgs e)
        {
            antwoordenList.Items.Clear();
            //get the input and insert in variable input
            int input = Convert.ToInt32(txtB.Text);

            //loop until i is smaller then 11
            for(int i = 1; i < 11; i++)
            {
                //put the result from the MaalDrie method in the output variable
                int output = MaalDrie(i, input);
                //add the output to the list
                antwoordenList.Items.Add(output);
            }

        }

        int MaalDrie(int input1, int input2)
        {
            //multiply the input with 3 and put the result in the output 
            int output = input1 * input2;
            //return the output 
            return output;
        }

    }
}
