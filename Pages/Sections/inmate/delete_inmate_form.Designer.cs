namespace PrisonManagment.Pages
{
    partial class delete_inmate_form
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
            this.enterID = new TextBox();
            this.delete_button = new Button();
            this.back_button = new Button();

            // 
            // enterID
            // 
            this.enterID.Location = new Point(300, 150);
            this.enterID.Name = "enterID";
            this.enterID.PlaceholderText = "Enter Inmate ID";
            this.enterID.Size = new Size(200, 27);

            // 
            // delete_button
            // 
            this.delete_button.Text = "Delete";
            this.delete_button.Location = new Point(300, 200);
            this.delete_button.Size = new Size(200, 35);
            this.delete_button.Click += new EventHandler(this.delete_button_Click);

            // 
            // back_button
            // 
            this.back_button.Location = new Point(10, 10);
            this.back_button.Size = new Size(50, 50);
            this.back_button.BackgroundImage = Properties.Resources.back;
            this.back_button.BackgroundImageLayout = ImageLayout.Stretch;
            this.back_button.Click += new EventHandler(this.back_button_Click);

            // 
            // delete_inmate_form
            // 
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.enterID);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.back_button);
            this.Name = "delete_inmate_form";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Delete Inmate";
            this.BackgroundImage = Properties.Resources.Untitled_design;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        #endregion

        private TextBox enterID;
        private Button delete_button;
        private Button back_button;
    }
}
