namespace PrisonManagment.Pages.Sections
{
    partial class supplies_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplies_form));
            back_button = new Button();
            dataGridView1 = new DataGridView();
            search_bar = new TextBox();
            btnAddSupply = new Button();
            btnUpdateSupply = new Button();
            btnDeleteSupply = new Button();
            label1 = new Label();
            panelContent = new Panel();
            panelTitle = new Panel();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelContent.SuspendLayout();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.BackColor = Color.Transparent;
            back_button.BackgroundImage = Properties.Resources.back;
            back_button.BackgroundImageLayout = ImageLayout.Stretch;
            back_button.Cursor = Cursors.Hand;
            back_button.Location = new Point(0, 0);
            back_button.Name = "back_button";
            back_button.Size = new Size(50, 50);
            back_button.TabIndex = 3;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // dataGridView1
            // 
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
                Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold),
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
                Font = new Font("Segoe UI", 9F),
                Padding = new Padding(5)
            };
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView1.Location = new Point(20, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(960, 510);
            dataGridView1.TabIndex = 8;
            dataGridView1.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(247, 248, 250)
            };
            // 
            // search_bar
            // 
            search_bar.BorderStyle = BorderStyle.FixedSingle;
            search_bar.Font = new Font("Segoe UI", 10F);
            search_bar.Location = new Point(100, 20);
            search_bar.Name = "search_bar";
            search_bar.Size = new Size(250, 30);
            search_bar.TabIndex = 9;
            search_bar.TextChanged += search_bar_TextChanged;
            search_bar.BackColor = Color.FromArgb(245, 245, 245);
            search_bar.ForeColor = Color.FromArgb(45, 66, 91);
            search_bar.PlaceholderText = "Search supplies...";
            // 
            // btnAddSupply
            // 
            btnAddSupply.BackColor = Color.FromArgb(45, 66, 91);
            btnAddSupply.Cursor = Cursors.Hand;
            btnAddSupply.FlatAppearance.BorderSize = 0;
            btnAddSupply.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 84, 96);
            btnAddSupply.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 39, 46);
            btnAddSupply.FlatStyle = FlatStyle.Flat;
            btnAddSupply.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddSupply.ForeColor = Color.White;
            btnAddSupply.Location = new Point(500, 20);
            btnAddSupply.Name = "btnAddSupply";
            btnAddSupply.Size = new Size(130, 35);
            btnAddSupply.TabIndex = 10;
            btnAddSupply.Text = "Add Supply";
            btnAddSupply.UseVisualStyleBackColor = false;
            btnAddSupply.Click += btnAddSupply_Click;
            // 
            // btnUpdateSupply
            // 
            btnUpdateSupply.BackColor = Color.FromArgb(45, 66, 91);
            btnUpdateSupply.Cursor = Cursors.Hand;
            btnUpdateSupply.FlatAppearance.BorderSize = 0;
            btnUpdateSupply.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 84, 96);
            btnUpdateSupply.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 39, 46);
            btnUpdateSupply.FlatStyle = FlatStyle.Flat;
            btnUpdateSupply.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateSupply.ForeColor = Color.White;
            btnUpdateSupply.Location = new Point(640, 20);
            btnUpdateSupply.Name = "btnUpdateSupply";
            btnUpdateSupply.Size = new Size(130, 35);
            btnUpdateSupply.TabIndex = 11;
            btnUpdateSupply.Text = "Update";
            btnUpdateSupply.UseVisualStyleBackColor = false;
            btnUpdateSupply.Click += btnUpdateSupply_Click;
            // 
            // btnDeleteSupply
            // 
            btnDeleteSupply.BackColor = Color.FromArgb(214, 40, 40);
            btnDeleteSupply.Cursor = Cursors.Hand;
            btnDeleteSupply.FlatAppearance.BorderSize = 0;
            btnDeleteSupply.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 65, 65);
            btnDeleteSupply.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 30, 30);
            btnDeleteSupply.FlatStyle = FlatStyle.Flat;
            btnDeleteSupply.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteSupply.ForeColor = Color.White;
            btnDeleteSupply.Location = new Point(780, 20);
            btnDeleteSupply.Name = "btnDeleteSupply";
            btnDeleteSupply.Size = new Size(130, 35);
            btnDeleteSupply.TabIndex = 12;
            btnDeleteSupply.Text = "Delete";
            btnDeleteSupply.UseVisualStyleBackColor = false;
            btnDeleteSupply.Click += btnDeleteSupply_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 66, 91);
            label1.Location = new Point(60, 24);
            label1.Name = "label1";
            label1.Size = new Size(67, 23);
            label1.TabIndex = 13;
            label1.Text = "Search:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(dataGridView1);
            panelContent.Location = new Point(20, 70);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(960, 510);
            panelContent.TabIndex = 14;
            panelContent.BorderStyle = BorderStyle.None;
            panelContent.Padding = new Padding(10);
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.FromArgb(45, 66, 91);
            panelTitle.Controls.Add(lblTitle);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1000, 60);
            panelTitle.TabIndex = 15;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = false;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1000, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Supplies Management";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // supplies_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1000, 600);
            Controls.Add(label1);
            Controls.Add(btnDeleteSupply);
            Controls.Add(btnUpdateSupply);
            Controls.Add(btnAddSupply);
            Controls.Add(search_bar);
            Controls.Add(panelContent);
            Controls.Add(back_button);
            Controls.Add(panelTitle);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "supplies_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplies Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelContent.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button back_button;
        private DataGridView dataGridView1;
        private TextBox search_bar;
        private Button btnAddSupply;
        private Button btnUpdateSupply;
        private Button btnDeleteSupply;
        private Label label1;
        private Panel panelContent;
        private Panel panelTitle;
        private Label lblTitle;
    }
}