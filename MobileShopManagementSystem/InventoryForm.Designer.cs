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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new ReaLTaiizor.Controls.Button();
            this.btn_search = new ReaLTaiizor.Controls.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.col_productid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_categoryid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dateinsert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dateupdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fkcategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_inventoryProductID = new System.Windows.Forms.TextBox();
            this.txt_inventoryProductName = new System.Windows.Forms.TextBox();
            this.txt_inventoryPrice = new System.Windows.Forms.TextBox();
            this.txt_inventoryStock = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_inventoryImport = new ReaLTaiizor.Controls.Button();
            this.cb_inventoryStatus = new System.Windows.Forms.ComboBox();
            this.cb_inventoryCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_inventoryUpdate = new ReaLTaiizor.Controls.Button();
            this.btn_inventoryClear = new ReaLTaiizor.Controls.Button();
            this.btn_inventoryDelete = new ReaLTaiizor.Controls.Button();
            this.btn_inventoryAdd = new ReaLTaiizor.Controls.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_search);
            this.panel1.Controls.Add(this.dgv_products);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1271, 422);
            this.panel1.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_refresh.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_refresh.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = null;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_refresh.Location = new System.Drawing.Point(1002, 389);
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
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderColor = System.Drawing.Color.Transparent;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_search.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_search.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = null;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_search.Location = new System.Drawing.Point(866, 389);
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
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(552, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Input :";
            // 
            // cb_search
            // 
            this.cb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Product ID",
            "Product Name",
            "Category"});
            this.cb_search.Location = new System.Drawing.Point(350, 386);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(185, 24);
            this.cb_search.TabIndex = 27;
            // 
            // dgv_products
            // 
            this.dgv_products.AllowUserToAddRows = false;
            this.dgv_products.AllowUserToDeleteRows = false;
            this.dgv_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products.BackgroundColor = System.Drawing.Color.White;
            this.dgv_products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
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
            this.col_price,
            this.col_status,
            this.col_dateinsert,
            this.col_dateupdate,
            this.col_image,
            this.col_fkcategory});
            this.dgv_products.EnableHeadersVisualStyles = false;
            this.dgv_products.Location = new System.Drawing.Point(13, 36);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.ReadOnly = true;
            this.dgv_products.RowHeadersVisible = false;
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.Size = new System.Drawing.Size(1245, 332);
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
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "ProductName";
            this.col_name.HeaderText = "Name";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            // 
            // col_categoryid
            // 
            this.col_categoryid.DataPropertyName = "CategoryID";
            this.col_categoryid.HeaderText = "Category ID";
            this.col_categoryid.MinimumWidth = 6;
            this.col_categoryid.Name = "col_categoryid";
            this.col_categoryid.ReadOnly = true;
            // 
            // col_category
            // 
            this.col_category.DataPropertyName = "Category";
            this.col_category.HeaderText = "Category";
            this.col_category.MinimumWidth = 6;
            this.col_category.Name = "col_category";
            this.col_category.ReadOnly = true;
            // 
            // col_stock
            // 
            this.col_stock.DataPropertyName = "Stock";
            this.col_stock.HeaderText = "Stock";
            this.col_stock.MinimumWidth = 6;
            this.col_stock.Name = "col_stock";
            this.col_stock.ReadOnly = true;
            // 
            // col_price
            // 
            this.col_price.DataPropertyName = "Price";
            this.col_price.HeaderText = "Price";
            this.col_price.MinimumWidth = 6;
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "Status";
            this.col_status.HeaderText = "Status";
            this.col_status.MinimumWidth = 6;
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // col_dateinsert
            // 
            this.col_dateinsert.DataPropertyName = "DateInsert";
            this.col_dateinsert.HeaderText = "Date Insert";
            this.col_dateinsert.MinimumWidth = 6;
            this.col_dateinsert.Name = "col_dateinsert";
            this.col_dateinsert.ReadOnly = true;
            // 
            // col_dateupdate
            // 
            this.col_dateupdate.DataPropertyName = "DateUpdate";
            this.col_dateupdate.HeaderText = "Date Update";
            this.col_dateupdate.MinimumWidth = 6;
            this.col_dateupdate.Name = "col_dateupdate";
            this.col_dateupdate.ReadOnly = true;
            // 
            // col_image
            // 
            this.col_image.DataPropertyName = "Image";
            this.col_image.HeaderText = "Image";
            this.col_image.MinimumWidth = 6;
            this.col_image.Name = "col_image";
            this.col_image.ReadOnly = true;
            // 
            // col_fkcategory
            // 
            this.col_fkcategory.DataPropertyName = "Category1";
            this.col_fkcategory.HeaderText = "ForeignKey";
            this.col_fkcategory.MinimumWidth = 6;
            this.col_fkcategory.Name = "col_fkcategory";
            this.col_fkcategory.ReadOnly = true;
            this.col_fkcategory.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "All products";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_search.Location = new System.Drawing.Point(618, 389);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(233, 22);
            this.txt_search.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(445, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stock :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(445, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price ($) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(445, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status : ";
            // 
            // txt_inventoryProductID
            // 
            this.txt_inventoryProductID.Enabled = false;
            this.txt_inventoryProductID.Location = new System.Drawing.Point(173, 50);
            this.txt_inventoryProductID.Name = "txt_inventoryProductID";
            this.txt_inventoryProductID.Size = new System.Drawing.Size(233, 22);
            this.txt_inventoryProductID.TabIndex = 10;
            // 
            // txt_inventoryProductName
            // 
            this.txt_inventoryProductName.Location = new System.Drawing.Point(173, 114);
            this.txt_inventoryProductName.Name = "txt_inventoryProductName";
            this.txt_inventoryProductName.Size = new System.Drawing.Size(233, 22);
            this.txt_inventoryProductName.TabIndex = 11;
            // 
            // txt_inventoryPrice
            // 
            this.txt_inventoryPrice.Location = new System.Drawing.Point(538, 114);
            this.txt_inventoryPrice.Name = "txt_inventoryPrice";
            this.txt_inventoryPrice.Size = new System.Drawing.Size(233, 22);
            this.txt_inventoryPrice.TabIndex = 13;
            // 
            // txt_inventoryStock
            // 
            this.txt_inventoryStock.Location = new System.Drawing.Point(538, 50);
            this.txt_inventoryStock.Name = "txt_inventoryStock";
            this.txt_inventoryStock.Size = new System.Drawing.Size(233, 22);
            this.txt_inventoryStock.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1070, 13);
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
            // btn_inventoryImport
            // 
            this.btn_inventoryImport.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventoryImport.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventoryImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventoryImport.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_inventoryImport.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_inventoryImport.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventoryImport.Image = null;
            this.btn_inventoryImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryImport.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_inventoryImport.Location = new System.Drawing.Point(1070, 214);
            this.btn_inventoryImport.Name = "btn_inventoryImport";
            this.btn_inventoryImport.PressedBorderColor = System.Drawing.Color.White;
            this.btn_inventoryImport.PressedColor = System.Drawing.Color.White;
            this.btn_inventoryImport.Size = new System.Drawing.Size(150, 30);
            this.btn_inventoryImport.TabIndex = 5;
            this.btn_inventoryImport.Text = "IMPORT";
            this.btn_inventoryImport.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_inventoryImport.Click += new System.EventHandler(this.btn_inventoryImport_Click);
            // 
            // cb_inventoryStatus
            // 
            this.cb_inventoryStatus.FormattingEnabled = true;
            this.cb_inventoryStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cb_inventoryStatus.Location = new System.Drawing.Point(538, 179);
            this.cb_inventoryStatus.Name = "cb_inventoryStatus";
            this.cb_inventoryStatus.Size = new System.Drawing.Size(233, 24);
            this.cb_inventoryStatus.TabIndex = 17;
            // 
            // cb_inventoryCategory
            // 
            this.cb_inventoryCategory.FormattingEnabled = true;
            this.cb_inventoryCategory.Location = new System.Drawing.Point(173, 179);
            this.cb_inventoryCategory.Name = "cb_inventoryCategory";
            this.cb_inventoryCategory.Size = new System.Drawing.Size(233, 24);
            this.cb_inventoryCategory.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.btn_inventoryUpdate);
            this.panel2.Controls.Add(this.btn_inventoryClear);
            this.panel2.Controls.Add(this.btn_inventoryDelete);
            this.panel2.Controls.Add(this.btn_inventoryAdd);
            this.panel2.Controls.Add(this.cb_inventoryCategory);
            this.panel2.Controls.Add(this.cb_inventoryStatus);
            this.panel2.Controls.Add(this.btn_inventoryImport);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txt_inventoryStock);
            this.panel2.Controls.Add(this.txt_inventoryPrice);
            this.panel2.Controls.Add(this.txt_inventoryProductName);
            this.panel2.Controls.Add(this.txt_inventoryProductID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 460);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1271, 277);
            this.panel2.TabIndex = 3;
            // 
            // btn_inventoryUpdate
            // 
            this.btn_inventoryUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventoryUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventoryUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventoryUpdate.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_inventoryUpdate.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_inventoryUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventoryUpdate.Image = null;
            this.btn_inventoryUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryUpdate.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_inventoryUpdate.Location = new System.Drawing.Point(866, 132);
            this.btn_inventoryUpdate.Name = "btn_inventoryUpdate";
            this.btn_inventoryUpdate.PressedBorderColor = System.Drawing.Color.White;
            this.btn_inventoryUpdate.PressedColor = System.Drawing.Color.White;
            this.btn_inventoryUpdate.Size = new System.Drawing.Size(130, 30);
            this.btn_inventoryUpdate.TabIndex = 26;
            this.btn_inventoryUpdate.Text = "UPDATE";
            this.btn_inventoryUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_inventoryUpdate.Click += new System.EventHandler(this.btn_inventoryUpdate_Click);
            // 
            // btn_inventoryClear
            // 
            this.btn_inventoryClear.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventoryClear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventoryClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventoryClear.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_inventoryClear.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_inventoryClear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventoryClear.Image = null;
            this.btn_inventoryClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryClear.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_inventoryClear.Location = new System.Drawing.Point(866, 179);
            this.btn_inventoryClear.Name = "btn_inventoryClear";
            this.btn_inventoryClear.PressedBorderColor = System.Drawing.Color.White;
            this.btn_inventoryClear.PressedColor = System.Drawing.Color.White;
            this.btn_inventoryClear.Size = new System.Drawing.Size(130, 30);
            this.btn_inventoryClear.TabIndex = 25;
            this.btn_inventoryClear.Text = "CLEAR";
            this.btn_inventoryClear.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_inventoryClear.Click += new System.EventHandler(this.btn_inventoryClear_Click);
            // 
            // btn_inventoryDelete
            // 
            this.btn_inventoryDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventoryDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventoryDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventoryDelete.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_inventoryDelete.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_inventoryDelete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventoryDelete.Image = null;
            this.btn_inventoryDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryDelete.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_inventoryDelete.Location = new System.Drawing.Point(866, 86);
            this.btn_inventoryDelete.Name = "btn_inventoryDelete";
            this.btn_inventoryDelete.PressedBorderColor = System.Drawing.Color.White;
            this.btn_inventoryDelete.PressedColor = System.Drawing.Color.White;
            this.btn_inventoryDelete.Size = new System.Drawing.Size(130, 30);
            this.btn_inventoryDelete.TabIndex = 24;
            this.btn_inventoryDelete.Text = "DELETE";
            this.btn_inventoryDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_inventoryDelete.Click += new System.EventHandler(this.btn_inventoryDelete_Click);
            // 
            // btn_inventoryAdd
            // 
            this.btn_inventoryAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventoryAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btn_inventoryAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventoryAdd.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_inventoryAdd.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_inventoryAdd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventoryAdd.Image = null;
            this.btn_inventoryAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryAdd.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_inventoryAdd.Location = new System.Drawing.Point(866, 41);
            this.btn_inventoryAdd.Name = "btn_inventoryAdd";
            this.btn_inventoryAdd.PressedBorderColor = System.Drawing.Color.White;
            this.btn_inventoryAdd.PressedColor = System.Drawing.Color.White;
            this.btn_inventoryAdd.Size = new System.Drawing.Size(130, 30);
            this.btn_inventoryAdd.TabIndex = 23;
            this.btn_inventoryAdd.Text = "ADD";
            this.btn_inventoryAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_inventoryAdd.Click += new System.EventHandler(this.btn_inventoryAdd_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_inventoryProductID;
        private System.Windows.Forms.TextBox txt_inventoryProductName;
        private System.Windows.Forms.TextBox txt_inventoryPrice;
        private System.Windows.Forms.TextBox txt_inventoryStock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Button btn_inventoryImport;
        private System.Windows.Forms.ComboBox cb_inventoryStatus;
        private System.Windows.Forms.ComboBox cb_inventoryCategory;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.Button btn_inventoryUpdate;
        private ReaLTaiizor.Controls.Button btn_inventoryClear;
        private ReaLTaiizor.Controls.Button btn_inventoryDelete;
        private ReaLTaiizor.Controls.Button btn_inventoryAdd;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_search;
        private ReaLTaiizor.Controls.Button btn_refresh;
        private ReaLTaiizor.Controls.Button btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_categoryid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dateinsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dateupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fkcategory;
    }
}