using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class inventory_form : Form
    {
        private DataTable inventoryDataTable;
        private DataView inventoryDataView;
        private BindingSource _bs;

        public inventory_form()
        {
            InitializeComponent();
            LoadInventory();
            this.Load += inventory_form_Load;
        }

        private void LoadInventory()
        {
            try
            {
                inventoryDataTable = Database.GetAllInventory();
                inventoryDataView = new DataView(inventoryDataTable);
                _bs = new BindingSource();
                _bs.DataSource = inventoryDataView;
                dataGridView1.DataSource = _bs;
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading inventory: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_inventory_form addForm = new add_inventory_form();
            addForm.FormClosed += (s, args) => { this.Show(); LoadInventory(); };
            addForm.ShowDialog();
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_inventory_form updateForm = new update_inventory_form();
            updateForm.FormClosed += (s, args) => { this.Show(); LoadInventory(); };
            updateForm.ShowDialog();
        }

        private void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_inventory_form deleteForm = new delete_inventory_form();
            deleteForm.FormClosed += (s, args) => { this.Show(); LoadInventory(); };
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
                    filter = $"ID = {number} OR Amount = {number}";
                }
                
                // Always search in name field
                if (!string.IsNullOrEmpty(filter))
                    filter += " OR ";
                    
                filter += $"Name LIKE '%{searchText.Replace("'", "''")}%'";

                _bs.Filter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Search Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void inventory_form_Load(object sender, EventArgs e)
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
