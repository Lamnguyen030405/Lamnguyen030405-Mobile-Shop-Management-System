namespace MobileShopManagementSystem
{
    partial class BillForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_bill = new System.Windows.Forms.DataGridView();
            this.billid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downpaymentamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outstandingamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latefee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymenthistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_billID = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_userName = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_userID = new ReaLTaiizor.Controls.CyberTextBox();
            this.dt_dateOrder = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_customerPN = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_customerAddr = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_customerName = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_customerID = new ReaLTaiizor.Controls.CyberTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_orderID = new ReaLTaiizor.Controls.CyberTextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.artanPanel7 = new ArtanComponent.ArtanPanel();
            this.dgv_cart = new System.Windows.Forms.DataGridView();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_update = new ReaLTaiizor.Controls.Button();
            this.btn_emport = new ReaLTaiizor.Controls.Button();
            this.btn_delete = new ReaLTaiizor.Controls.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.artanPanel4 = new ArtanComponent.ArtanPanel();
            this.btn_pay = new ReaLTaiizor.Controls.Button();
            this.txt_paymentAmount = new MobileShopManagementSystem.ExtendedDungeonTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_lateFee = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_outstandingAmount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.artanPanel3 = new ArtanComponent.ArtanPanel();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.artanPanel5 = new ArtanComponent.ArtanPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_paymentHistory = new MobileShopManagementSystem.ExtendedDungeonTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_filter = new ReaLTaiizor.Controls.MetroComboBox();
            this.txt_search = new ReaLTaiizor.Controls.CyberTextBox();
            this.cb_search = new ReaLTaiizor.Controls.MetroComboBox();
            this.artanPanel6 = new ArtanComponent.ArtanPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_refresh = new ReaLTaiizor.Controls.Button();
            this.btn_search = new ReaLTaiizor.Controls.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.artanPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.artanPanel4.SuspendLayout();
            this.artanPanel3.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            this.artanPanel1.SuspendLayout();
            this.artanPanel5.SuspendLayout();
            this.artanPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_bill
            // 
            this.dgv_bill.AllowUserToAddRows = false;
            this.dgv_bill.AllowUserToDeleteRows = false;
            this.dgv_bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_bill.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_bill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billid,
            this.userid,
            this.username,
            this.customerid,
            this.customername,
            this.orderid,
            this.totalquantity,
            this.totalprice,
            this.downpaymentamount,
            this.remainingamount,
            this.selectedterm,
            this.interestrate,
            this.penaltyrate,
            this.outstandingamount,
            this.latefee,
            this.paymenthistory,
            this.duedate,
            this.dateorder,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bill.EnableHeadersVisualStyles = false;
            this.dgv_bill.Location = new System.Drawing.Point(0, 0);
            this.dgv_bill.Name = "dgv_bill";
            this.dgv_bill.ReadOnly = true;
            this.dgv_bill.RowHeadersVisible = false;
            this.dgv_bill.RowHeadersWidth = 51;
            this.dgv_bill.RowTemplate.Height = 24;
            this.dgv_bill.Size = new System.Drawing.Size(938, 291);
            this.dgv_bill.TabIndex = 21;
            this.dgv_bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bill_CellClick);
            // 
            // billid
            // 
            this.billid.DataPropertyName = "BillID";
            this.billid.HeaderText = "Bill ID";
            this.billid.MinimumWidth = 6;
            this.billid.Name = "billid";
            this.billid.ReadOnly = true;
            this.billid.Width = 64;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "UserID";
            this.userid.HeaderText = "User ID";
            this.userid.MinimumWidth = 6;
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Visible = false;
            this.userid.Width = 96;
            // 
            // username
            // 
            this.username.DataPropertyName = "UserName";
            this.username.HeaderText = "Staff Name";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 119;
            // 
            // customerid
            // 
            this.customerid.DataPropertyName = "CustomerID";
            this.customerid.HeaderText = "Customer ID";
            this.customerid.MinimumWidth = 6;
            this.customerid.Name = "customerid";
            this.customerid.ReadOnly = true;
            this.customerid.Visible = false;
            this.customerid.Width = 138;
            // 
            // customername
            // 
            this.customername.DataPropertyName = "CustomerName";
            this.customername.HeaderText = "Customer Name";
            this.customername.MinimumWidth = 6;
            this.customername.Name = "customername";
            this.customername.ReadOnly = true;
            this.customername.Width = 153;
            // 
            // orderid
            // 
            this.orderid.DataPropertyName = "OrderID";
            this.orderid.HeaderText = "Order ID";
            this.orderid.MinimumWidth = 6;
            this.orderid.Name = "orderid";
            this.orderid.ReadOnly = true;
            this.orderid.Visible = false;
            this.orderid.Width = 125;
            // 
            // totalquantity
            // 
            this.totalquantity.DataPropertyName = "TotalQuantity";
            this.totalquantity.HeaderText = "Total Quantity";
            this.totalquantity.MinimumWidth = 6;
            this.totalquantity.Name = "totalquantity";
            this.totalquantity.ReadOnly = true;
            this.totalquantity.Width = 139;
            // 
            // totalprice
            // 
            this.totalprice.DataPropertyName = "TotalPrice";
            this.totalprice.HeaderText = "Total Price";
            this.totalprice.MinimumWidth = 6;
            this.totalprice.Name = "totalprice";
            this.totalprice.ReadOnly = true;
            this.totalprice.Width = 111;
            // 
            // downpaymentamount
            // 
            this.downpaymentamount.DataPropertyName = "DownPaymentAmount";
            this.downpaymentamount.HeaderText = "Down Payment Amount";
            this.downpaymentamount.MinimumWidth = 6;
            this.downpaymentamount.Name = "downpaymentamount";
            this.downpaymentamount.ReadOnly = true;
            this.downpaymentamount.Width = 209;
            // 
            // remainingamount
            // 
            this.remainingamount.DataPropertyName = "RemainingAmount";
            this.remainingamount.HeaderText = "Remaining Amount";
            this.remainingamount.MinimumWidth = 6;
            this.remainingamount.Name = "remainingamount";
            this.remainingamount.ReadOnly = true;
            this.remainingamount.Width = 177;
            // 
            // selectedterm
            // 
            this.selectedterm.DataPropertyName = "SelectedTerm";
            this.selectedterm.HeaderText = "Term";
            this.selectedterm.MinimumWidth = 6;
            this.selectedterm.Name = "selectedterm";
            this.selectedterm.ReadOnly = true;
            this.selectedterm.Width = 78;
            // 
            // interestrate
            // 
            this.interestrate.DataPropertyName = "InterestRate";
            this.interestrate.HeaderText = "Interest Rate";
            this.interestrate.MinimumWidth = 6;
            this.interestrate.Name = "interestrate";
            this.interestrate.ReadOnly = true;
            this.interestrate.Width = 128;
            // 
            // penaltyrate
            // 
            this.penaltyrate.DataPropertyName = "PenaltyRate";
            this.penaltyrate.HeaderText = "Penalty Rate";
            this.penaltyrate.MinimumWidth = 6;
            this.penaltyrate.Name = "penaltyrate";
            this.penaltyrate.ReadOnly = true;
            this.penaltyrate.Width = 126;
            // 
            // outstandingamount
            // 
            this.outstandingamount.DataPropertyName = "OutstandingAmount";
            this.outstandingamount.HeaderText = "Outstanding Amount";
            this.outstandingamount.MinimumWidth = 6;
            this.outstandingamount.Name = "outstandingamount";
            this.outstandingamount.ReadOnly = true;
            this.outstandingamount.Width = 190;
            // 
            // latefee
            // 
            this.latefee.DataPropertyName = "LateFee";
            this.latefee.HeaderText = "Late Fee";
            this.latefee.MinimumWidth = 6;
            this.latefee.Name = "latefee";
            this.latefee.ReadOnly = true;
            this.latefee.Width = 72;
            // 
            // paymenthistory
            // 
            this.paymenthistory.DataPropertyName = "PaymentHistory";
            this.paymenthistory.HeaderText = "Payment History";
            this.paymenthistory.MinimumWidth = 6;
            this.paymenthistory.Name = "paymenthistory";
            this.paymenthistory.ReadOnly = true;
            this.paymenthistory.Visible = false;
            this.paymenthistory.Width = 157;
            // 
            // duedate
            // 
            this.duedate.DataPropertyName = "DueDate";
            this.duedate.HeaderText = "Due Date";
            this.duedate.MinimumWidth = 6;
            this.duedate.Name = "duedate";
            this.duedate.ReadOnly = true;
            this.duedate.Width = 104;
            // 
            // dateorder
            // 
            this.dateorder.DataPropertyName = "DateOrder";
            this.dateorder.HeaderText = "Date Order";
            this.dateorder.MinimumWidth = 6;
            this.dateorder.Name = "dateorder";
            this.dateorder.ReadOnly = true;
            this.dateorder.Width = 118;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 88;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_billID);
            this.groupBox1.Controls.Add(this.txt_userName);
            this.groupBox1.Controls.Add(this.txt_userID);
            this.groupBox1.Controls.Add(this.dt_dateOrder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seller Information";
            // 
            // txt_billID
            // 
            this.txt_billID.Alpha = 20;
            this.txt_billID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_billID.BackColor = System.Drawing.Color.Transparent;
            this.txt_billID.Background_WidthPen = 5F;
            this.txt_billID.BackgroundPen = true;
            this.txt_billID.ColorBackground = System.Drawing.Color.White;
            this.txt_billID.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_billID.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_billID.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_billID.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_billID.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_billID.Enabled = false;
            this.txt_billID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_billID.ForeColor = System.Drawing.Color.Black;
            this.txt_billID.Lighting = false;
            this.txt_billID.LinearGradientPen = true;
            this.txt_billID.Location = new System.Drawing.Point(93, 129);
            this.txt_billID.Name = "txt_billID";
            this.txt_billID.PenWidth = 15;
            this.txt_billID.RGB = false;
            this.txt_billID.Rounding = true;
            this.txt_billID.RoundingInt = 30;
            this.txt_billID.Size = new System.Drawing.Size(226, 42);
            this.txt_billID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_billID.TabIndex = 36;
            this.txt_billID.Tag = "Cyber";
            this.txt_billID.TextButton = "";
            this.txt_billID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_billID.Timer_RGB = 300;
            // 
            // txt_userName
            // 
            this.txt_userName.Alpha = 20;
            this.txt_userName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userName.BackColor = System.Drawing.Color.Transparent;
            this.txt_userName.Background_WidthPen = 5F;
            this.txt_userName.BackgroundPen = true;
            this.txt_userName.ColorBackground = System.Drawing.Color.White;
            this.txt_userName.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_userName.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userName.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userName.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_userName.Enabled = false;
            this.txt_userName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_userName.ForeColor = System.Drawing.Color.Black;
            this.txt_userName.Lighting = false;
            this.txt_userName.LinearGradientPen = true;
            this.txt_userName.Location = new System.Drawing.Point(93, 81);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.PenWidth = 15;
            this.txt_userName.RGB = false;
            this.txt_userName.Rounding = true;
            this.txt_userName.RoundingInt = 30;
            this.txt_userName.Size = new System.Drawing.Size(226, 42);
            this.txt_userName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_userName.TabIndex = 35;
            this.txt_userName.Tag = "Cyber";
            this.txt_userName.TextButton = "";
            this.txt_userName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_userName.Timer_RGB = 300;
            // 
            // txt_userID
            // 
            this.txt_userID.Alpha = 20;
            this.txt_userID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userID.BackColor = System.Drawing.Color.Transparent;
            this.txt_userID.Background_WidthPen = 5F;
            this.txt_userID.BackgroundPen = true;
            this.txt_userID.ColorBackground = System.Drawing.Color.White;
            this.txt_userID.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_userID.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userID.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userID.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userID.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_userID.Enabled = false;
            this.txt_userID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_userID.ForeColor = System.Drawing.Color.Black;
            this.txt_userID.Lighting = false;
            this.txt_userID.LinearGradientPen = true;
            this.txt_userID.Location = new System.Drawing.Point(93, 33);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.PenWidth = 15;
            this.txt_userID.RGB = false;
            this.txt_userID.Rounding = true;
            this.txt_userID.RoundingInt = 30;
            this.txt_userID.Size = new System.Drawing.Size(226, 42);
            this.txt_userID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_userID.TabIndex = 34;
            this.txt_userID.Tag = "Cyber";
            this.txt_userID.TextButton = "";
            this.txt_userID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_userID.Timer_RGB = 300;
            // 
            // dt_dateOrder
            // 
            this.dt_dateOrder.CustomFormat = "yyyy-MM-dd";
            this.dt_dateOrder.Enabled = false;
            this.dt_dateOrder.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_dateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_dateOrder.Location = new System.Drawing.Point(93, 183);
            this.dt_dateOrder.Name = "dt_dateOrder";
            this.dt_dateOrder.Size = new System.Drawing.Size(126, 27);
            this.dt_dateOrder.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Order :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "BID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_customerPN);
            this.groupBox2.Controls.Add(this.txt_customerAddr);
            this.groupBox2.Controls.Add(this.txt_customerName);
            this.groupBox2.Controls.Add(this.txt_customerID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 275);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Information";
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
            this.txt_customerPN.Location = new System.Drawing.Point(124, 177);
            this.txt_customerPN.Name = "txt_customerPN";
            this.txt_customerPN.PenWidth = 15;
            this.txt_customerPN.RGB = false;
            this.txt_customerPN.Rounding = true;
            this.txt_customerPN.RoundingInt = 30;
            this.txt_customerPN.Size = new System.Drawing.Size(204, 42);
            this.txt_customerPN.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_customerPN.TabIndex = 39;
            this.txt_customerPN.Tag = "Cyber";
            this.txt_customerPN.TextButton = "";
            this.txt_customerPN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_customerPN.Timer_RGB = 300;
            // 
            // txt_customerAddr
            // 
            this.txt_customerAddr.Alpha = 20;
            this.txt_customerAddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerAddr.BackColor = System.Drawing.Color.Transparent;
            this.txt_customerAddr.Background_WidthPen = 5F;
            this.txt_customerAddr.BackgroundPen = true;
            this.txt_customerAddr.ColorBackground = System.Drawing.Color.White;
            this.txt_customerAddr.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_customerAddr.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerAddr.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerAddr.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_customerAddr.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_customerAddr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_customerAddr.ForeColor = System.Drawing.Color.Black;
            this.txt_customerAddr.Lighting = false;
            this.txt_customerAddr.LinearGradientPen = true;
            this.txt_customerAddr.Location = new System.Drawing.Point(124, 129);
            this.txt_customerAddr.Name = "txt_customerAddr";
            this.txt_customerAddr.PenWidth = 15;
            this.txt_customerAddr.RGB = false;
            this.txt_customerAddr.Rounding = true;
            this.txt_customerAddr.RoundingInt = 30;
            this.txt_customerAddr.Size = new System.Drawing.Size(204, 42);
            this.txt_customerAddr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_customerAddr.TabIndex = 38;
            this.txt_customerAddr.Tag = "Cyber";
            this.txt_customerAddr.TextButton = "";
            this.txt_customerAddr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_customerAddr.Timer_RGB = 300;
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
            this.txt_customerName.Location = new System.Drawing.Point(124, 81);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.PenWidth = 15;
            this.txt_customerName.RGB = false;
            this.txt_customerName.Rounding = true;
            this.txt_customerName.RoundingInt = 30;
            this.txt_customerName.Size = new System.Drawing.Size(204, 42);
            this.txt_customerName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_customerName.TabIndex = 36;
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
            this.txt_customerID.Location = new System.Drawing.Point(124, 33);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.PenWidth = 15;
            this.txt_customerID.RGB = false;
            this.txt_customerID.Rounding = true;
            this.txt_customerID.RoundingInt = 30;
            this.txt_customerID.Size = new System.Drawing.Size(204, 42);
            this.txt_customerID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_customerID.TabIndex = 37;
            this.txt_customerID.Tag = "Cyber";
            this.txt_customerID.TextButton = "";
            this.txt_customerID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_customerID.Timer_RGB = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Phone Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "ID :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txt_orderID);
            this.groupBox3.Controls.Add(this.lbl_quantity);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lbl_price);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.artanPanel7);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 275);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carts";
            // 
            // txt_orderID
            // 
            this.txt_orderID.Alpha = 20;
            this.txt_orderID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_orderID.BackColor = System.Drawing.Color.Transparent;
            this.txt_orderID.Background_WidthPen = 5F;
            this.txt_orderID.BackgroundPen = true;
            this.txt_orderID.ColorBackground = System.Drawing.Color.White;
            this.txt_orderID.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_orderID.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_orderID.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_orderID.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_orderID.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_orderID.Enabled = false;
            this.txt_orderID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_orderID.ForeColor = System.Drawing.Color.Black;
            this.txt_orderID.Lighting = false;
            this.txt_orderID.LinearGradientPen = true;
            this.txt_orderID.Location = new System.Drawing.Point(92, 23);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.PenWidth = 15;
            this.txt_orderID.RGB = false;
            this.txt_orderID.Rounding = true;
            this.txt_orderID.RoundingInt = 30;
            this.txt_orderID.Size = new System.Drawing.Size(204, 42);
            this.txt_orderID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_orderID.TabIndex = 40;
            this.txt_orderID.Tag = "Cyber";
            this.txt_orderID.TextButton = "";
            this.txt_orderID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_orderID.Timer_RGB = 300;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_quantity.ForeColor = System.Drawing.Color.White;
            this.lbl_quantity.Location = new System.Drawing.Point(124, 232);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(28, 20);
            this.lbl_quantity.TabIndex = 19;
            this.lbl_quantity.Text = "0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total quantity :";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(270, 233);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(28, 20);
            this.lbl_price.TabIndex = 17;
            this.lbl_price.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(193, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Total ($): ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Order ID :";
            // 
            // artanPanel7
            // 
            this.artanPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel7.BackColor = System.Drawing.Color.White;
            this.artanPanel7.BorderRadius = 50;
            this.artanPanel7.Controls.Add(this.dgv_cart);
            this.artanPanel7.ForeColor = System.Drawing.Color.Black;
            this.artanPanel7.GradientAngle = 90F;
            this.artanPanel7.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel7.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel7.Location = new System.Drawing.Point(6, 71);
            this.artanPanel7.Name = "artanPanel7";
            this.artanPanel7.Size = new System.Drawing.Size(349, 148);
            this.artanPanel7.TabIndex = 8;
            // 
            // dgv_cart
            // 
            this.dgv_cart.AllowUserToAddRows = false;
            this.dgv_cart.AllowUserToDeleteRows = false;
            this.dgv_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cart.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productname,
            this.quantity});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cart.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cart.EnableHeadersVisualStyles = false;
            this.dgv_cart.Location = new System.Drawing.Point(0, 0);
            this.dgv_cart.Name = "dgv_cart";
            this.dgv_cart.ReadOnly = true;
            this.dgv_cart.RowHeadersVisible = false;
            this.dgv_cart.RowHeadersWidth = 51;
            this.dgv_cart.RowTemplate.Height = 24;
            this.dgv_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cart.Size = new System.Drawing.Size(349, 148);
            this.dgv_cart.TabIndex = 22;
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
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BorderColor = System.Drawing.Color.Transparent;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_update.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_update.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = null;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_update.Location = new System.Drawing.Point(333, 14);
            this.btn_update.Name = "btn_update";
            this.btn_update.PressedBorderColor = System.Drawing.Color.White;
            this.btn_update.PressedColor = System.Drawing.Color.White;
            this.btn_update.Size = new System.Drawing.Size(91, 30);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_emport
            // 
            this.btn_emport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_emport.BackColor = System.Drawing.Color.Transparent;
            this.btn_emport.BorderColor = System.Drawing.Color.Transparent;
            this.btn_emport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_emport.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_emport.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_emport.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emport.Image = null;
            this.btn_emport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emport.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_emport.Location = new System.Drawing.Point(430, 14);
            this.btn_emport.Name = "btn_emport";
            this.btn_emport.PressedBorderColor = System.Drawing.Color.White;
            this.btn_emport.PressedColor = System.Drawing.Color.White;
            this.btn_emport.Size = new System.Drawing.Size(91, 30);
            this.btn_emport.TabIndex = 18;
            this.btn_emport.Text = "Export";
            this.btn_emport.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_emport.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_delete.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_delete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Image = null;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_delete.Location = new System.Drawing.Point(236, 14);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PressedBorderColor = System.Drawing.Color.White;
            this.btn_delete.PressedColor = System.Drawing.Color.White;
            this.btn_delete.Size = new System.Drawing.Size(91, 30);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.56126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.40711F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6419F));
            this.tableLayoutPanel1.Controls.Add(this.artanPanel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.artanPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.artanPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.artanPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1269, 289);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // artanPanel4
            // 
            this.artanPanel4.BackColor = System.Drawing.Color.White;
            this.artanPanel4.BorderRadius = 50;
            this.artanPanel4.Controls.Add(this.btn_pay);
            this.artanPanel4.Controls.Add(this.txt_paymentAmount);
            this.artanPanel4.Controls.Add(this.label17);
            this.artanPanel4.Controls.Add(this.lbl_lateFee);
            this.artanPanel4.Controls.Add(this.label16);
            this.artanPanel4.Controls.Add(this.lbl_outstandingAmount);
            this.artanPanel4.Controls.Add(this.label15);
            this.artanPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel4.ForeColor = System.Drawing.Color.Black;
            this.artanPanel4.GradientAngle = 45F;
            this.artanPanel4.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel4.Location = new System.Drawing.Point(1058, 6);
            this.artanPanel4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.artanPanel4.Name = "artanPanel4";
            this.artanPanel4.Size = new System.Drawing.Size(203, 275);
            this.artanPanel4.TabIndex = 15;
            // 
            // btn_pay
            // 
            this.btn_pay.AllowDrop = true;
            this.btn_pay.BackColor = System.Drawing.Color.Transparent;
            this.btn_pay.BorderColor = System.Drawing.Color.Transparent;
            this.btn_pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pay.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_pay.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_pay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_pay.Image = null;
            this.btn_pay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pay.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_pay.Location = new System.Drawing.Point(62, 218);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.PressedBorderColor = System.Drawing.Color.White;
            this.btn_pay.PressedColor = System.Drawing.Color.White;
            this.btn_pay.Size = new System.Drawing.Size(97, 34);
            this.btn_pay.TabIndex = 48;
            this.btn_pay.Text = "Pay";
            this.btn_pay.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // txt_paymentAmount
            // 
            this.txt_paymentAmount.BackColor = System.Drawing.Color.Transparent;
            this.txt_paymentAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_paymentAmount.EdgeColor = System.Drawing.Color.White;
            this.txt_paymentAmount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_paymentAmount.ForeColor = System.Drawing.Color.DimGray;
            this.txt_paymentAmount.Location = new System.Drawing.Point(11, 173);
            this.txt_paymentAmount.MaxLength = 32767;
            this.txt_paymentAmount.Multiline = false;
            this.txt_paymentAmount.Name = "txt_paymentAmount";
            this.txt_paymentAmount.ReadOnly = false;
            this.txt_paymentAmount.Size = new System.Drawing.Size(187, 31);
            this.txt_paymentAmount.TabIndex = 47;
            this.txt_paymentAmount.Text = "0.0";
            this.txt_paymentAmount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_paymentAmount.UseSystemPasswordChar = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(5, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 20);
            this.label17.TabIndex = 45;
            this.label17.Text = "Late Fee :";
            // 
            // lbl_lateFee
            // 
            this.lbl_lateFee.AutoSize = true;
            this.lbl_lateFee.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lateFee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lateFee.ForeColor = System.Drawing.Color.White;
            this.lbl_lateFee.Location = new System.Drawing.Point(7, 110);
            this.lbl_lateFee.Name = "lbl_lateFee";
            this.lbl_lateFee.Size = new System.Drawing.Size(36, 20);
            this.lbl_lateFee.TabIndex = 46;
            this.lbl_lateFee.Text = "$0.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(5, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Outstanding Amount :";
            // 
            // lbl_outstandingAmount
            // 
            this.lbl_outstandingAmount.AutoSize = true;
            this.lbl_outstandingAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_outstandingAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outstandingAmount.ForeColor = System.Drawing.Color.White;
            this.lbl_outstandingAmount.Location = new System.Drawing.Point(7, 59);
            this.lbl_outstandingAmount.Name = "lbl_outstandingAmount";
            this.lbl_outstandingAmount.Size = new System.Drawing.Size(36, 20);
            this.lbl_outstandingAmount.TabIndex = 44;
            this.lbl_outstandingAmount.Text = "$0.0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(5, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "Payment Amount :";
            // 
            // artanPanel3
            // 
            this.artanPanel3.BackColor = System.Drawing.Color.White;
            this.artanPanel3.BorderRadius = 50;
            this.artanPanel3.Controls.Add(this.groupBox3);
            this.artanPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 45F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel3.Location = new System.Drawing.Point(687, 6);
            this.artanPanel3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(361, 275);
            this.artanPanel3.TabIndex = 15;
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 50;
            this.artanPanel2.Controls.Add(this.groupBox2);
            this.artanPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 45F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel2.Location = new System.Drawing.Point(343, 6);
            this.artanPanel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(334, 275);
            this.artanPanel2.TabIndex = 14;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 50;
            this.artanPanel1.Controls.Add(this.groupBox1);
            this.artanPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 45F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel1.Location = new System.Drawing.Point(8, 6);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(325, 275);
            this.artanPanel1.TabIndex = 7;
            // 
            // artanPanel5
            // 
            this.artanPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel5.BackColor = System.Drawing.Color.White;
            this.artanPanel5.BorderRadius = 30;
            this.artanPanel5.Controls.Add(this.label18);
            this.artanPanel5.Controls.Add(this.txt_paymentHistory);
            this.artanPanel5.Controls.Add(this.label13);
            this.artanPanel5.Controls.Add(this.cb_filter);
            this.artanPanel5.Controls.Add(this.btn_delete);
            this.artanPanel5.Controls.Add(this.btn_update);
            this.artanPanel5.Controls.Add(this.txt_search);
            this.artanPanel5.Controls.Add(this.btn_emport);
            this.artanPanel5.Controls.Add(this.cb_search);
            this.artanPanel5.Controls.Add(this.artanPanel6);
            this.artanPanel5.Controls.Add(this.label11);
            this.artanPanel5.Controls.Add(this.btn_refresh);
            this.artanPanel5.Controls.Add(this.btn_search);
            this.artanPanel5.Controls.Add(this.label14);
            this.artanPanel5.ForeColor = System.Drawing.Color.Black;
            this.artanPanel5.GradientAngle = 90F;
            this.artanPanel5.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel5.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel5.Location = new System.Drawing.Point(13, 333);
            this.artanPanel5.Name = "artanPanel5";
            this.artanPanel5.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel5.Size = new System.Drawing.Size(1269, 403);
            this.artanPanel5.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(956, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 28);
            this.label18.TabIndex = 49;
            this.label18.Text = "Payment History :";
            // 
            // txt_paymentHistory
            // 
            this.txt_paymentHistory.AllowDrop = true;
            this.txt_paymentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_paymentHistory.BackColor = System.Drawing.Color.Transparent;
            this.txt_paymentHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_paymentHistory.EdgeColor = System.Drawing.Color.White;
            this.txt_paymentHistory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_paymentHistory.ForeColor = System.Drawing.Color.Black;
            this.txt_paymentHistory.Location = new System.Drawing.Point(961, 50);
            this.txt_paymentHistory.MaxLength = 32767;
            this.txt_paymentHistory.Multiline = true;
            this.txt_paymentHistory.Name = "txt_paymentHistory";
            this.txt_paymentHistory.ReadOnly = true;
            this.txt_paymentHistory.Size = new System.Drawing.Size(295, 291);
            this.txt_paymentHistory.TabIndex = 30;
            this.txt_paymentHistory.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_paymentHistory.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(601, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 28);
            this.label13.TabIndex = 48;
            this.label13.Text = "Filter : ";
            // 
            // cb_filter
            // 
            this.cb_filter.AllowDrop = true;
            this.cb_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_filter.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_filter.BackColor = System.Drawing.Color.Transparent;
            this.cb_filter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cb_filter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_filter.CausesValidation = false;
            this.cb_filter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_filter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_filter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.IsDerivedStyle = true;
            this.cb_filter.ItemHeight = 20;
            this.cb_filter.Items.AddRange(new object[] {
            "All",
            "Complete",
            "Not Complete",
            "Over Due"});
            this.cb_filter.Location = new System.Drawing.Point(677, 14);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_filter.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_filter.Size = new System.Drawing.Size(162, 26);
            this.cb_filter.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_filter.StyleManager = null;
            this.cb_filter.TabIndex = 47;
            this.cb_filter.ThemeAuthor = "Taiizor";
            this.cb_filter.ThemeName = "MetroLight";
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
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
            this.txt_search.Location = new System.Drawing.Point(400, 349);
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
            "Bill ID",
            "Customer ID",
            "Customer Name",
            "Order ID",
            "User ID",
            "User Name"});
            this.cb_search.Location = new System.Drawing.Point(26, 354);
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
            // artanPanel6
            // 
            this.artanPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel6.BackColor = System.Drawing.Color.White;
            this.artanPanel6.BorderRadius = 50;
            this.artanPanel6.Controls.Add(this.dgv_bill);
            this.artanPanel6.ForeColor = System.Drawing.Color.Black;
            this.artanPanel6.GradientAngle = 90F;
            this.artanPanel6.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel6.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel6.Location = new System.Drawing.Point(13, 50);
            this.artanPanel6.Name = "artanPanel6";
            this.artanPanel6.Size = new System.Drawing.Size(938, 291);
            this.artanPanel6.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(22, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 28);
            this.label11.TabIndex = 46;
            this.label11.Text = "All Bills :";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_refresh.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_refresh.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = null;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_refresh.Location = new System.Drawing.Point(802, 355);
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
            this.btn_search.Location = new System.Drawing.Point(666, 355);
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
            this.label14.Location = new System.Drawing.Point(327, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 28);
            this.label14.TabIndex = 27;
            this.label14.Text = "Input :";
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.artanPanel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "BillForm";
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.artanPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.artanPanel4.ResumeLayout(false);
            this.artanPanel4.PerformLayout();
            this.artanPanel3.ResumeLayout(false);
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel5.ResumeLayout(false);
            this.artanPanel5.PerformLayout();
            this.artanPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label label10;
        private ReaLTaiizor.Controls.Button btn_update;
        private ReaLTaiizor.Controls.Button btn_emport;
        private ReaLTaiizor.Controls.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_bill;
        private System.Windows.Forms.DataGridView dgv_cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DateTimePicker dt_dateOrder;
        private ArtanComponent.ArtanPanel artanPanel1;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ArtanComponent.ArtanPanel artanPanel4;
        private ArtanComponent.ArtanPanel artanPanel3;
        private ArtanComponent.ArtanPanel artanPanel5;
        private ReaLTaiizor.Controls.CyberTextBox txt_search;
        private ReaLTaiizor.Controls.MetroComboBox cb_search;
        private ArtanComponent.ArtanPanel artanPanel6;
        private System.Windows.Forms.Label label11;
        private ReaLTaiizor.Controls.Button btn_refresh;
        private ReaLTaiizor.Controls.Button btn_search;
        private System.Windows.Forms.Label label14;
        private ReaLTaiizor.Controls.CyberTextBox txt_billID;
        private ReaLTaiizor.Controls.CyberTextBox txt_userName;
        private ReaLTaiizor.Controls.CyberTextBox txt_userID;
        private ReaLTaiizor.Controls.CyberTextBox txt_customerID;
        private ReaLTaiizor.Controls.CyberTextBox txt_customerName;
        private ReaLTaiizor.Controls.CyberTextBox txt_customerPN;
        private ReaLTaiizor.Controls.CyberTextBox txt_customerAddr;
        private ReaLTaiizor.Controls.CyberTextBox txt_orderID;
        private ArtanComponent.ArtanPanel artanPanel7;
        private ReaLTaiizor.Controls.MetroComboBox cb_filter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_outstandingAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_lateFee;
        private ExtendedDungeonTextBox txt_paymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn billid;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn downpaymentamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn outstandingamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn latefee;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymenthistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private ReaLTaiizor.Controls.Button btn_pay;
        private ExtendedDungeonTextBox txt_paymentHistory;
        private System.Windows.Forms.Label label18;
    }
}