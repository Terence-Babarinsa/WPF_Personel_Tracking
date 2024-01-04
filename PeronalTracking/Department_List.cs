using DAL.DAO;
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
    public partial class frmDepartment_List : Form
    {
        public frmDepartment_List()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDepartment frm = new frmDepartment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmDepartment frm = new frmDepartment();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void frmDepartment_List_Load(object sender, EventArgs e)
        {
            List<Department> list = new List<Department>();
            list = BLL.DepartmentBLL.GetDepartments();
            dataGridView1.DataSource = list;
        }
    }
}
