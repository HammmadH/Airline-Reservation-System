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
    public partial class frmPassenger : Form
    {
        public frmPassenger()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bll_AMS objPassenger = new bll_AMS();
            objPassenger.insertPassenger(Convert.ToInt32(txtPassengerID.Text), txtPassengerCNIC.Text, txtPassengerName.Text, Convert.ToInt32(txtPassengerAge.Text), txtPassengerGender.Text, Convert.ToInt32(txtPassengerPhNumber.Text), txtadd.Text, txtfrom.Text, txtto.Text, txtday.Text, Convert.ToInt32(txtseat.Text), comboBoxclass.Text);
            MessageBox.Show("Data Inserted!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bll_AMS objPassenger = new bll_AMS();
            objPassenger.deletePassenger(Convert.ToInt32(txtPassengerID.Text));
            MessageBox.Show("Data Deleted!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bll_AMS objPassenger = new bll_AMS();
            objPassenger.updatePassenger(Convert.ToInt32(txtPassengerID.Text), txtPassengerCNIC.Text, txtPassengerName.Text, Convert.ToInt32(txtPassengerAge.Text), txtPassengerGender.Text, Convert.ToInt32(txtPassengerPhNumber.Text), txtadd.Text, txtfrom.Text, txtto.Text, txtday.Text, Convert.ToInt32(txtseat.Text), comboBoxclass.Text);
            MessageBox.Show("Data Updated!");
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.Show();
            this.Hide();
        }
    }
}
