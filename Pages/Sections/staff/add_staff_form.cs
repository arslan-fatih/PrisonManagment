using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace PrisonManagment.Pages.Sections
{
    public partial class add_staff_form : Form
    {
        public add_staff_form()
        {
            InitializeComponent();
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(ID_text.Text);
                string role = role_text.Text;
                string name = name_text.Text;
                int age = (int)numericUpDownAge.Value;
                decimal wage = decimal.Parse(wage_text.Text);
                int? supervisor = string.IsNullOrWhiteSpace(supervisor_text.Text) ? (int?)null : int.Parse(supervisor_text.Text);
                int? block = string.IsNullOrWhiteSpace(block_text.Text) ? (int?)null : int.Parse(block_text.Text);

                Database.AddStaff(id, role, name, age, wage, supervisor, block);

                MessageBox.Show("Staff member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.DialogResult = DialogResult.OK;
                //this.Close();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            ID_text.Clear();
            role_text.Clear();
            name_text.Clear();
            wage_text.Clear();
            supervisor_text.Clear();
            block_text.Clear();
            numericUpDownAge.Value = numericUpDownAge.Minimum;
        }

        private void back_button_Click(object sender, EventArgs e)
        {

            Form currentForm = this.FindForm();
            staff_form staff_Form = new staff_form();
            this.Hide();
            staff_Form.ShowDialog();
            this.Close();
        }
    }
    }

