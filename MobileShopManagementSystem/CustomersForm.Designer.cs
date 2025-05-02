namespace MobileShopManagementSystem
{
    partial class CustomersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_customerClear = new ReaLTaiizor.Controls.Button();
            this.btn_customerUpdate = new ReaLTaiizor.Controls.Button();
            this.btn_customerDelete = new ReaLTaiizor.Controls.Button();
            this.txt_customerPN = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_customerAddress = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_customerName = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_customerID = new ReaLTaiizor.Controls.CyberTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.txt_search = new ReaLTaiizor.Controls.CyberTextBox();
            this.cb_search = new ReaLTaiizor.Controls.MetroComboBox();
            this.artanPanel3 = new ArtanComponent.ArtanPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_refresh = new ReaLTaiizor.Controls.Button();
            this.btn_search = new ReaLTaiizor.Controls.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.artanPanel1.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            this.artanPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_customer
            // 
            this.dgv_customer.AllowUserToAddRows = false;
            this.dgv_customer.AllowUserToDeleteRows = false;
            this.dgv_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_customer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.phonenumber});
            this.dgv_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_customer.EnableHeadersVisualStyles = false;
            this.dgv_customer.Location = new System.Drawing.Point(0, 0);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.ReadOnly = true;
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.RowTemplate.Height = 24;
            this.dgv_customer.Size = new System.Drawing.Size(1243, 348);
            this.dgv_customer.TabIndex = 22;
            this.dgv_customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customer_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "CustomerID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "CustomerName";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phonenumber
            // 
            this.phonenumber.DataPropertyName = "PhoneNumber";
            this.phonenumber.HeaderText = "Phone Number";
            this.phonenumber.MinimumWidth = 6;
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            // 
            // artanPanel1
            // 
            this.artanPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.label4);
            this.artanPanel1.Controls.Add(this.label5);
            this.artanPanel1.Controls.Add(this.label10);
            this.artanPanel1.Controls.Add(this.btn_customerClear);
            this.artanPanel1.Controls.Add(this.btn_customerUpdate);
            this.artanPanel1.Controls.Add(this.btn_customerDelete);
            this.artanPanel1.Controls.Add(this.txt_customerPN);
            this.artanPanel1.Controls.Add(this.txt_customerAddress);
            this.artanPanel1.Controls.Add(this.txt_customerName);
            this.artanPanel1.Controls.Add(this.txt_customerID);
            this.artanPanel1.Controls.Add(this.bigLabel1);
            this.artanPanel1.Controls.Add(this.label11);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel1.Location = new System.Drawing.Point(13, 13);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel1.Size = new System.Drawing.Size(1269, 221);
            this.artanPanel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(542, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(94, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "Customer Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(95, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 28);
            this.label10.TabIndex = 42;
            this.label10.Text = "Customer ID :";
            // 
            // btn_customerClear
            // 
            this.btn_customerClear.AllowDrop = true;
            this.btn_customerClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_customerClear.BackColor = System.Drawing.Color.Transparent;
            this.btn_customerClear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_customerClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customerClear.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_customerClear.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_customerClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_customerClear.Image = null;
            this.btn_customerClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerClear.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_customerClear.Location = new System.Drawing.Point(1134, 163);
            this.btn_customerClear.Name = "btn_customerClear";
            this.btn_customerClear.PressedBorderColor = System.Drawing.Color.White;
            this.btn_customerClear.PressedColor = System.Drawing.Color.White;
            this.btn_customerClear.Size = new System.Drawing.Size(122, 34);
            this.btn_customerClear.TabIndex = 40;
            this.btn_customerClear.Text = "Clear";
            this.btn_customerClear.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_customerClear.Click += new System.EventHandler(this.btn_customerClear_Click);
            // 
            // btn_customerUpdate
            // 
            this.btn_customerUpdate.AllowDrop = true;
            this.btn_customerUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_customerUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_customerUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btn_customerUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customerUpdate.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_customerUpdate.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_customerUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_customerUpdate.Image = null;
            this.btn_customerUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerUpdate.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_customerUpdate.Location = new System.Drawing.Point(1134, 123);
            this.btn_customerUpdate.Name = "btn_customerUpdate";
            this.btn_customerUpdate.PressedBorderColor = System.Drawing.Color.White;
            this.btn_customerUpdate.PressedColor = System.Drawing.Color.White;
            this.btn_customerUpdate.Size = new System.Drawing.Size(122, 34);
            this.btn_customerUpdate.TabIndex = 39;
            this.btn_customerUpdate.Text = "Update";
            this.btn_customerUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_customerUpdate.Click += new System.EventHandler(this.btn_customerUpdate_Click);
            // 
            // btn_customerDelete
            // 
            this.btn_customerDelete.AllowDrop = true;
            this.btn_customerDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_customerDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_customerDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_customerDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customerDelete.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_customerDelete.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_customerDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_customerDelete.Image = null;
            this.btn_customerDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerDelete.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_customerDelete.Location = new System.Drawing.Point(1134, 83);
            this.btn_customerDelete.Name = "btn_customerDelete";
            this.btn_customerDelete.PressedBorderColor = System.Drawing.Color.White;
            this.btn_customerDelete.PressedColor = System.Drawing.Color.White;
            this.btn_customerDelete.Size = new System.Drawing.Size(122, 34);
            this.btn_customerDelete.TabIndex = 38;
            this.btn_customerDelete.Text = "Delete";
            this.btn_customerDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_customerDelete.Click += new System.EventHandler(this.btn_customerDelete_Click);
            // 
            // txt_customerPN
            // 
            this.txt_customerPN.Alpha = 20;
            this.txt_customerPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerPN.BackColor = System.Drawing.Color.Transparent;
            this.txt_customerPN.Background_WidthPen = 5F;
            this.txt_customerPN.BackgroundPen = true;
            this.txt_customerPN.ColorBackground = System.Drawing.Color.White;
            this.txt_customerPN.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_customerPN.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerPN.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerPN.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerPN.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_customerPN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_customerPN.ForeColor = System.Drawing.Color.Black;
            this.txt_customerPN.Lighting = false;
            this.txt_customerPN.LinearGradientPen = true;
            this.txt_customerPN.Location = new System.Drawing.Point(701, 147);
            this.txt_customerPN.Name = "txt_customerPN";
            this.txt_customerPN.PenWidth = 15;
            this.txt_customerPN.RGB = false;
            this.txt_customerPN.Rounding = true;
            this.txt_customerPN.RoundingInt = 30;
            this.txt_customerPN.Size = new System.Drawing.Size(345, 42);
            this.txt_customerPN.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_customerPN.TabIndex = 36;
            this.txt_customerPN.Tag = "Cyber";
            this.txt_customerPN.TextButton = "";
            this.txt_customerPN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_customerPN.Timer_RGB = 300;
            // 
            // txt_customerAddress
            // 
            this.txt_customerAddress.Alpha = 20;
            this.txt_customerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerAddress.BackColor = System.Drawing.Color.Transparent;
            this.txt_customerAddress.Background_WidthPen = 5F;
            this.txt_customerAddress.BackgroundPen = true;
            this.txt_customerAddress.ColorBackground = System.Drawing.Color.White;
            this.txt_customerAddress.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_customerAddress.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerAddress.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerAddress.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerAddress.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_customerAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_customerAddress.ForeColor = System.Drawing.Color.Black;
            this.txt_customerAddress.Lighting = false;
            this.txt_customerAddress.LinearGradientPen = true;
            this.txt_customerAddress.Location = new System.Drawing.Point(701, 83);
            this.txt_customerAddress.Name = "txt_customerAddress";
            this.txt_customerAddress.PenWidth = 15;
            this.txt_customerAddress.RGB = false;
            this.txt_customerAddress.Rounding = true;
            this.txt_customerAddress.RoundingInt = 30;
            this.txt_customerAddress.Size = new System.Drawing.Size(345, 42);
            this.txt_customerAddress.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_customerAddress.TabIndex = 35;
            this.txt_customerAddress.Tag = "Cyber";
            this.txt_customerAddress.TextButton = "";
            this.txt_customerAddress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_customerAddress.Timer_RGB = 300;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Alpha = 20;
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
            this.txt_customerName.Location = new System.Drawing.Point(262, 147);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.PenWidth = 15;
            this.txt_customerName.RGB = false;
            this.txt_customerName.Rounding = true;
            this.txt_customerName.RoundingInt = 30;
            this.txt_customerName.Size = new System.Drawing.Size(274, 42);
            this.txt_customerName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_customerName.TabIndex = 34;
            this.txt_customerName.Tag = "Cyber";
            this.txt_customerName.TextButton = "";
            this.txt_customerName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_customerName.Timer_RGB = 300;
            // 
            // txt_customerID
            // 
            this.txt_customerID.Alpha = 20;
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
            this.txt_customerID.Location = new System.Drawing.Point(262, 83);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.PenWidth = 15;
            this.txt_customerID.RGB = false;
            this.txt_customerID.Rounding = true;
            this.txt_customerID.RoundingInt = 30;
            this.txt_customerID.Size = new System.Drawing.Size(274, 42);
            this.txt_customerID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_customerID.TabIndex = 33;
            this.txt_customerID.Tag = "Cyber";
            this.txt_customerID.TextButton = "";
            this.txt_customerID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_customerID.Timer_RGB = 300;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(14, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(238, 52);
            this.bigLabel1.TabIndex = 26;
            this.bigLabel1.Text = "CUSTOMER";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(542, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 28);
            this.label11.TabIndex = 8;
            this.label11.Text = "Phone Number :";
            // 
            // artanPanel2
            // 
            this.artanPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 30;
            this.artanPanel2.Controls.Add(this.txt_search);
            this.artanPanel2.Controls.Add(this.cb_search);
            this.artanPanel2.Controls.Add(this.artanPanel3);
            this.artanPanel2.Controls.Add(this.label13);
            this.artanPanel2.Controls.Add(this.btn_refresh);
            this.artanPanel2.Controls.Add(this.btn_search);
            this.artanPanel2.Controls.Add(this.label14);
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel2.Location = new System.Drawing.Point(13, 276);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel2.Size = new System.Drawing.Size(1269, 460);
            this.artanPanel2.TabIndex = 6;
            // 
            // txt_search
            // 
            this.txt_search.Alpha = 20;
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.txt_search.Location = new System.Drawing.Point(561, 404);
            this.txt_search.Name = "txt_search";
            this.txt_search.PenWidth = 15;
            this.txt_search.RGB = false;
            this.txt_search.Rounding = true;
            this.txt_search.RoundingInt = 30;
            this.txt_search.Size = new System.Drawing.Size(260, 42);
            this.txt_search.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_search.TabIndex = 46;
            this.txt_search.Tag = "Cyber";
            this.txt_search.TextButton = "";
            this.txt_search.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_search.Timer_RGB = 300;
            // 
            // cb_search
            // 
            this.cb_search.AllowDrop = true;
            this.cb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_search.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_search.BackColor = System.Drawing.Color.Transparent;
            this.cb_search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cb_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_search.CausesValidation = false;
            this.cb_search.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_search.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_search.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_search.FormattingEnabled = true;
            this.cb_search.IsDerivedStyle = true;
            this.cb_search.ItemHeight = 20;
            this.cb_search.Items.AddRange(new object[] {
            "Customer ID",
            "Customer Name",
            "Phone Number"});
            this.cb_search.Location = new System.Drawing.Point(187, 409);
            this.cb_search.Name = "cb_search";
            this.cb_search.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_search.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_search.Size = new System.Drawing.Size(295, 26);
            this.cb_search.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_search.StyleManager = null;
            this.cb_search.TabIndex = 46;
            this.cb_search.ThemeAuthor = "Taiizor";
            this.cb_search.ThemeName = "MetroLight";
            // 
            // artanPanel3
            // 
            this.artanPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel3.BackColor = System.Drawing.Color.White;
            this.artanPanel3.BorderRadius = 50;
            this.artanPanel3.Controls.Add(this.dgv_customer);
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel3.Location = new System.Drawing.Point(13, 41);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(1243, 348);
            this.artanPanel3.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(22, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 28);
            this.label13.TabIndex = 46;
            this.label13.Text = "All customers :";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BorderColor = System.Drawing.Color.Teal;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_refresh.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_refresh.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = null;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_refresh.Location = new System.Drawing.Point(963, 410);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.PressedBorderColor = System.Drawing.Color.White;
            this.btn_refresh.PressedColor = System.Drawing.Color.White;
            this.btn_refresh.Size = new System.Drawing.Size(130, 24);
            this.btn_refresh.TabIndex = 29;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderColor = System.Drawing.Color.Transparent;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_search.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_search.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = null;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_search.Location = new System.Drawing.Point(827, 410);
            this.btn_search.Name = "btn_search";
            this.btn_search.PressedBorderColor = System.Drawing.Color.White;
            this.btn_search.PressedColor = System.Drawing.Color.White;
            this.btn_search.Size = new System.Drawing.Size(130, 24);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(488, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 28);
            this.label14.TabIndex = 27;
            this.label14.Text = "Input :";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.ControlBox = false;
            this.Controls.Add(this.artanPanel1);
            this.Controls.Add(this.artanPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            this.artanPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private ArtanComponent.ArtanPanel artanPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private ReaLTaiizor.Controls.Button btn_customerClear;
        private ReaLTaiizor.Controls.Button btn_customerUpdate;
        private ReaLTaiizor.Controls.Button btn_customerDelete;
        private ReaLTaiizor.Controls.CyberTextBox txt_customerPN;
        private ReaLTaiizor.Controls.CyberTextBox txt_customerAddress;
        private ReaLTaiizor.Controls.CyberTextBox txt_customerName;
        private ReaLTaiizor.Controls.CyberTextBox txt_customerID;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Label label11;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ReaLTaiizor.Controls.CyberTextBox txt_search;
        private ReaLTaiizor.Controls.MetroComboBox cb_search;
        private ArtanComponent.ArtanPanel artanPanel3;
        private System.Windows.Forms.Label label13;
        private ReaLTaiizor.Controls.Button btn_refresh;
        private ReaLTaiizor.Controls.Button btn_search;
        private System.Windows.Forms.Label label14;
    }
}