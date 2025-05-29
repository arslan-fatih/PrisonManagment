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
    public partial class inmate_form : Form
    {
        private DataTable _inmateTable;
        private BindingSource _bs;
        public inmate_form()
        {
            InitializeComponent();
            this.Load += inmate_form_Load;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void inmate_form_Load(object sender, EventArgs e)
        {

            // 1) SQL’den veriyi çek
            _inmateTable = Database.GetAllInmates();

            // 2) BindingSource hazırla
            _bs = new BindingSource { DataSource = _inmateTable };

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
        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            string s = search_bar.Text.Replace("'", "''");

            if (string.IsNullOrWhiteSpace(s))
            {
                _bs.RemoveFilter();
            }
            else
            {
                _bs.Filter =
                    $"Name LIKE '%{s}%' OR " +
                    $"Gender LIKE '%{s}%' OR " +
                    $"Crime LIKE '%{s}%' OR " +
                    $"Convert(ID, 'System.String') LIKE '%{s}%' OR " +
                    $"Convert(Age, 'System.String') LIKE '%{s}%' OR " +
                    $"Convert(DateOfBirth, 'System.String') LIKE '%{s}%' OR " +
                    $"Convert(EntryDate, 'System.String') LIKE '%{s}%' OR " +
                    $"Convert(ReleaseDate, 'System.String') LIKE '%{s}%'";
            }
        }

        private void add_staff_form_button_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            add_inmate_form add_inmate_form = new add_inmate_form();
            this.Hide();
            add_inmate_form.ShowDialog();
            this.Close();
        }

        private void inmate_form_Load_1(object sender, EventArgs e)
        {

        }
    }
}