using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PrisonManagment;

namespace PrisonManagment.Pages.Sections
{
    public partial class supplies_form : Form
    {
        private DataTable suppliesDataTable;
        private DataView suppliesDataView;
        private BindingSource _bs;

        public supplies_form()
        {
            InitializeComponent();
            LoadSupplies();
        }

        private void LoadSupplies()
        {
            try
            {
                suppliesDataTable = Database.GetAllSupplies();
                suppliesDataView = new DataView(suppliesDataTable);
                _bs = new BindingSource();
                _bs.DataSource = suppliesDataView;
                dataGridView1.DataSource = _bs;
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading supplies: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new PrisonManagment.MainMenu();
            mainForm.ShowDialog();
            this.Close();
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_supply_form addForm = new add_supply_form();
            addForm.FormClosed += (s, args) => { this.Show(); LoadSupplies(); };
            addForm.ShowDialog();
        }

        private void btnUpdateSupply_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_supply_form updateForm = new update_supply_form();
            updateForm.FormClosed += (s, args) => { this.Show(); LoadSupplies(); };
            updateForm.ShowDialog();
        }

        private void btnDeleteSupply_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_supply_form deleteForm = new delete_supply_form();
            deleteForm.FormClosed += (s, args) => { this.Show(); LoadSupplies(); };
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
                    filter = $"InventoryID = {number} OR StaffID = {number}";
                }
                
                // Always search in text fields
                if (!string.IsNullOrEmpty(filter))
                    filter += " OR ";
                    
                filter += $"Supplier LIKE '%{searchText.Replace("'", "''")}%'";

                _bs.Filter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Search Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void supplies_form_Load(object sender, EventArgs e)
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