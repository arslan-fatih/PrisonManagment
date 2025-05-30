namespace PrisonManagment.Pages.Sections
{
    partial class Medical_Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medical_Record));
            back_button = new Button();
            dataGridView1 = new DataGridView();
            search_bar = new TextBox();
            btnAddRecord = new Button();
            btnUpdateRecord = new Button();
            btnDeleteRecord = new Button();
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
            // btnAddRecord
            // 
            btnAddRecord.Location = new Point(400, 60);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(94, 29);
            btnAddRecord.TabIndex = 9;
            btnAddRecord.Text = "Add";
            btnAddRecord.UseVisualStyleBackColor = true;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // btnUpdateRecord
            // 
            btnUpdateRecord.Location = new Point(510, 60);
            btnUpdateRecord.Name = "btnUpdateRecord";
            btnUpdateRecord.Size = new Size(94, 29);
            btnUpdateRecord.TabIndex = 10;
            btnUpdateRecord.Text = "Update";
            btnUpdateRecord.UseVisualStyleBackColor = true;
            btnUpdateRecord.Click += btnUpdateRecord_Click;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.Location = new Point(620, 60);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(94, 29);
            btnDeleteRecord.TabIndex = 11;
            btnDeleteRecord.Text = "Delete";
            btnDeleteRecord.UseVisualStyleBackColor = true;
            btnDeleteRecord.Click += btnDeleteRecord_Click;
            // 
            // Medical_Record
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteRecord);
            Controls.Add(btnUpdateRecord);
            Controls.Add(btnAddRecord);
            Controls.Add(search_bar);
            Controls.Add(dataGridView1);
            Controls.Add(back_button);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Medical_Record";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medical_Record";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_button;
        private DataGridView dataGridView1;
        private TextBox search_bar;
        private Button btnAddRecord;
        private Button btnUpdateRecord;
        private Button btnDeleteRecord;
    }
}