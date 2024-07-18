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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        comment c = new comment();
        public int aa = 0;

        private void lblcomment_Click(object sender, EventArgs e)
        {
            lstbxc.Items.Clear();
            if (aa == 0)
            {
                lstbxc.Show();
                c.showcmnt(lstbxc);
                aa = 1;
            }
            else
            {
                aa = 0;
                lstbxc.Hide();
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
            lstbxc.Hide();
            panelflight.Hide();
        }

        private void lbladdflight_Click(object sender, EventArgs e)
        {
            panelflight.Show();
        }
        add_flights a = new add_flights();

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (cbday.Text == "MONDAY")
            {
                a.monday(cbfrom, cbto, cbclass, txtseat, cbday);
            }
            if (cbday.Text == "FRIDAY")
            {
                a.friday(cbfrom, cbto, cbclass, txtseat, cbday);
            }
            if (cbday.Text == "SUNDAY")
            {
                a.sunday(cbfrom, cbto, cbclass, txtseat, cbday);
            }
        }
        regestr r = new regestr();

        private void lblreg_Click(object sender, EventArgs e)
        {
            dgvbook.Rows.Clear();
            r.reg(dgvbook);
        }
        canc ccc = new canc();

        private void lblcancel_Click(object sender, EventArgs e)
        {
            dgvbook.Rows.Clear();
            ccc.canl(dgvbook);
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Hide();
        }

        private void lblcross_Click(object sender, EventArgs e)
        {
            panelflight.Hide();
        }

        private void lbllistcross_Click(object sender, EventArgs e)
        {
            lstbxc.Hide();
        }

        private void lblabout_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
        }

        private void lbladdemm_Click(object sender, EventArgs e)
        {
            frmEmployee fe = new frmEmployee();
            fe.Show();
            this.Hide();
        }
    }
}
