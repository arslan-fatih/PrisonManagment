using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class delete_cell_form : Form
    {
        public delete_cell_form()
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

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCellNumber.Text))
                    throw new ArgumentException("Please enter a cell number.");

                if (!int.TryParse(txtCellNumber.Text, out int cellNumber))
                    throw new ArgumentException("Please enter a valid cell number.");

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Cell Number: {cellNumber}?\nThis action cannot be undone.", 
                    "Confirm Deletion", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Database.DeleteCell(cellNumber);
                    MessageBox.Show("Cell deleted successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCellNumber.Clear();
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
