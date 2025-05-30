using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class add_house_form : Form
    {
        public add_house_form()
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

        private void ClearInputs()
        {
            txtInmateID.Clear();
            txtCellNumber.Clear();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Get data from form
                if (!int.TryParse(txtInmateID.Text, out int inmateId))
                    throw new ArgumentException("Please enter a valid inmate ID.");

                int? cellNumber = null;
                if (!string.IsNullOrWhiteSpace(txtCellNumber.Text))
                {
                    if (!int.TryParse(txtCellNumber.Text, out int cellNum))
                        throw new ArgumentException("Please enter a valid cell number or leave it empty.");
                    cellNumber = cellNum;
                }

                // Save to database
                Database.AddHouse(inmateId, cellNumber);

                MessageBox.Show("House record added successfully!", "Success",
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
