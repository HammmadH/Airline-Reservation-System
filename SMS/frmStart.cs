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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee emp = new frmEmployee();
            emp.Show();
        }

        private void btnPassenger_Click(object sender, EventArgs e)
        {
            frmPassenger pass = new frmPassenger();
            pass.Show();
        }
    }
}
