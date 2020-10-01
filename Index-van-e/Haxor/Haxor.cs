using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haxor
{
    public partial class Fhaxor : Form
    {
        public Fhaxor()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //put the input text in the string variable input
            string input = txtInput.Text;
            //replace the characters and make new String variable called replaced
            string replaced = input.Replace('a', '4').Replace('s', '5').Replace('e', '3').Replace("v", @"\/").Replace("V", @"\/").Replace("m", "|V|").Replace("M", "|V|");
            //put the replaced string in the label
            lblAnswer.Text = replaced;

        }
    }
}
