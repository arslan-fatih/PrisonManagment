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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_textBox.Text;
            string password = password_textBox.Text;

            if ((username == "admin" && password == "admin") || (username == "" && password == ""))
            {
                MainMenu main = new MainMenu();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Gerekirse şifre alanını temizleyelim:
                password_textBox.Clear();
                password_textBox.Focus();
            }
        }

       

        
    }
}
