namespace DataBaseWinforms
{
    partial class EmployeesManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.newEmployeeMenu = new System.Windows.Forms.Button();
            this.updateEmployeeMenu = new System.Windows.Forms.Button();
            this.uC_InsertNewEmployee1 = new DataBaseWinforms.UserControls.UC_InsertNewEmployee();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.updateEmployeeMenu);
            this.panel1.Controls.Add(this.newEmployeeMenu);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 886);
            this.panel1.TabIndex = 0;
            // 
            // newEmployeeMenu
            // 
            this.newEmployeeMenu.Location = new System.Drawing.Point(36, 35);
            this.newEmployeeMenu.Name = "newEmployeeMenu";
            this.newEmployeeMenu.Size = new System.Drawing.Size(205, 89);
            this.newEmployeeMenu.TabIndex = 0;
            this.newEmployeeMenu.Text = "Añadir Empleado";
            this.newEmployeeMenu.UseVisualStyleBackColor = true;
            this.newEmployeeMenu.Click += new System.EventHandler(this.newEmployeeMenu_Click);
            // 
            // updateEmployeeMenu
            // 
            this.updateEmployeeMenu.Location = new System.Drawing.Point(36, 175);
            this.updateEmployeeMenu.Name = "updateEmployeeMenu";
            this.updateEmployeeMenu.Size = new System.Drawing.Size(205, 89);
            this.updateEmployeeMenu.TabIndex = 1;
            this.updateEmployeeMenu.Text = "Editar Empleado";
            this.updateEmployeeMenu.UseVisualStyleBackColor = true;
            // 
            // uC_InsertNewEmployee1
            // 
            this.uC_InsertNewEmployee1.Location = new System.Drawing.Point(298, 1);
            this.uC_InsertNewEmployee1.Name = "uC_InsertNewEmployee1";
            this.uC_InsertNewEmployee1.Size = new System.Drawing.Size(814, 736);
            this.uC_InsertNewEmployee1.TabIndex = 1;
            // 
            // EmployeesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 887);
            this.Controls.Add(this.uC_InsertNewEmployee1);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeesManagement";
            this.Text = "EmployeesManagement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateEmployeeMenu;
        private System.Windows.Forms.Button newEmployeeMenu;
        private UserControls.UC_InsertNewEmployee uC_InsertNewEmployee1;
    }
}