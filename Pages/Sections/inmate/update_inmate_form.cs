using System;
using System.Windows.Forms;
using PrisonManagment.Pages.Sections;

namespace PrisonManagment.Pages
{
    public partial class update_inmate_form : Form
    {
        public update_inmate_form()
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

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(enterID.Text);
                string name = name_text.Text.Trim();
                string gender = gender_textBox.Text.Trim().ToUpper();
                int age = (int)AgeUpDownAge.Value;
                DateTime birthDate = birth_dateTimePicker.Value.Date;
                DateTime? releaseDate = release_dateTimePicker.Value.Date;
                string crime = crime_textBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(crime))
                    throw new ArgumentException("İsim, cinsiyet ve suç alanları boş olamaz.");

                if (gender != "M" && gender != "F")
                    throw new ArgumentException("Cinsiyet alanına sadece 'M' veya 'F' giriniz.");

                Database.UpdateInmate(id, name, gender, age, birthDate, releaseDate, crime);

                MessageBox.Show("Mahkum bilgileri güncellendi!", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Güncelleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
