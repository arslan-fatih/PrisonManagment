using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class update_block_form : Form
    {
        public update_block_form()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBlockID.Text, out int blockId))
                {
                    MessageBox.Show("Please enter a valid Block ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var blocks = Database.GetAllBlocks(); // Veritabanı sorgusu
                var block = blocks.Rows.Cast<DataRow>()
                    .FirstOrDefault(r => Convert.ToInt32(r["BlockID"]) == blockId);

                if (block == null)
                {
                    MessageBox.Show("Block not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Form alanlarını doldur
                numSecurityLevel.Value = Convert.ToDecimal(block["SecurityLevel"]);
                txtType.Text = block["Type"].ToString();
                txtGarden.Text = block["Garden"].ToString();
                txtManagerID.Text = block["ManagerID"] != DBNull.Value ? block["ManagerID"].ToString() : "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtBlockID.Text);
                int securityLevel = (int)numSecurityLevel.Value;
                string type = txtType.Text.Trim();
                string garden = txtGarden.Text.Trim();
                int? managerId = !string.IsNullOrWhiteSpace(txtManagerID.Text)
                    ? int.Parse(txtManagerID.Text) : (int?)null;

                if (string.IsNullOrWhiteSpace(type))
                    throw new ArgumentException("Block type cannot be empty.");

                Database.UpdateBlock(id, securityLevel, type, garden, managerId);

                MessageBox.Show("Block updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
