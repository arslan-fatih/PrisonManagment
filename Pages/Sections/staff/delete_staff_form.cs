using System;
using System.Windows.Forms;

namespace PrisonManagment
{
    public partial class DeleteStaffForm : Form
    {
        public DeleteStaffForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStaffID.Text, out int staffId))
            {
                try
                {
                    Database.DeleteStaff(staffId);
                    MessageBox.Show("Staff deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStaffID.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Staff ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
