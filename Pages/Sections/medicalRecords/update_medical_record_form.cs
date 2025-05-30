using System;
using System.Data;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class update_medical_record_form : Form
    {
        public update_medical_record_form()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtID.Text, out int id))
                    throw new ArgumentException("Please enter a valid ID to search.");

                // Search for the medical record in the database
                var records = Database.GetAllMedicalRecords();
                var record = records.Rows.Cast<DataRow>()
                    .FirstOrDefault(r => Convert.ToInt32(r["ID"]) == id);

                if (record == null)
                {
                    MessageBox.Show("Medical record not found.", "Not Found", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Fill the form with the found record's data
                txtInmateID.Text = record["InmateID"] != DBNull.Value ? record["InmateID"].ToString() : "";
                txtConditions.Text = record["Conditions"].ToString();
                txtMedications.Text = record["Medications"] != DBNull.Value ? record["Medications"].ToString() : "";
                txtNotes.Text = record["Notes"] != DBNull.Value ? record["Notes"].ToString() : "";
                
                if (record["LastCheckup"] != DBNull.Value)
                {
                    dtpLastCheckup.Checked = true;
                    dtpLastCheckup.Value = Convert.ToDateTime(record["LastCheckup"]);
                }
                else
                {
                    dtpLastCheckup.Checked = false;
                    dtpLastCheckup.CustomFormat = " ";
                }
                
                // Enable the update button and fields
                update_button.Enabled = true;
                txtInmateID.Enabled = true;
                txtConditions.Enabled = true;
                txtMedications.Enabled = true;
                txtNotes.Enabled = true;
                dtpLastCheckup.Enabled = true;
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

                // Update the medical record in the database
                Database.UpdateMedicalRecord(
                    id,
                    string.IsNullOrWhiteSpace(txtInmateID.Text) ? (int?)null : inmateId,
                    txtConditions.Text.Trim(),
                    medications,
                    lastCheckup,
                    notes
                );

                MessageBox.Show("Medical record updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear the form for the next operation
                txtID.Clear();
                txtInmateID.Clear();
                txtConditions.Clear();
                txtMedications.Clear();
                txtNotes.Clear();
                dtpLastCheckup.Checked = false;
                dtpLastCheckup.CustomFormat = " ";
                
                update_button.Enabled = false;
                txtInmateID.Enabled = false;
                txtConditions.Enabled = false;
                txtMedications.Enabled = false;
                txtNotes.Enabled = false;
                dtpLastCheckup.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Failed",
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
