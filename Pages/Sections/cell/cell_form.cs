using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PrisonManagment;

namespace PrisonManagment.Pages.Sections
{
    public partial class cell_form : Form
    {
        private DataTable cellsDataTable;
        private DataView cellsDataView;
        private BindingSource _bs;

        public cell_form()
        {
            InitializeComponent();
            LoadCells();
            this.Load += cell_form_Load;
        }

        private void LoadCells()
        {
            try
            {
                cellsDataTable = Database.GetAllCells();
                cellsDataView = new DataView(cellsDataTable);
                _bs = new BindingSource();
                _bs.DataSource = cellsDataView;
                dataGridView1.DataSource = _bs;
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cells: {ex.Message}", "Error", 
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

        private void btnAddCell_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_cell_form addForm = new add_cell_form();
            addForm.FormClosed += (s, args) => { this.Show(); LoadCells(); };
            addForm.ShowDialog();
        }

        private void btnUpdateCell_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_cell_form updateForm = new update_cell_form();
            updateForm.FormClosed += (s, args) => { this.Show(); LoadCells(); };
            updateForm.ShowDialog();
        }

        private void btnDeleteCell_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_cell_form deleteForm = new delete_cell_form();
            deleteForm.FormClosed += (s, args) => { this.Show(); LoadCells(); };
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
                    filter = $"Number = {number} OR BlockID = {number}";
                }
                else
                {
                    // For text search (solitary)
                    filter = $"Solitary = '{searchText}'";
                }

                _bs.Filter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Search Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cell_form_Load(object sender, EventArgs e)
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
