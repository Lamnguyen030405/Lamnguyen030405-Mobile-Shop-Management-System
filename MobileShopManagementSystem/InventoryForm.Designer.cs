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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.dgv_products);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1271, 422);
            this.panel1.TabIndex = 1;
            // 
            // dgv_products
            // 
            this.dgv_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(13, 36);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowHeadersWidth = 51;
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.Size = new System.Drawing.Size(1245, 373);
            this.dgv_products.TabIndex = 3;
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
    }
}