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
            this.btnHam = new System.Windows.Forms.Button();
            this.slidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.shopContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_shop = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.shopTransition = new System.Windows.Forms.Timer(this.components);
            this.slidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
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
            this.slidebar.Location = new System.Drawing.Point(0, 39);
            this.slidebar.Name = "slidebar";
            this.slidebar.Size = new System.Drawing.Size(62, 749);
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(3, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 49);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::MobileShopManagementSystem.Properties.Resources.Statistics;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(249, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
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
            this.panel8.Controls.Add(this.button7);
            this.panel8.ForeColor = System.Drawing.Color.Transparent;
            this.panel8.Location = new System.Drawing.Point(0, 49);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(249, 49);
            this.panel8.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(101)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::MobileShopManagementSystem.Properties.Resources.Buy_For_Coins;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(249, 49);
            this.button7.TabIndex = 2;
            this.button7.Text = "Bill";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button8);
            this.panel9.ForeColor = System.Drawing.Color.Transparent;
            this.panel9.Location = new System.Drawing.Point(0, 98);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(249, 49);
            this.panel9.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(35)))), ((int)(((byte)(101)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::MobileShopManagementSystem.Properties.Resources.iPhone_14;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(249, 49);
            this.button8.TabIndex = 2;
            this.button8.Text = "Categories";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(3, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 49);
            this.panel4.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::MobileShopManagementSystem.Properties.Resources.Warehouse;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(249, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Inventory";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button5);
            this.panel6.ForeColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(3, 331);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 49);
            this.panel6.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::MobileShopManagementSystem.Properties.Resources.Staff;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(249, 49);
            this.button5.TabIndex = 2;
            this.button5.Text = "Customers";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(3, 386);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 49);
            this.panel5.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::MobileShopManagementSystem.Properties.Resources.Logout;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(249, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1357, 788);
            this.Controls.Add(this.slidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_shop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FlowLayoutPanel shopContainer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer shopTransition;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer slidebarTransition;
        private System.Windows.Forms.Button btnHam;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}