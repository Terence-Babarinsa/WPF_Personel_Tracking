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
using DAL;
using DAL.DAO;

namespace PeronalTracking
{
    public partial class frmPosition : Form
    {
        public frmPosition()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }
        List<Department> departmentlist = new List<Department>();
        private void frmPosition_Load(object sender, EventArgs e)
        {
            departmentlist = Department.GetDepartments();
            cmbDepartment.DataSource = departmentlist;
            cmbDepartment.DisplayMember = "Departemnt Name";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
