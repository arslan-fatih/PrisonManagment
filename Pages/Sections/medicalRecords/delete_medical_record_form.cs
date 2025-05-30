using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class delete_medical_record_form : Form
    {
        public delete_medical_record_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medical_Record medicalRecordForm = new Medical_Record();
            medicalRecordForm.ShowDialog();
            this.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                    throw new ArgumentException("Please enter a record ID.");

                if (!int.TryParse(txtID.Text, out int id))
                    throw new ArgumentException("Please enter a valid record ID.");

                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete medical record with ID: {id}?\nThis action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the medical record from the database
                    Database.DeleteMedicalRecord(id);
                    
                    MessageBox.Show("Medical record deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Clear the input field for the next operation
                    txtID.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Deletion Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
