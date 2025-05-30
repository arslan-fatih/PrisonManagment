namespace PrisonManagment.Pages.Sections
{
    partial class supplier_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier_form));
            back_button = new Button();
            dataGridView1 = new DataGridView();
            search_bar = new TextBox();
            btnAddSupplier = new Button();
            btnUpdateSupplier = new Button();
            btnDeleteSupplier = new Button();
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
            back_button.TabIndex = 2;
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
            dataGridView1.TabIndex = 7;
            // 
            // search_bar
            // 
            search_bar.Location = new Point(100, 60);
            search_bar.Name = "search_bar";
            search_bar.PlaceholderText = "Search...";
            search_bar.Size = new Size(250, 27);
            search_bar.TabIndex = 8;
            search_bar.TextChanged += search_bar_TextChanged;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(400, 60);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(94, 29);
            btnAddSupplier.TabIndex = 9;
            btnAddSupplier.Text = "Add";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.Location = new Point(510, 60);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(94, 29);
            btnUpdateSupplier.TabIndex = 10;
            btnUpdateSupplier.Text = "Update";
            btnUpdateSupplier.UseVisualStyleBackColor = true;
            btnUpdateSupplier.Click += btnUpdateSupplier_Click;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.Location = new Point(620, 60);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(94, 29);
            btnDeleteSupplier.TabIndex = 11;
            btnDeleteSupplier.Text = "Delete";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
            // 
            // supplier_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteSupplier);
            Controls.Add(btnUpdateSupplier);
            Controls.Add(btnAddSupplier);
            Controls.Add(search_bar);
            Controls.Add(dataGridView1);
            Controls.Add(back_button);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "supplier_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "supplier_form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_button;
        private DataGridView dataGridView1;
        private TextBox search_bar;
        private Button btnAddSupplier;
        private Button btnUpdateSupplier;
        private Button btnDeleteSupplier;
    }
}