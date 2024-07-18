using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace AMS
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            //popup.Image = Properties.Resources.info;
            popup.TitleText = "Welcome To Airline Management System";
            popup.ContentText = "Made By Hammad Hassan & Ezan Siddqui";
            popup.Popup();
            paneladmin.Hide();
        }

        private void lbladmin_Click(object sender, EventArgs e)
        {
            paneladmin.Show();
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {
            if (txtname.Text != " " && txtpass.Text != " ")
            {
                if (txtname.Text == "hammad".ToLower() && txtpass.Text == "ezan".ToLower())
                {
                    admin a = new admin();
                    a.Show();
                    this.Hide();
                }


                else
                {
                    MessageBox.Show("FILL RIGHT PASSWORD");
                    txtname.Clear();
                    txtpass.Clear();
                }
            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbluser_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchflight F = new searchflight();
            F.Show();
        }
    }
}
