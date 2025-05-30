using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class houses_form : Form
    {
        private DataTable housesDataTable;
        private DataView housesDataView;
        private BindingSource _bs;

        public houses_form()
        {
            InitializeComponent();
            LoadHouses();
        }

        private void LoadHouses()
        {
            try
            {
                housesDataTable = Database.GetAllHouses();
                housesDataView = new DataView(housesDataTable);
                _bs = new BindingSource();
                _bs.DataSource = housesDataView;
                dataGridView1.DataSource = _bs;
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading houses: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
{
        this.Hide();
        MainMenu mainMenu = new MainMenu();
        mainMenu.ShowDialog();
        this.Close();
}


        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_house_form addForm = new add_house_form();
            addForm.FormClosed += (s, args) => { this.Show(); LoadHouses(); };
            addForm.ShowDialog();
        }

        private void btnUpdateHouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_house_form updateForm = new update_house_form();
            updateForm.FormClosed += (s, args) => { this.Show(); LoadHouses(); };
            updateForm.ShowDialog();
        }

        private void btnDeleteHouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_house_form deleteForm = new delete_house_form();
            deleteForm.FormClosed += (s, args) => { this.Show(); LoadHouses(); };
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
                    filter = $"InmateID = {number} OR CellNumber = {number}";
                }
                else
                {
                    // If not a number, search in text fields if any
                    filter = $"1=0"; // No text fields to search in Houses table
                }

                _bs.Filter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Search Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void houses_form_Load(object sender, EventArgs e)
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
