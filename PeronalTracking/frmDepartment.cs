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
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtDepartment.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a Department");
            }
            else
            {
                Department department = new Department();
                department.Department1 = txtDepartment.Text;
                BLL.DepartmentBLL.AddDepartment(department);
                MessageBox.Show("Department has been added");
                txtDepartment.Clear();
            }

        }
    }
}
