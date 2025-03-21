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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.btnHam = new System.Windows.Forms.Button();
            this.slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.shopContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_shop = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_bill = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_categories = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_customers = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.shopTransition = new System.Windows.Forms.Timer(this.components);
            this.slidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.slidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.shopContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 39);
            this.panel1.TabIndex = 0;
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
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.Color.White;
            this.btnHam.FlatAppearance.BorderSize = 0;
            this.btnHam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHam.Image = global::MobileShopManagementSystem.Properties.Resources.Menu;
            this.btnHam.Location = new System.Drawing.Point(12, -1);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(42, 41);
            this.btnHam.TabIndex = 2;
            this.btnHam.UseVisualStyleBackColor = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // slidebar
            // 
            this.slidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.slidebar.Controls.Add(this.pictureBox2);
            this.slidebar.Controls.Add(this.panel2);
            this.slidebar.Controls.Add(this.shopContainer);
            this.slidebar.Controls.Add(this.panel4);
            this.slidebar.Controls.Add(this.panel6);
            this.slidebar.Controls.Add(this.panel5);
            this.slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.slidebar.Location = new System.Drawing.Point(0, 39);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(249, 749);
            this.slidebar.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 163);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_dashboard);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(3, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 49);
            this.panel2.TabIndex = 3;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Image = global::MobileShopManagementSystem.Properties.Resources.Statistics;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 0);
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
            this.shopContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(101)))));
            this.shopContainer.Controls.Add(this.panel3);
            this.shopContainer.Controls.Add(this.panel8);
            this.shopContainer.Controls.Add(this.panel9);
            this.shopContainer.Location = new System.Drawing.Point(0, 224);
            this.shopContainer.Margin = new System.Windows.Forms.Padding(0);
            this.shopContainer.Name = "shopContainer";
            this.shopContainer.Size = new System.Drawing.Size(249, 49);
            this.shopContainer.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_shop);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 49);
            this.panel3.TabIndex = 4;
            // 
            // btn_shop
            // 
            this.btn_shop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.btn_shop.FlatAppearance.BorderSize = 0;
            this.btn_shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_bill);
            this.panel8.ForeColor = System.Drawing.Color.Transparent;
            this.panel8.Location = new System.Drawing.Point(0, 49);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(249, 49);
            this.panel8.TabIndex = 5;
            // 
            // btn_bill
            // 
            this.btn_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(101)))));
            this.btn_bill.FlatAppearance.BorderSize = 0;
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill.ForeColor = System.Drawing.Color.White;
            this.btn_bill.Image = global::MobileShopManagementSystem.Properties.Resources.Buy_For_Coins;
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.Location = new System.Drawing.Point(0, 0);
            this.btn_bill.Margin = new System.Windows.Forms.Padding(0);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_bill.Size = new System.Drawing.Size(249, 49);
            this.btn_bill.TabIndex = 3;
            this.btn_bill.Text = "Bill";
            this.btn_bill.UseVisualStyleBackColor = false;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_categories);
            this.panel9.ForeColor = System.Drawing.Color.Transparent;
            this.panel9.Location = new System.Drawing.Point(0, 98);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(249, 49);
            this.panel9.TabIndex = 7;
            // 
            // btn_categories
            // 
            this.btn_categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(101)))));
            this.btn_categories.FlatAppearance.BorderSize = 0;
            this.btn_categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories.ForeColor = System.Drawing.Color.White;
            this.btn_categories.Image = global::MobileShopManagementSystem.Properties.Resources.iPhone_14;
            this.btn_categories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categories.Location = new System.Drawing.Point(0, 0);
            this.btn_categories.Margin = new System.Windows.Forms.Padding(0);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_categories.Size = new System.Drawing.Size(249, 49);
            this.btn_categories.TabIndex = 2;
            this.btn_categories.Text = "Categories";
            this.btn_categories.UseVisualStyleBackColor = false;
            this.btn_categories.Click += new System.EventHandler(this.btn_categories_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_inventory);
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(3, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 49);
            this.panel4.TabIndex = 5;
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.btn_inventory.FlatAppearance.BorderSize = 0;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.ForeColor = System.Drawing.Color.White;
            this.btn_inventory.Image = global::MobileShopManagementSystem.Properties.Resources.Warehouse;
            this.btn_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventory.Location = new System.Drawing.Point(0, 0);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_inventory.Size = new System.Drawing.Size(249, 49);
            this.btn_inventory.TabIndex = 2;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = false;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_customers);
            this.panel6.ForeColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(3, 331);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 49);
            this.panel6.TabIndex = 7;
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.btn_customers.FlatAppearance.BorderSize = 0;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.White;
            this.btn_customers.Image = global::MobileShopManagementSystem.Properties.Resources.Staff;
            this.btn_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.Location = new System.Drawing.Point(0, 0);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_customers.Size = new System.Drawing.Size(249, 49);
            this.btn_customers.TabIndex = 2;
            this.btn_customers.Text = "Customers";
            this.btn_customers.UseVisualStyleBackColor = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_logout);
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(3, 386);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 49);
            this.panel5.TabIndex = 9;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::MobileShopManagementSystem.Properties.Resources.Logout;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 0);
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
            // slidebarTransition
            // 
            this.slidebarTransition.Enabled = true;
            this.slidebarTransition.Interval = 10;
            this.slidebarTransition.Tick += new System.EventHandler(this.slidebarTransition_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1357, 788);
            this.ControlBox = false;
            this.Controls.Add(this.slidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.slidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.shopContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel slidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_shop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.FlowLayoutPanel shopContainer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_categories;
        private System.Windows.Forms.Timer shopTransition;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Timer slidebarTransition;
        private System.Windows.Forms.Button btnHam;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Button btn_bill;
    }
}