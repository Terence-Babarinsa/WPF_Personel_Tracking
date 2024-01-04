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
    public partial class frmPermission_List : Form
    {
        public frmPermission_List()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled =  General.NumberTextbox(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.NumberTextbox(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPermission frm = new frmPermission();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmPermission frm = new frmPermission();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
