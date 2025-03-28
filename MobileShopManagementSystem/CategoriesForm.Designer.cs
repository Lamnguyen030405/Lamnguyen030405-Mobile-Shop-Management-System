namespace MobileShopManagementSystem
{
    partial class CategoriesForm
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
            this.btn_categoriesUpdate = new ReaLTaiizor.Controls.Button();
            this.btn_categoriesClear = new ReaLTaiizor.Controls.Button();
            this.btn_categoriesDelete = new ReaLTaiizor.Controls.Button();
            this.btn_categoriesAdd = new ReaLTaiizor.Controls.Button();
            this.cb_categoriesStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_categoriesInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_categories = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date_insert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_categoriesID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.txt_categoriesID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_categoriesUpdate);
            this.panel1.Controls.Add(this.btn_categoriesClear);
            this.panel1.Controls.Add(this.btn_categoriesDelete);
            this.panel1.Controls.Add(this.btn_categoriesAdd);
            this.panel1.Controls.Add(this.cb_categoriesStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_categoriesInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 725);
            this.panel1.TabIndex = 0;
            // 
            // btn_categoriesUpdate
            // 
            this.btn_categoriesUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_categoriesUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_categoriesUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btn_categoriesUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categoriesUpdate.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_categoriesUpdate.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_categoriesUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categoriesUpdate.Image = null;
            this.btn_categoriesUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoriesUpdate.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_categoriesUpdate.Location = new System.Drawing.Point(213, 320);
            this.btn_categoriesUpdate.Name = "btn_categoriesUpdate";
            this.btn_categoriesUpdate.PressedBorderColor = System.Drawing.Color.White;
            this.btn_categoriesUpdate.PressedColor = System.Drawing.Color.White;
            this.btn_categoriesUpdate.Size = new System.Drawing.Size(130, 30);
            this.btn_categoriesUpdate.TabIndex = 6;
            this.btn_categoriesUpdate.Text = "UPDATE";
            this.btn_categoriesUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_categoriesUpdate.Click += new System.EventHandler(this.btn_categoriesUpdate_Click);
            // 
            // btn_categoriesClear
            // 
            this.btn_categoriesClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_categoriesClear.BackColor = System.Drawing.Color.Transparent;
            this.btn_categoriesClear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_categoriesClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categoriesClear.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_categoriesClear.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_categoriesClear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categoriesClear.Image = null;
            this.btn_categoriesClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoriesClear.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_categoriesClear.Location = new System.Drawing.Point(36, 320);
            this.btn_categoriesClear.Name = "btn_categoriesClear";
            this.btn_categoriesClear.PressedBorderColor = System.Drawing.Color.White;
            this.btn_categoriesClear.PressedColor = System.Drawing.Color.White;
            this.btn_categoriesClear.Size = new System.Drawing.Size(130, 30);
            this.btn_categoriesClear.TabIndex = 5;
            this.btn_categoriesClear.Text = "CLEAR";
            this.btn_categoriesClear.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_categoriesClear.Click += new System.EventHandler(this.btn_categoriesClear_Click);
            // 
            // btn_categoriesDelete
            // 
            this.btn_categoriesDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_categoriesDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_categoriesDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_categoriesDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categoriesDelete.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_categoriesDelete.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_categoriesDelete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categoriesDelete.Image = null;
            this.btn_categoriesDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoriesDelete.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_categoriesDelete.Location = new System.Drawing.Point(213, 238);
            this.btn_categoriesDelete.Name = "btn_categoriesDelete";
            this.btn_categoriesDelete.PressedBorderColor = System.Drawing.Color.White;
            this.btn_categoriesDelete.PressedColor = System.Drawing.Color.White;
            this.btn_categoriesDelete.Size = new System.Drawing.Size(130, 30);
            this.btn_categoriesDelete.TabIndex = 4;
            this.btn_categoriesDelete.Text = "DELETE";
            this.btn_categoriesDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_categoriesDelete.Click += new System.EventHandler(this.btn_categoriesDelete_Click);
            // 
            // btn_categoriesAdd
            // 
            this.btn_categoriesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_categoriesAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_categoriesAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btn_categoriesAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categoriesAdd.EnteredBorderColor = System.Drawing.Color.White;
            this.btn_categoriesAdd.EnteredColor = System.Drawing.Color.Aqua;
            this.btn_categoriesAdd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categoriesAdd.Image = null;
            this.btn_categoriesAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoriesAdd.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btn_categoriesAdd.Location = new System.Drawing.Point(36, 238);
            this.btn_categoriesAdd.Name = "btn_categoriesAdd";
            this.btn_categoriesAdd.PressedBorderColor = System.Drawing.Color.White;
            this.btn_categoriesAdd.PressedColor = System.Drawing.Color.White;
            this.btn_categoriesAdd.Size = new System.Drawing.Size(130, 30);
            this.btn_categoriesAdd.TabIndex = 3;
            this.btn_categoriesAdd.Text = "ADD";
            this.btn_categoriesAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_categoriesAdd.Click += new System.EventHandler(this.btn_categoriesAdd_Click);
            // 
            // cb_categoriesStatus
            // 
            this.cb_categoriesStatus.FormattingEnabled = true;
            this.cb_categoriesStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cb_categoriesStatus.Location = new System.Drawing.Point(36, 185);
            this.cb_categoriesStatus.Name = "cb_categoriesStatus";
            this.cb_categoriesStatus.Size = new System.Drawing.Size(307, 24);
            this.cb_categoriesStatus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status";
            // 
            // txt_categoriesInput
            // 
            this.txt_categoriesInput.Location = new System.Drawing.Point(36, 118);
            this.txt_categoriesInput.Name = "txt_categoriesInput";
            this.txt_categoriesInput.Size = new System.Drawing.Size(307, 22);
            this.txt_categoriesInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Categories";
            // 
            // dgv_categories
            // 
            this.dgv_categories.AllowUserToAddRows = false;
            this.dgv_categories.AllowUserToDeleteRows = false;
            this.dgv_categories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_categories.BackgroundColor = System.Drawing.Color.White;
            this.dgv_categories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_categories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_category,
            this.col_status,
            this.col_date_insert});
            this.dgv_categories.EnableHeadersVisualStyles = false;
            this.dgv_categories.Location = new System.Drawing.Point(17, 47);
            this.dgv_categories.Name = "dgv_categories";
            this.dgv_categories.ReadOnly = true;
            this.dgv_categories.RowHeadersVisible = false;
            this.dgv_categories.RowHeadersWidth = 51;
            this.dgv_categories.RowTemplate.Height = 24;
            this.dgv_categories.Size = new System.Drawing.Size(788, 665);
            this.dgv_categories.TabIndex = 7;
            this.dgv_categories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categories_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgv_categories);
            this.panel2.Location = new System.Drawing.Point(465, 12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(818, 725);
            this.panel2.TabIndex = 1;
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "CategoryID";
            this.col_id.HeaderText = "ID";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            // 
            // col_category
            // 
            this.col_category.DataPropertyName = "CategoryName";
            this.col_category.HeaderText = "Name";
            this.col_category.MinimumWidth = 6;
            this.col_category.Name = "col_category";
            this.col_category.ReadOnly = true;
            // 
            // col_status
            // 
            this.col_status.DataPropertyName = "Status";
            this.col_status.HeaderText = "Status";
            this.col_status.MinimumWidth = 6;
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // col_date_insert
            // 
            this.col_date_insert.DataPropertyName = "DateInsert";
            this.col_date_insert.HeaderText = "Date Insert";
            this.col_date_insert.MinimumWidth = 6;
            this.col_date_insert.Name = "col_date_insert";
            this.col_date_insert.ReadOnly = true;
            // 
            // txt_categoriesID
            // 
            this.txt_categoriesID.Location = new System.Drawing.Point(36, 47);
            this.txt_categoriesID.Name = "txt_categoriesID";
            this.txt_categoriesID.Size = new System.Drawing.Size(307, 22);
            this.txt_categoriesID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Category ID";
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_categories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_categoriesInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_categoriesStatus;
        private ReaLTaiizor.Controls.Button btn_categoriesUpdate;
        private ReaLTaiizor.Controls.Button btn_categoriesClear;
        private ReaLTaiizor.Controls.Button btn_categoriesDelete;
        private ReaLTaiizor.Controls.Button btn_categoriesAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date_insert;
        private System.Windows.Forms.TextBox txt_categoriesID;
        private System.Windows.Forms.Label label4;
    }
}