using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AMS
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void lblaboutcross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblsearchflight_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchflight f = new searchflight();
            f.Show();
        }

        private void lblfb_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }

        private void lbltwt_Click(object sender, EventArgs e)
        {
            Process.Start("www.twitter.com");
        }

        private void lblsnap_Click(object sender, EventArgs e)
        {
            Process.Start("www.snapchat.com");
        }
    }
}
