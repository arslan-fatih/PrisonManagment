using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class add_supplier_form : Form
    {
        public add_supplier_form()
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

        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtContactPerson.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtName.Text))
                    throw new ArgumentException("Please enter a supplier name.");

                // Get optional fields
                string phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim();
                string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();

                // Save to database - using the correct method signature
                Database.AddSupplier(
                    txtName.Text.Trim(),
                    phone,
                    email
                );

                MessageBox.Show("Supplier added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Add Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
