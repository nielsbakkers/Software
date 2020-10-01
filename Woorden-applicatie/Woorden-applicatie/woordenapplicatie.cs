using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Woorden_applicatie
{
    public partial class woordenapplicatie : Form
    {
        public woordenapplicatie()
        {
            InitializeComponent();
        }

        List<string> woorden = new List<string>();

        private void listItems()
        {
            for (int i = 0; i < woorden.Count; i++)
            {
                lbOverzicht.Items.Add(woorden[i]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            string woord = txtNaam.Text;

            if (nieuwWoord(woord))
            {
                lblError.Visible = true;
                lblError.Text = "Het woord bestaat al in de woordenlijst";
            }
            else
            {
                woorden.Add(woord);
            }
            lbOverzicht.Items.Clear();
            listItems();
        }

        public bool nieuwWoord(string woord)
        {
            if (woorden.Contains(woord))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
