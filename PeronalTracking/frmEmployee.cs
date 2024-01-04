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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void texUserNo_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void texUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.NumberTextbox(e);
        }
    }
}
