using System;
using System.Windows.Forms;

namespace PrisonManagment
{
    public partial class update_staff_form : Form
    {
        public update_staff_form()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string role = txtRole.Text;
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                decimal wage = decimal.Parse(txtWage.Text);
                int? supervisor = string.IsNullOrWhiteSpace(txtSupervisor.Text) ? null : int.Parse(txtSupervisor.Text);
                int? assignedBlock = string.IsNullOrWhiteSpace(txtAssignedBlock.Text) ? null : int.Parse(txtAssignedBlock.Text);

                Database.UpdateStaff(id, role, name, age, wage, supervisor, assignedBlock);
                MessageBox.Show("Staff updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
