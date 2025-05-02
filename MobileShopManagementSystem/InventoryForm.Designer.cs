namespace MobileShopManagementSystem
{
    partial class InventoryForm
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
            this.btn_refresh = new ReaLTaiizor.Controls.Button();
            this.btn_search = new ReaLTaiizor.Controls.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.col_productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_categoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_importprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sellingprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_realprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dateinsert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dateupdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.col_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fkcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.c_Discount = new System.Windows.Forms.CheckBox();
            this.txt_inventoryDiscount = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_inventorySellingPrice = new ReaLTaiizor.Controls.CyberTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_inventoryImport = new ReaLTaiizor.Controls.Button();
            this.btn_inventoryClear = new ReaLTaiizor.Controls.Button();
            this.btn_inventoryUpdate = new ReaLTaiizor.Controls.Button();
            this.btn_inventoryDelete = new ReaLTaiizor.Controls.Button();
            this.btn_inventoryAdd = new ReaLTaiizor.Controls.Button();
            this.txt_inventoryImportPrice = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_inventoryStock = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_inventoryProductName = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_inventoryProductID = new ReaLTaiizor.Controls.CyberTextBox();
            this.cb_inventoryCategory = new ReaLTaiizor.Controls.MetroComboBox();
            this.cb_inventoryStatus = new ReaLTaiizor.Controls.MetroComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.txt_search = new ReaLTaiizor.Controls.CyberTextBox();
            this.cb_search = new ReaLTaiizor.Controls.MetroComboBox();
            this.artanPanel3 = new ArtanComponent.ArtanPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_inventoryDescription = new MobileShopManagementSystem.ExtendedDungeonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.artanPanel1.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            this.artanPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_refresh.Location = new System.Drawing.Point(959, 295);
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
            this.btn_search.Location = new System.Drawing.Point(823, 295);
            this.btn_search.Name = "btn_search";
            this.btn_search.PressedBorderColor = System.Drawing.Color.White;
            this.btn_search.PressedColor = System.Drawing.Color.White;
            this.btn_search.Size = new System.Drawing.Size(130, 24);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(488, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 28);
            this.label8.TabIndex = 27;
            this.label8.Text = "Input :";
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_products.BackgroundColor = System.Drawing.Color.White;
            this.dgv_products.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_productid,
            this.col_name,
            this.col_categoryid,
            this.col_category,
            this.col_stock,
            this.col_importprice,
            this.col_sellingprice,
            this.col_discount,
            this.col_realprice,
            this.col_status,
            this.col_dateinsert,
            this.col_dateupdate,
            this.col_image,
            this.col_description,
            this.col_fkcategory});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_products.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_products.EnableHeadersVisualStyles = false;
            this.dgv_products.Location = new System.Drawing.Point(0, 0);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.RowHeadersVisible = false;
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.Size = new System.Drawing.Size(1239, 233);
            this.dgv_products.TabIndex = 3;
            this.dgv_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellClick);
            // 
            // col_productid
            // 
            this.col_productid.DataPropertyName = "ProductID";
            this.col_productid.HeaderText = "ID";
            this.col_productid.MinimumWidth = 6;
            this.col_productid.Name = "col_productid";
            this.col_productid.ReadOnly = true;
            this.col_productid.Width = 61;
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "ProductName";
            this.col_name.HeaderText = "Name";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Width = 96;
            // 
            // col_categoryid
            // 
            this.col_categoryid.DataPropertyName = "CategoryID";
            this.col_categoryid.HeaderText = "Category ID";
            this.col_categoryid.MinimumWidth = 6;
            this.col_categoryid.Name = "col_categoryid";
            this.col_categoryid.ReadOnly = true;
            this.col_categoryid.Width = 153;
            // 
            // col_category
            // 
            this.col_category.DataPropertyName = "Category";
            this.col_category.HeaderText = "Category";
            this.col_category.MinimumWidth = 6;
            this.col_category.Name = "col_category";
            this.col_category.ReadOnly = true;
            this.col_category.Width = 126;
            // 
            // col_stock
            // 
            this.col_stock.DataPropertyName = "Stock";
            this.col_stock.HeaderText = "Stock";
            this.col_stock.MinimumWidth = 6;
            this.col_stock.Name = "col_stock";
            this.col_stock.ReadOnly = true;
            this.col_stock.Width = 92;
            // 
            // col_importprice
            // 
            this.col_importprice.DataPropertyName = "ImportPrice";
            this.col_importprice.HeaderText = "Import Price";
            this.col_importprice.MinimumWidth = 6;
            this.col_importprice.Name = "col_importprice";
            this.col_importprice.ReadOnly = true;
            this.col_importprice.Width = 158;
            // 
            // col_sellingprice
            // 
            this.col_sellingprice.DataPropertyName = "SellingPrice";
            this.col_sellingprice.HeaderText = "Selling Price";
            this.col_sellingprice.MinimumWidth = 6;
            this.col_sellingprice.Name = "col_sellingprice";
            this.col_sellingprice.ReadOnly = true;
            this.col_sellingprice.Width = 157;
            // 
            // col_discount
            // 
            this.col_discount.DataPropertyName = "Discount";
            this.col_discount.HeaderText = "Discount";
            this.col_discount.MinimumWidth = 6;
            this.col_discount.Name = "col_discount";
            this.col_discount.ReadOnly = true;
            this.col_discount.Width = 124;
            // 
            // col_realprice
            // 
            this.col_realprice.DataPropertyName = "RealPrice";
            this.col_realprice.HeaderText = "Real Price";
            this.col_realprice.MinimumWidth = 6;
            this.col_realprice.Name = "col_realprice";
            this.col_realprice.ReadOnly = true;
            this.col_realprice.Width = 134;
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "Status";
            this.col_status.HeaderText = "Status";
            this.col_status.MinimumWidth = 6;
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            this.col_status.Width = 99;
            // 
            // col_dateinsert
            // 
            this.col_dateinsert.DataPropertyName = "DateInsert";
            this.col_dateinsert.HeaderText = "Date Insert";
            this.col_dateinsert.MinimumWidth = 6;
            this.col_dateinsert.Name = "col_dateinsert";
            this.col_dateinsert.ReadOnly = true;
            this.col_dateinsert.Width = 146;
            // 
            // col_dateupdate
            // 
            this.col_dateupdate.DataPropertyName = "DateUpdate";
            this.col_dateupdate.HeaderText = "Date Update";
            this.col_dateupdate.MinimumWidth = 6;
            this.col_dateupdate.Name = "col_dateupdate";
            this.col_dateupdate.ReadOnly = true;
            this.col_dateupdate.Width = 159;
            // 
            // col_image
            // 
            this.col_image.DataPropertyName = "Image";
            this.col_image.HeaderText = "Image";
            this.col_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.col_image.MinimumWidth = 6;
            this.col_image.Name = "col_image";
            this.col_image.ReadOnly = true;
            this.col_image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_image.Width = 98;
            // 
            // col_description
            // 
            this.col_description.DataPropertyName = "Description";
            this.col_description.HeaderText = "Description";
            this.col_description.MinimumWidth = 6;
            this.col_description.Name = "col_description";
            this.col_description.ReadOnly = true;
            this.col_description.Width = 149;
            // 
            // col_fkcategory
            // 
            this.col_fkcategory.DataPropertyName = "Category1";
            this.col_fkcategory.HeaderText = "ForeignKey";
            this.col_fkcategory.MinimumWidth = 6;
            this.col_fkcategory.Name = "col_fkcategory";
            this.col_fkcategory.ReadOnly = true;
            this.col_fkcategory.Visible = false;
            this.col_fkcategory.Width = 146;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(560, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "* Import Price ($) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(561, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "* Status : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(13, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 186);
            this.panel3.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.artanPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.artanPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.64491F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.355091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1271, 725);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.c_Discount);
            this.artanPanel1.Controls.Add(this.txt_inventoryDiscount);
            this.artanPanel1.Controls.Add(this.txt_inventorySellingPrice);
            this.artanPanel1.Controls.Add(this.label2);
            this.artanPanel1.Controls.Add(this.label4);
            this.artanPanel1.Controls.Add(this.label3);
            this.artanPanel1.Controls.Add(this.label1);
            this.artanPanel1.Controls.Add(this.label10);
            this.artanPanel1.Controls.Add(this.btn_inventoryImport);
            this.artanPanel1.Controls.Add(this.btn_inventoryClear);
            this.artanPanel1.Controls.Add(this.btn_inventoryUpdate);
            this.artanPanel1.Controls.Add(this.btn_inventoryDelete);
            this.artanPanel1.Controls.Add(this.btn_inventoryAdd);
            this.artanPanel1.Controls.Add(this.txt_inventoryImportPrice);
            this.artanPanel1.Controls.Add(this.txt_inventoryStock);
            this.artanPanel1.Controls.Add(this.txt_inventoryProductName);
            this.artanPanel1.Controls.Add(this.txt_inventoryProductID);
            this.artanPanel1.Controls.Add(this.cb_inventoryCategory);
            this.artanPanel1.Controls.Add(this.cb_inventoryStatus);
            this.artanPanel1.Controls.Add(this.txt_inventoryDescription);
            this.artanPanel1.Controls.Add(this.label9);
            this.artanPanel1.Controls.Add(this.bigLabel1);
            this.artanPanel1.Controls.Add(this.panel3);
            this.artanPanel1.Controls.Add(this.label6);
            this.artanPanel1.Controls.Add(this.label5);
            this.artanPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel1.Location = new System.Drawing.Point(3, 386);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel1.Size = new System.Drawing.Size(1265, 336);
            this.artanPanel1.TabIndex = 5;
            // 
            // c_Discount
            // 
            this.c_Discount.AutoSize = true;
            this.c_Discount.BackColor = System.Drawing.Color.Transparent;
            this.c_Discount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.c_Discount.ForeColor = System.Drawing.Color.White;
            this.c_Discount.Location = new System.Drawing.Point(566, 182);
            this.c_Discount.Name = "c_Discount";
            this.c_Discount.Size = new System.Drawing.Size(111, 32);
            this.c_Discount.TabIndex = 52;
            this.c_Discount.Text = "Discount";
            this.c_Discount.UseVisualStyleBackColor = false;
            this.c_Discount.CheckedChanged += new System.EventHandler(this.c_Discount_CheckedChanged);
            // 
            // txt_inventoryDiscount
            // 
            this.txt_inventoryDiscount.Alpha = 20;
            this.txt_inventoryDiscount.BackColor = System.Drawing.Color.Transparent;
            this.txt_inventoryDiscount.Background_WidthPen = 5F;
            this.txt_inventoryDiscount.BackgroundPen = true;
            this.txt_inventoryDiscount.ColorBackground = System.Drawing.Color.White;
            this.txt_inventoryDiscount.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_inventoryDiscount.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryDiscount.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryDiscount.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryDiscount.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_inventoryDiscount.Enabled = false;
            this.txt_inventoryDiscount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_inventoryDiscount.ForeColor = System.Drawing.Color.Black;
            this.txt_inventoryDiscount.Lighting = false;
            this.txt_inventoryDiscount.LinearGradientPen = true;
            this.txt_inventoryDiscount.Location = new System.Drawing.Point(726, 182);
            this.txt_inventoryDiscount.Name = "txt_inventoryDiscount";
            this.txt_inventoryDiscount.PenWidth = 15;
            this.txt_inventoryDiscount.RGB = false;
            this.txt_inventoryDiscount.Rounding = true;
            this.txt_inventoryDiscount.RoundingInt = 30;
            this.txt_inventoryDiscount.Size = new System.Drawing.Size(211, 42);
            this.txt_inventoryDiscount.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_inventoryDiscount.TabIndex = 48;
            this.txt_inventoryDiscount.Tag = "Cyber";
            this.txt_inventoryDiscount.TextButton = "";
            this.txt_inventoryDiscount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_inventoryDiscount.Timer_RGB = 300;
            // 
            // txt_inventorySellingPrice
            // 
            this.txt_inventorySellingPrice.Alpha = 20;
            this.txt_inventorySellingPrice.BackColor = System.Drawing.Color.Transparent;
            this.txt_inventorySellingPrice.Background_WidthPen = 5F;
            this.txt_inventorySellingPrice.BackgroundPen = true;
            this.txt_inventorySellingPrice.ColorBackground = System.Drawing.Color.White;
            this.txt_inventorySellingPrice.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_inventorySellingPrice.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventorySellingPrice.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventorySellingPrice.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventorySellingPrice.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_inventorySellingPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_inventorySellingPrice.ForeColor = System.Drawing.Color.Black;
            this.txt_inventorySellingPrice.Lighting = false;
            this.txt_inventorySellingPrice.LinearGradientPen = true;
            this.txt_inventorySellingPrice.Location = new System.Drawing.Point(726, 124);
            this.txt_inventorySellingPrice.Name = "txt_inventorySellingPrice";
            this.txt_inventorySellingPrice.PenWidth = 15;
            this.txt_inventorySellingPrice.RGB = false;
            this.txt_inventorySellingPrice.Rounding = true;
            this.txt_inventorySellingPrice.RoundingInt = 30;
            this.txt_inventorySellingPrice.Size = new System.Drawing.Size(211, 42);
            this.txt_inventorySellingPrice.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_inventorySellingPrice.TabIndex = 47;
            this.txt_inventorySellingPrice.Tag = "Cyber";
            this.txt_inventorySellingPrice.TextButton = "";
            this.txt_inventorySellingPrice.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_inventorySellingPrice.Timer_RGB = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(560, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 46;
            this.label2.Text = "* Selling Price ($) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(168, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "* Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(169, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 44;
            this.label3.Text = "* Category :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "* Product Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(168, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 28);
            this.label10.TabIndex = 42;
            this.label10.Tag = "";
            this.label10.Text = "* Product ID :";
            // 
            // btn_inventoryImport
            // 
            this.btn_inventoryImport.AllowDrop = true;
            this.btn_inventoryImport.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventoryImport.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventoryImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventoryImport.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_inventoryImport.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_inventoryImport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_inventoryImport.Image = null;
            this.btn_inventoryImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryImport.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_inventoryImport.Location = new System.Drawing.Point(27, 267);
            this.btn_inventoryImport.Name = "btn_inventoryImport";
            this.btn_inventoryImport.PressedBorderColor = System.Drawing.Color.White;
            this.btn_inventoryImport.PressedColor = System.Drawing.Color.White;
            this.btn_inventoryImport.Size = new System.Drawing.Size(122, 34);
            this.btn_inventoryImport.TabIndex = 41;
            this.btn_inventoryImport.Text = "Import";
            this.btn_inventoryImport.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_inventoryImport.Click += new System.EventHandler(this.btn_inventoryImport_Click);
            // 
            // btn_inventoryClear
            // 
            this.btn_inventoryClear.AllowDrop = true;
            this.btn_inventoryClear.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventoryClear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventoryClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventoryClear.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_inventoryClear.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_inventoryClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_inventoryClear.Image = null;
            this.btn_inventoryClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryClear.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_inventoryClear.Location = new System.Drawing.Point(707, 293);
            this.btn_inventoryClear.Name = "btn_inventoryClear";
            this.btn_inventoryClear.PressedBorderColor = System.Drawing.Color.White;
            this.btn_inventoryClear.PressedColor = System.Drawing.Color.White;
            this.btn_inventoryClear.Size = new System.Drawing.Size(122, 34);
            this.btn_inventoryClear.TabIndex = 40;
            this.btn_inventoryClear.Text = "Clear";
            this.btn_inventoryClear.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_inventoryClear.Click += new System.EventHandler(this.btn_inventoryClear_Click);
            // 
            // btn_inventoryUpdate
            // 
            this.btn_inventoryUpdate.AllowDrop = true;
            this.btn_inventoryUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventoryUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventoryUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventoryUpdate.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_inventoryUpdate.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_inventoryUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_inventoryUpdate.Image = null;
            this.btn_inventoryUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryUpdate.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_inventoryUpdate.Location = new System.Drawing.Point(579, 293);
            this.btn_inventoryUpdate.Name = "btn_inventoryUpdate";
            this.btn_inventoryUpdate.PressedBorderColor = System.Drawing.Color.White;
            this.btn_inventoryUpdate.PressedColor = System.Drawing.Color.White;
            this.btn_inventoryUpdate.Size = new System.Drawing.Size(122, 34);
            this.btn_inventoryUpdate.TabIndex = 39;
            this.btn_inventoryUpdate.Text = "Update";
            this.btn_inventoryUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_inventoryUpdate.Click += new System.EventHandler(this.btn_inventoryUpdate_Click);
            // 
            // btn_inventoryDelete
            // 
            this.btn_inventoryDelete.AllowDrop = true;
            this.btn_inventoryDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventoryDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventoryDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventoryDelete.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_inventoryDelete.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_inventoryDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_inventoryDelete.Image = null;
            this.btn_inventoryDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryDelete.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_inventoryDelete.Location = new System.Drawing.Point(451, 293);
            this.btn_inventoryDelete.Name = "btn_inventoryDelete";
            this.btn_inventoryDelete.PressedBorderColor = System.Drawing.Color.White;
            this.btn_inventoryDelete.PressedColor = System.Drawing.Color.White;
            this.btn_inventoryDelete.Size = new System.Drawing.Size(122, 34);
            this.btn_inventoryDelete.TabIndex = 38;
            this.btn_inventoryDelete.Text = "Delete";
            this.btn_inventoryDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_inventoryDelete.Click += new System.EventHandler(this.btn_inventoryDelete_Click);
            // 
            // btn_inventoryAdd
            // 
            this.btn_inventoryAdd.AllowDrop = true;
            this.btn_inventoryAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventoryAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventoryAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventoryAdd.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_inventoryAdd.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_inventoryAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_inventoryAdd.Image = null;
            this.btn_inventoryAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryAdd.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_inventoryAdd.Location = new System.Drawing.Point(323, 294);
            this.btn_inventoryAdd.Name = "btn_inventoryAdd";
            this.btn_inventoryAdd.PressedBorderColor = System.Drawing.Color.White;
            this.btn_inventoryAdd.PressedColor = System.Drawing.Color.White;
            this.btn_inventoryAdd.Size = new System.Drawing.Size(122, 34);
            this.btn_inventoryAdd.TabIndex = 37;
            this.btn_inventoryAdd.Text = "Add";
            this.btn_inventoryAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_inventoryAdd.Click += new System.EventHandler(this.btn_inventoryAdd_Click);
            // 
            // txt_inventoryImportPrice
            // 
            this.txt_inventoryImportPrice.Alpha = 20;
            this.txt_inventoryImportPrice.BackColor = System.Drawing.Color.Transparent;
            this.txt_inventoryImportPrice.Background_WidthPen = 5F;
            this.txt_inventoryImportPrice.BackgroundPen = true;
            this.txt_inventoryImportPrice.ColorBackground = System.Drawing.Color.White;
            this.txt_inventoryImportPrice.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_inventoryImportPrice.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryImportPrice.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryImportPrice.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryImportPrice.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_inventoryImportPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_inventoryImportPrice.ForeColor = System.Drawing.Color.Black;
            this.txt_inventoryImportPrice.Lighting = false;
            this.txt_inventoryImportPrice.LinearGradientPen = true;
            this.txt_inventoryImportPrice.Location = new System.Drawing.Point(726, 64);
            this.txt_inventoryImportPrice.Name = "txt_inventoryImportPrice";
            this.txt_inventoryImportPrice.PenWidth = 15;
            this.txt_inventoryImportPrice.RGB = false;
            this.txt_inventoryImportPrice.Rounding = true;
            this.txt_inventoryImportPrice.RoundingInt = 30;
            this.txt_inventoryImportPrice.Size = new System.Drawing.Size(211, 42);
            this.txt_inventoryImportPrice.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_inventoryImportPrice.TabIndex = 36;
            this.txt_inventoryImportPrice.Tag = "Cyber";
            this.txt_inventoryImportPrice.TextButton = "";
            this.txt_inventoryImportPrice.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_inventoryImportPrice.Timer_RGB = 300;
            // 
            // txt_inventoryStock
            // 
            this.txt_inventoryStock.Alpha = 20;
            this.txt_inventoryStock.BackColor = System.Drawing.Color.Transparent;
            this.txt_inventoryStock.Background_WidthPen = 5F;
            this.txt_inventoryStock.BackgroundPen = true;
            this.txt_inventoryStock.ColorBackground = System.Drawing.Color.White;
            this.txt_inventoryStock.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_inventoryStock.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryStock.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryStock.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryStock.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_inventoryStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_inventoryStock.ForeColor = System.Drawing.Color.Black;
            this.txt_inventoryStock.Lighting = false;
            this.txt_inventoryStock.LinearGradientPen = true;
            this.txt_inventoryStock.Location = new System.Drawing.Point(339, 182);
            this.txt_inventoryStock.Name = "txt_inventoryStock";
            this.txt_inventoryStock.PenWidth = 15;
            this.txt_inventoryStock.RGB = false;
            this.txt_inventoryStock.Rounding = true;
            this.txt_inventoryStock.RoundingInt = 30;
            this.txt_inventoryStock.Size = new System.Drawing.Size(218, 42);
            this.txt_inventoryStock.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_inventoryStock.TabIndex = 35;
            this.txt_inventoryStock.Tag = "Cyber";
            this.txt_inventoryStock.TextButton = "";
            this.txt_inventoryStock.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_inventoryStock.Timer_RGB = 300;
            // 
            // txt_inventoryProductName
            // 
            this.txt_inventoryProductName.Alpha = 20;
            this.txt_inventoryProductName.BackColor = System.Drawing.Color.Transparent;
            this.txt_inventoryProductName.Background_WidthPen = 5F;
            this.txt_inventoryProductName.BackgroundPen = true;
            this.txt_inventoryProductName.ColorBackground = System.Drawing.Color.White;
            this.txt_inventoryProductName.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_inventoryProductName.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryProductName.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryProductName.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryProductName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_inventoryProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_inventoryProductName.ForeColor = System.Drawing.Color.Black;
            this.txt_inventoryProductName.Lighting = false;
            this.txt_inventoryProductName.LinearGradientPen = true;
            this.txt_inventoryProductName.Location = new System.Drawing.Point(339, 124);
            this.txt_inventoryProductName.Name = "txt_inventoryProductName";
            this.txt_inventoryProductName.PenWidth = 15;
            this.txt_inventoryProductName.RGB = false;
            this.txt_inventoryProductName.Rounding = true;
            this.txt_inventoryProductName.RoundingInt = 30;
            this.txt_inventoryProductName.Size = new System.Drawing.Size(218, 42);
            this.txt_inventoryProductName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_inventoryProductName.TabIndex = 34;
            this.txt_inventoryProductName.Tag = "Cyber";
            this.txt_inventoryProductName.TextButton = "";
            this.txt_inventoryProductName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_inventoryProductName.Timer_RGB = 300;
            // 
            // txt_inventoryProductID
            // 
            this.txt_inventoryProductID.Alpha = 20;
            this.txt_inventoryProductID.BackColor = System.Drawing.Color.Transparent;
            this.txt_inventoryProductID.Background_WidthPen = 5F;
            this.txt_inventoryProductID.BackgroundPen = true;
            this.txt_inventoryProductID.ColorBackground = System.Drawing.Color.White;
            this.txt_inventoryProductID.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_inventoryProductID.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryProductID.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryProductID.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_inventoryProductID.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_inventoryProductID.Enabled = false;
            this.txt_inventoryProductID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_inventoryProductID.ForeColor = System.Drawing.Color.Black;
            this.txt_inventoryProductID.Lighting = false;
            this.txt_inventoryProductID.LinearGradientPen = true;
            this.txt_inventoryProductID.Location = new System.Drawing.Point(339, 64);
            this.txt_inventoryProductID.Name = "txt_inventoryProductID";
            this.txt_inventoryProductID.PenWidth = 15;
            this.txt_inventoryProductID.RGB = false;
            this.txt_inventoryProductID.Rounding = true;
            this.txt_inventoryProductID.RoundingInt = 30;
            this.txt_inventoryProductID.Size = new System.Drawing.Size(218, 42);
            this.txt_inventoryProductID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_inventoryProductID.TabIndex = 33;
            this.txt_inventoryProductID.Tag = "Cyber";
            this.txt_inventoryProductID.TextButton = "";
            this.txt_inventoryProductID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_inventoryProductID.Timer_RGB = 300;
            // 
            // cb_inventoryCategory
            // 
            this.cb_inventoryCategory.AllowDrop = true;
            this.cb_inventoryCategory.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_inventoryCategory.BackColor = System.Drawing.Color.Transparent;
            this.cb_inventoryCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cb_inventoryCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_inventoryCategory.CausesValidation = false;
            this.cb_inventoryCategory.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_inventoryCategory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_inventoryCategory.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_inventoryCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_inventoryCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inventoryCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_inventoryCategory.FormattingEnabled = true;
            this.cb_inventoryCategory.IsDerivedStyle = true;
            this.cb_inventoryCategory.ItemHeight = 20;
            this.cb_inventoryCategory.Location = new System.Drawing.Point(339, 244);
            this.cb_inventoryCategory.Name = "cb_inventoryCategory";
            this.cb_inventoryCategory.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_inventoryCategory.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_inventoryCategory.Size = new System.Drawing.Size(216, 26);
            this.cb_inventoryCategory.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_inventoryCategory.StyleManager = null;
            this.cb_inventoryCategory.TabIndex = 32;
            this.cb_inventoryCategory.ThemeAuthor = "Taiizor";
            this.cb_inventoryCategory.ThemeName = "MetroLight";
            // 
            // cb_inventoryStatus
            // 
            this.cb_inventoryStatus.AllowDrop = true;
            this.cb_inventoryStatus.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_inventoryStatus.BackColor = System.Drawing.Color.Transparent;
            this.cb_inventoryStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cb_inventoryStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_inventoryStatus.CausesValidation = false;
            this.cb_inventoryStatus.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_inventoryStatus.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_inventoryStatus.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_inventoryStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_inventoryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inventoryStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_inventoryStatus.FormattingEnabled = true;
            this.cb_inventoryStatus.IsDerivedStyle = true;
            this.cb_inventoryStatus.ItemHeight = 20;
            this.cb_inventoryStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cb_inventoryStatus.Location = new System.Drawing.Point(726, 244);
            this.cb_inventoryStatus.Name = "cb_inventoryStatus";
            this.cb_inventoryStatus.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_inventoryStatus.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_inventoryStatus.Size = new System.Drawing.Size(211, 26);
            this.cb_inventoryStatus.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_inventoryStatus.StyleManager = null;
            this.cb_inventoryStatus.TabIndex = 31;
            this.cb_inventoryStatus.ThemeAuthor = "Taiizor";
            this.cb_inventoryStatus.ThemeName = "MetroLight";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(962, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "Description :";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(14, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(253, 52);
            this.bigLabel1.TabIndex = 26;
            this.bigLabel1.Text = "Inventory";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 30;
            this.artanPanel2.Controls.Add(this.txt_search);
            this.artanPanel2.Controls.Add(this.cb_search);
            this.artanPanel2.Controls.Add(this.artanPanel3);
            this.artanPanel2.Controls.Add(this.label7);
            this.artanPanel2.Controls.Add(this.btn_refresh);
            this.artanPanel2.Controls.Add(this.btn_search);
            this.artanPanel2.Controls.Add(this.label8);
            this.artanPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel2.Location = new System.Drawing.Point(3, 3);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel2.Size = new System.Drawing.Size(1265, 345);
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
            this.txt_search.Location = new System.Drawing.Point(561, 289);
            this.txt_search.Name = "txt_search";
            this.txt_search.PenWidth = 15;
            this.txt_search.RGB = false;
            this.txt_search.Rounding = true;
            this.txt_search.RoundingInt = 30;
            this.txt_search.Size = new System.Drawing.Size(256, 42);
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
            "Product ID",
            "Product Name",
            "Category"});
            this.cb_search.Location = new System.Drawing.Point(187, 294);
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
            this.artanPanel3.Controls.Add(this.dgv_products);
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel3.Location = new System.Drawing.Point(13, 41);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(1239, 233);
            this.artanPanel3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 28);
            this.label7.TabIndex = 46;
            this.label7.Text = "All products :";
            // 
            // txt_inventoryDescription
            // 
            this.txt_inventoryDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_inventoryDescription.BackColor = System.Drawing.Color.Transparent;
            this.txt_inventoryDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txt_inventoryDescription.EdgeColor = System.Drawing.Color.White;
            this.txt_inventoryDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_inventoryDescription.ForeColor = System.Drawing.Color.Black;
            this.txt_inventoryDescription.Location = new System.Drawing.Point(957, 56);
            this.txt_inventoryDescription.MaxLength = 32767;
            this.txt_inventoryDescription.Multiline = true;
            this.txt_inventoryDescription.Name = "txt_inventoryDescription";
            this.txt_inventoryDescription.ReadOnly = false;
            this.txt_inventoryDescription.Size = new System.Drawing.Size(295, 257);
            this.txt_inventoryDescription.TabIndex = 29;
            this.txt_inventoryDescription.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_inventoryDescription.UseSystemPasswordChar = false;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            this.artanPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private ReaLTaiizor.Controls.Button btn_refresh;
        private ReaLTaiizor.Controls.Button btn_search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ArtanComponent.ArtanPanel artanPanel1;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Label label9;
        private ExtendedDungeonTextBox txt_inventoryDescription;
        private ReaLTaiizor.Controls.MetroComboBox cb_inventoryCategory;
        private ReaLTaiizor.Controls.MetroComboBox cb_inventoryStatus;
        private ReaLTaiizor.Controls.CyberTextBox txt_inventoryProductID;
        private ReaLTaiizor.Controls.CyberTextBox txt_inventoryImportPrice;
        private ReaLTaiizor.Controls.CyberTextBox txt_inventoryStock;
        private ReaLTaiizor.Controls.CyberTextBox txt_inventoryProductName;
        private ReaLTaiizor.Controls.Button btn_inventoryClear;
        private ReaLTaiizor.Controls.Button btn_inventoryUpdate;
        private ReaLTaiizor.Controls.Button btn_inventoryDelete;
        private ReaLTaiizor.Controls.Button btn_inventoryAdd;
        private ReaLTaiizor.Controls.Button btn_inventoryImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private ArtanComponent.ArtanPanel artanPanel3;
        private ReaLTaiizor.Controls.MetroComboBox cb_search;
        private ReaLTaiizor.Controls.CyberTextBox txt_search;
        private ReaLTaiizor.Controls.CyberTextBox txt_inventorySellingPrice;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.CyberTextBox txt_inventoryDiscount;
        private System.Windows.Forms.CheckBox c_Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_categoryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_importprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sellingprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_realprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dateinsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dateupdate;
        private System.Windows.Forms.DataGridViewImageColumn col_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fkcategory;
    }
}