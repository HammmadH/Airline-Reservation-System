using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AMS
{
    public partial class searchflight : Form
    {
        public searchflight()
        {
            InitializeComponent();
        }

        private void lblcutsf_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblreg_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
        }

        private void lblsearch_Click(object sender, EventArgs e)
        {
            if (cmb_flying.Text == cmb_to.Text)
            {
                MessageBox.Show("SAME PLACE NOT FOUND");
            }
            else
            {
                search ss = new search();
                if (cmb_day.Text == "MONDAY")
                {


                    ss.monday(cmb_flying, cmb_to, cmb_class, txt_young, cmb_day);

                }

                if (cmb_day.Text == "FRIDAY")
                {


                    ss.friday(cmb_flying, cmb_to, cmb_class, txt_young, cmb_day);

                }


                if (cmb_day.Text == "SUNDAY")
                {
                    ss.sunday(cmb_flying, cmb_to, cmb_class, txt_young, cmb_day);

                }

                register reg = new register();
                reg.Show();
                this.Hide();
            }
        }

        private void searchflight_Load(object sender, EventArgs e)
        {
            panelreservation.Hide();
            panelseat.Hide();
            panellist.Hide();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
        }

        private void lblcancel_Click(object sender, EventArgs e)
        {
            panelreservation.Show();
        }
        canc cc = new canc();

        private void btncan_Click(object sender, EventArgs e)
        {
            if (txtresnum.Text != "")
            {
                cc.del(txtresnum, panelreservation);
                this.panelreservation.Hide();
            }


            else
            {
                MessageBox.Show("ILLEGAL...");
            }
        }

        private void lblaboutus_Click(object sender, EventArgs e)
        {
            this.Hide();
            about a = new about();
            a.Show();
        }

        private void btnse_Click(object sender, EventArgs e)
        {
            if (txtlb.Text != " ")
            {
                cc.detail(txtlb, listBox1);
            }
        }

        private void lblflghtdetails_Click(object sender, EventArgs e)
        {
            panellist.Show();
        }

        private void lblcutlb_Click(object sender, EventArgs e)
        {
            panellist.Hide();
        }

        private void lblcutrb_Click(object sender, EventArgs e)
        {
            panelreservation.Hide();
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Hide();
        }
    }
}
