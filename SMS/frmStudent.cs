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

namespace SMS
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bll_Student objStudent = new bll_Student();
            objStudent.saveStudent( Convert.ToInt32(txtStudentID.Text), txtStudentName.Text);
            
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
