namespace PrisonManagment.Pages.Sections
{
    partial class houses_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(houses_form));
            this.back_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.btnUpdateHouse = new System.Windows.Forms.Button();
            this.btnDeleteHouse = new System.Windows.Forms.Button();
            this.search_bar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // btnAddHouse
            // 
            this.btnAddHouse.Location = new System.Drawing.Point(500, 12);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(100, 30);
            this.btnAddHouse.TabIndex = 2;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // btnUpdateHouse
            // 
            this.btnUpdateHouse.Location = new System.Drawing.Point(620, 12);
            this.btnUpdateHouse.Name = "btnUpdateHouse";
            this.btnUpdateHouse.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateHouse.TabIndex = 3;
            this.btnUpdateHouse.Text = "Update House";
            this.btnUpdateHouse.UseVisualStyleBackColor = true;
            this.btnUpdateHouse.Click += new System.EventHandler(this.btnUpdateHouse_Click);
            // 
            // btnDeleteHouse
            // 
            this.btnDeleteHouse.Location = new System.Drawing.Point(740, 12);
            this.btnDeleteHouse.Name = "btnDeleteHouse";
            this.btnDeleteHouse.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteHouse.TabIndex = 4;
            this.btnDeleteHouse.Text = "Delete House";
            this.btnDeleteHouse.UseVisualStyleBackColor = true;
            this.btnDeleteHouse.Click += new System.EventHandler(this.btnDeleteHouse_Click);
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
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // houses_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrisonManagment.Properties.Resources.Untitled_design;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.btnDeleteHouse);
            this.Controls.Add(this.btnUpdateHouse);
            this.Controls.Add(this.btnAddHouse);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "houses_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Houses Management";
            this.Load += new System.EventHandler(this.houses_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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