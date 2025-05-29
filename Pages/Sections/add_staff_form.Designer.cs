namespace PrisonManagment.Pages.Sections
{
    partial class add_staff_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_staff_form));
            ID_text = new TextBox();
            role_text = new TextBox();
            name_text = new TextBox();
            numericUpDownAge = new NumericUpDown();
            wage_text = new TextBox();
            supervisor_text = new TextBox();
            block_text = new TextBox();
            insert_button = new Button();
            back_button = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // ID_text
            // 
            ID_text.Location = new Point(337, 12);
            ID_text.Name = "ID_text";
            ID_text.PlaceholderText = "Enter ID";
            ID_text.Size = new Size(125, 27);
            ID_text.TabIndex = 0;
            // 
            // role_text
            // 
            role_text.Location = new Point(337, 45);
            role_text.Name = "role_text";
            role_text.PlaceholderText = "Enter Role";
            role_text.Size = new Size(125, 27);
            role_text.TabIndex = 1;
            // 
            // name_text
            // 
            name_text.Location = new Point(337, 78);
            name_text.Name = "name_text";
            name_text.PlaceholderText = "Enter Name";
            name_text.Size = new Size(125, 27);
            name_text.TabIndex = 2;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(337, 111);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(125, 27);
            numericUpDownAge.TabIndex = 3;
            // 
            // wage_text
            // 
            wage_text.Location = new Point(337, 144);
            wage_text.Name = "wage_text";
            wage_text.PlaceholderText = "Enter Wage";
            wage_text.Size = new Size(124, 27);
            wage_text.TabIndex = 4;
            // 
            // supervisor_text
            // 
            supervisor_text.Location = new Point(337, 177);
            supervisor_text.Name = "supervisor_text";
            supervisor_text.PlaceholderText = "Enter SuperVisor";
            supervisor_text.Size = new Size(124, 27);
            supervisor_text.TabIndex = 5;
            // 
            // block_text
            // 
            block_text.Location = new Point(337, 212);
            block_text.Name = "block_text";
            block_text.PlaceholderText = "Enter Block";
            block_text.Size = new Size(125, 27);
            block_text.TabIndex = 6;
            // 
            // insert_button
            // 
            insert_button.Cursor = Cursors.Hand;
            insert_button.FlatStyle = FlatStyle.Flat;
            insert_button.Location = new Point(337, 400);
            insert_button.Name = "insert_button";
            insert_button.Size = new Size(124, 29);
            insert_button.TabIndex = 7;
            insert_button.Text = "Insert";
            insert_button.UseVisualStyleBackColor = true;
            insert_button.Click += insert_button_Click;
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
            back_button.TabIndex = 8;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // add_staff_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(back_button);
            Controls.Add(insert_button);
            Controls.Add(block_text);
            Controls.Add(supervisor_text);
            Controls.Add(wage_text);
            Controls.Add(numericUpDownAge);
            Controls.Add(name_text);
            Controls.Add(role_text);
            Controls.Add(ID_text);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "add_staff_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_staff_form";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ID_text;
        private TextBox role_text;
        private TextBox name_text;
        private NumericUpDown numericUpDownAge;
        private TextBox wage_text;
        private TextBox supervisor_text;
        private TextBox block_text;
        private Button insert_button;
        private Button back_button;
    }
}