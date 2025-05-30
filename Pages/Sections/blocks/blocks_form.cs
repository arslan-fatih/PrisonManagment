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
    public partial class blocks_form : Form
    {
        private DataTable _blocksTable;
        private BindingSource _bs;

        public blocks_form()
        {
            InitializeComponent();
            this.Load += blocks_form_Load;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void blocks_form_Load(object sender, EventArgs e)
        {
            LoadBlocksData();
        }

        private void LoadBlocksData()
        {
            // 1) Get data from database
            _blocksTable = Database.GetAllBlocks();

            // 2) Prepare BindingSource
            _bs = new BindingSource { DataSource = _blocksTable };

            // 3) Bind to DataGridView
            dataGridView1.DataSource = _bs;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void btnAddBlock_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_block_form addForm = new add_block_form();
            addForm.FormClosed += (s, args) => { this.Show(); LoadBlocksData(); };
            addForm.ShowDialog();
        }

        private void btnUpdateBlock_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_block_form updateForm = new update_block_form();
            updateForm.FormClosed += (s, args) => { this.Show(); LoadBlocksData(); };
            updateForm.ShowDialog();
        }

        private void btnDeleteBlock_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_block_form deleteForm = new delete_block_form();
            deleteForm.FormClosed += (s, args) => { this.Show(); LoadBlocksData(); };
            deleteForm.ShowDialog();
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            string searchText = search_bar.Text.Replace("'", "''").ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _bs.RemoveFilter();
            }
            else
            {
                string filter = $"ID = {searchText} OR " +
                              $"SecurityLV = {searchText} OR " +
                              $"Type LIKE '%{searchText}%' OR " +
                              $"Garden LIKE '%{searchText}%' OR " +
                              $"ManagerID = {searchText}";
                
                try
                {
                    _bs.Filter = filter;
                }
                catch (Exception ex)
                {
                    // If the filter expression is invalid, just clear the filter
                    _bs.Filter = "";
                }
            }
        }
    }
}
