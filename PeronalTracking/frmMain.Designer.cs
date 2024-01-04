namespace PeronalTracking
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btbnPersmission = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.Location = new System.Drawing.Point(145, 146);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(208, 179);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTasks.Location = new System.Drawing.Point(412, 146);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(208, 179);
            this.btnTasks.TabIndex = 1;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalary.Location = new System.Drawing.Point(673, 146);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(208, 179);
            this.btnSalary.TabIndex = 2;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.Location = new System.Drawing.Point(925, 235);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(208, 90);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btbnPersmission
            // 
            this.btbnPersmission.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btbnPersmission.Location = new System.Drawing.Point(145, 369);
            this.btbnPersmission.Name = "btbnPersmission";
            this.btbnPersmission.Size = new System.Drawing.Size(208, 179);
            this.btbnPersmission.TabIndex = 4;
            this.btbnPersmission.Text = "Permission";
            this.btbnPersmission.UseVisualStyleBackColor = true;
            this.btbnPersmission.Click += new System.EventHandler(this.btbnPersmission_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartment.Location = new System.Drawing.Point(412, 369);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(208, 179);
            this.btnDepartment.TabIndex = 5;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPosition.Location = new System.Drawing.Point(673, 369);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(208, 179);
            this.btnPosition.TabIndex = 6;
            this.btnPosition.Text = "Position";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.Location = new System.Drawing.Point(925, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(208, 90);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 771);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btbnPersmission);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnEmployee);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Tracking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btbnPersmission;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnExit;
    }
}