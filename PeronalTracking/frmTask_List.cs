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
    public partial class frmTask_List : Form
    {
        public frmTask_List()
        {
            InitializeComponent();
        }

        private void frmTask_List_Load(object sender, EventArgs e)
        {
            pnlForAdmin.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTask frm = new frmTask();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmTask frm = new frmTask();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
