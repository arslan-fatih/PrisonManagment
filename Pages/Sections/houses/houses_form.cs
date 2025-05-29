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
    public partial class houses_form : Form
    {
        private DataTable _cellTable;
        private BindingSource _bs;
        public houses_form()
        {
            InitializeComponent();
            this.Load += houses_form_Load;
            dataGridView1.AutoGenerateColumns = true;
        }
        private void houses_form_Load(object sender, EventArgs e)
        {

            // 1) SQL’den veriyi çek
            _cellTable = Database.GetAllHouses();

            // 2) BindingSource hazırla
            _bs = new BindingSource { DataSource = _cellTable };

            // 3) DataGridView’e bağla
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
    }
}
