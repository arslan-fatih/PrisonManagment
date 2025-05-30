using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class Medical_Record : Form
    {
        private DataTable medicalRecordsDataTable;
        private DataView medicalRecordsDataView;
        private BindingSource _bs;

        public Medical_Record()
        {
            InitializeComponent();
            LoadMedicalRecords();
            this.Load += medical_records_form_Load;
        }

        private void LoadMedicalRecords()
        {
            try
            {
                medicalRecordsDataTable = Database.GetAllMedicalRecords();
                medicalRecordsDataView = new DataView(medicalRecordsDataTable);
                _bs = new BindingSource();
                _bs.DataSource = medicalRecordsDataView;
                dataGridView1.DataSource = _bs;
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medical records: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_medical_record_form addForm = new add_medical_record_form();
            addForm.FormClosed += (s, args) => { this.Show(); LoadMedicalRecords(); };
            addForm.ShowDialog();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_medical_record_form updateForm = new update_medical_record_form();
            updateForm.FormClosed += (s, args) => { this.Show(); LoadMedicalRecords(); };
            updateForm.ShowDialog();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_medical_record_form deleteForm = new delete_medical_record_form();
            deleteForm.FormClosed += (s, args) => { this.Show(); LoadMedicalRecords(); };
            deleteForm.ShowDialog();
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(search_bar.Text))
                {
                    _bs.Filter = string.Empty;
                    return;
                }

                string searchText = search_bar.Text.Trim();
                string filter = string.Empty;

                // Try to parse as int for numeric fields
                if (int.TryParse(searchText, out int number))
                {
                    filter = $"ID = {number} OR InmateID = {number}";
                }
                
                // Always search in text fields
                if (!string.IsNullOrEmpty(filter))
                    filter += " OR ";
                    
                filter += $"Conditions LIKE '%{searchText.Replace("'", "''")}%' OR " +
                         $"Medications LIKE '%{searchText.Replace("'", "''")}%' OR " +
                         $"Notes LIKE '%{searchText.Replace("'", "''")}%'";

                _bs.Filter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Search Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void medical_records_form_Load(object sender, EventArgs e)
        {
            // Set up DataGridView properties
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
    }
}
