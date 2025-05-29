namespace PrisonManagment
{
    partial class update_staff_form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.txtAssignedBlock = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            int labelX = 20, textX = 140, y = 20, yStep = 30, width = 180;

            // Labels and TextBoxes
            AddLabel("Staff ID:", labelX, y);
            txtID.Location = new System.Drawing.Point(textX, y);
            txtID.Size = new System.Drawing.Size(width, 20);

            AddLabel("Role:", labelX, y += yStep);
            txtRole.Location = new System.Drawing.Point(textX, y);
            txtRole.Size = new System.Drawing.Size(width, 20);

            AddLabel("Name:", labelX, y += yStep);
            txtName.Location = new System.Drawing.Point(textX, y);
            txtName.Size = new System.Drawing.Size(width, 20);

            AddLabel("Age:", labelX, y += yStep);
            txtAge.Location = new System.Drawing.Point(textX, y);
            txtAge.Size = new System.Drawing.Size(width, 20);

            AddLabel("Wage:", labelX, y += yStep);
            txtWage.Location = new System.Drawing.Point(textX, y);
            txtWage.Size = new System.Drawing.Size(width, 20);

            AddLabel("Supervisor ID:", labelX, y += yStep);
            txtSupervisor.Location = new System.Drawing.Point(textX, y);
            txtSupervisor.Size = new System.Drawing.Size(width, 20);

            AddLabel("Assigned Block ID:", labelX, y += yStep);
            txtAssignedBlock.Location = new System.Drawing.Point(textX, y);
            txtAssignedBlock.Size = new System.Drawing.Size(width, 20);

            // Buttons
            btnUpdate.Text = "Update";
            btnUpdate.Location = new System.Drawing.Point(50, y += yStep + 10);
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            btnCancel.Text = "Cancel";
            btnCancel.Location = new System.Drawing.Point(170, y);
            btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(360, y + 60);
            this.Controls.AddRange(new Control[] {
                txtID, txtRole, txtName, txtAge, txtWage, txtSupervisor, txtAssignedBlock,
                btnUpdate, btnCancel
            });
            this.Name = "update_staff_form";
            this.Text = "Update Staff";
            this.ResumeLayout(false);
        }

        private void AddLabel(string text, int x, int y)
        {
            var lbl = new System.Windows.Forms.Label();
            lbl.Text = text;
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(120, 20);
            this.Controls.Add(lbl);
        }

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtWage;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.TextBox txtAssignedBlock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}
