using System;
using System.Windows.Forms;
using PrisonManagment.Pages.Sections;

namespace PrisonManagment.Pages
{
    public partial class delete_inmate_form : Form
    {
        public delete_inmate_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            inmate_form inmateForm = new inmate_form();
            inmateForm.ShowDialog();
            this.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(enterID.Text);

                DialogResult result = MessageBox.Show("Mahkumu silmek istediğinizden emin misiniz?", "Onayla",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Database.DeleteInmate(id);
                    MessageBox.Show("Mahkum başarıyla silindi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enterID.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Silme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
