using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace somvaneenreeksgetallen
{
    public partial class somvanreeksgetallen : Form
    {
        public somvanreeksgetallen()
        {
            InitializeComponent();
        }

        private void btnSom_Click(object sender, EventArgs e)
        {
            //clear the antwoordenlist
            antwoordenList.Items.Clear();

            //get input value and put in variable input
            int input = Convert.ToInt32(txtB.Text);
            //set the times to multiply to 11 times
            int x = 11;

            //loop until i is smaller then x (11)
            for(int i = 1; i < x; i++)
            {
                //append the answer to the antwoordenlist
                antwoordenList.Items.Add(input * i);
            }
        }
    }
}
