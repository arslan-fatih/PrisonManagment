using System.Windows.Forms;
using System.Drawing;

namespace PrisonManagment.Pages.Sections
{
    partial class inmate_form
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelContent;
        private Panel panelTitle;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inmate_form));
            back_button = new Button();
            dataGridView1 = new DataGridView();
            add_staff_form_button = new Button();
            delete_inmate_form_button = new Button();
            update_inmate_form_button = new Button();
            search_bar = new TextBox();
            panelContent = new Panel();
            panelTitle = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelContent.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();

            // panelContent
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(dataGridView1);
            panelContent.Controls.Add(panelTitle);
            panelContent.Location = new Point(12, 12);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(10);
            panelContent.Size = new Size(1000, 600);
            panelContent.TabIndex = 0;

            // panelTitle
            panelTitle.BackColor = Color.FromArgb(45, 66, 91);
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(10, 10);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(980, 50);
            panelTitle.TabIndex = 0;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(159, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inmate Records";

            // back_button
            back_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            back_button.BackColor = Color.Transparent;
            back_button.Cursor = Cursors.Hand;
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_button.ForeColor = Color.White;
            back_button.Image = Properties.Resources.back;
            back_button.Location = new Point(920, 15);
            back_button.Name = "back_button";
            back_button.Size = new Size(30, 30);
            back_button.TabIndex = 5;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;

            // dataGridView1
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(45, 66, 91),
                ForeColor = Color.White,
                SelectionBackColor = Color.FromArgb(45, 66, 91),
                SelectionForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0),
                WrapMode = DataGridViewTriState.True,
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(5)
            };
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(45, 66, 91),
                SelectionBackColor = Color.FromArgb(231, 229, 255),
                SelectionForeColor = Color.FromArgb(45, 66, 91),
                Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Padding = new Padding(5)
            };
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.Location = new Point(10, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(980, 510);
            dataGridView1.TabIndex = 0;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(247, 248, 250)
            };

            // ADD BUTTON (➕ Add Inmate)
add_staff_form_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
add_staff_form_button.BackColor = Color.FromArgb(45, 66, 91);
add_staff_form_button.Cursor = Cursors.Hand;
add_staff_form_button.FlatAppearance.BorderSize = 0;
add_staff_form_button.FlatStyle = FlatStyle.Flat;
add_staff_form_button.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
add_staff_form_button.ForeColor = Color.White;
add_staff_form_button.Text = "  ➕ Add Inmate";  // Unicode plus işareti
add_staff_form_button.TextAlign = ContentAlignment.MiddleLeft;
add_staff_form_button.Location = new Point(650, 15);
add_staff_form_button.Name = "add_staff_form_button";
add_staff_form_button.Padding = new Padding(8, 0, 8, 0);
add_staff_form_button.Size = new Size(120, 35);
add_staff_form_button.TabIndex = 1;
add_staff_form_button.UseVisualStyleBackColor = false;
add_staff_form_button.Click += add_staff_form_button_Click;

// DELETE BUTTON (❌ Delete)
delete_inmate_form_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
delete_inmate_form_button.BackColor = Color.FromArgb(220, 53, 69);
delete_inmate_form_button.Cursor = Cursors.Hand;
delete_inmate_form_button.FlatAppearance.BorderSize = 0;
delete_inmate_form_button.FlatStyle = FlatStyle.Flat;
delete_inmate_form_button.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
delete_inmate_form_button.ForeColor = Color.White;
delete_inmate_form_button.Text = "  ❌ Delete";  // Unicode çarpı işareti
delete_inmate_form_button.TextAlign = ContentAlignment.MiddleLeft;
delete_inmate_form_button.Location = new Point(400, 15);
delete_inmate_form_button.Name = "delete_inmate_form_button";
delete_inmate_form_button.Padding = new Padding(8, 0, 8, 0);
delete_inmate_form_button.Size = new Size(120, 35);
delete_inmate_form_button.TabIndex = 3;
delete_inmate_form_button.UseVisualStyleBackColor = false;
delete_inmate_form_button.Click += delete_inmate_form_button_Click;

// UPDATE BUTTON (✏️ Update)
update_inmate_form_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
update_inmate_form_button.BackColor = Color.FromArgb(13, 110, 253);
update_inmate_form_button.Cursor = Cursors.Hand;
update_inmate_form_button.FlatAppearance.BorderSize = 0;
update_inmate_form_button.FlatStyle = FlatStyle.Flat;
update_inmate_form_button.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
update_inmate_form_button.ForeColor = Color.White;
update_inmate_form_button.Text = "  ✏️ Update";  // Unicode kalem işareti
update_inmate_form_button.TextAlign = ContentAlignment.MiddleLeft;
update_inmate_form_button.Location = new Point(525, 15);
update_inmate_form_button.Name = "update_inmate_form_button";
update_inmate_form_button.Padding = new Padding(8, 0, 8, 0);
update_inmate_form_button.Size = new Size(120, 35);
update_inmate_form_button.TabIndex = 2;
update_inmate_form_button.UseVisualStyleBackColor = false;
update_inmate_form_button.Click += update_inmate_form_button_Click;


            // search_bar
            search_bar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            search_bar.BorderStyle = BorderStyle.FixedSingle;
            search_bar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_bar.Location = new Point(180, 15);
            search_bar.Name = "search_bar";
            search_bar.PlaceholderText = "Search inmates...";
            search_bar.Size = new Size(200, 25);
            search_bar.TabIndex = 4;
            search_bar.TextChanged += search_bar_TextChanged;

            // inmate_form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1024, 624);
            Controls.Add(panelContent);
            Controls.Add(back_button);
            Controls.Add(delete_inmate_form_button);
            Controls.Add(update_inmate_form_button);
            Controls.Add(add_staff_form_button);
            Controls.Add(search_bar);
            MinimumSize = new Size(1040, 663);
            Name = "inmate_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inmate Management";
            WindowState = FormWindowState.Maximized;
            Load += inmate_form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button back_button;
        private DataGridView dataGridView1;
        private Button add_staff_form_button;
        private Button delete_inmate_form_button;
        private Button update_inmate_form_button;
        private TextBox search_bar;
    }
}
