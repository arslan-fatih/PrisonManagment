using System;
using System.Data;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class update_inventory_form : Form
    {
        public update_inventory_form()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtID.Text, out int id))
                    throw new ArgumentException("Please enter a valid ID to search.");

                // Search for the inventory item in the database
                var inventory = Database.GetAllInventory();
                var item = inventory.Rows.Cast<DataRow>()
                    .FirstOrDefault(r => Convert.ToInt32(r["ID"]) == id);

                if (item == null)
                {
                    MessageBox.Show("Inventory item not found.", "Not Found", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Fill the form with the found item's data
                txtName.Text = item["Name"].ToString();
                txtAmount.Text = item["Amount"].ToString();
                
                if (item["LastRestock"] != DBNull.Value)
                {
                    dtpLastRestock.Checked = true;
                    dtpLastRestock.Value = Convert.ToDateTime(item["LastRestock"]);
                }
                else
                {
                    dtpLastRestock.Checked = false;
                    dtpLastRestock.CustomFormat = " ";
                }
                
                // Enable the update button and fields
                update_button.Enabled = true;
                txtName.Enabled = true;
                txtAmount.Enabled = true;
                dtpLastRestock.Enabled = true;
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
                    throw new ArgumentException("Please enter an inventory item name.");

                if (!int.TryParse(txtAmount.Text, out int amount) || amount < 0)
                    throw new ArgumentException("Please enter a valid amount (must be a positive number).");

                // Get LastRestock date (can be null if not specified)
                DateTime? lastRestock = dtpLastRestock.Checked ? dtpLastRestock.Value : (DateTime?)null;

                // Update the inventory item in the database
                Database.UpdateInventory(id, txtName.Text.Trim(), amount, lastRestock);

                MessageBox.Show("Inventory item updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear the form for the next operation
                txtID.Clear();
                txtName.Clear();
                txtAmount.Clear();
                dtpLastRestock.Checked = false;
                dtpLastRestock.CustomFormat = " ";
                update_button.Enabled = false;
                txtName.Enabled = false;
                txtAmount.Enabled = false;
                dtpLastRestock.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpLastRestock_ValueChanged(object sender, EventArgs e)
        {
            // This prevents the " " custom format from showing after a date is selected
            if (dtpLastRestock.Checked && dtpLastRestock.CustomFormat == " ")
            {
                dtpLastRestock.CustomFormat = "MM/dd/yyyy";
            }
        }
    }
}
