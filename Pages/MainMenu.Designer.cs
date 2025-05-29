namespace PrisonManagment
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panelSidebar = new Panel();
            inventoryButton = new Button();
            InmateButton = new Button();
            staffButton = new Button();
            lblSidebarTitle = new Label();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSidebar.AutoSize = true;
            panelSidebar.BackColor = Color.DarkSlateGray;
            panelSidebar.Controls.Add(inventoryButton);
            panelSidebar.Controls.Add(InmateButton);
            panelSidebar.Controls.Add(staffButton);
            panelSidebar.Controls.Add(lblSidebarTitle);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(180, 450);
            panelSidebar.TabIndex = 0;
            // 
            // inventoryButton
            // 
            inventoryButton.Cursor = Cursors.Hand;
            inventoryButton.Dock = DockStyle.Top;
            inventoryButton.FlatAppearance.BorderSize = 0;
            inventoryButton.FlatStyle = FlatStyle.Flat;
            inventoryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            inventoryButton.ForeColor = Color.White;
            inventoryButton.Location = new Point(0, 249);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(180, 29);
            inventoryButton.TabIndex = 8;
            inventoryButton.Text = "Inventory";
            inventoryButton.UseVisualStyleBackColor = true;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // InmateButton
            // 
            InmateButton.Cursor = Cursors.Hand;
            InmateButton.Dock = DockStyle.Top;
            InmateButton.FlatAppearance.BorderSize = 0;
            InmateButton.FlatStyle = FlatStyle.Flat;
            InmateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            InmateButton.ForeColor = Color.White;
            InmateButton.Location = new Point(0, 220);
            InmateButton.Name = "InmateButton";
            InmateButton.Size = new Size(180, 29);
            InmateButton.TabIndex = 7;
            InmateButton.Text = "Inmate";
            InmateButton.UseVisualStyleBackColor = true;
            InmateButton.Click += InmateButton_Click;
            // 
            // staffButton
            // 
            staffButton.Cursor = Cursors.Hand;
            staffButton.Dock = DockStyle.Top;
            staffButton.FlatAppearance.BorderSize = 0;
            staffButton.FlatStyle = FlatStyle.Flat;
            staffButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            staffButton.ForeColor = Color.White;
            staffButton.Location = new Point(0, 191);
            staffButton.Name = "staffButton";
            staffButton.Size = new Size(180, 29);
            staffButton.TabIndex = 6;
            staffButton.Text = "Staff";
            staffButton.UseVisualStyleBackColor = true;
            staffButton.Click += btnStaff_Click;
            // 
            // lblSidebarTitle
            // 
            lblSidebarTitle.Dock = DockStyle.Top;
            lblSidebarTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSidebarTitle.ForeColor = Color.White;
            lblSidebarTitle.Location = new Point(0, 0);
            lblSidebarTitle.Name = "lblSidebarTitle";
            lblSidebarTitle.Size = new Size(180, 191);
            lblSidebarTitle.TabIndex = 10;
            lblSidebarTitle.Text = "PRISON MANAGEMENT SYSTEM";
            lblSidebarTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 450);
            Controls.Add(panelSidebar);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
           
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private Button inventoryButton;
        private Button InmateButton;
        private Button staffButton;
        private Label lblSidebarTitle;
    }
}
