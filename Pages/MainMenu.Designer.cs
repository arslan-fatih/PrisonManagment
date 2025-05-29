﻿namespace PrisonManagment
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
            SupplierButton = new Button();
            SuppliesButton = new Button();
            MedicalRecordButton = new Button();
            HousesButton = new Button();
            blocks_button = new Button();
            Cell = new Button();
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
            panelSidebar.Controls.Add(SupplierButton);
            panelSidebar.Controls.Add(SuppliesButton);
            panelSidebar.Controls.Add(MedicalRecordButton);
            panelSidebar.Controls.Add(HousesButton);
            panelSidebar.Controls.Add(blocks_button);
            panelSidebar.Controls.Add(Cell);
            panelSidebar.Controls.Add(inventoryButton);
            panelSidebar.Controls.Add(InmateButton);
            panelSidebar.Controls.Add(staffButton);
            panelSidebar.Controls.Add(lblSidebarTitle);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(180, 450);
            panelSidebar.TabIndex = 0;
            // 
            // SupplierButton
            // 
            SupplierButton.Cursor = Cursors.Hand;
            SupplierButton.Dock = DockStyle.Top;
            SupplierButton.FlatAppearance.BorderSize = 0;
            SupplierButton.FlatStyle = FlatStyle.Flat;
            SupplierButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SupplierButton.ForeColor = Color.White;
            SupplierButton.Location = new Point(0, 361);
            SupplierButton.Name = "SupplierButton";
            SupplierButton.Size = new Size(180, 29);
            SupplierButton.TabIndex = 16;
            SupplierButton.Text = "Supplier";
            SupplierButton.UseVisualStyleBackColor = true;
            SupplierButton.Click += SupplierButton_Click;
            // 
            // SuppliesButton
            // 
            SuppliesButton.Cursor = Cursors.Hand;
            SuppliesButton.Dock = DockStyle.Top;
            SuppliesButton.FlatAppearance.BorderSize = 0;
            SuppliesButton.FlatStyle = FlatStyle.Flat;
            SuppliesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            SuppliesButton.ForeColor = Color.White;
            SuppliesButton.Location = new Point(0, 332);
            SuppliesButton.Name = "SuppliesButton";
            SuppliesButton.Size = new Size(180, 29);
            SuppliesButton.TabIndex = 15;
            SuppliesButton.Text = "Supplies";
            SuppliesButton.UseVisualStyleBackColor = true;
            SuppliesButton.Click += SuppliesButton_Click;
            // 
            // MedicalRecordButton
            // 
            MedicalRecordButton.Cursor = Cursors.Hand;
            MedicalRecordButton.Dock = DockStyle.Top;
            MedicalRecordButton.FlatAppearance.BorderSize = 0;
            MedicalRecordButton.FlatStyle = FlatStyle.Flat;
            MedicalRecordButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            MedicalRecordButton.ForeColor = Color.White;
            MedicalRecordButton.Location = new Point(0, 303);
            MedicalRecordButton.Name = "MedicalRecordButton";
            MedicalRecordButton.Size = new Size(180, 29);
            MedicalRecordButton.TabIndex = 14;
            MedicalRecordButton.Text = "Medical Record";
            MedicalRecordButton.UseVisualStyleBackColor = true;
            MedicalRecordButton.Click += MedicalRecordButton_Click;
            // 
            // HousesButton
            // 
            HousesButton.Cursor = Cursors.Hand;
            HousesButton.Dock = DockStyle.Top;
            HousesButton.FlatAppearance.BorderSize = 0;
            HousesButton.FlatStyle = FlatStyle.Flat;
            HousesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            HousesButton.ForeColor = Color.White;
            HousesButton.Location = new Point(0, 274);
            HousesButton.Name = "HousesButton";
            HousesButton.Size = new Size(180, 29);
            HousesButton.TabIndex = 13;
            HousesButton.Text = "Houses";
            HousesButton.UseVisualStyleBackColor = true;
            HousesButton.Click += HousesButton_Click;
            // 
            // blocks_button
            // 
            blocks_button.Cursor = Cursors.Hand;
            blocks_button.Dock = DockStyle.Top;
            blocks_button.FlatAppearance.BorderSize = 0;
            blocks_button.FlatStyle = FlatStyle.Flat;
            blocks_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            blocks_button.ForeColor = Color.White;
            blocks_button.Location = new Point(0, 245);
            blocks_button.Name = "blocks_button";
            blocks_button.Size = new Size(180, 29);
            blocks_button.TabIndex = 12;
            blocks_button.Text = "Blocks";
            blocks_button.UseVisualStyleBackColor = true;
            blocks_button.Click += blocks_button_Click;
            // 
            // Cell
            // 
            Cell.Cursor = Cursors.Hand;
            Cell.Dock = DockStyle.Top;
            Cell.FlatAppearance.BorderSize = 0;
            Cell.FlatStyle = FlatStyle.Flat;
            Cell.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Cell.ForeColor = Color.White;
            Cell.Location = new Point(0, 216);
            Cell.Name = "Cell";
            Cell.Size = new Size(180, 29);
            Cell.TabIndex = 11;
            Cell.Text = "Cell";
            Cell.UseVisualStyleBackColor = true;
            Cell.Click += Cell_Click;
            // 
            // inventoryButton
            // 
            inventoryButton.Cursor = Cursors.Hand;
            inventoryButton.Dock = DockStyle.Top;
            inventoryButton.FlatAppearance.BorderSize = 0;
            inventoryButton.FlatStyle = FlatStyle.Flat;
            inventoryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            inventoryButton.ForeColor = Color.White;
            inventoryButton.Location = new Point(0, 187);
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
            InmateButton.Location = new Point(0, 158);
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
            staffButton.Location = new Point(0, 129);
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
            lblSidebarTitle.Size = new Size(180, 129);
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
        private Button Cell;
        private Button blocks_button;
        private Button HousesButton;
        private Button MedicalRecordButton;
        private Button SuppliesButton;
        private Button SupplierButton;
    }
}