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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titlepanel = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.btnHam = new System.Windows.Forms.Button();
            this.shopContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_shop = new System.Windows.Forms.Button();
            this.btn_categories = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.shopTransition = new System.Windows.Forms.Timer(this.components);
            this.slidebar = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cyberGroupBox1 = new ReaLTaiizor.Controls.CyberGroupBox();
            this.lbl_role = new ReaLTaiizor.Controls.DungeonLabel();
            this.lbl_userName = new ReaLTaiizor.Controls.DungeonLabel();
            this.cyberGroupBox2 = new ReaLTaiizor.Controls.CyberGroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titlepanel.SuspendLayout();
            this.shopContainer.SuspendLayout();
            this.slidebar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.cyberGroupBox1.SuspendLayout();
            this.cyberGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.nightControlBox1.Click += new System.EventHandler(this.nightControlBox1_Click);
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
            this.btn_categories.Image = global::MobileShopManagementSystem.Properties.Resources.Warehouse;
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
            // shopTransition
            // 
            this.shopTransition.Interval = 10;
            this.shopTransition.Tick += new System.EventHandler(this.shopTransition_Tick);
            // 
            // slidebar
            // 
            this.slidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.slidebar.BottomLeft = System.Drawing.Color.Gray;
            this.slidebar.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.slidebar.CollapseControl = this.btnHam;
            this.slidebar.Collapsed = false;
            this.slidebar.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.slidebar.Controls.Add(this.flowLayoutPanel1);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.HideControls = false;
            this.slidebar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.High;
            this.slidebar.Location = new System.Drawing.Point(0, 39);
            this.slidebar.Name = "slidebar";
            this.slidebar.PanelWidthCollapsed = 62;
            this.slidebar.PanelWidthExpanded = 249;
            this.slidebar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.slidebar.PrimerColor = System.Drawing.Color.White;
            this.slidebar.Size = new System.Drawing.Size(249, 749);
            this.slidebar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.slidebar.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.slidebar.TabIndex = 3;
            this.slidebar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.slidebar.TopLeft = System.Drawing.Color.Blue;
            this.slidebar.TopRight = System.Drawing.Color.Black;
            this.slidebar.OnCollapsedStateChanged += new System.EventHandler(this.slidebar_OnCollapsedStateChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.cyberGroupBox1);
            this.flowLayoutPanel1.Controls.Add(this.btn_dashboard);
            this.flowLayoutPanel1.Controls.Add(this.shopContainer);
            this.flowLayoutPanel1.Controls.Add(this.btn_inventory);
            this.flowLayoutPanel1.Controls.Add(this.btn_customers);
            this.flowLayoutPanel1.Controls.Add(this.btn_user);
            this.flowLayoutPanel1.Controls.Add(this.btn_setting);
            this.flowLayoutPanel1.Controls.Add(this.btn_logout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 749);
            this.flowLayoutPanel1.TabIndex = 10;
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
            this.cyberGroupBox1.Controls.Add(this.lbl_role);
            this.cyberGroupBox1.Controls.Add(this.lbl_userName);
            this.cyberGroupBox1.Controls.Add(this.cyberGroupBox2);
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
            this.cyberGroupBox1.RoundingInt = 30;
            this.cyberGroupBox1.Size = new System.Drawing.Size(243, 215);
            this.cyberGroupBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberGroupBox1.TabIndex = 10;
            this.cyberGroupBox1.Tag = "Cyber";
            this.cyberGroupBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberGroupBox1.Timer_RGB = 300;
            // 
            // lbl_role
            // 
            this.lbl_role.BackColor = System.Drawing.Color.Transparent;
            this.lbl_role.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_role.ForeColor = System.Drawing.Color.White;
            this.lbl_role.Location = new System.Drawing.Point(19, 174);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(205, 25);
            this.lbl_role.TabIndex = 11;
            this.lbl_role.Text = "Role";
            this.lbl_role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_userName
            // 
            this.lbl_userName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_userName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.ForeColor = System.Drawing.Color.White;
            this.lbl_userName.Location = new System.Drawing.Point(9, 146);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(231, 28);
            this.lbl_userName.TabIndex = 10;
            this.lbl_userName.Text = "Username";
            this.lbl_userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cyberGroupBox2
            // 
            this.cyberGroupBox2.Alpha = 20;
            this.cyberGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.cyberGroupBox2.Background = true;
            this.cyberGroupBox2.Background_WidthPen = 3F;
            this.cyberGroupBox2.BackgroundPen = true;
            this.cyberGroupBox2.ColorBackground = System.Drawing.Color.Transparent;
            this.cyberGroupBox2.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox2.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberGroupBox2.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberGroupBox2.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberGroupBox2.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberGroupBox2.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberGroupBox2.Controls.Add(this.pictureBox1);
            this.cyberGroupBox2.CyberGroupBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberGroupBox2.Lighting = false;
            this.cyberGroupBox2.LinearGradient_Background = false;
            this.cyberGroupBox2.LinearGradientPen = false;
            this.cyberGroupBox2.Location = new System.Drawing.Point(56, 13);
            this.cyberGroupBox2.Name = "cyberGroupBox2";
            this.cyberGroupBox2.PenWidth = 15;
            this.cyberGroupBox2.RGB = false;
            this.cyberGroupBox2.Rounding = true;
            this.cyberGroupBox2.RoundingInt = 90;
            this.cyberGroupBox2.Size = new System.Drawing.Size(133, 130);
            this.cyberGroupBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberGroupBox2.TabIndex = 3;
            this.cyberGroupBox2.Tag = "Cyber";
            this.cyberGroupBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberGroupBox2.Timer_RGB = 300;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MobileShopManagementSystem.Properties.Resources.Male_User;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventory.FlatAppearance.BorderSize = 0;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_inventory.ForeColor = System.Drawing.Color.White;
            this.btn_inventory.Image = global::MobileShopManagementSystem.Properties.Resources.iPhone_14;
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
            this.btn_customers.Text = "Customer";
            this.btn_customers.UseVisualStyleBackColor = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_user.FlatAppearance.BorderSize = 0;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_user.ForeColor = System.Drawing.Color.White;
            this.btn_user.Image = global::MobileShopManagementSystem.Properties.Resources.Male_User_1;
            this.btn_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user.Location = new System.Drawing.Point(3, 438);
            this.btn_user.Name = "btn_user";
            this.btn_user.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_user.Size = new System.Drawing.Size(249, 49);
            this.btn_user.TabIndex = 5;
            this.btn_user.Text = "User";
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_setting.ForeColor = System.Drawing.Color.White;
            this.btn_setting.Image = global::MobileShopManagementSystem.Properties.Resources.Settings;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(3, 493);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_setting.Size = new System.Drawing.Size(249, 49);
            this.btn_setting.TabIndex = 5;
            this.btn_setting.Text = "Setting";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(249, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1108, 749);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1357, 788);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.slidebar);
            this.Controls.Add(this.titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.titlepanel.ResumeLayout(false);
            this.shopContainer.ResumeLayout(false);
            this.slidebar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.cyberGroupBox1.ResumeLayout(false);
            this.cyberGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private ReaLTaiizor.Controls.ParrotSlidingPanel slidebar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox1;
        private ReaLTaiizor.Controls.DungeonLabel lbl_userName;
        private ReaLTaiizor.Controls.DungeonLabel lbl_role;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.CyberGroupBox cyberGroupBox2;
    }
}