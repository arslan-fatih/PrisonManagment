using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class add_supply_form : Form
    {
        public add_supply_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplies_form suppliesForm = new supplies_form();
            suppliesForm.ShowDialog();
            this.Close();
        }

        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtCategory.Clear();
            txtQuantity.Clear();
            txtUnit.Clear();
            txtSupplierID.Clear();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (!int.TryParse(txtID.Text, out int id))
                    throw new ArgumentException("Please enter a valid ID.");

                if (string.IsNullOrWhiteSpace(txtName.Text))
                    throw new ArgumentException("Please enter a supply name.");

                if (!int.TryParse(txtQuantity.Text, out int quantity))
                    throw new ArgumentException("Please enter a valid quantity.");

                // Get optional fields
                string category = string.IsNullOrWhiteSpace(txtCategory.Text) ? null : txtCategory.Text.Trim();
                string unit = string.IsNullOrWhiteSpace(txtUnit.Text) ? null : txtUnit.Text.Trim();
                int? supplierId = string.IsNullOrWhiteSpace(txtSupplierID.Text) ? 
                    (int?)null : int.Parse(txtSupplierID.Text.Trim());

                // Save to database
                // Using the existing Database.AddSupplies method
                Database.AddSupplies(
                    id,  // Using ID as InventoryID
                    supplierId, // StaffID
                    txtName.Text.Trim() // Using Name as Supplier
                );

                MessageBox.Show("Supply added successfully!", "Success",
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
