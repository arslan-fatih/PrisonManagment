namespace PrisonManagment.Pages.Sections
{
    partial class houses_form
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelContent;
        private Panel panelTitle;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(houses_form));
            this.back_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.btnUpdateHouse = new System.Windows.Forms.Button();
            this.btnDeleteHouse = new System.Windows.Forms.Button();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblTitle.Size = new System.Drawing.Size(146, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Houses / Blocks";
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(920, 15);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(30, 30);
            this.back_button.TabIndex = 5;
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
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
            this.dataGridView1.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
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
            this.dataGridView1.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
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
            this.dataGridView1.Size = new System.Drawing.Size(980, 510);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle {
                BackColor = System.Drawing.Color.FromArgb(247, 248, 250)
            };
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHouse.BackColor = System.Drawing.Color.FromArgb(45, 66, 91);
            this.btnAddHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddHouse.FlatAppearance.BorderSize = 0;
            this.btnAddHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHouse.ForeColor = System.Drawing.Color.White;
            this.btnAddHouse.Location = new System.Drawing.Point(650, 15);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnAddHouse.Size = new System.Drawing.Size(140, 35);
            this.btnAddHouse.TabIndex = 1;
            this.btnAddHouse.Text = "➕ Add House";
            this.btnAddHouse.UseVisualStyleBackColor = false;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // btnUpdateHouse
            // 
            this.btnUpdateHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateHouse.BackColor = System.Drawing.Color.FromArgb(13, 110, 253);
            this.btnUpdateHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateHouse.FlatAppearance.BorderSize = 0;
            this.btnUpdateHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHouse.ForeColor = System.Drawing.Color.White;
            this.btnUpdateHouse.Location = new System.Drawing.Point(500, 15);
            this.btnUpdateHouse.Name = "btnUpdateHouse";
            this.btnUpdateHouse.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnUpdateHouse.Size = new System.Drawing.Size(140, 35);
            this.btnUpdateHouse.TabIndex = 2;
            this.btnUpdateHouse.Text = "✏️ Update";
            this.btnUpdateHouse.UseVisualStyleBackColor = false;
            this.btnUpdateHouse.Click += new System.EventHandler(this.btnUpdateHouse_Click);
            // 
            // btnDeleteHouse
            // 
            this.btnDeleteHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteHouse.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDeleteHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteHouse.FlatAppearance.BorderSize = 0;
            this.btnDeleteHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHouse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHouse.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHouse.Location = new System.Drawing.Point(350, 15);
            this.btnDeleteHouse.Name = "btnDeleteHouse";
            this.btnDeleteHouse.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDeleteHouse.Size = new System.Drawing.Size(140, 35);
            this.btnDeleteHouse.TabIndex = 3;
            this.btnDeleteHouse.Text = "❌ Delete";
            this.btnDeleteHouse.UseVisualStyleBackColor = false;
            this.btnDeleteHouse.Click += new System.EventHandler(this.btnDeleteHouse_Click);
            // 
            // search_bar
            // 
            this.search_bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_bar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bar.Location = new System.Drawing.Point(180, 15);
            this.search_bar.Name = "search_bar";
            this.search_bar.PlaceholderText = "Search houses...";
            this.search_bar.Size = new System.Drawing.Size(160, 25);
            this.search_bar.TabIndex = 4;
            this.search_bar.TextChanged += new System.EventHandler(this.search_bar_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // houses_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(1024, 624);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.btnDeleteHouse);
            this.Controls.Add(this.btnUpdateHouse);
            this.Controls.Add(this.btnAddHouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_bar);
            this.MinimumSize = new System.Drawing.Size(1040, 663);
            this.Name = "houses_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Houses / Blocks Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.houses_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.Button btnUpdateHouse;
        private System.Windows.Forms.Button btnDeleteHouse;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.Label label1;
    }
}