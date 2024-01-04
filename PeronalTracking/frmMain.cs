using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeronalTracking
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmployee_List frm = new frmEmployee_List();
            this.Hide();   
            frm.ShowDialog();
            this.Visible = true;    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Close();
            frm.ShowDialog();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            frmTask_List frm= new frmTask_List();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            frmSalary_List frm = new frmSalary_List();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btbnPersmission_Click(object sender, EventArgs e)
        {
            frmPermission_List frm = new frmPermission_List();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment_List frm = new frmDepartment_List();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            frmPosition_List frm = new frmPosition_List();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
