using PrisonManagment.Pages.Sections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagment.Pages
{
    public partial class add_inmate_form : Form
    {
        public add_inmate_form()
        {
            InitializeComponent();
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            inmate_form inmate_form = new inmate_form();
            this.Hide();
            inmate_form.ShowDialog();
            this.Close();
        }

        private void ClearInputs()
        {
            enterID.Clear();
            name_text.Clear();
            gender_textBox.Clear();
            AgeUpDownAge.Value = 0;
            birth_dateTimePicker.Value = DateTime.Today;
            entry_dateTimePicker.Value = DateTime.Today;
            release_dateTimePicker.Value = DateTime.Today;
            crime_textBox.Clear();
        }


        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Formdan verileri oku
                int id = int.Parse(enterID.Text);
                string name = name_text.Text.Trim();
                string gender = gender_textBox.Text.Trim().ToUpper();   // M / F
                int age = (int)AgeUpDownAge.Value;
                DateTime birthDate = birth_dateTimePicker.Value.Date;
                DateTime entryDate = entry_dateTimePicker.Value.Date;
                DateTime? releaseDate = release_dateTimePicker.Value.Date;
                string crime = crime_textBox.Text.Trim();

                // 2) Temel doğrulamalar
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(crime))
                    throw new ArgumentException("İsim, cinsiyet ve suç alanları boş olamaz.");

                if (gender != "M" && gender != "F")
                    throw new ArgumentException("Cinsiyet alanına sadece 'M' veya 'F' giriniz.");

                // 3) DB’ye kaydet
                Database.AddInmate(id, name, gender, age, birthDate, entryDate, releaseDate, crime);

                MessageBox.Show("Mahkum başarıyla eklendi!", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Ekleme Başarısız",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
