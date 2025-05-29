namespace PrisonManagment.Pages
{
    partial class update_inmate_form
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            enterID = new TextBox();
            name_text = new TextBox();
            gender_textBox = new TextBox();
            crime_textBox = new TextBox();
            AgeUpDownAge = new NumericUpDown();
            birth_dateTimePicker = new DateTimePicker();
            release_dateTimePicker = new DateTimePicker();
            update_button = new Button();
            back_button = new Button();

            ((System.ComponentModel.ISupportInitialize)(AgeUpDownAge)).BeginInit();
            SuspendLayout();

            // enterID
            enterID.Location = new Point(300, 20);
            enterID.PlaceholderText = "Enter ID";
            enterID.Size = new Size(200, 27);

            // name_text
            name_text.Location = new Point(300, 60);
            name_text.PlaceholderText = "Enter Name";
            name_text.Size = new Size(200, 27);

            // gender_textBox
            gender_textBox.Location = new Point(300, 100);
            gender_textBox.PlaceholderText = "Enter Gender (M/F)";
            gender_textBox.Size = new Size(200, 27);

            // AgeUpDownAge
            AgeUpDownAge.Location = new Point(300, 140);
            AgeUpDownAge.Size = new Size(200, 27);

            // birth_dateTimePicker
            birth_dateTimePicker.Location = new Point(300, 180);
            birth_dateTimePicker.Size = new Size(200, 27);

            // release_dateTimePicker
            release_dateTimePicker.Location = new Point(300, 220);
            release_dateTimePicker.Size = new Size(200, 27);

            // crime_textBox
            crime_textBox.Location = new Point(300, 260);
            crime_textBox.PlaceholderText = "Enter Crime";
            crime_textBox.Size = new Size(200, 27);

            // update_button
            update_button.Text = "Update";
            update_button.Location = new Point(300, 300);
            update_button.Size = new Size(200, 35);
            update_button.Click += new EventHandler(update_button_Click);

            // back_button
            back_button.Location = new Point(10, 10);
            back_button.Size = new Size(50, 50);
            back_button.BackgroundImage = Properties.Resources.back;
            back_button.BackgroundImageLayout = ImageLayout.Stretch;
            back_button.Click += new EventHandler(back_button_Click);

            // Form
            ClientSize = new Size(800, 450);
            Controls.AddRange(new Control[]
            {
                enterID, name_text, gender_textBox, AgeUpDownAge,
                birth_dateTimePicker, release_dateTimePicker,
                crime_textBox, update_button, back_button
            });
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            Name = "update_inmate_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Inmate";

            ((System.ComponentModel.ISupportInitialize)(AgeUpDownAge)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox enterID;
        private TextBox name_text;
        private TextBox gender_textBox;
        private NumericUpDown AgeUpDownAge;
        private DateTimePicker birth_dateTimePicker;
        private DateTimePicker release_dateTimePicker;
        private TextBox crime_textBox;
        private Button update_button;
        private Button back_button;
    }
}
