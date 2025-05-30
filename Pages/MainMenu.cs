using PrisonManagment.Pages;
using PrisonManagment.Pages.Sections;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace PrisonManagment
{
    public partial class MainMenu : Form
    {
        private Panel panelMainContent;
        private Panel panelStatistics;

        public MainMenu()
        {
            InitializeComponent();
            InitializeMainContentPanel();
            InitializeStatisticsPanel();
            LoadStatistics();
        }

        private void InitializeMainContentPanel()
        {
            panelMainContent = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };
            Controls.Add(panelMainContent);
            Controls.SetChildIndex(panelSidebar, 0); // Sidebar önde
        }
        
        private void InitializeStatisticsPanel()
        {
            panelStatistics = new Panel
            {
                Width = 400,
                Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
                Location = new Point(ClientSize.Width - 400, 0),
                BackColor = Color.FromArgb(45, 52, 54),
                BorderStyle = BorderStyle.None,
                Padding = new Padding(0)
            };
            
            // Create gradient header panel
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(30, 39, 46)
            };
            
            Label titleLabel = new Label
            {
                Text = "PRISON STATISTICS",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter
            };
            
            // Add an icon to the header
            PictureBox iconBox = new PictureBox
            {
                Size = new Size(24, 24),
                Location = new Point(15, 18),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            
            // Use a system icon since we don't have custom icons
            iconBox.Image = System.Drawing.SystemIcons.Information.ToBitmap();
            
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(iconBox);
            
            // Add a separator line
            Panel separatorLine = new Panel
            {
                Height = 2,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(72, 126, 176)
            };
            
            panelStatistics.Controls.Add(separatorLine);
            panelStatistics.Controls.Add(headerPanel);
            Controls.Add(panelStatistics);
            Controls.SetChildIndex(panelStatistics, 1);
        }
        
        private void LoadStatistics()
        {
            try
            {
                // Create a panel to hold statistics items with padding
                Panel statsContainer = new Panel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(15, 15, 15, 15),
                    BackColor = Color.FromArgb(45, 52, 54)
                };
                
                // Create a flowlayout panel to hold statistics items
                FlowLayoutPanel statsFlow = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.TopDown,
                    AutoScroll = true,
                    WrapContents = false,
                    Padding = new Padding(0),
                    BackColor = Color.Transparent
                };
                
                // Summary section at the top
                Panel summaryPanel = new Panel
                {
                    Width = statsFlow.Width - 5,
                    Height = 100,
                    Margin = new Padding(0, 0, 0, 15),
                    BackColor = Color.FromArgb(30, 39, 46),
                    BorderStyle = BorderStyle.None
                };
                
                // Create a 2x2 grid for the main stats
                TableLayoutPanel summaryGrid = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    RowCount = 2,
                    ColumnCount = 2,
                    Padding = new Padding(5),
                    BackColor = Color.Transparent
                };
                
                summaryGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                summaryGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                summaryGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                summaryGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                
                // Add the main statistics to the grid
                AddSummaryItem(summaryGrid, 0, 0, "Inmates", GetInmateCount().ToString(), Color.FromArgb(214, 48, 49), "👤");
                AddSummaryItem(summaryGrid, 0, 1, "Staff", GetStaffCount().ToString(), Color.FromArgb(9, 132, 227), "👮");
                AddSummaryItem(summaryGrid, 1, 0, "Blocks", GetBlockCount().ToString(), Color.FromArgb(0, 184, 148), "🏢");
                AddSummaryItem(summaryGrid, 1, 1, "Cells", GetCellCount().ToString(), Color.FromArgb(253, 203, 110), "🔒");
                
                summaryPanel.Controls.Add(summaryGrid);
                statsFlow.Controls.Add(summaryPanel);
                
                // Add a facility overview section
                AddFacilityOverview(statsFlow);
                
                // Add the detailed statistics items with icons
                AddStatItem(statsFlow, "📊 Inmates by Gender", null, GetInmatesByGender(), Color.FromArgb(214, 48, 49));
                AddStatItem(statsFlow, "🔒 Security Level Distribution", null, GetBlocksBySecurityLevel(), Color.FromArgb(9, 132, 227));
                AddStatItem(statsFlow, "📦 Inventory Items", GetInventoryCount(), null, Color.FromArgb(0, 184, 148));
                AddStatItem(statsFlow, "📅 Upcoming Releases", GetUpcomingReleaseCount(), null, Color.FromArgb(253, 203, 110));
                
                // Add occupancy rate chart
                AddOccupancyRate(statsFlow);
                
                // Add the flow panel to the container
                statsContainer.Controls.Add(statsFlow);
                
                // Add the container to the statistics panel
                panelStatistics.Controls.Add(statsContainer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void AddSummaryItem(TableLayoutPanel grid, int row, int col, string title, string value, Color accentColor, string icon = null)
        {
            Panel itemPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(5),
                BackColor = Color.FromArgb(53, 59, 72),
                Padding = new Padding(0, 0, 0, 0)
            };
            
            // Add a colored accent bar at the top
            Panel accentBar = new Panel
            {
                Height = 3,
                Dock = DockStyle.Top,
                BackColor = accentColor
            };
            
            // Create a panel for the title with icon
            Panel titlePanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 20,
                BackColor = Color.Transparent
            };
            
            Label titleLabel = new Label
            {
                Text = icon != null ? $"{icon} {title}" : title,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.LightGray,
                TextAlign = ContentAlignment.TopCenter,
                Padding = new Padding(0, 2, 0, 0)
            };
            
            titlePanel.Controls.Add(titleLabel);
            
            Label valueLabel = new Label
            {
                Text = value,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter
            };
            
            // Add a subtle glow effect with a slightly lighter background in the center
            Panel glowPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                Margin = new Padding(5, 5, 5, 5)
            };
            
            glowPanel.Paint += (sender, e) => {
                // Create a radial gradient for a subtle glow effect
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    glowPanel.ClientRectangle,
                    Color.FromArgb(20, accentColor),
                    Color.Transparent,
                    System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
                {
                    e.Graphics.FillRectangle(brush, glowPanel.ClientRectangle);
                }
            };
            
            glowPanel.Controls.Add(valueLabel);
            itemPanel.Controls.Add(glowPanel);
            itemPanel.Controls.Add(titlePanel);
            itemPanel.Controls.Add(accentBar);
            
            grid.Controls.Add(itemPanel, col, row);
        }
        
        private void AddStatItem(FlowLayoutPanel container, string title, int? count = null, DataTable details = null, Color accentColor = default)
        {
            if (accentColor == default)
                accentColor = Color.FromArgb(72, 126, 176);
                
            Panel statPanel = new Panel
            {
                Width = container.Width - 5,
                Height = (details != null) ? 140 : 80,
                Margin = new Padding(0, 0, 0, 15),
                BackColor = Color.FromArgb(53, 59, 72),
                BorderStyle = BorderStyle.None
            };
            
            // Add a colored accent bar at the left
            Panel accentBar = new Panel
            {
                Width = 4,
                Dock = DockStyle.Left,
                BackColor = accentColor
            };
            
            Label titleLabel = new Label
            {
                Text = title,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(15, 0, 0, 0)
            };
            
            Panel contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(15, 5, 15, 5)
            };
            
            statPanel.Controls.Add(contentPanel);
            statPanel.Controls.Add(titleLabel);
            statPanel.Controls.Add(accentBar);
            
            if (count.HasValue)
            {
                Label countLabel = new Label
                {
                    Text = count.Value.ToString(),
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 22, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                contentPanel.Controls.Add(countLabel);
            }
            else if (details != null)
            {
                // Create a more visual representation of the details
                TableLayoutPanel detailsTable = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 2,
                    RowCount = details.Rows.Count,
                    BackColor = Color.Transparent
                };
                
                detailsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
                detailsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
                
                for (int i = 0; i < details.Rows.Count; i++)
                {
                    detailsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / details.Rows.Count));
                    
                    string category = details.Rows[i][0].ToString();
                    string value = details.Rows[i][1].ToString();
                    
                    // Category label with progress bar background
                    Panel categoryPanel = new Panel
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(0, 5, 5, 5),
                        Padding = new Padding(0)
                    };
                    
                    // Progress bar background
                    Panel progressBg = new Panel
                    {
                        Dock = DockStyle.Fill,
                        BackColor = Color.FromArgb(45, 52, 54)
                    };
                    
                    // Get percentage for progress bar width (assuming we have at least 2 rows)
                    int maxValue = 0;
                    foreach (DataRow row in details.Rows)
                    {
                        int rowValue;
                        if (int.TryParse(row[1].ToString(), out rowValue) && rowValue > maxValue)
                            maxValue = rowValue;
                    }
                    
                    int currentValue;
                    int.TryParse(value, out currentValue);
                    
                    // Progress bar fill
                    int fillWidth = (maxValue > 0) ? (int)((float)currentValue / maxValue * categoryPanel.Width) : 0;
                    Panel progressFill = new Panel
                    {
                        Width = fillWidth,
                        Dock = DockStyle.Left,
                        BackColor = Color.FromArgb(accentColor.R, accentColor.G, accentColor.B, 100)
                    };
                    
                    Label categoryLabel = new Label
                    {
                        Text = category,
                        Dock = DockStyle.Fill,
                        Font = new Font("Segoe UI", 9),
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Padding = new Padding(5, 0, 0, 0),
                        BackColor = Color.Transparent
                    };
                    
                    Label valueLabel = new Label
                    {
                        Text = value,
                        Dock = DockStyle.Fill,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.Transparent
                    };
                    
                    progressBg.Controls.Add(progressFill);
                    categoryPanel.Controls.Add(categoryLabel);
                    categoryPanel.Controls.Add(progressBg);
                    
                    detailsTable.Controls.Add(categoryPanel, 0, i);
                    detailsTable.Controls.Add(valueLabel, 1, i);
                }
                
                contentPanel.Controls.Add(detailsTable);
            }
            
            container.Controls.Add(statPanel);
        }
        
        private void AddFacilityOverview(FlowLayoutPanel container)
        {
            Panel overviewPanel = new Panel
            {
                Width = container.Width - 5,
                Height = 80,
                Margin = new Padding(0, 0, 0, 15),
                BackColor = Color.FromArgb(53, 59, 72),
                BorderStyle = BorderStyle.None
            };
            
            // Add a colored accent bar at the left
            Panel accentBar = new Panel
            {
                Width = 4,
                Dock = DockStyle.Left,
                BackColor = Color.FromArgb(72, 126, 176)
            };
            
            Label titleLabel = new Label
            {
                Text = "🏢 Facility Overview",
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(15, 0, 0, 0)
            };
            
            // Create a panel for the blocks and cells relationship
            Panel contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(15, 5, 15, 5)
            };
            
            // Calculate cells per block ratio
            double cellsPerBlock = GetBlockCount() > 0 ? (double)GetCellCount() / GetBlockCount() : 0;
            
            Label overviewLabel = new Label
            {
                Text = $"Average {cellsPerBlock:F1} cells per block",
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.White,
                Height = 20,
                TextAlign = ContentAlignment.MiddleCenter
            };
            
            // Create a visual representation of blocks and cells
            Panel visualPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20, 0, 20, 0)
            };
            
            // Add block indicators
            int blockCount = Math.Min(GetBlockCount(), 10); // Limit to 10 visual blocks
            int blockWidth = (visualPanel.Width - 40) / Math.Max(blockCount, 1);
            
            for (int i = 0; i < blockCount; i++)
            {
                Panel blockIndicator = new Panel
                {
                    Width = blockWidth - 4,
                    Height = 10,
                    BackColor = Color.FromArgb(0, 184, 148),
                    Location = new Point(i * blockWidth + 2, 0)
                };
                visualPanel.Controls.Add(blockIndicator);
            }
            
            contentPanel.Controls.Add(visualPanel);
            contentPanel.Controls.Add(overviewLabel);
            
            overviewPanel.Controls.Add(contentPanel);
            overviewPanel.Controls.Add(titleLabel);
            overviewPanel.Controls.Add(accentBar);
            
            container.Controls.Add(overviewPanel);
        }
        
        private void AddOccupancyRate(FlowLayoutPanel container)
        {
            Panel occupancyPanel = new Panel
            {
                Width = container.Width - 5,
                Height = 100,
                Margin = new Padding(0, 0, 0, 15),
                BackColor = Color.FromArgb(53, 59, 72),
                BorderStyle = BorderStyle.None
            };
            
            // Add a colored accent bar at the left
            Panel accentBar = new Panel
            {
                Width = 4,
                Dock = DockStyle.Left,
                BackColor = Color.FromArgb(72, 126, 176)
            };
            
            Label titleLabel = new Label
            {
                Text = "📈 Occupancy Rate",
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(15, 0, 0, 0)
            };
            
            // Create a panel for the occupancy rate visualization
            Panel contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(15, 5, 15, 5)
            };
            
            // Calculate occupancy rate
            int inmates = GetInmateCount();
            int cells = GetCellCount();
            double occupancyRate = cells > 0 ? (double)inmates / cells * 100 : 0;
            occupancyRate = Math.Min(occupancyRate, 100); // Cap at 100%
            
            // Create progress bar for occupancy
            Panel progressBg = new Panel
            {
                Dock = DockStyle.Top,
                Height = 20,
                BackColor = Color.FromArgb(45, 52, 54),
                Margin = new Padding(0, 10, 0, 5)
            };
            
            Panel progressFill = new Panel
            {
                Width = (int)((occupancyRate / 100) * progressBg.Width),
                Dock = DockStyle.Left,
                BackColor = GetOccupancyColor(occupancyRate)
            };
            
            Label occupancyLabel = new Label
            {
                Text = $"Occupancy Rate: {occupancyRate:F1}% ({inmates} inmates / {cells} cells)",
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.White,
                Height = 20,
                TextAlign = ContentAlignment.MiddleCenter
            };
            
            progressBg.Controls.Add(progressFill);
            contentPanel.Controls.Add(occupancyLabel);
            contentPanel.Controls.Add(progressBg);
            
            occupancyPanel.Controls.Add(contentPanel);
            occupancyPanel.Controls.Add(titleLabel);
            occupancyPanel.Controls.Add(accentBar);
            
            container.Controls.Add(occupancyPanel);
        }
        
        private Color GetOccupancyColor(double rate)
        {
            if (rate < 70)
                return Color.FromArgb(0, 184, 148); // Green for low occupancy
            else if (rate < 90)
                return Color.FromArgb(253, 203, 110); // Yellow for medium occupancy
            else
                return Color.FromArgb(214, 48, 49); // Red for high occupancy
        }
        
        #region Database Statistics Methods
        
        private int GetInmateCount()
        {
            DataTable inmates = Database.GetAllInmates();
            return inmates.Rows.Count;
        }
        
        private int GetStaffCount()
        {
            DataTable staff = Database.GetAllStaff();
            return staff.Rows.Count;
        }
        
        private int GetBlockCount()
        {
            DataTable blocks = Database.GetAllBlocks();
            return blocks.Rows.Count;
        }
        
        private int GetCellCount()
        {
            DataTable cells = Database.GetAllCells();
            return cells.Rows.Count;
        }
        
        private int GetInventoryCount()
        {
            DataTable inventory = Database.GetAllInventory();
            return inventory.Rows.Count;
        }
        
        private int GetUpcomingReleaseCount()
        {
            DataTable inmates = Database.GetAllInmates();
            int count = 0;
            
            foreach (DataRow row in inmates.Rows)
            {
                if (row["ReleaseDate"] != DBNull.Value)
                {
                    DateTime releaseDate = Convert.ToDateTime(row["ReleaseDate"]);
                    if (releaseDate > DateTime.Now && releaseDate < DateTime.Now.AddMonths(1))
                    {
                        count++;
                    }
                }
            }
            
            return count;
        }
        
        private DataTable GetInmatesByGender()
        {
            DataTable inmates = Database.GetAllInmates();
            DataTable result = new DataTable();
            result.Columns.Add("Gender", typeof(string));
            result.Columns.Add("Count", typeof(string));
            
            var maleCount = inmates.AsEnumerable()
                .Count(r => r.Field<string>("Gender")?.ToLower() == "male");
            
            var femaleCount = inmates.AsEnumerable()
                .Count(r => r.Field<string>("Gender")?.ToLower() == "female");
            
            result.Rows.Add("Male", maleCount.ToString());
            result.Rows.Add("Female", femaleCount.ToString());
            
            return result;
        }
        
        private DataTable GetBlocksBySecurityLevel()
        {
            DataTable blocks = Database.GetAllBlocks();
            DataTable result = new DataTable();
            result.Columns.Add("Level", typeof(string));
            result.Columns.Add("Count", typeof(string));
            
            var levels = blocks.AsEnumerable()
                .GroupBy(r => r.Field<int>("SecurityLV"))
                .Select(g => new { Level = g.Key, Count = g.Count() });
            
            foreach (var level in levels)
            {
                result.Rows.Add($"Level {level.Level}", level.Count.ToString());
            }
            
            return result;
        }
        
        #endregion

        private void LoadUserControl(UserControl uc)
        {
            panelMainContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(uc);
        }





        private void btnStaff_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            staff_form staff_Form = new staff_form();
            this.Hide();
            staff_Form.ShowDialog();
            this.Close();

        }

        private void InmateButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            inmate_form inmate_Form = new inmate_form();
            this.Hide();
            inmate_Form.ShowDialog();
            this.Close();

        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            inventory_form inventory_Form = new inventory_form();
            this.Hide();
            inventory_Form.ShowDialog();
            this.Close();

        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            cell_form cellForm = new cell_form();
            this.Hide();
            cellForm.ShowDialog();
            this.Close();

        }

        private void blocks_button_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            blocks_form BlocksForm = new blocks_form();
            this.Hide();
            BlocksForm.ShowDialog();
            this.Close();
        }

        private void HousesButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            houses_form housesForm = new houses_form();
            this.Hide();
            housesForm.ShowDialog();
            this.Close();
        }

        private void MedicalRecordButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            Medical_Record medicalRecordsForm = new Medical_Record();
            this.Hide();
            medicalRecordsForm.ShowDialog();
            this.Close();
        }

        private void SuppliesButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            supplies_form SuppliesForm = new supplies_form();
            this.Hide();
            SuppliesForm.ShowDialog();
            this.Close();
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            Form currentForm = this.FindForm();
            supplier_form SupplierForm = new supplier_form();
            this.Hide();
            SupplierForm.ShowDialog();
            this.Close();
        }
    }
}