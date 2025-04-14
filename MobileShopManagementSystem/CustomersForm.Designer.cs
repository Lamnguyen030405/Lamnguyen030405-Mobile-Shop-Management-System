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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_customerUpdate = new ReaLTaiizor.Controls.Button();
            this.btn_customerClear = new ReaLTaiizor.Controls.Button();
            this.btn_customerDelete = new ReaLTaiizor.Controls.Button();
            this.txt_customerAddress = new System.Windows.Forms.TextBox();
            this.txt_customerPN = new System.Windows.Forms.TextBox();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.txt_customerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_refresh = new ReaLTaiizor.Controls.Button();
            this.btn_search = new ReaLTaiizor.Controls.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.btn_customerUpdate);
            this.panel1.Controls.Add(this.btn_customerClear);
            this.panel1.Controls.Add(this.btn_customerDelete);
            this.panel1.Controls.Add(this.txt_customerAddress);
            this.panel1.Controls.Add(this.txt_customerPN);
            this.panel1.Controls.Add(this.txt_customerName);
            this.panel1.Controls.Add(this.txt_customerID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 221);
            this.panel1.TabIndex = 0;
            // 
            // btn_customerUpdate
            // 
            this.btn_customerUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_customerUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_customerUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btn_customerUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customerUpdate.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_customerUpdate.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_customerUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerUpdate.Image = null;
            this.btn_customerUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerUpdate.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_customerUpdate.Location = new System.Drawing.Point(1092, 82);
            this.btn_customerUpdate.Name = "btn_customerUpdate";
            this.btn_customerUpdate.PressedBorderColor = System.Drawing.Color.White;
            this.btn_customerUpdate.PressedColor = System.Drawing.Color.White;
            this.btn_customerUpdate.Size = new System.Drawing.Size(130, 30);
            this.btn_customerUpdate.TabIndex = 44;
            this.btn_customerUpdate.Text = "UPDATE";
            this.btn_customerUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_customerUpdate.Click += new System.EventHandler(this.btn_customerUpdate_Click);
            // 
            // btn_customerClear
            // 
            this.btn_customerClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_customerClear.BackColor = System.Drawing.Color.Transparent;
            this.btn_customerClear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_customerClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customerClear.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_customerClear.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_customerClear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerClear.Image = null;
            this.btn_customerClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerClear.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_customerClear.Location = new System.Drawing.Point(1092, 129);
            this.btn_customerClear.Name = "btn_customerClear";
            this.btn_customerClear.PressedBorderColor = System.Drawing.Color.White;
            this.btn_customerClear.PressedColor = System.Drawing.Color.White;
            this.btn_customerClear.Size = new System.Drawing.Size(130, 30);
            this.btn_customerClear.TabIndex = 43;
            this.btn_customerClear.Text = "CLEAR";
            this.btn_customerClear.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_customerClear.Click += new System.EventHandler(this.btn_customerClear_Click);
            // 
            // btn_customerDelete
            // 
            this.btn_customerDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_customerDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_customerDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_customerDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customerDelete.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_customerDelete.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_customerDelete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerDelete.Image = null;
            this.btn_customerDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customerDelete.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_customerDelete.Location = new System.Drawing.Point(1092, 36);
            this.btn_customerDelete.Name = "btn_customerDelete";
            this.btn_customerDelete.PressedBorderColor = System.Drawing.Color.White;
            this.btn_customerDelete.PressedColor = System.Drawing.Color.White;
            this.btn_customerDelete.Size = new System.Drawing.Size(130, 30);
            this.btn_customerDelete.TabIndex = 42;
            this.btn_customerDelete.Text = "DELETE";
            this.btn_customerDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_customerDelete.Click += new System.EventHandler(this.btn_customerDelete_Click);
            // 
            // txt_customerAddress
            // 
            this.txt_customerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerAddress.Location = new System.Drawing.Point(775, 57);
            this.txt_customerAddress.Name = "txt_customerAddress";
            this.txt_customerAddress.Size = new System.Drawing.Size(233, 22);
            this.txt_customerAddress.TabIndex = 37;
            // 
            // txt_customerPN
            // 
            this.txt_customerPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerPN.Location = new System.Drawing.Point(775, 121);
            this.txt_customerPN.Name = "txt_customerPN";
            this.txt_customerPN.Size = new System.Drawing.Size(233, 22);
            this.txt_customerPN.TabIndex = 36;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerName.Location = new System.Drawing.Point(375, 121);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(219, 22);
            this.txt_customerName.TabIndex = 35;
            // 
            // txt_customerID
            // 
            this.txt_customerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerID.Enabled = false;
            this.txt_customerID.Location = new System.Drawing.Point(375, 57);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(219, 22);
            this.txt_customerID.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(633, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Phone Number :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(633, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Address :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(225, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Customer Name :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer ID :";
            // 
            // dgv_customer
            // 
            this.dgv_customer.AllowUserToAddRows = false;
            this.dgv_customer.AllowUserToDeleteRows = false;
            this.dgv_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_customer.BackgroundColor = System.Drawing.Color.White;
            this.dgv_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
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
            this.dgv_customer.EnableHeadersVisualStyles = false;
            this.dgv_customer.Location = new System.Drawing.Point(13, 62);
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.ReadOnly = true;
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowHeadersWidth = 51;
            this.dgv_customer.RowTemplate.Height = 24;
            this.dgv_customer.Size = new System.Drawing.Size(1245, 399);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.dgv_customer);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cb_search);
            this.panel2.Location = new System.Drawing.Point(12, 263);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1271, 474);
            this.panel2.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_refresh.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_refresh.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = null;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_refresh.Location = new System.Drawing.Point(665, 16);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.PressedBorderColor = System.Drawing.Color.White;
            this.btn_refresh.PressedColor = System.Drawing.Color.White;
            this.btn_refresh.Size = new System.Drawing.Size(130, 24);
            this.btn_refresh.TabIndex = 49;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderColor = System.Drawing.Color.Transparent;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_search.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_search.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = null;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_search.Location = new System.Drawing.Point(529, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.PressedBorderColor = System.Drawing.Color.White;
            this.btn_search.PressedColor = System.Drawing.Color.White;
            this.btn_search.Size = new System.Drawing.Size(130, 24);
            this.btn_search.TabIndex = 45;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(281, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(233, 22);
            this.txt_search.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(215, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 46;
            this.label8.Text = "Input :";
            // 
            // cb_search
            // 
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Customer ID",
            "Customer Name",
            "Phone Number"});
            this.cb_search.Location = new System.Drawing.Point(13, 13);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(185, 24);
            this.cb_search.TabIndex = 47;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.Button btn_customerUpdate;
        private ReaLTaiizor.Controls.Button btn_customerClear;
        private ReaLTaiizor.Controls.Button btn_customerDelete;
        private System.Windows.Forms.TextBox txt_customerAddress;
        private System.Windows.Forms.TextBox txt_customerPN;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.TextBox txt_customerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.Button btn_refresh;
        private ReaLTaiizor.Controls.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
    }
}