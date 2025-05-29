
namespace PrisonManagment.Pages
{
    partial class add_inmate_form
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
            back_button = new Button();
            enterID = new TextBox();
            name_text = new TextBox();
            gender_textBox = new TextBox();
            crime_textBox = new TextBox();
            AgeUpDownAge = new NumericUpDown();
            birth_dateTimePicker = new DateTimePicker();
            enterBDate = new TextBox();
            EnterAge = new TextBox();
            EntryDate = new TextBox();
            entry_dateTimePicker = new DateTimePicker();
            enterReleaseDate = new TextBox();
            release_dateTimePicker = new DateTimePicker();
            insert_button = new Button();
            ((System.ComponentModel.ISupportInitialize)AgeUpDownAge).BeginInit();
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
            back_button.TabIndex = 9;
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click_1;
            // 
            // enterID
            // 
            enterID.Location = new Point(338, 12);
            enterID.Name = "enterID";
            enterID.PlaceholderText = "Enter ID";
            enterID.Size = new Size(125, 27);
            enterID.TabIndex = 11;
            // 
            // name_text
            // 
            name_text.Location = new Point(338, 45);
            name_text.Name = "name_text";
            name_text.PlaceholderText = "Enter Name";
            name_text.Size = new Size(125, 27);
            name_text.TabIndex = 12;
            // 
            // gender_textBox
            // 
            gender_textBox.Location = new Point(338, 78);
            gender_textBox.Name = "gender_textBox";
            gender_textBox.PlaceholderText = "Enter Gender";
            gender_textBox.Size = new Size(125, 27);
            gender_textBox.TabIndex = 13;
            // 
            // crime_textBox
            // 
            crime_textBox.Location = new Point(338, 374);
            crime_textBox.Name = "crime_textBox";
            crime_textBox.PlaceholderText = "Enter Crime";
            crime_textBox.Size = new Size(125, 27);
            crime_textBox.TabIndex = 14;
            // 
            // AgeUpDownAge
            // 
            AgeUpDownAge.Location = new Point(338, 144);
            AgeUpDownAge.Name = "AgeUpDownAge";
            AgeUpDownAge.Size = new Size(125, 27);
            AgeUpDownAge.TabIndex = 15;
            // 
            // birth_dateTimePicker
            // 
            birth_dateTimePicker.Location = new Point(338, 210);
            birth_dateTimePicker.Name = "birth_dateTimePicker";
            birth_dateTimePicker.Size = new Size(227, 27);
            birth_dateTimePicker.TabIndex = 16;
            // 
            // enterBDate
            // 
            enterBDate.Location = new Point(338, 177);
            enterBDate.Name = "enterBDate";
            enterBDate.Size = new Size(125, 27);
            enterBDate.TabIndex = 17;
            enterBDate.Text = "Enter Birth Date:";
            // 
            // EnterAge
            // 
            EnterAge.Location = new Point(338, 111);
            EnterAge.Name = "EnterAge";
            EnterAge.Size = new Size(125, 27);
            EnterAge.TabIndex = 18;
            EnterAge.Text = "Enter Age:";
            // 
            // EntryDate
            // 
            EntryDate.Location = new Point(338, 243);
            EntryDate.Name = "EntryDate";
            EntryDate.Size = new Size(125, 27);
            EntryDate.TabIndex = 19;
            EntryDate.Text = "Enter Entry Date:";
            // 
            // entry_dateTimePicker
            // 
            entry_dateTimePicker.Location = new Point(338, 276);
            entry_dateTimePicker.Name = "entry_dateTimePicker";
            entry_dateTimePicker.Size = new Size(227, 27);
            entry_dateTimePicker.TabIndex = 20;
            // 
            // enterReleaseDate
            // 
            enterReleaseDate.Location = new Point(338, 309);
            enterReleaseDate.Name = "enterReleaseDate";
            enterReleaseDate.Size = new Size(139, 27);
            enterReleaseDate.TabIndex = 21;
            enterReleaseDate.Text = "Enter Release Date:";
            // 
            // release_dateTimePicker
            // 
            release_dateTimePicker.Location = new Point(338, 341);
            release_dateTimePicker.Name = "release_dateTimePicker";
            release_dateTimePicker.Size = new Size(227, 27);
            release_dateTimePicker.TabIndex = 22;
            // 
            // insert_button
            // 
            insert_button.Cursor = Cursors.Hand;
            insert_button.FlatStyle = FlatStyle.Flat;
            insert_button.Location = new Point(338, 407);
            insert_button.Name = "insert_button";
            insert_button.Size = new Size(124, 29);
            insert_button.TabIndex = 23;
            insert_button.Text = "Insert";
            insert_button.UseVisualStyleBackColor = true;
            insert_button.Click += insert_button_Click;
            // 
            // add_inmate_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(insert_button);
            Controls.Add(release_dateTimePicker);
            Controls.Add(enterReleaseDate);
            Controls.Add(entry_dateTimePicker);
            Controls.Add(EntryDate);
            Controls.Add(EnterAge);
            Controls.Add(enterBDate);
            Controls.Add(birth_dateTimePicker);
            Controls.Add(AgeUpDownAge);
            Controls.Add(crime_textBox);
            Controls.Add(gender_textBox);
            Controls.Add(name_text);
            Controls.Add(enterID);
            Controls.Add(back_button);
            DoubleBuffered = true;
            Name = "add_inmate_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_inmate_form";
            ((System.ComponentModel.ISupportInitialize)AgeUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button back_button;
        private TextBox enterID;
        private TextBox name_text;
        private TextBox gender_textBox;
        private TextBox crime_textBox;
        private NumericUpDown AgeUpDownAge;
        private DateTimePicker birth_dateTimePicker;
        private TextBox enterBDate;
        private TextBox EnterAge;
        private TextBox EntryDate;
        private DateTimePicker entry_dateTimePicker;
        private TextBox enterReleaseDate;
        private DateTimePicker release_dateTimePicker;
        private Button insert_button;
    }
}