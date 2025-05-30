namespace PrisonManagment.Pages.Sections
{
    partial class cell_form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cell_form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_button = new System.Windows.Forms.Button();
            this.btnAddCell = new System.Windows.Forms.Button();
            this.btnUpdateCell = new System.Windows.Forms.Button();
            this.btnDeleteCell = new System.Windows.Forms.Button();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 550);
            this.dataGridView1.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BackgroundImage = global::PrisonManagment.Properties.Resources.back;
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.Location = new System.Drawing.Point(0, 0);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(50, 50);
            this.back_button.TabIndex = 1;
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // btnAddCell
            // 
            this.btnAddCell.Location = new System.Drawing.Point(500, 12);
            this.btnAddCell.Name = "btnAddCell";
            this.btnAddCell.Size = new System.Drawing.Size(100, 30);
            this.btnAddCell.TabIndex = 2;
            this.btnAddCell.Text = "Add Cell";
            this.btnAddCell.UseVisualStyleBackColor = true;
            this.btnAddCell.Click += new System.EventHandler(this.btnAddCell_Click);
            // 
            // btnUpdateCell
            // 
            this.btnUpdateCell.Location = new System.Drawing.Point(620, 12);
            this.btnUpdateCell.Name = "btnUpdateCell";
            this.btnUpdateCell.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateCell.TabIndex = 3;
            this.btnUpdateCell.Text = "Update Cell";
            this.btnUpdateCell.UseVisualStyleBackColor = true;
            this.btnUpdateCell.Click += new System.EventHandler(this.btnUpdateCell_Click);
            // 
            // btnDeleteCell
            // 
            this.btnDeleteCell.Location = new System.Drawing.Point(740, 12);
            this.btnDeleteCell.Name = "btnDeleteCell";
            this.btnDeleteCell.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteCell.TabIndex = 4;
            this.btnDeleteCell.Text = "Delete Cell";
            this.btnDeleteCell.UseVisualStyleBackColor = true;
            this.btnDeleteCell.Click += new System.EventHandler(this.btnDeleteCell_Click);
            // 
            // search_bar
            // 
            this.search_bar.Location = new System.Drawing.Point(100, 15);
            this.search_bar.Name = "search_bar";
            this.search_bar.Size = new System.Drawing.Size(200, 27);
            this.search_bar.TabIndex = 5;
            this.search_bar.TextChanged += new System.EventHandler(this.search_bar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // cell_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrisonManagment.Properties.Resources.Untitled_design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.btnDeleteCell);
            this.Controls.Add(this.btnUpdateCell);
            this.Controls.Add(this.btnAddCell);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cell_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cell Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button btnAddCell;
        private System.Windows.Forms.Button btnUpdateCell;
        private System.Windows.Forms.Button btnDeleteCell;
        private System.Windows.Forms.TextBox search_bar;
        private System.Windows.Forms.Label label1;
    }
}
