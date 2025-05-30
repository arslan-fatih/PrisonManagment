using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PrisonManagment;

namespace PrisonManagment.Pages.Sections
{
    public partial class supplier_form : Form
    {
        private DataTable suppliersDataTable;
        private DataView suppliersDataView;
        private BindingSource _bs;

        public supplier_form()
        {
            InitializeComponent();
            LoadSuppliers();
            this.Load += supplier_form_Load;
        }

        private void LoadSuppliers()
        {
            try
            {
                suppliersDataTable = Database.GetAllSuppliers();
                suppliersDataView = new DataView(suppliersDataTable);
                _bs = new BindingSource();
                _bs.DataSource = suppliersDataView;
                dataGridView1.DataSource = _bs;
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", 
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

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_supplier_form addForm = new add_supplier_form();
            addForm.FormClosed += (s, args) => { this.Show(); LoadSuppliers(); };
            addForm.ShowDialog();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_supplier_form updateForm = new update_supplier_form();
            updateForm.FormClosed += (s, args) => { this.Show(); LoadSuppliers(); };
            updateForm.ShowDialog();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_supplier_form deleteForm = new delete_supplier_form();
            deleteForm.FormClosed += (s, args) => { this.Show(); LoadSuppliers(); };
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
                    filter = $"ID = {number}";
                }
                
                // Always search in text fields
                if (!string.IsNullOrEmpty(filter))
                    filter += " OR ";
                    
                filter += $"Name LIKE '%{searchText.Replace("'", "''")}%' OR " +
                         $"ContactPerson LIKE '%{searchText.Replace("'", "''")}%' OR " +
                         $"Email LIKE '%{searchText.Replace("'", "''")}%' OR " +
                         $"Phone LIKE '%{searchText.Replace("'", "''")}%' OR " +
                         $"Address LIKE '%{searchText.Replace("'", "''")}%'";

                _bs.Filter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Search Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void supplier_form_Load(object sender, EventArgs e)
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
