using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class update_cell_form : Form
    {
        public update_cell_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            cell_form cellForm = new cell_form();
            cellForm.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCellNumber.Text, out int cellNumber))
                    throw new ArgumentException("Please enter a valid cell number to search.");

                // Search for the cell in the database
                var cells = Database.GetAllCells();
                var cell = cells.Rows.Cast<DataRow>()
                    .FirstOrDefault(r => Convert.ToInt32(r["Number"]) == cellNumber);

                if (cell == null)
                {
                    MessageBox.Show("Cell not found.", "Not Found", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                // Fill the form with the found cell's data
                chkSolitary.Checked = cell["Solitary"] != DBNull.Value && Convert.ToBoolean(cell["Solitary"]);
                txtBlockID.Text = cell["BlockID"].ToString();
                
                // Enable the update button
                update_button.Enabled = true;
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
                if (!int.TryParse(txtCellNumber.Text, out int cellNumber))
                    throw new ArgumentException("Please enter a valid cell number.");

                bool? solitary = chkSolitary.Checked;
                
                if (!int.TryParse(txtBlockID.Text, out int blockId))
                    throw new ArgumentException("Please enter a valid block ID.");

                // Update the cell in the database
                Database.UpdateCell(cellNumber, solitary, blockId);

                MessageBox.Show("Cell updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear the form for the next operation
                txtCellNumber.Clear();
                chkSolitary.Checked = false;
                txtBlockID.Clear();
                update_button.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
