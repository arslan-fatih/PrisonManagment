using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class delete_supply_form : Form
    {
        public delete_supply_form()
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

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSupplyID.Text, out int supplyId))
                {
                    MessageBox.Show("Please enter a valid supply ID.", "Invalid Input", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this supply? This action cannot be undone.",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Using the existing DeleteSupplies method
                    Database.DeleteSupplies(supplyId);
                    MessageBox.Show("Supply deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplyID.Clear();
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
