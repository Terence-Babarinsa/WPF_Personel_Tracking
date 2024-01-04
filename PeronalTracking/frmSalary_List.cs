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
    public partial class frmSalary_List : Form
    {
        public frmSalary_List()
        {
            InitializeComponent();
        }

        private void frmSalary_List_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSalary  frm = new frmSalary();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmSalary frm = new frmSalary();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
