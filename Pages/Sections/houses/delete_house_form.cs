using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class delete_house_form : Form
    {
        public delete_house_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            houses_form housesForm = new houses_form();
            housesForm.ShowDialog();
            this.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtInmateID.Text))
                    throw new ArgumentException("Please enter an inmate ID.");

                if (!int.TryParse(txtInmateID.Text, out int inmateId))
                    throw new ArgumentException("Please enter a valid inmate ID.");

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete house record for Inmate ID: {inmateId}?\nThis action cannot be undone.", 
                    "Confirm Deletion", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Database.DeleteHouse(inmateId);
                    MessageBox.Show("House record deleted successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInmateID.Clear();
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
