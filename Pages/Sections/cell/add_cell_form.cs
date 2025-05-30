using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class add_cell_form : Form
    {
        public add_cell_form()
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

        private void ClearInputs()
        {
            txtCellNumber.Clear();
            chkSolitary.Checked = false;
            txtBlockID.Clear();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Get data from form
                if (!int.TryParse(txtCellNumber.Text, out int number))
                    throw new ArgumentException("Please enter a valid cell number.");

                bool? solitary = chkSolitary.Checked;
                
                if (!int.TryParse(txtBlockID.Text, out int blockId))
                    throw new ArgumentException("Please enter a valid block ID.");

                // Save to database
                Database.AddCell(number, solitary, blockId);

                MessageBox.Show("Cell added successfully!", "Success",
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
