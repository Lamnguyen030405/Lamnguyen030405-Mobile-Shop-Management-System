using System;

namespace MobileShopManagementSystem
{
    partial class ShopForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_price = new System.Windows.Forms.Label();
            this.btn_categoryRefresh = new ReaLTaiizor.Controls.Button();
            this.btn_search = new ReaLTaiizor.Controls.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.txt_search = new ReaLTaiizor.Controls.CyberTextBox();
            this.artanPanel4 = new ArtanComponent.ArtanPanel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.artanPanel5 = new ArtanComponent.ArtanPanel();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.total_quantity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_shopTerm = new ReaLTaiizor.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.c_partialPayment = new ReaLTaiizor.Controls.CyberCheckBox();
            this.btn_refresh = new ReaLTaiizor.Controls.Button();
            this.btn_delete = new ReaLTaiizor.Controls.Button();
            this.btn_placeOrder = new ReaLTaiizor.Controls.Button();
            this.artanPanel3 = new ArtanComponent.ArtanPanel();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_remainingAmount = new System.Windows.Forms.Label();
            this.artanPanel6 = new ArtanComponent.ArtanPanel();
            this.cb_shopCategory = new ReaLTaiizor.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_description = new MobileShopManagementSystem.ExtendedDungeonTextBox();
            this.txt_downPaymentAmount = new MobileShopManagementSystem.ExtendedDungeonTextBox();
            this.artanPanel1.SuspendLayout();
            this.artanPanel4.SuspendLayout();
            this.artanPanel5.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            this.artanPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.artanPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(742, 550);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total ($): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Down Payment :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remaining Payment :";
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.BackColor = System.Drawing.Color.Transparent;
            this.total_price.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.total_price.ForeColor = System.Drawing.Color.White;
            this.total_price.Location = new System.Drawing.Point(110, 449);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(49, 28);
            this.total_price.TabIndex = 5;
            this.total_price.Text = "$0.0";
            // 
            // btn_categoryRefresh
            // 
            this.btn_categoryRefresh.AllowDrop = true;
            this.btn_categoryRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_categoryRefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_categoryRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categoryRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_categoryRefresh.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_categoryRefresh.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_categoryRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_categoryRefresh.Image = null;
            this.btn_categoryRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoryRefresh.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_categoryRefresh.Location = new System.Drawing.Point(142, 0);
            this.btn_categoryRefresh.Name = "btn_categoryRefresh";
            this.btn_categoryRefresh.PressedBorderColor = System.Drawing.Color.White;
            this.btn_categoryRefresh.PressedColor = System.Drawing.Color.White;
            this.btn_categoryRefresh.Size = new System.Drawing.Size(91, 72);
            this.btn_categoryRefresh.TabIndex = 3;
            this.btn_categoryRefresh.Text = "Refresh";
            this.btn_categoryRefresh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_categoryRefresh.Click += new System.EventHandler(this.btn_categoryRefresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.AllowDrop = true;
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderColor = System.Drawing.Color.Transparent;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_search.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_search.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_search.Image = null;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.Location = new System.Drawing.Point(430, 0);
            this.btn_search.Name = "btn_search";
            this.btn_search.PressedBorderColor = System.Drawing.Color.White;
            this.btn_search.PressedColor = System.Drawing.Color.White;
            this.btn_search.Size = new System.Drawing.Size(93, 72);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product\'s name :";
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.txt_search);
            this.artanPanel1.Controls.Add(this.btn_search);
            this.artanPanel1.Controls.Add(this.label1);
            this.artanPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 45F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel1.Location = new System.Drawing.Point(3, 3);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(523, 72);
            this.artanPanel1.TabIndex = 6;
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
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.Lighting = false;
            this.txt_search.LinearGradientPen = true;
            this.txt_search.Location = new System.Drawing.Point(154, 6);
            this.txt_search.Name = "txt_search";
            this.txt_search.PenWidth = 15;
            this.txt_search.RGB = false;
            this.txt_search.Rounding = true;
            this.txt_search.RoundingInt = 30;
            this.txt_search.Size = new System.Drawing.Size(270, 48);
            this.txt_search.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_search.TabIndex = 4;
            this.txt_search.Tag = "Cyber";
            this.txt_search.TextButton = "";
            this.txt_search.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_search.Timer_RGB = 300;
            // 
            // artanPanel4
            // 
            this.artanPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel4.BackColor = System.Drawing.Color.White;
            this.artanPanel4.BorderRadius = 30;
            this.artanPanel4.Controls.Add(this.bigLabel1);
            this.artanPanel4.Controls.Add(this.artanPanel5);
            this.artanPanel4.ForeColor = System.Drawing.Color.Black;
            this.artanPanel4.GradientAngle = 90F;
            this.artanPanel4.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.artanPanel4.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.artanPanel4.Location = new System.Drawing.Point(12, 119);
            this.artanPanel4.Name = "artanPanel4";
            this.artanPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel4.Size = new System.Drawing.Size(768, 618);
            this.artanPanel4.TabIndex = 7;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(2, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(134, 52);
            this.bigLabel1.TabIndex = 25;
            this.bigLabel1.Text = "Shop";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artanPanel5
            // 
            this.artanPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel5.BackColor = System.Drawing.Color.White;
            this.artanPanel5.BorderRadius = 30;
            this.artanPanel5.Controls.Add(this.flowLayoutPanel1);
            this.artanPanel5.ForeColor = System.Drawing.Color.Black;
            this.artanPanel5.GradientAngle = 90F;
            this.artanPanel5.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel5.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel5.Location = new System.Drawing.Point(13, 55);
            this.artanPanel5.Name = "artanPanel5";
            this.artanPanel5.Size = new System.Drawing.Size(742, 550);
            this.artanPanel5.TabIndex = 1;
            // 
            // artanPanel2
            // 
            this.artanPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 30;
            this.artanPanel2.Controls.Add(this.label8);
            this.artanPanel2.Controls.Add(this.txt_description);
            this.artanPanel2.Controls.Add(this.total_quantity);
            this.artanPanel2.Controls.Add(this.label7);
            this.artanPanel2.Controls.Add(this.cb_shopTerm);
            this.artanPanel2.Controls.Add(this.label5);
            this.artanPanel2.Controls.Add(this.c_partialPayment);
            this.artanPanel2.Controls.Add(this.btn_refresh);
            this.artanPanel2.Controls.Add(this.txt_downPaymentAmount);
            this.artanPanel2.Controls.Add(this.btn_delete);
            this.artanPanel2.Controls.Add(this.btn_placeOrder);
            this.artanPanel2.Controls.Add(this.label4);
            this.artanPanel2.Controls.Add(this.artanPanel3);
            this.artanPanel2.Controls.Add(this.label3);
            this.artanPanel2.Controls.Add(this.label2);
            this.artanPanel2.Controls.Add(this.lbl_remainingAmount);
            this.artanPanel2.Controls.Add(this.total_price);
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel2.Location = new System.Drawing.Point(818, 12);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel2.Size = new System.Drawing.Size(452, 725);
            this.artanPanel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 28);
            this.label8.TabIndex = 36;
            this.label8.Text = "Description :";
            // 
            // total_quantity
            // 
            this.total_quantity.AutoSize = true;
            this.total_quantity.BackColor = System.Drawing.Color.Transparent;
            this.total_quantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.total_quantity.ForeColor = System.Drawing.Color.White;
            this.total_quantity.Location = new System.Drawing.Point(349, 449);
            this.total_quantity.Name = "total_quantity";
            this.total_quantity.Size = new System.Drawing.Size(75, 28);
            this.total_quantity.TabIndex = 34;
            this.total_quantity.Text = "0 items";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(246, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "Quantity: ";
            // 
            // cb_shopTerm
            // 
            this.cb_shopTerm.AllowDrop = true;
            this.cb_shopTerm.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_shopTerm.BackColor = System.Drawing.Color.Transparent;
            this.cb_shopTerm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cb_shopTerm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_shopTerm.CausesValidation = false;
            this.cb_shopTerm.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_shopTerm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_shopTerm.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_shopTerm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_shopTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_shopTerm.Enabled = false;
            this.cb_shopTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_shopTerm.FormattingEnabled = true;
            this.cb_shopTerm.IsDerivedStyle = true;
            this.cb_shopTerm.ItemHeight = 20;
            this.cb_shopTerm.Items.AddRange(new object[] {
            "30 days",
            "60 days",
            "90 days",
            "120 days"});
            this.cb_shopTerm.Location = new System.Drawing.Point(174, 629);
            this.cb_shopTerm.Name = "cb_shopTerm";
            this.cb_shopTerm.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_shopTerm.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_shopTerm.Size = new System.Drawing.Size(94, 26);
            this.cb_shopTerm.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_shopTerm.StyleManager = null;
            this.cb_shopTerm.TabIndex = 32;
            this.cb_shopTerm.ThemeAuthor = "Taiizor";
            this.cb_shopTerm.ThemeName = "MetroLight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Term :";
            // 
            // c_partialPayment
            // 
            this.c_partialPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_partialPayment.BackColor = System.Drawing.Color.Transparent;
            this.c_partialPayment.Background = true;
            this.c_partialPayment.Background_WidthPen = 2F;
            this.c_partialPayment.BackgroundPen = true;
            this.c_partialPayment.Checked = false;
            this.c_partialPayment.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.c_partialPayment.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.c_partialPayment.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.c_partialPayment.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.c_partialPayment.ColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.c_partialPayment.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.c_partialPayment.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.c_partialPayment.CyberCheckBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.c_partialPayment.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.c_partialPayment.Effect_1_Transparency = 25;
            this.c_partialPayment.Effect_2 = true;
            this.c_partialPayment.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.c_partialPayment.Effect_2_Transparency = 15;
            this.c_partialPayment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.c_partialPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.c_partialPayment.LinearGradient_Background = false;
            this.c_partialPayment.LinearGradientPen = false;
            this.c_partialPayment.Location = new System.Drawing.Point(10, 480);
            this.c_partialPayment.Name = "c_partialPayment";
            this.c_partialPayment.RGB = false;
            this.c_partialPayment.Rounding = true;
            this.c_partialPayment.RoundingInt = 100;
            this.c_partialPayment.Size = new System.Drawing.Size(199, 45);
            this.c_partialPayment.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.c_partialPayment.TabIndex = 14;
            this.c_partialPayment.Tag = "Cyber";
            this.c_partialPayment.TextButton = "Partial Payment";
            this.c_partialPayment.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.c_partialPayment.Timer_Effect_1 = 1;
            this.c_partialPayment.Timer_RGB = 300;
            this.c_partialPayment.CheckedChanged += new ReaLTaiizor.Controls.CyberCheckBox.EventHandler(this.c_partialPayment_CheckedChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.AllowDrop = true;
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_refresh.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_refresh.Image = null;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_refresh.Location = new System.Drawing.Point(320, 686);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.PressedBorderColor = System.Drawing.Color.White;
            this.btn_refresh.PressedColor = System.Drawing.Color.White;
            this.btn_refresh.Size = new System.Drawing.Size(96, 34);
            this.btn_refresh.TabIndex = 13;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AllowDrop = true;
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_delete.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_delete.Image = null;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.Location = new System.Drawing.Point(212, 686);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PressedBorderColor = System.Drawing.Color.White;
            this.btn_delete.PressedColor = System.Drawing.Color.White;
            this.btn_delete.Size = new System.Drawing.Size(102, 34);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.AllowDrop = true;
            this.btn_placeOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_placeOrder.BackColor = System.Drawing.Color.Transparent;
            this.btn_placeOrder.BorderColor = System.Drawing.Color.Transparent;
            this.btn_placeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_placeOrder.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_placeOrder.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_placeOrder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_placeOrder.Image = null;
            this.btn_placeOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_placeOrder.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_placeOrder.Location = new System.Drawing.Point(84, 686);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.PressedBorderColor = System.Drawing.Color.White;
            this.btn_placeOrder.PressedColor = System.Drawing.Color.White;
            this.btn_placeOrder.Size = new System.Drawing.Size(122, 34);
            this.btn_placeOrder.TabIndex = 9;
            this.btn_placeOrder.Text = "Place order";
            this.btn_placeOrder.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // artanPanel3
            // 
            this.artanPanel3.BackColor = System.Drawing.Color.White;
            this.artanPanel3.BorderRadius = 60;
            this.artanPanel3.Controls.Add(this.dgv_product);
            this.artanPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.artanPanel3.ForeColor = System.Drawing.Color.Transparent;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel3.Location = new System.Drawing.Point(10, 10);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(432, 231);
            this.artanPanel3.TabIndex = 10;
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_product.BackgroundColor = System.Drawing.Color.White;
            this.dgv_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.productid,
            this.productname,
            this.quantity,
            this.price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_product.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_product.EnableHeadersVisualStyles = false;
            this.dgv_product.GridColor = System.Drawing.Color.Silver;
            this.dgv_product.Location = new System.Drawing.Point(0, 0);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.RowHeadersWidth = 51;
            this.dgv_product.RowTemplate.Height = 24;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(432, 231);
            this.dgv_product.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // productid
            // 
            this.productid.HeaderText = "Product ID";
            this.productid.MinimumWidth = 6;
            this.productid.Name = "productid";
            this.productid.ReadOnly = true;
            this.productid.Visible = false;
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
            // lbl_remainingAmount
            // 
            this.lbl_remainingAmount.AutoSize = true;
            this.lbl_remainingAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_remainingAmount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_remainingAmount.ForeColor = System.Drawing.Color.White;
            this.lbl_remainingAmount.Location = new System.Drawing.Point(236, 528);
            this.lbl_remainingAmount.Name = "lbl_remainingAmount";
            this.lbl_remainingAmount.Size = new System.Drawing.Size(49, 28);
            this.lbl_remainingAmount.TabIndex = 6;
            this.lbl_remainingAmount.Text = "$0.0";
            // 
            // artanPanel6
            // 
            this.artanPanel6.BackColor = System.Drawing.Color.White;
            this.artanPanel6.BorderRadius = 30;
            this.artanPanel6.Controls.Add(this.cb_shopCategory);
            this.artanPanel6.Controls.Add(this.label6);
            this.artanPanel6.Controls.Add(this.btn_categoryRefresh);
            this.artanPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel6.ForeColor = System.Drawing.Color.Black;
            this.artanPanel6.GradientAngle = 45F;
            this.artanPanel6.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel6.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel6.Location = new System.Drawing.Point(532, 3);
            this.artanPanel6.Name = "artanPanel6";
            this.artanPanel6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.artanPanel6.Size = new System.Drawing.Size(233, 72);
            this.artanPanel6.TabIndex = 7;
            // 
            // cb_shopCategory
            // 
            this.cb_shopCategory.AllowDrop = true;
            this.cb_shopCategory.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_shopCategory.BackColor = System.Drawing.Color.Transparent;
            this.cb_shopCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cb_shopCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_shopCategory.CausesValidation = false;
            this.cb_shopCategory.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_shopCategory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_shopCategory.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_shopCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_shopCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_shopCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_shopCategory.FormattingEnabled = true;
            this.cb_shopCategory.IsDerivedStyle = true;
            this.cb_shopCategory.ItemHeight = 20;
            this.cb_shopCategory.Items.AddRange(new object[] {
            "All"});
            this.cb_shopCategory.Location = new System.Drawing.Point(13, 37);
            this.cb_shopCategory.Name = "cb_shopCategory";
            this.cb_shopCategory.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_shopCategory.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_shopCategory.Size = new System.Drawing.Size(123, 26);
            this.cb_shopCategory.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_shopCategory.StyleManager = null;
            this.cb_shopCategory.TabIndex = 67;
            this.cb_shopCategory.ThemeAuthor = "Taiizor";
            this.cb_shopCategory.ThemeName = "MetroLight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Categories :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.88021F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.11979F));
            this.tableLayoutPanel1.Controls.Add(this.artanPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.artanPanel6, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 78);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.Color.Transparent;
            this.txt_description.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_description.EdgeColor = System.Drawing.Color.White;
            this.txt_description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.DimGray;
            this.txt_description.Location = new System.Drawing.Point(10, 283);
            this.txt_description.MaxLength = 32767;
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.ReadOnly = true;
            this.txt_description.Size = new System.Drawing.Size(429, 144);
            this.txt_description.TabIndex = 35;
            this.txt_description.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_description.UseSystemPasswordChar = false;
            // 
            // txt_downPaymentAmount
            // 
            this.txt_downPaymentAmount.BackColor = System.Drawing.Color.Transparent;
            this.txt_downPaymentAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_downPaymentAmount.EdgeColor = System.Drawing.Color.White;
            this.txt_downPaymentAmount.Enabled = false;
            this.txt_downPaymentAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_downPaymentAmount.ForeColor = System.Drawing.Color.DimGray;
            this.txt_downPaymentAmount.Location = new System.Drawing.Point(174, 574);
            this.txt_downPaymentAmount.MaxLength = 32767;
            this.txt_downPaymentAmount.Multiline = false;
            this.txt_downPaymentAmount.Name = "txt_downPaymentAmount";
            this.txt_downPaymentAmount.ReadOnly = false;
            this.txt_downPaymentAmount.Size = new System.Drawing.Size(271, 35);
            this.txt_downPaymentAmount.TabIndex = 9;
            this.txt_downPaymentAmount.Text = "0.0";
            this.txt_downPaymentAmount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_downPaymentAmount.UseSystemPasswordChar = false;
            this.txt_downPaymentAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_downPaymentAmount_KeyDown);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.artanPanel2);
            this.Controls.Add(this.artanPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.ShowIcon = false;
            this.Text = "ShopForm";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.artanPanel4.ResumeLayout(false);
            this.artanPanel4.PerformLayout();
            this.artanPanel5.ResumeLayout(false);
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            this.artanPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.artanPanel6.ResumeLayout(false);
            this.artanPanel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.Button btn_search;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.Button btn_categoryRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total_price;
        private ArtanComponent.ArtanPanel artanPanel1;
        private ArtanComponent.ArtanPanel artanPanel4;
        private ArtanComponent.ArtanPanel artanPanel5;
        private ArtanComponent.ArtanPanel artanPanel3;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private ArtanComponent.ArtanPanel artanPanel2;
        private System.Windows.Forms.Label lbl_remainingAmount;
        private ArtanComponent.ArtanPanel artanPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.Button btn_refresh;
        private ReaLTaiizor.Controls.Button btn_delete;
        private ReaLTaiizor.Controls.Button btn_placeOrder;
        private ExtendedDungeonTextBox txt_downPaymentAmount;
        private System.Windows.Forms.Label label6;
        private ReaLTaiizor.Controls.CyberTextBox txt_search;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.CyberCheckBox c_partialPayment;
        private System.Windows.Forms.Label label5;
        private ReaLTaiizor.Controls.MetroComboBox cb_shopTerm;
        private System.Windows.Forms.Label total_quantity;
        private System.Windows.Forms.Label label7;
        private ReaLTaiizor.Controls.MetroComboBox cb_shopCategory;
        private ExtendedDungeonTextBox txt_description;
        private System.Windows.Forms.Label label8;
    }
}