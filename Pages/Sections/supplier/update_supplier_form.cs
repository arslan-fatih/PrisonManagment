using System;
using System.Data;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class update_supplier_form : Form
    {
        public update_supplier_form()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                    throw new ArgumentException("Please enter a supplier name to search.");

                // Search for the supplier in the database by name
                var suppliers = Database.GetAllSuppliers();
                var supplier = suppliers.Rows.Cast<DataRow>()
                    .FirstOrDefault(r => r["Name"].ToString().Equals(txtID.Text.Trim(), StringComparison.OrdinalIgnoreCase));

                if (supplier == null)
                {
                    MessageBox.Show("Supplier not found.", "Not Found", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Fill the form with the found supplier's data
                txtName.Text = supplier["Name"].ToString();
                txtContactPerson.Text = supplier["ContactPerson"] != DBNull.Value ? supplier["ContactPerson"].ToString() : "";
                txtEmail.Text = supplier["Email"] != DBNull.Value ? supplier["Email"].ToString() : "";
                txtPhone.Text = supplier["Phone"] != DBNull.Value ? supplier["Phone"].ToString() : "";
                txtAddress.Text = supplier["Address"] != DBNull.Value ? supplier["Address"].ToString() : "";
                
                // Enable the update button and fields
                update_button.Enabled = true;
                txtName.Enabled = true;
                txtContactPerson.Enabled = true;
                txtEmail.Enabled = true;
                txtPhone.Enabled = true;
                txtAddress.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Search Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtID.Text, out int id))
                    throw new ArgumentException("Please enter a valid ID.");

                if (string.IsNullOrWhiteSpace(txtName.Text))
                    throw new ArgumentException("Please enter a supplier name.");

                // Get optional fields
                string contactPerson = string.IsNullOrWhiteSpace(txtContactPerson.Text) ? null : txtContactPerson.Text.Trim();
                string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
                string phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim();
                string address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim();

                // Update the supplier in the database - using the correct method signature
                Database.UpdateSupplier(
                    txtName.Text.Trim(),
                    phone,
                    email
                );

                MessageBox.Show("Supplier updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear the form for the next operation
                txtID.Clear();
                txtName.Clear();
                txtContactPerson.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtAddress.Clear();
                
                update_button.Enabled = false;
                txtName.Enabled = false;
                txtContactPerson.Enabled = false;
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;
                txtAddress.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
