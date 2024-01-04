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
    public partial class frmPosition_List : Form
    {
        public frmPosition_List()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPosition frm = new frmPosition();
            this.Hide();
            frm.ShowDialog();
            this.Hide();

        }
    }
}
