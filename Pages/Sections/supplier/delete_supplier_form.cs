using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class delete_supplier_form : Form
    {
        public delete_supplier_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplier_form supplierForm = new supplier_form();
            supplierForm.ShowDialog();
            this.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                    throw new ArgumentException("Please enter a supplier name.");

                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete supplier with name: {txtID.Text}?\nThis action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the supplier from the database - using the correct method signature
                    Database.DeleteSupplier(txtID.Text.Trim());
                    
                    MessageBox.Show("Supplier deleted successfully!", "Success",
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
