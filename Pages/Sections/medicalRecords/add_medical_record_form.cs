using System;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class add_medical_record_form : Form
    {
        public add_medical_record_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medical_Record medicalRecordForm = new Medical_Record();
            medicalRecordForm.ShowDialog();
            this.Close();
        }

        private void ClearInputs()
        {
            txtID.Clear();
            txtInmateID.Clear();
            txtConditions.Clear();
            txtMedications.Clear();
            txtNotes.Clear();
            dtpLastCheckup.Checked = false;
            dtpLastCheckup.CustomFormat = " ";
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (!int.TryParse(txtID.Text, out int id))
                    throw new ArgumentException("Please enter a valid ID.");

                if (!int.TryParse(txtInmateID.Text, out int inmateId) && !string.IsNullOrWhiteSpace(txtInmateID.Text))
                    throw new ArgumentException("Please enter a valid Inmate ID or leave it empty.");

                if (string.IsNullOrWhiteSpace(txtConditions.Text))
                    throw new ArgumentException("Please enter the medical conditions.");

                // Get optional fields
                string medications = string.IsNullOrWhiteSpace(txtMedications.Text) ? null : txtMedications.Text.Trim();
                string notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim();
                DateTime? lastCheckup = dtpLastCheckup.Checked ? dtpLastCheckup.Value : (DateTime?)null;

                // Save to database
                Database.AddMedicalRecord(
                    id,
                    string.IsNullOrWhiteSpace(txtInmateID.Text) ? (int?)null : inmateId,
                    txtConditions.Text.Trim(),
                    medications,
                    lastCheckup,
                    notes
                );

                MessageBox.Show("Medical record added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Add Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpLastCheckup_ValueChanged(object sender, EventArgs e)
        {
            // This prevents the " " custom format from showing after a date is selected
            if (dtpLastCheckup.Checked && dtpLastCheckup.CustomFormat == " ")
            {
                dtpLastCheckup.CustomFormat = "MM/dd/yyyy";
            }
        }
    }
}
