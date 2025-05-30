namespace PrisonManagment.Pages.Sections
{
    partial class blocks_form
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blocks_form));
            back_button = new Button();
            dataGridView1 = new DataGridView();
            btnAddBlock = new Button();
            btnUpdateBlock = new Button();
            btnDeleteBlock = new Button();
            search_bar = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            back_button.TabIndex = 10;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // btnAddBlock
            // 
            btnAddBlock.Location = new Point(500, 12);
            btnAddBlock.Name = "btnAddBlock";
            btnAddBlock.Size = new Size(100, 30);
            btnAddBlock.TabIndex = 11;
            btnAddBlock.Text = "Add Block";
            btnAddBlock.UseVisualStyleBackColor = true;
            btnAddBlock.Click += btnAddBlock_Click;
            // 
            // btnUpdateBlock
            // 
            btnUpdateBlock.Location = new Point(620, 12);
            btnUpdateBlock.Name = "btnUpdateBlock";
            btnUpdateBlock.Size = new Size(100, 30);
            btnUpdateBlock.TabIndex = 12;
            btnUpdateBlock.Text = "Update Block";
            btnUpdateBlock.UseVisualStyleBackColor = true;
            btnUpdateBlock.Click += btnUpdateBlock_Click;
            // 
            // btnDeleteBlock
            // 
            btnDeleteBlock.Location = new Point(740, 12);
            btnDeleteBlock.Name = "btnDeleteBlock";
            btnDeleteBlock.Size = new Size(100, 30);
            btnDeleteBlock.TabIndex = 13;
            btnDeleteBlock.Text = "Delete Block";
            btnDeleteBlock.UseVisualStyleBackColor = true;
            btnDeleteBlock.Click += btnDeleteBlock_Click;
            // 
            // search_bar
            // 
            search_bar.Location = new Point(100, 15);
            search_bar.Name = "search_bar";
            search_bar.Size = new Size(200, 23);
            search_bar.TabIndex = 14;
            search_bar.TextChanged += search_bar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 15;
            label1.Text = "Search:";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1000, 550);
            dataGridView1.TabIndex = 11;
            // 
            // blocks_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(label1);
            Controls.Add(search_bar);
            Controls.Add(btnDeleteBlock);
            Controls.Add(btnUpdateBlock);
            Controls.Add(btnAddBlock);
            Controls.Add(dataGridView1);
            Controls.Add(back_button);
            Name = "blocks_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blocks Management";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_button;
        private DataGridView dataGridView1;
        private Button btnAddBlock;
        private Button btnUpdateBlock;
        private Button btnDeleteBlock;
        private TextBox search_bar;
        private Label label1;
    }
}