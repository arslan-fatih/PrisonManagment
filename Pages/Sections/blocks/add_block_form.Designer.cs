namespace PrisonManagment.Pages.Sections
{
    partial class add_block_form
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
            this.txtBlockID = new System.Windows.Forms.TextBox();
            this.numSecurityLevel = new System.Windows.Forms.NumericUpDown();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtGarden = new System.Windows.Forms.TextBox();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.insert_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSecurityLevel)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Block ID:";
            
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Security Level:";
            
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            
            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Garden:";
            
            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manager ID:";
            
            // txtBlockID
            this.txtBlockID.Location = new System.Drawing.Point(150, 57);
            this.txtBlockID.Name = "txtBlockID";
            this.txtBlockID.Size = new System.Drawing.Size(200, 23);
            this.txtBlockID.TabIndex = 6;
            
            // numSecurityLevel
            this.numSecurityLevel.Location = new System.Drawing.Point(150, 88);
            this.numSecurityLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSecurityLevel.Name = "numSecurityLevel";
            this.numSecurityLevel.Size = new System.Drawing.Size(200, 23);
            this.numSecurityLevel.TabIndex = 7;
            this.numSecurityLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            
            // txtType
            this.txtType.Location = new System.Drawing.Point(150, 117);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 23);
            this.txtType.TabIndex = 8;
            
            // txtGarden
            this.txtGarden.Location = new System.Drawing.Point(150, 147);
            this.txtGarden.Name = "txtGarden";
            this.txtGarden.Size = new System.Drawing.Size(200, 23);
            this.txtGarden.TabIndex = 9;
            
            // txtManagerID
            this.txtManagerID.Location = new System.Drawing.Point(150, 177);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.Size = new System.Drawing.Size(200, 23);
            this.txtManagerID.TabIndex = 10;
            
            // insert_button
            this.insert_button.Location = new System.Drawing.Point(275, 220);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 23);
            this.insert_button.TabIndex = 11;
            this.insert_button.Text = "Add Block";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            
            // add_block_form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.txtManagerID);
            this.Controls.Add(this.txtGarden);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.numSecurityLevel);
            this.Controls.Add(this.txtBlockID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Name = "add_block_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Block";
            ((System.ComponentModel.ISupportInitialize)(this.numSecurityLevel)).EndInit();
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
        private System.Windows.Forms.TextBox txtBlockID;
        private System.Windows.Forms.NumericUpDown numSecurityLevel;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtGarden;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.Button insert_button;
    }
}
