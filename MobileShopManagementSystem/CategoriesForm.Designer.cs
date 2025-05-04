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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_categories = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date_insert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.cb_categoriesStatus = new ReaLTaiizor.Controls.MetroComboBox();
            this.btn_categoriesDelete = new ReaLTaiizor.Controls.Button();
            this.btn_categoriesUpdate = new ReaLTaiizor.Controls.Button();
            this.btn_categoriesClear = new ReaLTaiizor.Controls.Button();
            this.btn_categoriesAdd = new ReaLTaiizor.Controls.Button();
            this.txt_categoriesInput = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_categoriesID = new ReaLTaiizor.Controls.CyberTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.cb_search = new ReaLTaiizor.Controls.MetroComboBox();
            this.btn_refresh = new ReaLTaiizor.Controls.Button();
            this.btn_search = new ReaLTaiizor.Controls.Button();
            this.txt_search = new ReaLTaiizor.Controls.CyberTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.artanPanel3 = new ArtanComponent.ArtanPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).BeginInit();
            this.artanPanel1.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            this.artanPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_categories
            // 
            this.dgv_categories.AllowUserToAddRows = false;
            this.dgv_categories.AllowUserToDeleteRows = false;
            this.dgv_categories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_categories.BackgroundColor = System.Drawing.Color.White;
            this.dgv_categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_categories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_categories.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_categories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_categories.EnableHeadersVisualStyles = false;
            this.dgv_categories.GridColor = System.Drawing.Color.Silver;
            this.dgv_categories.Location = new System.Drawing.Point(0, 0);
            this.dgv_categories.Name = "dgv_categories";
            this.dgv_categories.ReadOnly = true;
            this.dgv_categories.RowHeadersVisible = false;
            this.dgv_categories.RowHeadersWidth = 51;
            this.dgv_categories.RowTemplate.Height = 24;
            this.dgv_categories.Size = new System.Drawing.Size(807, 608);
            this.dgv_categories.TabIndex = 7;
            this.dgv_categories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categories_CellClick);
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
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 50;
            this.artanPanel1.Controls.Add(this.cb_categoriesStatus);
            this.artanPanel1.Controls.Add(this.btn_categoriesDelete);
            this.artanPanel1.Controls.Add(this.btn_categoriesUpdate);
            this.artanPanel1.Controls.Add(this.btn_categoriesClear);
            this.artanPanel1.Controls.Add(this.btn_categoriesAdd);
            this.artanPanel1.Controls.Add(this.txt_categoriesInput);
            this.artanPanel1.Controls.Add(this.txt_categoriesID);
            this.artanPanel1.Controls.Add(this.label1);
            this.artanPanel1.Controls.Add(this.label4);
            this.artanPanel1.Controls.Add(this.label5);
            this.artanPanel1.Controls.Add(this.bigLabel1);
            this.artanPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel1.Location = new System.Drawing.Point(3, 3);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel1.Size = new System.Drawing.Size(390, 719);
            this.artanPanel1.TabIndex = 2;
            // 
            // cb_categoriesStatus
            // 
            this.cb_categoriesStatus.AllowDrop = true;
            this.cb_categoriesStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_categoriesStatus.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_categoriesStatus.BackColor = System.Drawing.Color.Transparent;
            this.cb_categoriesStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cb_categoriesStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_categoriesStatus.CausesValidation = false;
            this.cb_categoriesStatus.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_categoriesStatus.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_categoriesStatus.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_categoriesStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_categoriesStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoriesStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_categoriesStatus.FormattingEnabled = true;
            this.cb_categoriesStatus.IsDerivedStyle = true;
            this.cb_categoriesStatus.ItemHeight = 20;
            this.cb_categoriesStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cb_categoriesStatus.Location = new System.Drawing.Point(13, 344);
            this.cb_categoriesStatus.Name = "cb_categoriesStatus";
            this.cb_categoriesStatus.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_categoriesStatus.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_categoriesStatus.Size = new System.Drawing.Size(364, 26);
            this.cb_categoriesStatus.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_categoriesStatus.StyleManager = null;
            this.cb_categoriesStatus.TabIndex = 47;
            this.cb_categoriesStatus.ThemeAuthor = "Taiizor";
            this.cb_categoriesStatus.ThemeName = "MetroLight";
            // 
            // btn_categoriesDelete
            // 
            this.btn_categoriesDelete.AllowDrop = true;
            this.btn_categoriesDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_categoriesDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_categoriesDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_categoriesDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categoriesDelete.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_categoriesDelete.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_categoriesDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_categoriesDelete.Image = null;
            this.btn_categoriesDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoriesDelete.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_categoriesDelete.Location = new System.Drawing.Point(232, 413);
            this.btn_categoriesDelete.Name = "btn_categoriesDelete";
            this.btn_categoriesDelete.PressedBorderColor = System.Drawing.Color.White;
            this.btn_categoriesDelete.PressedColor = System.Drawing.Color.White;
            this.btn_categoriesDelete.Size = new System.Drawing.Size(122, 34);
            this.btn_categoriesDelete.TabIndex = 35;
            this.btn_categoriesDelete.Text = "Delete";
            this.btn_categoriesDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_categoriesDelete.Click += new System.EventHandler(this.btn_categoriesDelete_Click);
            // 
            // btn_categoriesUpdate
            // 
            this.btn_categoriesUpdate.AllowDrop = true;
            this.btn_categoriesUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_categoriesUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_categoriesUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btn_categoriesUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categoriesUpdate.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_categoriesUpdate.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_categoriesUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_categoriesUpdate.Image = null;
            this.btn_categoriesUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoriesUpdate.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_categoriesUpdate.Location = new System.Drawing.Point(232, 476);
            this.btn_categoriesUpdate.Name = "btn_categoriesUpdate";
            this.btn_categoriesUpdate.PressedBorderColor = System.Drawing.Color.White;
            this.btn_categoriesUpdate.PressedColor = System.Drawing.Color.White;
            this.btn_categoriesUpdate.Size = new System.Drawing.Size(122, 34);
            this.btn_categoriesUpdate.TabIndex = 34;
            this.btn_categoriesUpdate.Text = "Update";
            this.btn_categoriesUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_categoriesUpdate.Click += new System.EventHandler(this.btn_categoriesUpdate_Click);
            // 
            // btn_categoriesClear
            // 
            this.btn_categoriesClear.AllowDrop = true;
            this.btn_categoriesClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_categoriesClear.BackColor = System.Drawing.Color.Transparent;
            this.btn_categoriesClear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_categoriesClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categoriesClear.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_categoriesClear.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_categoriesClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_categoriesClear.Image = null;
            this.btn_categoriesClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoriesClear.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_categoriesClear.Location = new System.Drawing.Point(39, 476);
            this.btn_categoriesClear.Name = "btn_categoriesClear";
            this.btn_categoriesClear.PressedBorderColor = System.Drawing.Color.White;
            this.btn_categoriesClear.PressedColor = System.Drawing.Color.White;
            this.btn_categoriesClear.Size = new System.Drawing.Size(122, 34);
            this.btn_categoriesClear.TabIndex = 33;
            this.btn_categoriesClear.Text = "Clear";
            this.btn_categoriesClear.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_categoriesClear.Click += new System.EventHandler(this.btn_categoriesClear_Click);
            // 
            // btn_categoriesAdd
            // 
            this.btn_categoriesAdd.AllowDrop = true;
            this.btn_categoriesAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_categoriesAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_categoriesAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btn_categoriesAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_categoriesAdd.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_categoriesAdd.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_categoriesAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_categoriesAdd.Image = null;
            this.btn_categoriesAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categoriesAdd.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_categoriesAdd.Location = new System.Drawing.Point(39, 413);
            this.btn_categoriesAdd.Name = "btn_categoriesAdd";
            this.btn_categoriesAdd.PressedBorderColor = System.Drawing.Color.White;
            this.btn_categoriesAdd.PressedColor = System.Drawing.Color.White;
            this.btn_categoriesAdd.Size = new System.Drawing.Size(122, 34);
            this.btn_categoriesAdd.TabIndex = 32;
            this.btn_categoriesAdd.Text = "Add";
            this.btn_categoriesAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_categoriesAdd.Click += new System.EventHandler(this.btn_categoriesAdd_Click);
            // 
            // txt_categoriesInput
            // 
            this.txt_categoriesInput.Alpha = 20;
            this.txt_categoriesInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_categoriesInput.BackColor = System.Drawing.Color.Transparent;
            this.txt_categoriesInput.Background_WidthPen = 5F;
            this.txt_categoriesInput.BackgroundPen = true;
            this.txt_categoriesInput.ColorBackground = System.Drawing.Color.White;
            this.txt_categoriesInput.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_categoriesInput.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_categoriesInput.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_categoriesInput.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_categoriesInput.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_categoriesInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_categoriesInput.ForeColor = System.Drawing.Color.Black;
            this.txt_categoriesInput.Lighting = false;
            this.txt_categoriesInput.LinearGradientPen = true;
            this.txt_categoriesInput.Location = new System.Drawing.Point(13, 252);
            this.txt_categoriesInput.Name = "txt_categoriesInput";
            this.txt_categoriesInput.PenWidth = 15;
            this.txt_categoriesInput.RGB = false;
            this.txt_categoriesInput.Rounding = true;
            this.txt_categoriesInput.RoundingInt = 30;
            this.txt_categoriesInput.Size = new System.Drawing.Size(364, 42);
            this.txt_categoriesInput.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_categoriesInput.TabIndex = 31;
            this.txt_categoriesInput.Tag = "Cyber";
            this.txt_categoriesInput.TextButton = "";
            this.txt_categoriesInput.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_categoriesInput.Timer_RGB = 300;
            // 
            // txt_categoriesID
            // 
            this.txt_categoriesID.Alpha = 20;
            this.txt_categoriesID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_categoriesID.BackColor = System.Drawing.Color.Transparent;
            this.txt_categoriesID.Background_WidthPen = 5F;
            this.txt_categoriesID.BackgroundPen = true;
            this.txt_categoriesID.ColorBackground = System.Drawing.Color.White;
            this.txt_categoriesID.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_categoriesID.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_categoriesID.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_categoriesID.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_categoriesID.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_categoriesID.Enabled = false;
            this.txt_categoriesID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_categoriesID.ForeColor = System.Drawing.Color.Black;
            this.txt_categoriesID.Lighting = false;
            this.txt_categoriesID.LinearGradientPen = true;
            this.txt_categoriesID.Location = new System.Drawing.Point(13, 177);
            this.txt_categoriesID.Name = "txt_categoriesID";
            this.txt_categoriesID.PenWidth = 15;
            this.txt_categoriesID.RGB = false;
            this.txt_categoriesID.Rounding = true;
            this.txt_categoriesID.RoundingInt = 30;
            this.txt_categoriesID.Size = new System.Drawing.Size(364, 42);
            this.txt_categoriesID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_categoriesID.TabIndex = 30;
            this.txt_categoriesID.Tag = "Cyber";
            this.txt_categoriesID.TextButton = "";
            this.txt_categoriesID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_categoriesID.Timer_RGB = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "Category :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Category ID :";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(12, 10);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(268, 52);
            this.bigLabel1.TabIndex = 26;
            this.bigLabel1.Text = "Categories";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 50;
            this.artanPanel2.Controls.Add(this.cb_search);
            this.artanPanel2.Controls.Add(this.btn_refresh);
            this.artanPanel2.Controls.Add(this.btn_search);
            this.artanPanel2.Controls.Add(this.txt_search);
            this.artanPanel2.Controls.Add(this.label3);
            this.artanPanel2.Controls.Add(this.label2);
            this.artanPanel2.Controls.Add(this.artanPanel3);
            this.artanPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel2.Location = new System.Drawing.Point(435, 3);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel2.Size = new System.Drawing.Size(833, 719);
            this.artanPanel2.TabIndex = 3;
            // 
            // cb_search
            // 
            this.cb_search.AllowDrop = true;
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
            this.cb_search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_search.FormattingEnabled = true;
            this.cb_search.IsDerivedStyle = true;
            this.cb_search.ItemHeight = 20;
            this.cb_search.Items.AddRange(new object[] {
            "Category ID",
            "Category Name"});
            this.cb_search.Location = new System.Drawing.Point(13, 22);
            this.cb_search.Name = "cb_search";
            this.cb_search.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_search.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_search.Size = new System.Drawing.Size(176, 26);
            this.cb_search.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_search.StyleManager = null;
            this.cb_search.TabIndex = 38;
            this.cb_search.ThemeAuthor = "Taiizor";
            this.cb_search.ThemeName = "MetroLight";
            // 
            // btn_refresh
            // 
            this.btn_refresh.AllowDrop = true;
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.BorderColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_refresh.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_refresh.Image = null;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_refresh.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_refresh.Location = new System.Drawing.Point(698, 13);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.PressedBorderColor = System.Drawing.Color.White;
            this.btn_refresh.PressedColor = System.Drawing.Color.White;
            this.btn_refresh.Size = new System.Drawing.Size(122, 41);
            this.btn_refresh.TabIndex = 37;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.AllowDrop = true;
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BorderColor = System.Drawing.Color.Transparent;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_search.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_search.Image = null;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_search.Location = new System.Drawing.Point(570, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.PressedBorderColor = System.Drawing.Color.White;
            this.btn_search.PressedColor = System.Drawing.Color.White;
            this.btn_search.Size = new System.Drawing.Size(122, 42);
            this.btn_search.TabIndex = 36;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            this.txt_search.Location = new System.Drawing.Point(268, 13);
            this.txt_search.Name = "txt_search";
            this.txt_search.PenWidth = 15;
            this.txt_search.RGB = false;
            this.txt_search.Rounding = true;
            this.txt_search.RoundingInt = 30;
            this.txt_search.Size = new System.Drawing.Size(267, 42);
            this.txt_search.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_search.TabIndex = 36;
            this.txt_search.Tag = "Cyber";
            this.txt_search.TextButton = "";
            this.txt_search.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_search.Timer_RGB = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(195, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Input :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "All Categories";
            // 
            // artanPanel3
            // 
            this.artanPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel3.BackColor = System.Drawing.Color.White;
            this.artanPanel3.BorderRadius = 50;
            this.artanPanel3.Controls.Add(this.dgv_categories);
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel3.Location = new System.Drawing.Point(13, 98);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(807, 608);
            this.artanPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.15657F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.832415F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.93233F));
            this.tableLayoutPanel1.Controls.Add(this.artanPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.artanPanel2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1271, 725);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).EndInit();
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            this.artanPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date_insert;
        private ArtanComponent.ArtanPanel artanPanel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ReaLTaiizor.Controls.CyberTextBox txt_categoriesInput;
        private ReaLTaiizor.Controls.CyberTextBox txt_categoriesID;
        private ReaLTaiizor.Controls.Button btn_categoriesAdd;
        private ReaLTaiizor.Controls.Button btn_categoriesDelete;
        private ReaLTaiizor.Controls.Button btn_categoriesUpdate;
        private ReaLTaiizor.Controls.Button btn_categoriesClear;
        private System.Windows.Forms.Label label2;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ArtanComponent.ArtanPanel artanPanel3;
        private ReaLTaiizor.Controls.Button btn_refresh;
        private ReaLTaiizor.Controls.Button btn_search;
        private ReaLTaiizor.Controls.CyberTextBox txt_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.MetroComboBox cb_search;
        private ReaLTaiizor.Controls.MetroComboBox cb_categoriesStatus;
    }
}