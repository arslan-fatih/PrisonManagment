namespace PrisonManagment.Pages.Sections
{
    partial class inventory_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory_form));
            back_button = new Button();
            dataGridView1 = new DataGridView();
            add_inventory_form_button = new Button();
            search_bar = new TextBox();
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
            back_button.TabIndex = 0;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 395);
            dataGridView1.TabIndex = 7;
            // 
            // add_staff_form_button
            // 
            add_inventory_form_button.BackgroundImage = Properties.Resources.Untitled_design__1_;
            add_inventory_form_button.Cursor = Cursors.Hand;
            add_inventory_form_button.FlatStyle = FlatStyle.Flat;
            add_inventory_form_button.Location = new Point(750, 0);
            add_inventory_form_button.Name = "add_staff_form_button";
            add_inventory_form_button.Size = new Size(50, 50);
            add_inventory_form_button.TabIndex = 8;
            add_inventory_form_button.UseVisualStyleBackColor = true;
            // 
            // search_bar
            // 
            search_bar.Location = new Point(332, 12);
            search_bar.Name = "search_bar";
            search_bar.PlaceholderText = "Search...";
            search_bar.Size = new Size(125, 27);
            search_bar.TabIndex = 9;
            search_bar.TextChanged += search_bar_TextChanged;
            // 
            // inventory_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(search_bar);
            Controls.Add(add_inventory_form_button);
            Controls.Add(dataGridView1);
            Controls.Add(back_button);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "inventory_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inventory_form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_button;
        private DataGridView dataGridView1;
        private Button add_inventory_form_button;
        private TextBox search_bar;
    }
}