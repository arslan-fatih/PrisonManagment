using PrisonManagment.Pages;
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
            inventory_form inventory_Form = new inventory_form();
            this.Hide();
            inventory_Form.ShowDialog();
            this.Close();

        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            cell_form cellForm = new cell_form();
            this.Hide();
            cellForm.ShowDialog();
            this.Close();

        }

        private void blocks_button_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            blocks_form BlocksForm = new blocks_form();
            this.Hide();
            BlocksForm.ShowDialog();
            this.Close();
        }

        private void HousesButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            houses_form housesForm = new houses_form();
            this.Hide();
            housesForm.ShowDialog();
            this.Close();
        }

        private void MedicalRecordButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            Medical_Record medicalRecordsForm = new Medical_Record();
            this.Hide();
            medicalRecordsForm.ShowDialog();
            this.Close();
        }

        private void SuppliesButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            supplies_form SuppliesForm = new supplies_form();
            this.Hide();
            SuppliesForm.ShowDialog();
            this.Close();
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            supplier_form SupplierForm = new supplier_form();
            this.Hide();
            SupplierForm.ShowDialog();
            this.Close();
        }
    }
}