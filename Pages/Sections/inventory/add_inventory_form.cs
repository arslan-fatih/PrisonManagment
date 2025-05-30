using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class add_inventory_form : Form
    {
        public add_inventory_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            inventory_form inventoryForm = new inventory_form();
            inventoryForm.ShowDialog();
            this.Close();
        }

        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtAmount.Clear();
            dtpLastRestock.Value = DateTime.Now;
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (!int.TryParse(txtID.Text, out int id))
                    throw new ArgumentException("Please enter a valid ID.");

                if (string.IsNullOrWhiteSpace(txtName.Text))
                    throw new ArgumentException("Please enter an inventory item name.");

                if (!int.TryParse(txtAmount.Text, out int amount) || amount < 0)
                    throw new ArgumentException("Please enter a valid amount (must be a positive number).");

                // Get LastRestock date (can be null if not specified)
                DateTime? lastRestock = dtpLastRestock.Checked ? dtpLastRestock.Value : (DateTime?)null;

                // Save to database
                Database.AddInventory(id, txtName.Text.Trim(), amount, lastRestock);

                MessageBox.Show("Inventory item added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Add Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpLastRestock_ValueChanged(object sender, EventArgs e)
        {
            // This handler is needed for the DateTimePicker control
            // If the DateTimePicker was previously empty and now has a value
            if (dtpLastRestock.CustomFormat == " ")
            {
                dtpLastRestock.CustomFormat = null;
            }
        }
    }
}
