using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index_van_e
{
    public partial class IndexvanE : Form
    {
        public IndexvanE()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //get the text in the txtInput and put in the variable input
            string input = txtInput.Text;
            //get the first index of e and put the position in the positie integer
            int positie = input.IndexOf("e");
            //check if input has no e in the string
            if (positie == -1)
            {
                //if so put the input in the label
                lblAnswer.Text = input;
            }
            else
            {
                //else put the position integer in the label
                lblAnswer.Text = positie.ToString();
            }

        }
    }
}
