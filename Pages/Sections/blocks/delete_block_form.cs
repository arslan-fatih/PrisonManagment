using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class delete_block_form : Form
    {
        public delete_block_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            blocks_form blocksForm = new blocks_form();
            blocksForm.ShowDialog();
            this.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBlockID.Text))
                    throw new ArgumentException("Please enter a Block ID.");

                int id = int.Parse(txtBlockID.Text);

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Block ID: {id}?\nThis action cannot be undone.", 
                    "Confirm Deletion", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Database.DeleteBlock(id);
                    MessageBox.Show("Block deleted successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBlockID.Clear();
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
