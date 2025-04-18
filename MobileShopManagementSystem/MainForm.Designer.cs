namespace MobileShopManagementSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.titlepanel = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.shopContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_shop = new System.Windows.Forms.Button();
            this.btn_categories = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.shopTransition = new System.Windows.Forms.Timer(this.components);
            this.parrotSlidingPanel1 = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.btnHam = new System.Windows.Forms.Button();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.titlepanel.SuspendLayout();
            this.shopContainer.SuspendLayout();
            this.parrotSlidingPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cyberGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlepanel
            // 
            this.titlepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titlepanel.Controls.Add(this.nightControlBox1);
            this.titlepanel.Controls.Add(this.btnHam);
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlepanel.Location = new System.Drawing.Point(0, 0);
            this.titlepanel.Name = "titlepanel";
            this.titlepanel.Size = new System.Drawing.Size(1357, 39);
            this.titlepanel.TabIndex = 0;
            this.titlepanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.titlepanel_MouseDoubleClick);
            this.titlepanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlepanel_MouseDown);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1218, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 2;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = global::MobileShopManagementSystem.Properties.Resources.Statistics;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(3, 224);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_dashboard.Size = new System.Drawing.Size(249, 49);
            this.btn_dashboard.TabIndex = 2;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // shopContainer
            // 
            this.shopContainer.BackColor = System.Drawing.Color.Transparent;
            this.shopContainer.Controls.Add(this.btn_shop);
            this.shopContainer.Controls.Add(this.btn_categories);
            this.shopContainer.Controls.Add(this.btn_bill);
            this.shopContainer.Location = new System.Drawing.Point(0, 276);
            this.shopContainer.Margin = new System.Windows.Forms.Padding(0);
            this.shopContainer.Name = "shopContainer";
            this.shopContainer.Size = new System.Drawing.Size(249, 49);
            this.shopContainer.TabIndex = 9;
            // 
            // btn_shop
            // 
            this.btn_shop.BackColor = System.Drawing.Color.Transparent;
            this.btn_shop.FlatAppearance.BorderSize = 0;
            this.btn_shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shop.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_shop.ForeColor = System.Drawing.Color.White;
            this.btn_shop.Image = global::MobileShopManagementSystem.Properties.Resources.Online_Shop;
            this.btn_shop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_shop.Location = new System.Drawing.Point(0, 0);
            this.btn_shop.Margin = new System.Windows.Forms.Padding(0);
            this.btn_shop.Name = "btn_shop";
            this.btn_shop.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_shop.Size = new System.Drawing.Size(249, 49);
            this.btn_shop.TabIndex = 2;
            this.btn_shop.Text = "Shop";
            this.btn_shop.UseVisualStyleBackColor = false;
            this.btn_shop.Click += new System.EventHandler(this.btn_shop_Click);
            // 
            // btn_categories
            // 
            this.btn_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(101)))));
            this.btn_categories.FlatAppearance.BorderSize = 0;
            this.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categories.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_categories.ForeColor = System.Drawing.Color.White;
            this.btn_categories.Image = global::MobileShopManagementSystem.Properties.Resources.iPhone_14;
            this.btn_categories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categories.Location = new System.Drawing.Point(0, 49);
            this.btn_categories.Margin = new System.Windows.Forms.Padding(0);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_categories.Size = new System.Drawing.Size(249, 49);
            this.btn_categories.TabIndex = 2;
            this.btn_categories.Text = "Categories";
            this.btn_categories.UseVisualStyleBackColor = false;
            this.btn_categories.Click += new System.EventHandler(this.btn_categories_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(101)))));
            this.btn_bill.FlatAppearance.BorderSize = 0;
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_bill.ForeColor = System.Drawing.Color.White;
            this.btn_bill.Image = global::MobileShopManagementSystem.Properties.Resources.Buy_For_Coins;
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.Location = new System.Drawing.Point(0, 98);
            this.btn_bill.Margin = new System.Windows.Forms.Padding(0);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_bill.Size = new System.Drawing.Size(249, 49);
            this.btn_bill.TabIndex = 3;
            this.btn_bill.Text = "Bill";
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventory.FlatAppearance.BorderSize = 0;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_inventory.ForeColor = System.Drawing.Color.White;
            this.btn_inventory.Image = global::MobileShopManagementSystem.Properties.Resources.Warehouse;
            this.btn_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventory.Location = new System.Drawing.Point(3, 328);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_inventory.Size = new System.Drawing.Size(249, 49);
            this.btn_inventory.TabIndex = 2;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = false;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.Color.Transparent;
            this.btn_customers.FlatAppearance.BorderSize = 0;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_customers.ForeColor = System.Drawing.Color.White;
            this.btn_customers.Image = global::MobileShopManagementSystem.Properties.Resources.Staff;
            this.btn_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.Location = new System.Drawing.Point(3, 383);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_customers.Size = new System.Drawing.Size(249, 49);
            this.btn_customers.TabIndex = 2;
            this.btn_customers.Text = "Customers";
            this.btn_customers.UseVisualStyleBackColor = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::MobileShopManagementSystem.Properties.Resources.Logout;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(3, 548);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(249, 49);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // shopTransition
            // 
            this.shopTransition.Interval = 10;
            this.shopTransition.Tick += new System.EventHandler(this.shopTransition_Tick);
            // 
            // parrotSlidingPanel1
            // 
            this.parrotSlidingPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.parrotSlidingPanel1.BottomLeft = System.Drawing.Color.Gray;
            this.parrotSlidingPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.parrotSlidingPanel1.CollapseControl = this.btnHam;
            this.parrotSlidingPanel1.Collapsed = false;
            this.parrotSlidingPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.parrotSlidingPanel1.Controls.Add(this.flowLayoutPanel1);
            this.parrotSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.parrotSlidingPanel1.HideControls = false;
            this.parrotSlidingPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.High;
            this.parrotSlidingPanel1.Location = new System.Drawing.Point(0, 39);
            this.parrotSlidingPanel1.Name = "parrotSlidingPanel1";
            this.parrotSlidingPanel1.PanelWidthCollapsed = 62;
            this.parrotSlidingPanel1.PanelWidthExpanded = 249;
            this.parrotSlidingPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            this.parrotSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotSlidingPanel1.Size = new System.Drawing.Size(249, 749);
            this.parrotSlidingPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.parrotSlidingPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotSlidingPanel1.TabIndex = 3;
            this.parrotSlidingPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotSlidingPanel1.TopLeft = System.Drawing.Color.Blue;
            this.parrotSlidingPanel1.TopRight = System.Drawing.Color.Black;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.cyberGroupBox1);
            this.flowLayoutPanel1.Controls.Add(this.btn_dashboard);
            this.flowLayoutPanel1.Controls.Add(this.shopContainer);
            this.flowLayoutPanel1.Controls.Add(this.btn_inventory);
            this.flowLayoutPanel1.Controls.Add(this.btn_customers);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.btn_logout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 749);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MobileShopManagementSystem.Properties.Resources.Male_User;
            this.pictureBox1.Location = new System.Drawing.Point(68, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cyberGroupBox1
            // 
            this.cyberGroupBox1.Alpha = 20;
            this.cyberGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.cyberGroupBox1.Background = true;
            this.cyberGroupBox1.Background_WidthPen = 3F;
            this.cyberGroupBox1.BackgroundPen = true;
            this.cyberGroupBox1.ColorBackground = System.Drawing.Color.Transparent;
            this.cyberGroupBox1.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox1.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberGroupBox1.ColorBackground_Pen = System.Drawing.Color.White;
            this.cyberGroupBox1.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberGroupBox1.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox1.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberGroupBox1.Controls.Add(this.dungeonLabel2);
            this.cyberGroupBox1.Controls.Add(this.dungeonLabel1);
            this.cyberGroupBox1.Controls.Add(this.pictureBox1);
            this.cyberGroupBox1.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberGroupBox1.Lighting = false;
            this.cyberGroupBox1.LinearGradient_Background = false;
            this.cyberGroupBox1.LinearGradientPen = false;
            this.cyberGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.cyberGroupBox1.Name = "cyberGroupBox1";
            this.cyberGroupBox1.PenWidth = 15;
            this.cyberGroupBox1.RGB = false;
            this.cyberGroupBox1.Rounding = true;
            this.cyberGroupBox1.RoundingInt = 60;
            this.cyberGroupBox1.Size = new System.Drawing.Size(243, 215);
            this.cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberGroupBox1.TabIndex = 10;
            this.cyberGroupBox1.Tag = "Cyber";
            this.cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberGroupBox1.Timer_RGB = 300;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.White;
            this.dungeonLabel1.Location = new System.Drawing.Point(80, 124);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(97, 25);
            this.dungeonLabel1.TabIndex = 10;
            this.dungeonLabel1.Text = "Username";
            // 
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHam.FlatAppearance.BorderSize = 0;
            this.btnHam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHam.Image = global::MobileShopManagementSystem.Properties.Resources.Menu2;
            this.btnHam.Location = new System.Drawing.Point(12, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(42, 41);
            this.btnHam.TabIndex = 2;
            this.btnHam.UseVisualStyleBackColor = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.White;
            this.dungeonLabel2.Location = new System.Drawing.Point(80, 158);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(80, 25);
            this.dungeonLabel2.TabIndex = 11;
            this.dungeonLabel2.Text = "position";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::MobileShopManagementSystem.Properties.Resources.Staff;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 438);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(249, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "User";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::MobileShopManagementSystem.Properties.Resources.Staff;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 493);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(249, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Setting";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1357, 788);
            this.ControlBox = false;
            this.Controls.Add(this.parrotSlidingPanel1);
            this.Controls.Add(this.titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.titlepanel.ResumeLayout(false);
            this.shopContainer.ResumeLayout(false);
            this.parrotSlidingPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cyberGroupBox1.ResumeLayout(false);
            this.cyberGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titlepanel;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_shop;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.FlowLayoutPanel shopContainer;
        private System.Windows.Forms.Button btn_categories;
        private System.Windows.Forms.Timer shopTransition;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btnHam;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Button btn_bill;
        private ReaLTaiizor.Controls.ParrotSlidingPanel parrotSlidingPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}