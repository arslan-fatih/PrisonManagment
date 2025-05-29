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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Size = new System.Drawing.Size(740, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;

            // 
            // search_bar
            // 
            this.search_bar.Location = new System.Drawing.Point(90, 20);
            this.search_bar.Size = new System.Drawing.Size(300, 23);
            this.search_bar.TabIndex = 1;
            this.search_bar.TextChanged += new System.EventHandler(this.search_bar_TextChanged);

            // 
            // labelSearch
            // 
            this.labelSearch.Location = new System.Drawing.Point(20, 23);
            this.labelSearch.Size = new System.Drawing.Size(70, 15);
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
            this.back_button.Location = new System.Drawing.Point(610, 380);
            this.back_button.Size = new System.Drawing.Size(150, 40);
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);

            // 
            // staff_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.search_bar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_staff_form_button);
            this.Controls.Add(this.update_staff_form_button);
            this.Controls.Add(this.delete_staff_form_button);
            this.Controls.Add(this.back_button);
            this.Name = "staff_form";
            this.Text = "Manage Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
