using System;
using System.Data;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class update_supply_form : Form
    {
        private int? currentSupplyId = null;
        private bool isSearching = false;

        public update_supply_form()
        {
            InitializeComponent();
            SetFormState(false);
        }

        private void SetFormState(bool enabled)
        {
            txtName.Enabled = enabled;
            txtCategory.Enabled = enabled;
            txtQuantity.Enabled = enabled;
            txtUnit.Enabled = enabled;
            txtSupplierID.Enabled = enabled;
            update_button.Enabled = enabled;
            btnSearch.Enabled = !enabled;
            txtSearchID.Enabled = !enabled;
        }

        private void ClearForm()
        {
            txtSearchID.Clear();
            txtName.Clear();
            txtCategory.Clear();
            txtQuantity.Clear();
            txtUnit.Clear();
            txtSupplierID.Clear();
            currentSupplyId = null;
            SetFormState(false);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplies_form suppliesForm = new supplies_form();
            suppliesForm.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSearchID.Text, out int supplyId))
                    throw new ArgumentException("Please enter a valid supply ID.");

                // Using the existing GetAllSupplies method and filtering by ID
                DataTable allSupplies = Database.GetAllSupplies();
                DataTable supplyData = new DataTable();
                supplyData = allSupplies.Clone();
                
                // Filter by InventoryID
                var foundRows = allSupplies.Select($"InventoryID = {supplyId}");
                foreach (var foundRow in foundRows)
                    supplyData.ImportRow(foundRow);

                if (supplyData.Rows.Count == 0)
                {
                    MessageBox.Show("No supply found with the specified ID.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow row = supplyData.Rows[0];
                currentSupplyId = supplyId;
                // Map database fields to form fields
                txtName.Text = row["Supplier"]?.ToString() ?? "";
                txtCategory.Text = "";
                txtQuantity.Text = "0";
                txtUnit.Text = "";
                txtSupplierID.Text = row["StaffID"]?.ToString() ?? "";

                SetFormState(true);
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
                if (!currentSupplyId.HasValue)
                    throw new InvalidOperationException("No supply selected for update.");

                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtName.Text))
                    throw new ArgumentException("Please enter a supply name.");

                if (!int.TryParse(txtQuantity.Text, out int quantity))
                    throw new ArgumentException("Please enter a valid quantity.");

                // Get optional fields
                string category = string.IsNullOrWhiteSpace(txtCategory.Text) ? null : txtCategory.Text.Trim();
                string unit = string.IsNullOrWhiteSpace(txtUnit.Text) ? null : txtUnit.Text.Trim();
                int? supplierId = string.IsNullOrWhiteSpace(txtSupplierID.Text) ? 
                    (int?)null : int.Parse(txtSupplierID.Text.Trim());

                // Update in database using the existing UpdateSupplies method
                Database.UpdateSupplies(
                    currentSupplyId.Value, // InventoryID
                    supplierId, // StaffID
                    txtName.Text.Trim() // Supplier
                );

                MessageBox.Show("Supply updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
