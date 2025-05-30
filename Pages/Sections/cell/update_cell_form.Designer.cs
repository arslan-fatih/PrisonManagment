namespace PrisonManagment.Pages.Sections
{
    partial class update_cell_form
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
            this.txtCellNumber = new System.Windows.Forms.TextBox();
            this.chkSolitary = new System.Windows.Forms.CheckBox();
            this.txtBlockID = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cell Number:";
            
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solitary:";
            
            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Block ID:";
            
            // txtCellNumber
            this.txtCellNumber.Location = new System.Drawing.Point(150, 57);
            this.txtCellNumber.Name = "txtCellNumber";
            this.txtCellNumber.Size = new System.Drawing.Size(120, 23);
            this.txtCellNumber.TabIndex = 4;
            
            // chkSolitary
            this.chkSolitary.AutoSize = true;
            this.chkSolitary.Enabled = false;
            this.chkSolitary.Location = new System.Drawing.Point(150, 90);
            this.chkSolitary.Name = "chkSolitary";
            this.chkSolitary.Size = new System.Drawing.Size(15, 14);
            this.chkSolitary.TabIndex = 5;
            this.chkSolitary.UseVisualStyleBackColor = true;
            
            // txtBlockID
            this.txtBlockID.Enabled = false;
            this.txtBlockID.Location = new System.Drawing.Point(150, 117);
            this.txtBlockID.Name = "txtBlockID";
            this.txtBlockID.Size = new System.Drawing.Size(200, 23);
            this.txtBlockID.TabIndex = 6;
            
            // update_button
            this.update_button.Enabled = false;
            this.update_button.Location = new System.Drawing.Point(275, 160);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 8;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            
            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(275, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            
            // update_cell_form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 200);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBlockID);
            this.Controls.Add(this.chkSolitary);
            this.Controls.Add(this.txtCellNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Name = "update_cell_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Cell";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCellNumber;
        private System.Windows.Forms.CheckBox chkSolitary;
        private System.Windows.Forms.TextBox txtBlockID;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button btnSearch;
    }
}
