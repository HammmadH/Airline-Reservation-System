using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void lblcutreg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblsearch_Click(object sender, EventArgs e)
        {
            searchflight sf = new searchflight();
            sf.Show();
            this.Hide();
        }

        private void btnpass_Click(object sender, EventArgs e)
        {
            frmPassenger fp = new frmPassenger();
            fp.Show();
            this.Hide();
        }

        private void register_Load(object sender, EventArgs e)
        {
            panelsr.Hide();
            panelseatrev.Hide();
            panelrnnum.Hide();
            panelcom.Hide();
            panelsrn.Hide();
            panellb.Hide();
        }

        private void lblfd_Click(object sender, EventArgs e)
        {
            panellb.Show();
        }

        private void lblout_Click(object sender, EventArgs e)
        {
            welcome C = new welcome();
            C.Show();
            this.Hide();
        }

        private void lblcom_Click(object sender, EventArgs e)
        {
            panelcom.Show();
        }

        private void lblcan_Click(object sender, EventArgs e)
        {
            panelrnnum.Show();
        }
        comment c = new comment();

        private void btnok_Click(object sender, EventArgs e)
        {
            c.cmnt(txtname, txtcom);
            panelcom.Hide();
        }
        canc cc = new canc();

        private void btncan_Click(object sender, EventArgs e)
        {
            if (txtrnum.Text != "")
            {
                cc.del(txtrnum, panelrnnum);
                panelrnnum.Hide();
            }
            else
            {
                MessageBox.Show("ILLEGAL");
            }
        }

        private void btnrnsearch_Click(object sender, EventArgs e)
        {
            cc.find(txtrncon);
            panelsrn.Hide();
        }

        private void lblseereg_Click(object sender, EventArgs e)
        {
            panelsrn.Show();
        }

        private void lblcutsrn_Click(object sender, EventArgs e)
        {
            panelsrn.Hide();
        }

        private void lblrb_Click(object sender, EventArgs e)
        {
            panelrnnum.Hide();
        }

        private void lblcb_Click(object sender, EventArgs e)
        {
            panelcom.Hide();
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            searchflight sf = new searchflight();
            sf.Show();
            this.Hide();
        }

        private void btnse_Click(object sender, EventArgs e)
        {
            if (txtse.Text != "")
            {
                cc.detail(txtse, listBox1);
            }
        }

        private void lblcutlb_Click(object sender, EventArgs e)
        {
            panellb.Hide();
        }
    }
}
