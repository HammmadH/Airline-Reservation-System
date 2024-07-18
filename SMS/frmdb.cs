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
    public partial class frmdb : Form
    {
        public frmdb()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDB.Text, txtUser.Text, txtpass.Text);
            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("Test connection succeded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                welcome w = new welcome();
                w.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmdb_Load(object sender, EventArgs e)
        {
            cboServer.Items.Add(".");
            cboServer.Items.Add("DESKTOP-TMKGBSB");
            cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboServer.SelectedIndex = 0;
        }
    }
}
