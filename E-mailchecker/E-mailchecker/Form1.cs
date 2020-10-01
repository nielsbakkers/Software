using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_mailchecker
{
    public partial class Femail : Form
    {
        public Femail()
        {
            InitializeComponent();
        }

        List<string> domein = new List<string> { "nl", "com", "edu" };


      
        private void btnCheck_Click(object sender, EventArgs e)
        {
            cbOne.Checked = false;
            cbTwo.Checked = false;
            cbThree.Checked = false;
            cbFour.Checked = false;

            string email = txtEmail.Text;

            if (checkDot(email))
            {
                cbOne.Checked = true;
            }
            if (checkAt(email))
            {
                cbTwo.Checked = true;
            }
            if (checkDotAt(email))
            {
                cbThree.Checked = true;
            }
            if (checkDomein(email))
            {
                cbFour.Checked = true;
            }




            //if (email.Contains("."))
            //{
            //    cbOne.Checked = true;

            //}
            //else
            //{

            //}


            //if (email.Contains("."))
            //{
            //    cbOne.Checked = true;
            //    if (email.Contains("@"))
            //    {
            //        cbTwo.Checked = true;
            //        int at = email.IndexOf("@");
            //        int dot = email.IndexOf(".");

            //        if (at < dot)
            //        {
            //            cbThree.Checked = true;
            //            string extensie = email.Substring(dot + 1);

            //            for (int i = 0; i < domein.Count; i++)
            //            {
            //                if (extensie == domein[i])
            //                {
            //                    cbFour.Checked = true;
            //                    label3.Text = "good";
            //                    return;
            //                }
            //                else
            //                {
            //                    label3.Text = "false";
            //                    cbFour.Checked = false;
            //                    return;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            label3.Text = "false";
            //            cbThree.Checked = false;
            //            cbTwo.Checked = false;
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        label3.Text = "false";
            //        cbTwo.Checked = false;
            //        cbThree.Checked = false;
            //        cbFour.Checked = false;
            //        return;
            //    }
            //}
            //else
            //{
            //    label3.Text = "false";
            //    cbOne.Checked = false;
            //    return;
            //}
        }

        private bool checkDot(string email)
        {
            if (email.Contains("."))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkAt(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkDotAt(string email)
        {
            int at = email.IndexOf("@");
            int dot = email.IndexOf(".");

            if(at < dot)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkDomein(string email)
        {
            int dot = email.IndexOf(".");
            string extensie = email.Substring(dot + 1);

            for(int i = 0; i < domein.Count; i++)
            {
                if(extensie == domein[i])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }



    }
}
