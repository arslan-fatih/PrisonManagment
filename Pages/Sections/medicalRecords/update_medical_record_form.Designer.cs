namespace PrisonManagment.Pages.Sections
{
    partial class update_medical_record_form
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
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInmateID = new System.Windows.Forms.TextBox();
            this.txtConditions = new System.Windows.Forms.TextBox();
            this.txtMedications = new System.Windows.Forms.TextBox();
            this.dtpLastCheckup = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // back_button
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record ID to Update:";
            
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inmate ID:";
            
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Conditions:";
            
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Medications:";
            
            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Checkup:";
            
            // label6
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Notes:";
            
            // txtID
            this.txtID.Location = new System.Drawing.Point(150, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 23);
            this.txtID.TabIndex = 7;
            
            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(375, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            
            // txtInmateID
            this.txtInmateID.Enabled = false;
            this.txtInmateID.Location = new System.Drawing.Point(150, 117);
            this.txtInmateID.Name = "txtInmateID";
            this.txtInmateID.Size = new System.Drawing.Size(200, 23);
            this.txtInmateID.TabIndex = 9;
            
            // txtConditions
            this.txtConditions.Enabled = false;
            this.txtConditions.Location = new System.Drawing.Point(150, 147);
            this.txtConditions.Multiline = true;
            this.txtConditions.Name = "txtConditions";
            this.txtConditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConditions.Size = new System.Drawing.Size(400, 60);
            this.txtConditions.TabIndex = 10;
            
            // txtMedications
            this.txtMedications.Enabled = false;
            this.txtMedications.Location = new System.Drawing.Point(150, 213);
            this.txtMedications.Multiline = true;
            this.txtMedications.Name = "txtMedications";
            this.txtMedications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMedications.Size = new System.Drawing.Size(400, 50);
            this.txtMedications.TabIndex = 11;
            
            // dtpLastCheckup
            this.dtpLastCheckup.CustomFormat = " ";
            this.dtpLastCheckup.Enabled = false;
            this.dtpLastCheckup.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastCheckup.Location = new System.Drawing.Point(150, 270);
            this.dtpLastCheckup.Name = "dtpLastCheckup";
            this.dtpLastCheckup.Size = new System.Drawing.Size(200, 23);
            this.dtpLastCheckup.TabIndex = 12;
            this.dtpLastCheckup.ValueChanged += new System.EventHandler(this.dtpLastCheckup_ValueChanged);
            
            // txtNotes
            this.txtNotes.Enabled = false;
            this.txtNotes.Location = new System.Drawing.Point(150, 300);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(400, 80);
            this.txtNotes.TabIndex = 13;
            
            // update_button
            this.update_button.Enabled = false;
            this.update_button.Location = new System.Drawing.Point(475, 390);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 14;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            
            // update_medical_record_form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dtpLastCheckup);
            this.Controls.Add(this.txtMedications);
            this.Controls.Add(this.txtConditions);
            this.Controls.Add(this.txtInmateID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Name = "update_medical_record_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Medical Record";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInmateID;
        private System.Windows.Forms.TextBox txtConditions;
        private System.Windows.Forms.TextBox txtMedications;
        private System.Windows.Forms.DateTimePicker dtpLastCheckup;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button update_button;
    }
}
