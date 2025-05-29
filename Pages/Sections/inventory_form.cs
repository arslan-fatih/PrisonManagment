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
    public partial class inventory_form : Form
    {
        private DataTable _inventoryTable;
        private BindingSource _bs;
        public inventory_form()
        {
            InitializeComponent();
            this.Load += inventory_form_Load;
            dataGridView1.AutoGenerateColumns = true;
        }
        private void inventory_form_Load(object sender, EventArgs e)
        {

            // 1) SQL’den veriyi çek
            _inventoryTable = Database.GetAllInventory();

            // 2) BindingSource hazırla
            _bs = new BindingSource { DataSource = _inventoryTable };

            // 3) DataGridView’e bağla
            dataGridView1.DataSource = _bs;
        }
        
        private void back_button_Click_1(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            string s = search_bar.Text.Replace("'", "''"); // SQL injection'a karşı önlem

            if (string.IsNullOrWhiteSpace(s))
            {
                _bs.RemoveFilter();
            }
            else
            {
                _bs.Filter =
                    $"Name LIKE '%{s}%' OR " +
                    $"Convert(ID, 'System.String') LIKE '%{s}%' OR " +
                    $"Convert(Amount, 'System.String') LIKE '%{s}%' OR " +
                    $"Convert(LastRestock, 'System.String') LIKE '%{s}%'";
            }
        }

    }
}
