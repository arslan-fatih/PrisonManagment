using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class add_block_form : Form
    {
        public add_block_form()
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

        private void ClearInputs()
        {
            txtBlockID.Clear();
            numSecurityLevel.Value = 1;
            txtType.Clear();
            txtGarden.Clear();
            txtManagerID.Clear();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Get data from form
                int id = int.Parse(txtBlockID.Text);
                int securityLevel = (int)numSecurityLevel.Value;
                string type = txtType.Text.Trim();
                string garden = txtGarden.Text.Trim();
                int? managerId = !string.IsNullOrWhiteSpace(txtManagerID.Text) ? 
                    int.Parse(txtManagerID.Text) : (int?)null;

                // Basic validation
                if (string.IsNullOrWhiteSpace(type))
                    throw new ArgumentException("Block type cannot be empty.");

                // Save to database
                Database.AddBlock(id, securityLevel, type, garden, managerId);

                MessageBox.Show("Block added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
