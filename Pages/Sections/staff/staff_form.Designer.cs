namespace PrisonManagment.Pages.Sections
{
    public partial class staff_form
    {
        public System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox search_bar;
        public System.Windows.Forms.Button add_staff_form_button;
        public System.Windows.Forms.Button update_staff_form_button;
        public System.Windows.Forms.Button delete_staff_form_button;
        public System.Windows.Forms.Button back_button;
        public System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.add_staff_form_button = new System.Windows.Forms.Button();
            this.update_staff_form_button = new System.Windows.Forms.Button();
            this.delete_staff_form_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.dataGridView1);
            this.panelContent.Controls.Add(this.panelTitle);
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelContent.Size = new System.Drawing.Size(1000, 600);
            this.panelContent.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(45, 66, 91);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(10, 10);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(980, 50);
            this.panelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Staff Members";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.FromArgb(45, 66, 91),
                ForeColor = System.Drawing.Color.White,
                SelectionBackColor = System.Drawing.Color.FromArgb(45, 66, 91),
                SelectionForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                WrapMode = System.Windows.Forms.DataGridViewTriState.True,
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
                Padding = new System.Windows.Forms.Padding(5)
            };
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.White,
                ForeColor = System.Drawing.Color.FromArgb(45, 66, 91),
                SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255),
                SelectionForeColor = System.Drawing.Color.FromArgb(45, 66, 91),
                Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Padding = new System.Windows.Forms.Padding(5)
            };
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            this.dataGridView1.Location = new System.Drawing.Point(10, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(980, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.FromArgb(247, 248, 250)
            };

            // 
            // search_bar
            // 
            this.search_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_bar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bar.Location = new System.Drawing.Point(650, 15);
            this.search_bar.Name = "search_bar";
            this.search_bar.PlaceholderText = "Search staff...";
            this.search_bar.Size = new System.Drawing.Size(300, 25);
            this.search_bar.TabIndex = 1;
            this.search_bar.TextChanged += new System.EventHandler(this.search_bar_TextChanged);

            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(585, 18);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(59, 17);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search:";

            // 
            // add_staff_form_button
            // 
            this.add_staff_form_button.Location = new System.Drawing.Point(20, 380);
            this.add_staff_form_button.Size = new System.Drawing.Size(150, 40);
            this.add_staff_form_button.Text = "Add Staff";
            this.add_staff_form_button.UseVisualStyleBackColor = true;
            this.add_staff_form_button.Click += new System.EventHandler(this.add_staff_form_button_Click);

            // 
            // update_staff_form_button
            // 
            this.update_staff_form_button.Location = new System.Drawing.Point(190, 380);
            this.update_staff_form_button.Size = new System.Drawing.Size(150, 40);
            this.update_staff_form_button.Text = "Update Staff";
            this.update_staff_form_button.UseVisualStyleBackColor = true;
            this.update_staff_form_button.Click += new System.EventHandler(this.update_staff_form_button_Click);

            // 
            // delete_staff_form_button
            // 
            this.delete_staff_form_button.Location = new System.Drawing.Point(360, 380);
            this.delete_staff_form_button.Size = new System.Drawing.Size(150, 40);
            this.delete_staff_form_button.Text = "Delete Staff";
            this.delete_staff_form_button.UseVisualStyleBackColor = true;
            this.delete_staff_form_button.Click += new System.EventHandler(this.delete_staff_form_button_Click);

            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.BackColor = System.Drawing.Color.FromArgb(45, 66, 91);
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(842, 550);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(150, 40);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "← Back to Menu";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);

            // 
            // staff_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(1024, 624);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.delete_staff_form_button);
            this.Controls.Add(this.update_staff_form_button);
            this.Controls.Add(this.add_staff_form_button);
            this.MinimumSize = new System.Drawing.Size(1040, 663);
            this.Name = "staff_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
