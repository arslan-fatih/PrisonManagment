using PrisonManagment.Pages.Sections;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrisonManagment
{
    public partial class MainMenu : Form
    {
        private Panel panelMainContent;

        public MainMenu()
        {
            InitializeComponent();
            InitializeMainContentPanel();
        }

        private void InitializeMainContentPanel()
        {
            Controls.Add(panelMainContent);
            Controls.SetChildIndex(panelSidebar, 0); // Sidebar önde
        }

        private void LoadUserControl(UserControl uc)
        {
            panelMainContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(uc);
        }

       

       

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            staff_form staff_Form = new staff_form();
            this.Hide();
            staff_Form.ShowDialog();
            this.Close();

        }

        private void InmateButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            inmate_form inmate_Form = new inmate_form();
            this.Hide();
            inmate_Form.ShowDialog();
            this.Close();

        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            inventory_form inventory_Form  = new inventory_form();
            this.Hide();
            inventory_Form.ShowDialog();
            this.Close();

        }
    }
}
