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
    public partial class staff_form : Form
    {
        private DataTable _staffTable;
        private BindingSource _bs;
        public staff_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }



        private void staff_form_Load(object sender, EventArgs e)
        {

            // 1) SQL’den veriyi çek
            _staffTable = Database.GetAllStaff();

            // 2) BindingSource hazırla
            _bs = new BindingSource { DataSource = _staffTable };

            // 3) DataGridView’e bağla
            dataGridView1.DataSource = _bs;
        }

        private void add_staff_form_button_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            add_staff_form add_Staff_Form = new add_staff_form();
            this.Hide();
            add_Staff_Form.ShowDialog();
            this.Close();
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            string s = search_bar.Text.Replace("'", "''");  // Tek tırnak kaçağı önle

            if (string.IsNullOrWhiteSpace(s))
            {
                _bs.RemoveFilter(); // Kutuyu boşaltınca tüm kayıtları göster
            }
            else
            {
                // Burada istediğin sütunlarda ara
                _bs.Filter =
                    $"Name LIKE '%{s}%' OR " +
                    $"Role LIKE '%{s}%' OR " +
                    $"Convert(ID, 'System.String') LIKE '%{s}%'";
            }
        }
    }
}
