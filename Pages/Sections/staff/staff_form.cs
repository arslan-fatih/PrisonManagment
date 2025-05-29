using System;
using System.Data;
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
            this.Load += staff_form_Load;
        }

        private void staff_form_Load(object sender, EventArgs e)
        {
            try
            {
                _staffTable = Database.GetAllStaff();
                _bs = new BindingSource { DataSource = _staffTable };
                dataGridView1.DataSource = _bs;
                dataGridView1.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading staff data:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var mainMenu = new MainMenu(); // MainMenu sınıfının tanımlı olduğundan emin ol!
                mainMenu.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't return to main menu:\n" + ex.Message);
            }
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            string s = search_bar.Text.Replace("'", "''");

            if (_bs == null) return;

            if (string.IsNullOrWhiteSpace(s))
            {
                _bs.RemoveFilter();
            }
            else
            {
                _bs.Filter =
                    $"Name LIKE '%{s}%' OR " +
                    $"Role LIKE '%{s}%' OR " +
                    $"Convert(ID, 'System.String') LIKE '%{s}%' OR " +
                    $"Convert(Age, 'System.String') LIKE '%{s}%' OR " +
                    $"Convert(Wage, 'System.String') LIKE '%{s}%' OR " +
                    $"Convert(Supervisor, 'System.String') LIKE '%{s}%' OR " +
                    $"Convert(AssignedBlock, 'System.String') LIKE '%{s}%'";
            }
        }

        private void add_staff_form_button_Click(object sender, EventArgs e)
{
    this.Hide();
    using var addForm = new add_staff_form(); // ✅ Namespace: PrisonManagment
    addForm.ShowDialog();
    this.Close();
}

private void delete_staff_form_button_Click(object sender, EventArgs e)
{
    this.Hide();
    using var deleteForm = new DeleteStaffForm(); // ✅ Class adı doğru, namespace PrisonManagment
    deleteForm.ShowDialog();
    this.Close();
}

private void update_staff_form_button_Click(object sender, EventArgs e)
{
    this.Hide();
    using var updateForm = new update_staff_form(); // ✅ Namespace: PrisonManagment
    updateForm.ShowDialog();
    this.Close();
}

    }
}
