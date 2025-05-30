using System;
using System.Data;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class update_house_form : Form
    {
        public update_house_form()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtInmateID.Text, out int inmateId))
                    throw new ArgumentException("Please enter a valid inmate ID to search.");

                // Search for the house record in the database
                var houses = Database.GetAllHouses();
                var house = houses.Rows.Cast<DataRow>()
                    .FirstOrDefault(r => Convert.ToInt32(r["InmateID"]) == inmateId);

                if (house == null)
                {
                    MessageBox.Show("House record not found.", "Not Found", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Fill the form with the found house's data
                txtCellNumber.Text = house["CellNumber"] != DBNull.Value ? 
                    house["CellNumber"].ToString() : "";
                
                // Enable the update button and cell number field
                update_button.Enabled = true;
                txtCellNumber.Enabled = true;
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
                if (!int.TryParse(txtInmateID.Text, out int inmateId))
                    throw new ArgumentException("Please enter a valid inmate ID.");

                int? cellNumber = null;
                if (!string.IsNullOrWhiteSpace(txtCellNumber.Text))
                {
                    if (!int.TryParse(txtCellNumber.Text, out int cellNum))
                        throw new ArgumentException("Please enter a valid cell number or leave it empty.");
                    cellNumber = cellNum;
                }

                // Update the house record in the database
                Database.UpdateHouse(inmateId, cellNumber);

                MessageBox.Show("House record updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear the form for the next operation
                txtInmateID.Clear();
                txtCellNumber.Clear();
                update_button.Enabled = false;
                txtCellNumber.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
