namespace DataBaseWinforms.UserControls
{
    partial class UC_InsertNewEmployee
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.managerCB = new System.Windows.Forms.ComboBox();
            this.departmentCB = new System.Windows.Forms.ComboBox();
            this.jobCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.salaryEmployeeNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hireDateEmployeeDP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneNumberEmployeeTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailEmployeeTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameEmployeeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameEmployeeTB = new System.Windows.Forms.TextBox();
            this.addNewEmployeeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salaryEmployeeNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // managerCB
            // 
            this.managerCB.FormattingEnabled = true;
            this.managerCB.Location = new System.Drawing.Point(395, 491);
            this.managerCB.Name = "managerCB";
            this.managerCB.Size = new System.Drawing.Size(280, 33);
            this.managerCB.TabIndex = 46;
            // 
            // departmentCB
            // 
            this.departmentCB.FormattingEnabled = true;
            this.departmentCB.Location = new System.Drawing.Point(64, 590);
            this.departmentCB.Name = "departmentCB";
            this.departmentCB.Size = new System.Drawing.Size(280, 33);
            this.departmentCB.TabIndex = 45;
            // 
            // jobCB
            // 
            this.jobCB.FormattingEnabled = true;
            this.jobCB.Location = new System.Drawing.Point(395, 388);
            this.jobCB.Name = "jobCB";
            this.jobCB.Size = new System.Drawing.Size(280, 33);
            this.jobCB.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "Departamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "Manager";
            // 
            // salaryEmployeeNUD
            // 
            this.salaryEmployeeNUD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.salaryEmployeeNUD.Location = new System.Drawing.Point(64, 491);
            this.salaryEmployeeNUD.Maximum = new decimal(new int[] {
            705032704,
            1,
            0,
            0});
            this.salaryEmployeeNUD.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.salaryEmployeeNUD.Name = "salaryEmployeeNUD";
            this.salaryEmployeeNUD.Size = new System.Drawing.Size(280, 31);
            this.salaryEmployeeNUD.TabIndex = 41;
            this.salaryEmployeeNUD.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Salario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Trabajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Fecha Contratado";
            // 
            // hireDateEmployeeDP
            // 
            this.hireDateEmployeeDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hireDateEmployeeDP.Location = new System.Drawing.Point(64, 386);
            this.hireDateEmployeeDP.Name = "hireDateEmployeeDP";
            this.hireDateEmployeeDP.Size = new System.Drawing.Size(280, 31);
            this.hireDateEmployeeDP.TabIndex = 37;
            this.hireDateEmployeeDP.Value = new System.DateTime(2024, 7, 9, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Numero Telefono";
            // 
            // phoneNumberEmployeeTB
            // 
            this.phoneNumberEmployeeTB.Location = new System.Drawing.Point(395, 274);
            this.phoneNumberEmployeeTB.Name = "phoneNumberEmployeeTB";
            this.phoneNumberEmployeeTB.Size = new System.Drawing.Size(280, 31);
            this.phoneNumberEmployeeTB.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Correo";
            // 
            // emailEmployeeTB
            // 
            this.emailEmployeeTB.Location = new System.Drawing.Point(64, 274);
            this.emailEmployeeTB.Name = "emailEmployeeTB";
            this.emailEmployeeTB.Size = new System.Drawing.Size(280, 31);
            this.emailEmployeeTB.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellidos";
            // 
            // lastNameEmployeeTB
            // 
            this.lastNameEmployeeTB.Location = new System.Drawing.Point(395, 169);
            this.lastNameEmployeeTB.Name = "lastNameEmployeeTB";
            this.lastNameEmployeeTB.Size = new System.Drawing.Size(280, 31);
            this.lastNameEmployeeTB.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 55);
            this.label2.TabIndex = 30;
            this.label2.Text = "Empleado Nuevo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre";
            // 
            // nameEmployeeTB
            // 
            this.nameEmployeeTB.Location = new System.Drawing.Point(64, 169);
            this.nameEmployeeTB.Name = "nameEmployeeTB";
            this.nameEmployeeTB.Size = new System.Drawing.Size(280, 31);
            this.nameEmployeeTB.TabIndex = 28;
            // 
            // addNewEmployeeBtn
            // 
            this.addNewEmployeeBtn.Location = new System.Drawing.Point(411, 548);
            this.addNewEmployeeBtn.Name = "addNewEmployeeBtn";
            this.addNewEmployeeBtn.Size = new System.Drawing.Size(253, 76);
            this.addNewEmployeeBtn.TabIndex = 27;
            this.addNewEmployeeBtn.Text = "Añadir Empleado";
            this.addNewEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // UC_InsertNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.managerCB);
            this.Controls.Add(this.departmentCB);
            this.Controls.Add(this.jobCB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.salaryEmployeeNUD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hireDateEmployeeDP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneNumberEmployeeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailEmployeeTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameEmployeeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameEmployeeTB);
            this.Controls.Add(this.addNewEmployeeBtn);
            this.Name = "UC_InsertNewEmployee";
            this.Size = new System.Drawing.Size(814, 736);
            ((System.ComponentModel.ISupportInitialize)(this.salaryEmployeeNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox managerCB;
        private System.Windows.Forms.ComboBox departmentCB;
        private System.Windows.Forms.ComboBox jobCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown salaryEmployeeNUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker hireDateEmployeeDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneNumberEmployeeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailEmployeeTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameEmployeeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameEmployeeTB;
        private System.Windows.Forms.Button addNewEmployeeBtn;
    }
}
