namespace PrisonManagment.Pages
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            label1 = new Label();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            login_button = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = false;
            label1.BackColor = Color.FromArgb(45, 52, 54, 180);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 80);
            label1.Name = "label1";
            label1.Size = new Size(500, 60);
            label1.TabIndex = 0;
            label1.Text = "Prison Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.BorderStyle = BorderStyle.None;
            label1.Padding = new Padding(10);
            // 
            // username_textBox
            // 
            username_textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_textBox.Location = new Point(450, 200);
            username_textBox.MaxLength = 30;
            username_textBox.Name = "username_textBox";
            username_textBox.PlaceholderText = "Username";
            username_textBox.Size = new Size(250, 30);
            username_textBox.TabIndex = 1;
            username_textBox.BorderStyle = BorderStyle.FixedSingle;
            username_textBox.BackColor = Color.FromArgb(245, 246, 250);
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_textBox.Location = new Point(450, 250);
            password_textBox.MaxLength = 30;
            password_textBox.Name = "password_textBox";
            password_textBox.PasswordChar = '*';
            password_textBox.PlaceholderText = "Password";
            password_textBox.Size = new Size(250, 30);
            password_textBox.TabIndex = 2;
            password_textBox.BorderStyle = BorderStyle.FixedSingle;
            password_textBox.BackColor = Color.FromArgb(245, 246, 250);
            // 
            // login_button
            // 
            login_button.BackColor = Color.FromArgb(45, 52, 54);
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 84, 96);
            login_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 39, 46);
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_button.ForeColor = Color.White;
            login_button.Location = new Point(450, 320);
            login_button.Name = "login_button";
            login_button.Size = new Size(250, 45);
            login_button.TabIndex = 3;
            login_button.Text = "Log In";
            login_button.UseVisualStyleBackColor = false;
            login_button.Cursor = Cursors.Hand;
            login_button.Click += login_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(300, 200);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(300, 250);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // Log_in
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(login_button);
            Controls.Add(password_textBox);
            Controls.Add(username_textBox);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Log_in";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prison Management System - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Button login_button;
        private Label label2;
        private Label label3;
    }
}