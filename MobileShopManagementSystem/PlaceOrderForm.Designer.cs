namespace MobileShopManagementSystem
{
    partial class PlaceOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titlepanel = new System.Windows.Forms.Panel();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.dgv_cart = new System.Windows.Forms.DataGridView();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.artanPanel4 = new ArtanComponent.ArtanPanel();
            this.btn_load = new ReaLTaiizor.Controls.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new ReaLTaiizor.Controls.Button();
            this.btn_placeOrder = new ReaLTaiizor.Controls.Button();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.txt_phoneNumber = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_address = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_customerName = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_customerID = new ReaLTaiizor.Controls.CyberTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_search = new ReaLTaiizor.Controls.CyberTextBox();
            this.artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).BeginInit();
            this.artanPanel2.SuspendLayout();
            this.artanPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlepanel
            // 
            this.titlepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlepanel.Location = new System.Drawing.Point(0, 0);
            this.titlepanel.Name = "titlepanel";
            this.titlepanel.Size = new System.Drawing.Size(1059, 39);
            this.titlepanel.TabIndex = 1;
            this.titlepanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.titlepanel_MouseDoubleClick);
            this.titlepanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlepanel_MouseDown);
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 50;
            this.artanPanel1.Controls.Add(this.dgv_cart);
            this.artanPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel1.Location = new System.Drawing.Point(15, 15);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(1004, 254);
            this.artanPanel1.TabIndex = 11;
            // 
            // dgv_cart
            // 
            this.dgv_cart.AllowUserToAddRows = false;
            this.dgv_cart.AllowUserToDeleteRows = false;
            this.dgv_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cart.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productname,
            this.quantity,
            this.price});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cart.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cart.EnableHeadersVisualStyles = false;
            this.dgv_cart.GridColor = System.Drawing.Color.Silver;
            this.dgv_cart.Location = new System.Drawing.Point(0, 0);
            this.dgv_cart.Name = "dgv_cart";
            this.dgv_cart.ReadOnly = true;
            this.dgv_cart.RowHeadersVisible = false;
            this.dgv_cart.RowHeadersWidth = 51;
            this.dgv_cart.RowTemplate.Height = 24;
            this.dgv_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cart.Size = new System.Drawing.Size(1004, 254);
            this.dgv_cart.TabIndex = 27;
            // 
            // productname
            // 
            this.productname.HeaderText = "Product Name";
            this.productname.MinimumWidth = 6;
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "QTY";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 50;
            this.artanPanel2.Controls.Add(this.artanPanel1);
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel2.Location = new System.Drawing.Point(13, 68);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Padding = new System.Windows.Forms.Padding(15);
            this.artanPanel2.Size = new System.Drawing.Size(1034, 284);
            this.artanPanel2.TabIndex = 12;
            // 
            // artanPanel4
            // 
            this.artanPanel4.BackColor = System.Drawing.Color.White;
            this.artanPanel4.BorderRadius = 0;
            this.artanPanel4.Controls.Add(this.btn_load);
            this.artanPanel4.Controls.Add(this.txt_search);
            this.artanPanel4.Controls.Add(this.label4);
            this.artanPanel4.Controls.Add(this.btn_cancel);
            this.artanPanel4.Controls.Add(this.btn_placeOrder);
            this.artanPanel4.Controls.Add(this.bigLabel1);
            this.artanPanel4.Controls.Add(this.artanPanel2);
            this.artanPanel4.Controls.Add(this.txt_phoneNumber);
            this.artanPanel4.Controls.Add(this.txt_address);
            this.artanPanel4.Controls.Add(this.txt_customerName);
            this.artanPanel4.Controls.Add(this.txt_customerID);
            this.artanPanel4.Controls.Add(this.label3);
            this.artanPanel4.Controls.Add(this.label1);
            this.artanPanel4.Controls.Add(this.label2);
            this.artanPanel4.Controls.Add(this.label5);
            this.artanPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel4.ForeColor = System.Drawing.Color.Black;
            this.artanPanel4.GradientAngle = 45F;
            this.artanPanel4.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel4.Location = new System.Drawing.Point(0, 39);
            this.artanPanel4.Name = "artanPanel4";
            this.artanPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel4.Size = new System.Drawing.Size(1059, 655);
            this.artanPanel4.TabIndex = 15;
            // 
            // btn_load
            // 
            this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_load.BackColor = System.Drawing.Color.Transparent;
            this.btn_load.BorderColor = System.Drawing.Color.Transparent;
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_load.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_load.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Image = null;
            this.btn_load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_load.Location = new System.Drawing.Point(748, 378);
            this.btn_load.Name = "btn_load";
            this.btn_load.PressedBorderColor = System.Drawing.Color.White;
            this.btn_load.PressedColor = System.Drawing.Color.White;
            this.btn_load.Size = new System.Drawing.Size(130, 24);
            this.btn_load.TabIndex = 29;
            this.btn_load.Text = "Load";
            this.btn_load.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(165, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Search customer :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AllowDrop = true;
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BorderColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_cancel.Image = null;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancel.Location = new System.Drawing.Point(547, 575);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.PressedBorderColor = System.Drawing.Color.White;
            this.btn_cancel.PressedColor = System.Drawing.Color.White;
            this.btn_cancel.Size = new System.Drawing.Size(163, 46);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.AllowDrop = true;
            this.btn_placeOrder.BackColor = System.Drawing.Color.Transparent;
            this.btn_placeOrder.BorderColor = System.Drawing.Color.Transparent;
            this.btn_placeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_placeOrder.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_placeOrder.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_placeOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_placeOrder.Image = null;
            this.btn_placeOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_placeOrder.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_placeOrder.Location = new System.Drawing.Point(331, 575);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.PressedBorderColor = System.Drawing.Color.White;
            this.btn_placeOrder.PressedColor = System.Drawing.Color.White;
            this.btn_placeOrder.Size = new System.Drawing.Size(179, 46);
            this.btn_placeOrder.TabIndex = 25;
            this.btn_placeOrder.Text = "Accept";
            this.btn_placeOrder.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(21, 10);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(128, 52);
            this.bigLabel1.TabIndex = 24;
            this.bigLabel1.Text = "Cart";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Alpha = 20;
            this.txt_phoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.txt_phoneNumber.Background_WidthPen = 5F;
            this.txt_phoneNumber.BackgroundPen = true;
            this.txt_phoneNumber.ColorBackground = System.Drawing.Color.White;
            this.txt_phoneNumber.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_phoneNumber.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_phoneNumber.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_phoneNumber.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_phoneNumber.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_phoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_phoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txt_phoneNumber.Lighting = false;
            this.txt_phoneNumber.LinearGradientPen = true;
            this.txt_phoneNumber.Location = new System.Drawing.Point(641, 441);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.PenWidth = 15;
            this.txt_phoneNumber.RGB = false;
            this.txt_phoneNumber.Rounding = true;
            this.txt_phoneNumber.RoundingInt = 30;
            this.txt_phoneNumber.Size = new System.Drawing.Size(406, 42);
            this.txt_phoneNumber.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_phoneNumber.TabIndex = 22;
            this.txt_phoneNumber.Tag = "Cyber";
            this.txt_phoneNumber.TextButton = "";
            this.txt_phoneNumber.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_phoneNumber.Timer_RGB = 300;
            // 
            // txt_address
            // 
            this.txt_address.Alpha = 20;
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address.BackColor = System.Drawing.Color.Transparent;
            this.txt_address.Background_WidthPen = 5F;
            this.txt_address.BackgroundPen = true;
            this.txt_address.ColorBackground = System.Drawing.Color.White;
            this.txt_address.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_address.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_address.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_address.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_address.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Lighting = false;
            this.txt_address.LinearGradientPen = true;
            this.txt_address.Location = new System.Drawing.Point(641, 496);
            this.txt_address.Name = "txt_address";
            this.txt_address.PenWidth = 15;
            this.txt_address.RGB = false;
            this.txt_address.Rounding = true;
            this.txt_address.RoundingInt = 30;
            this.txt_address.Size = new System.Drawing.Size(406, 42);
            this.txt_address.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_address.TabIndex = 23;
            this.txt_address.Tag = "Cyber";
            this.txt_address.TextButton = "";
            this.txt_address.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_address.Timer_RGB = 300;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Alpha = 20;
            this.txt_customerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerName.BackColor = System.Drawing.Color.Transparent;
            this.txt_customerName.Background_WidthPen = 5F;
            this.txt_customerName.BackgroundPen = true;
            this.txt_customerName.ColorBackground = System.Drawing.Color.White;
            this.txt_customerName.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_customerName.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerName.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerName.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_customerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_customerName.ForeColor = System.Drawing.Color.Black;
            this.txt_customerName.Lighting = false;
            this.txt_customerName.LinearGradientPen = true;
            this.txt_customerName.Location = new System.Drawing.Point(180, 496);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.PenWidth = 15;
            this.txt_customerName.RGB = false;
            this.txt_customerName.Rounding = true;
            this.txt_customerName.RoundingInt = 30;
            this.txt_customerName.Size = new System.Drawing.Size(273, 42);
            this.txt_customerName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_customerName.TabIndex = 21;
            this.txt_customerName.Tag = "Cyber";
            this.txt_customerName.TextButton = "";
            this.txt_customerName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_customerName.Timer_RGB = 300;
            // 
            // txt_customerID
            // 
            this.txt_customerID.Alpha = 20;
            this.txt_customerID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerID.BackColor = System.Drawing.Color.Transparent;
            this.txt_customerID.Background_WidthPen = 5F;
            this.txt_customerID.BackgroundPen = true;
            this.txt_customerID.ColorBackground = System.Drawing.Color.White;
            this.txt_customerID.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_customerID.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerID.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerID.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerID.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_customerID.Enabled = false;
            this.txt_customerID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_customerID.ForeColor = System.Drawing.Color.Black;
            this.txt_customerID.Lighting = false;
            this.txt_customerID.LinearGradientPen = true;
            this.txt_customerID.Location = new System.Drawing.Point(180, 441);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.PenWidth = 15;
            this.txt_customerID.RGB = false;
            this.txt_customerID.Rounding = true;
            this.txt_customerID.RoundingInt = 30;
            this.txt_customerID.Size = new System.Drawing.Size(273, 42);
            this.txt_customerID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_customerID.TabIndex = 20;
            this.txt_customerID.Tag = "Cyber";
            this.txt_customerID.TextButton = "";
            this.txt_customerID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_customerID.Timer_RGB = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(480, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Phone Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Customer name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Customer ID :";
            // 
            // txt_search
            // 
            this.txt_search.Alpha = 20;
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BackColor = System.Drawing.Color.Transparent;
            this.txt_search.Background_WidthPen = 5F;
            this.txt_search.BackgroundPen = true;
            this.txt_search.ColorBackground = System.Drawing.Color.White;
            this.txt_search.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_search.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_search.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_search.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_search.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.Lighting = false;
            this.txt_search.LinearGradientPen = true;
            this.txt_search.Location = new System.Drawing.Point(336, 367);
            this.txt_search.Name = "txt_search";
            this.txt_search.PenWidth = 15;
            this.txt_search.RGB = false;
            this.txt_search.Rounding = true;
            this.txt_search.RoundingInt = 30;
            this.txt_search.Size = new System.Drawing.Size(406, 42);
            this.txt_search.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_search.TabIndex = 28;
            this.txt_search.Tag = "Cyber";
            this.txt_search.TextButton = "Phone Number";
            this.txt_search.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_search.Timer_RGB = 300;
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // PlaceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 694);
            this.ControlBox = false;
            this.Controls.Add(this.artanPanel4);
            this.Controls.Add(this.titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlaceOrderForm";
            this.Text = "PlaceOrderForm";
            this.Load += new System.EventHandler(this.PlaceOrderForm_Load);
            this.artanPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).EndInit();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel4.ResumeLayout(false);
            this.artanPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titlepanel;
        private ArtanComponent.ArtanPanel artanPanel1;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ArtanComponent.ArtanPanel artanPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private ReaLTaiizor.Controls.CyberTextBox txt_phoneNumber;
        private ReaLTaiizor.Controls.CyberTextBox txt_address;
        private ReaLTaiizor.Controls.CyberTextBox txt_customerName;
        private ReaLTaiizor.Controls.CyberTextBox txt_customerID;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.Button btn_cancel;
        private ReaLTaiizor.Controls.Button btn_placeOrder;
        private System.Windows.Forms.DataGridView dgv_cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.Button btn_load;
        private ReaLTaiizor.Controls.CyberTextBox txt_search;
    }
}