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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.AutoSize = true;
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 350);
            dataGridView1.TabIndex = 8;
            // 
            // search_bar
            // 
            search_bar.Location = new Point(100, 60);
            search_bar.Name = "search_bar";
            search_bar.PlaceholderText = "Search...";
            search_bar.Size = new Size(250, 27);
            search_bar.TabIndex = 9;
            search_bar.TextChanged += search_bar_TextChanged;
            // 
            // btnAddSupply
            // 
            btnAddSupply.Location = new Point(400, 60);
            btnAddSupply.Name = "btnAddSupply";
            btnAddSupply.Size = new Size(94, 29);
            btnAddSupply.TabIndex = 10;
            btnAddSupply.Text = "Add";
            btnAddSupply.UseVisualStyleBackColor = true;
            btnAddSupply.Click += btnAddSupply_Click;
            // 
            // btnUpdateSupply
            // 
            btnUpdateSupply.Location = new Point(510, 60);
            btnUpdateSupply.Name = "btnUpdateSupply";
            btnUpdateSupply.Size = new Size(94, 29);
            btnUpdateSupply.TabIndex = 11;
            btnUpdateSupply.Text = "Update";
            btnUpdateSupply.UseVisualStyleBackColor = true;
            btnUpdateSupply.Click += btnUpdateSupply_Click;
            // 
            // btnDeleteSupply
            // 
            btnDeleteSupply.Location = new Point(620, 60);
            btnDeleteSupply.Name = "btnDeleteSupply";
            btnDeleteSupply.Size = new Size(94, 29);
            btnDeleteSupply.TabIndex = 12;
            btnDeleteSupply.Text = "Delete";
            btnDeleteSupply.UseVisualStyleBackColor = true;
            btnDeleteSupply.Click += btnDeleteSupply_Click;
            // 
            // supplies_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteSupply);
            Controls.Add(btnUpdateSupply);
            Controls.Add(btnAddSupply);
            Controls.Add(search_bar);
            Controls.Add(dataGridView1);
            Controls.Add(back_button);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "supplies_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "supplies_form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_button;
        private DataGridView dataGridView1;
        private TextBox search_bar;
        private Button btnAddSupply;
        private Button btnUpdateSupply;
        private Button btnDeleteSupply;
    }
}