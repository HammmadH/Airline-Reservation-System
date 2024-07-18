using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AMS
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bll_AMS objEmployee = new bll_AMS();
            objEmployee.insertEmployee(Convert.ToInt32(txtEmployeeID.Text), txtEmployeeCNIC.Text, txtEmployeeName.Text, Convert.ToInt32(txtEmployeeAge.Text), txtEmployeeGender.Text, Convert.ToInt32(txtEmployeePhNumber.Text));
            MessageBox.Show("Data Inserted!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bll_AMS objEmployee = new bll_AMS();
            objEmployee.deleteEmployee(Convert.ToInt32(txtEmployeeID.Text));
            MessageBox.Show("Data Deleted!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bll_AMS objEmployee = new bll_AMS();
            objEmployee.updateEmployee(Convert.ToInt32(txtEmployeeID.Text), txtEmployeeCNIC.Text, txtEmployeeName.Text, Convert.ToInt32(txtEmployeeAge.Text), txtEmployeeGender.Text, Convert.ToInt32(txtEmployeePhNumber.Text));
            MessageBox.Show("Data Updated!");
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.Show();
            this.Hide();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
