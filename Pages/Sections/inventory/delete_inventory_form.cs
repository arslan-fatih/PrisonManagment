using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class delete_inventory_form : Form
    {
        public delete_inventory_form()
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

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                    throw new ArgumentException("Please enter an ID.");

                if (!int.TryParse(txtID.Text, out int id))
                    throw new ArgumentException("Please enter a valid ID.");

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete inventory item with ID: {id}?\nThis action cannot be undone.", 
                    "Confirm Deletion", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Database.DeleteInventory(id);
                    MessageBox.Show("Inventory item deleted successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
