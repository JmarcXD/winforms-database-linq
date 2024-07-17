using System;
using System.Windows.Forms;

namespace DataBaseWinforms
{
    public partial class EmployeesManagement : Form
    {
        public EmployeesManagement()
        {
            InitializeComponent();
            HideUserControls();
        }

        private void newEmployeeMenu_Click(object sender, EventArgs e)
        {
            HideUserControls();
            this.uC_InsertNewEmployee1.Show();
        }

        private void HideUserControls()
        {
            foreach (Control uc in this.Controls)
            {
                if (uc is UserControl)
                {
                    uc.Visible = false;
                }
            }
        }
    }
}
