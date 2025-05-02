namespace MobileShopManagementSystem
{
    partial class UserForm
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
            this.txt_search = new ReaLTaiizor.Controls.CyberTextBox();
            this.cb_search = new ReaLTaiizor.Controls.MetroComboBox();
            this.artanPanel3 = new ArtanComponent.ArtanPanel();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_refresh = new ReaLTaiizor.Controls.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_userClear = new ReaLTaiizor.Controls.Button();
            this.btn_userUpdate = new ReaLTaiizor.Controls.Button();
            this.btn_userDelete = new ReaLTaiizor.Controls.Button();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.btn_search = new ReaLTaiizor.Controls.Button();
            this.txt_name = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_userID = new ReaLTaiizor.Controls.CyberTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.cb_userStatus = new ReaLTaiizor.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_userBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cb_userGender = new ReaLTaiizor.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_userPN = new ReaLTaiizor.Controls.CyberTextBox();
            this.txt_userAddress = new ReaLTaiizor.Controls.CyberTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_userRole = new ReaLTaiizor.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artanPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.artanPanel2.SuspendLayout();
            this.artanPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.txt_search.Location = new System.Drawing.Point(561, 317);
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
            "User ID",
            "User Name",
            "Phone Number"});
            this.cb_search.Location = new System.Drawing.Point(187, 322);
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
            this.artanPanel3.Controls.Add(this.dgv_user);
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel3.Location = new System.Drawing.Point(13, 41);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(1243, 261);
            this.artanPanel3.TabIndex = 7;
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.BackgroundColor = System.Drawing.Color.White;
            this.dgv_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.birthdate,
            this.datecreated,
            this.address,
            this.phonenumber,
            this.role,
            this.status,
            this.image,
            this.username,
            this.password});
            this.dgv_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_user.EnableHeadersVisualStyles = false;
            this.dgv_user.Location = new System.Drawing.Point(0, 0);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersVisible = false;
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 24;
            this.dgv_user.Size = new System.Drawing.Size(1243, 261);
            this.dgv_user.TabIndex = 22;
            this.dgv_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(22, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 28);
            this.label13.TabIndex = 46;
            this.label13.Text = "All Users :";
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
            this.btn_refresh.Location = new System.Drawing.Point(963, 323);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.PressedBorderColor = System.Drawing.Color.White;
            this.btn_refresh.PressedColor = System.Drawing.Color.White;
            this.btn_refresh.Size = new System.Drawing.Size(130, 24);
            this.btn_refresh.TabIndex = 29;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(488, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 28);
            this.label14.TabIndex = 27;
            this.label14.Text = "Input :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(223, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(223, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 28);
            this.label10.TabIndex = 42;
            this.label10.Text = "User ID :";
            // 
            // btn_userClear
            // 
            this.btn_userClear.AllowDrop = true;
            this.btn_userClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_userClear.BackColor = System.Drawing.Color.Transparent;
            this.btn_userClear.BorderColor = System.Drawing.Color.Transparent;
            this.btn_userClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userClear.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_userClear.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_userClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_userClear.Image = null;
            this.btn_userClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_userClear.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_userClear.Location = new System.Drawing.Point(747, 261);
            this.btn_userClear.Name = "btn_userClear";
            this.btn_userClear.PressedBorderColor = System.Drawing.Color.White;
            this.btn_userClear.PressedColor = System.Drawing.Color.White;
            this.btn_userClear.Size = new System.Drawing.Size(122, 34);
            this.btn_userClear.TabIndex = 40;
            this.btn_userClear.Text = "Clear";
            this.btn_userClear.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_userClear.Click += new System.EventHandler(this.btn_userClear_Click);
            // 
            // btn_userUpdate
            // 
            this.btn_userUpdate.AllowDrop = true;
            this.btn_userUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_userUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_userUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btn_userUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userUpdate.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_userUpdate.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_userUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_userUpdate.Image = null;
            this.btn_userUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_userUpdate.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_userUpdate.Location = new System.Drawing.Point(619, 260);
            this.btn_userUpdate.Name = "btn_userUpdate";
            this.btn_userUpdate.PressedBorderColor = System.Drawing.Color.White;
            this.btn_userUpdate.PressedColor = System.Drawing.Color.White;
            this.btn_userUpdate.Size = new System.Drawing.Size(122, 34);
            this.btn_userUpdate.TabIndex = 39;
            this.btn_userUpdate.Text = "Update";
            this.btn_userUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_userUpdate.Click += new System.EventHandler(this.btn_userUpdate_Click);
            // 
            // btn_userDelete
            // 
            this.btn_userDelete.AllowDrop = true;
            this.btn_userDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_userDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_userDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_userDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userDelete.EnteredBorderColor = System.Drawing.Color.Gainsboro;
            this.btn_userDelete.EnteredColor = System.Drawing.Color.Gainsboro;
            this.btn_userDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_userDelete.Image = null;
            this.btn_userDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_userDelete.InactiveColor = System.Drawing.Color.RoyalBlue;
            this.btn_userDelete.Location = new System.Drawing.Point(491, 261);
            this.btn_userDelete.Name = "btn_userDelete";
            this.btn_userDelete.PressedBorderColor = System.Drawing.Color.White;
            this.btn_userDelete.PressedColor = System.Drawing.Color.White;
            this.btn_userDelete.Size = new System.Drawing.Size(122, 34);
            this.btn_userDelete.TabIndex = 38;
            this.btn_userDelete.Text = "Delete";
            this.btn_userDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_userDelete.Click += new System.EventHandler(this.btn_userDelete_Click);
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
            this.artanPanel2.Location = new System.Drawing.Point(13, 363);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel2.Size = new System.Drawing.Size(1269, 373);
            this.artanPanel2.TabIndex = 8;
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
            this.btn_search.Location = new System.Drawing.Point(827, 323);
            this.btn_search.Name = "btn_search";
            this.btn_search.PressedBorderColor = System.Drawing.Color.White;
            this.btn_search.PressedColor = System.Drawing.Color.White;
            this.btn_search.Size = new System.Drawing.Size(130, 24);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_name
            // 
            this.txt_name.Alpha = 20;
            this.txt_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_name.Background_WidthPen = 5F;
            this.txt_name.BackgroundPen = true;
            this.txt_name.ColorBackground = System.Drawing.Color.White;
            this.txt_name.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_name.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_name.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_name.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_name.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_name.ForeColor = System.Drawing.Color.Black;
            this.txt_name.Lighting = false;
            this.txt_name.LinearGradientPen = true;
            this.txt_name.Location = new System.Drawing.Point(390, 92);
            this.txt_name.Name = "txt_name";
            this.txt_name.PenWidth = 15;
            this.txt_name.RGB = false;
            this.txt_name.Rounding = true;
            this.txt_name.RoundingInt = 30;
            this.txt_name.Size = new System.Drawing.Size(260, 42);
            this.txt_name.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_name.TabIndex = 34;
            this.txt_name.Tag = "Cyber";
            this.txt_name.TextButton = "";
            this.txt_name.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_name.Timer_RGB = 300;
            // 
            // txt_userID
            // 
            this.txt_userID.Alpha = 20;
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
            this.txt_userID.Location = new System.Drawing.Point(390, 28);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.PenWidth = 15;
            this.txt_userID.RGB = false;
            this.txt_userID.Rounding = true;
            this.txt_userID.RoundingInt = 30;
            this.txt_userID.Size = new System.Drawing.Size(260, 42);
            this.txt_userID.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_userID.TabIndex = 33;
            this.txt_userID.Tag = "Cyber";
            this.txt_userID.TextButton = "";
            this.txt_userID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_userID.Timer_RGB = 300;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(14, 9);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(125, 52);
            this.bigLabel1.TabIndex = 26;
            this.bigLabel1.Text = "User";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // artanPanel1
            // 
            this.artanPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.cb_userStatus);
            this.artanPanel1.Controls.Add(this.label6);
            this.artanPanel1.Controls.Add(this.label2);
            this.artanPanel1.Controls.Add(this.dt_userBirthDate);
            this.artanPanel1.Controls.Add(this.cb_userGender);
            this.artanPanel1.Controls.Add(this.label1);
            this.artanPanel1.Controls.Add(this.panel3);
            this.artanPanel1.Controls.Add(this.label4);
            this.artanPanel1.Controls.Add(this.label5);
            this.artanPanel1.Controls.Add(this.label10);
            this.artanPanel1.Controls.Add(this.btn_userClear);
            this.artanPanel1.Controls.Add(this.btn_userUpdate);
            this.artanPanel1.Controls.Add(this.btn_userDelete);
            this.artanPanel1.Controls.Add(this.txt_userPN);
            this.artanPanel1.Controls.Add(this.txt_userAddress);
            this.artanPanel1.Controls.Add(this.txt_name);
            this.artanPanel1.Controls.Add(this.txt_userID);
            this.artanPanel1.Controls.Add(this.bigLabel1);
            this.artanPanel1.Controls.Add(this.label11);
            this.artanPanel1.Controls.Add(this.cb_userRole);
            this.artanPanel1.Controls.Add(this.label3);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Fuchsia;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.artanPanel1.Location = new System.Drawing.Point(13, 13);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.artanPanel1.Size = new System.Drawing.Size(1269, 318);
            this.artanPanel1.TabIndex = 7;
            // 
            // cb_userStatus
            // 
            this.cb_userStatus.AllowDrop = true;
            this.cb_userStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_userStatus.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_userStatus.BackColor = System.Drawing.Color.Transparent;
            this.cb_userStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cb_userStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_userStatus.CausesValidation = false;
            this.cb_userStatus.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_userStatus.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_userStatus.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_userStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_userStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_userStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_userStatus.FormattingEnabled = true;
            this.cb_userStatus.IsDerivedStyle = true;
            this.cb_userStatus.ItemHeight = 20;
            this.cb_userStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cb_userStatus.Location = new System.Drawing.Point(852, 204);
            this.cb_userStatus.Name = "cb_userStatus";
            this.cb_userStatus.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_userStatus.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_userStatus.Size = new System.Drawing.Size(266, 26);
            this.cb_userStatus.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_userStatus.StyleManager = null;
            this.cb_userStatus.TabIndex = 55;
            this.cb_userStatus.ThemeAuthor = "Taiizor";
            this.cb_userStatus.ThemeName = "MetroLight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(693, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 28);
            this.label6.TabIndex = 54;
            this.label6.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 51;
            this.label2.Text = "Birth Date :";
            // 
            // dt_userBirthDate
            // 
            this.dt_userBirthDate.CustomFormat = "yyyy-MM-dd";
            this.dt_userBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dt_userBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_userBirthDate.Location = new System.Drawing.Point(390, 159);
            this.dt_userBirthDate.Name = "dt_userBirthDate";
            this.dt_userBirthDate.Size = new System.Drawing.Size(136, 30);
            this.dt_userBirthDate.TabIndex = 50;
            // 
            // cb_userGender
            // 
            this.cb_userGender.AllowDrop = true;
            this.cb_userGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_userGender.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_userGender.BackColor = System.Drawing.Color.Transparent;
            this.cb_userGender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cb_userGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_userGender.CausesValidation = false;
            this.cb_userGender.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_userGender.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_userGender.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_userGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_userGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_userGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_userGender.FormattingEnabled = true;
            this.cb_userGender.IsDerivedStyle = true;
            this.cb_userGender.ItemHeight = 20;
            this.cb_userGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say",
            "Other"});
            this.cb_userGender.Location = new System.Drawing.Point(390, 206);
            this.cb_userGender.Name = "cb_userGender";
            this.cb_userGender.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_userGender.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_userGender.Size = new System.Drawing.Size(260, 26);
            this.cb_userGender.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_userGender.StyleManager = null;
            this.cb_userGender.TabIndex = 47;
            this.cb_userGender.ThemeAuthor = "Taiizor";
            this.cb_userGender.ThemeName = "MetroLight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 49;
            this.label1.Text = "Gender :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(27, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 186);
            this.panel3.TabIndex = 46;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(693, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "Address :";
            // 
            // txt_userPN
            // 
            this.txt_userPN.Alpha = 20;
            this.txt_userPN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userPN.BackColor = System.Drawing.Color.Transparent;
            this.txt_userPN.Background_WidthPen = 5F;
            this.txt_userPN.BackgroundPen = true;
            this.txt_userPN.ColorBackground = System.Drawing.Color.White;
            this.txt_userPN.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_userPN.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userPN.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userPN.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userPN.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_userPN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_userPN.ForeColor = System.Drawing.Color.Black;
            this.txt_userPN.Lighting = false;
            this.txt_userPN.LinearGradientPen = true;
            this.txt_userPN.Location = new System.Drawing.Point(852, 92);
            this.txt_userPN.Name = "txt_userPN";
            this.txt_userPN.PenWidth = 15;
            this.txt_userPN.RGB = false;
            this.txt_userPN.Rounding = true;
            this.txt_userPN.RoundingInt = 30;
            this.txt_userPN.Size = new System.Drawing.Size(266, 42);
            this.txt_userPN.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_userPN.TabIndex = 36;
            this.txt_userPN.Tag = "Cyber";
            this.txt_userPN.TextButton = "";
            this.txt_userPN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_userPN.Timer_RGB = 300;
            // 
            // txt_userAddress
            // 
            this.txt_userAddress.Alpha = 20;
            this.txt_userAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userAddress.BackColor = System.Drawing.Color.Transparent;
            this.txt_userAddress.Background_WidthPen = 5F;
            this.txt_userAddress.BackgroundPen = true;
            this.txt_userAddress.ColorBackground = System.Drawing.Color.White;
            this.txt_userAddress.ColorBackground_Pen = System.Drawing.Color.Cyan;
            this.txt_userAddress.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userAddress.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userAddress.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.txt_userAddress.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.txt_userAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_userAddress.ForeColor = System.Drawing.Color.Black;
            this.txt_userAddress.Lighting = false;
            this.txt_userAddress.LinearGradientPen = true;
            this.txt_userAddress.Location = new System.Drawing.Point(852, 28);
            this.txt_userAddress.Name = "txt_userAddress";
            this.txt_userAddress.PenWidth = 15;
            this.txt_userAddress.RGB = false;
            this.txt_userAddress.Rounding = true;
            this.txt_userAddress.RoundingInt = 30;
            this.txt_userAddress.Size = new System.Drawing.Size(266, 42);
            this.txt_userAddress.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.txt_userAddress.TabIndex = 35;
            this.txt_userAddress.Tag = "Cyber";
            this.txt_userAddress.TextButton = "";
            this.txt_userAddress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.txt_userAddress.Timer_RGB = 300;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(693, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 28);
            this.label11.TabIndex = 8;
            this.label11.Text = "Phone Number :";
            // 
            // cb_userRole
            // 
            this.cb_userRole.AllowDrop = true;
            this.cb_userRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_userRole.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_userRole.BackColor = System.Drawing.Color.Transparent;
            this.cb_userRole.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cb_userRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cb_userRole.CausesValidation = false;
            this.cb_userRole.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cb_userRole.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cb_userRole.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cb_userRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_userRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_userRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_userRole.FormattingEnabled = true;
            this.cb_userRole.IsDerivedStyle = true;
            this.cb_userRole.ItemHeight = 20;
            this.cb_userRole.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cb_userRole.Location = new System.Drawing.Point(852, 157);
            this.cb_userRole.Name = "cb_userRole";
            this.cb_userRole.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cb_userRole.SelectedItemForeColor = System.Drawing.Color.White;
            this.cb_userRole.Size = new System.Drawing.Size(266, 26);
            this.cb_userRole.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cb_userRole.StyleManager = null;
            this.cb_userRole.TabIndex = 53;
            this.cb_userRole.ThemeAuthor = "Taiizor";
            this.cb_userRole.ThemeName = "MetroLight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(693, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 52;
            this.label3.Text = "Role :";
            // 
            // id
            // 
            this.id.DataPropertyName = "UserID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // birthdate
            // 
            this.birthdate.DataPropertyName = "BirthDate";
            this.birthdate.HeaderText = "Birth Date";
            this.birthdate.MinimumWidth = 6;
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            // 
            // datecreated
            // 
            this.datecreated.DataPropertyName = "DateCreated";
            this.datecreated.HeaderText = "Date Created";
            this.datecreated.MinimumWidth = 6;
            this.datecreated.Name = "datecreated";
            this.datecreated.ReadOnly = true;
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
            // role
            // 
            this.role.DataPropertyName = "Role";
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // image
            // 
            this.image.DataPropertyName = "Image";
            this.image.HeaderText = "Image";
            this.image.MinimumWidth = 6;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "Username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Visible = false;
            // 
            // password
            // 
            this.password.DataPropertyName = "Password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1295, 749);
            this.ControlBox = false;
            this.Controls.Add(this.artanPanel2);
            this.Controls.Add(this.artanPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.artanPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.CyberTextBox txt_search;
        private ReaLTaiizor.Controls.MetroComboBox cb_search;
        private ArtanComponent.ArtanPanel artanPanel3;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.Label label13;
        private ReaLTaiizor.Controls.Button btn_refresh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private ReaLTaiizor.Controls.Button btn_userClear;
        private ReaLTaiizor.Controls.Button btn_userUpdate;
        private ReaLTaiizor.Controls.Button btn_userDelete;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ReaLTaiizor.Controls.Button btn_search;
        private ReaLTaiizor.Controls.CyberTextBox txt_name;
        private ReaLTaiizor.Controls.CyberTextBox txt_userID;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ArtanComponent.ArtanPanel artanPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MetroComboBox cb_userGender;
        private System.Windows.Forms.DateTimePicker dt_userBirthDate;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.MetroComboBox cb_userStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.CyberTextBox txt_userPN;
        private ReaLTaiizor.Controls.CyberTextBox txt_userAddress;
        private System.Windows.Forms.Label label11;
        private ReaLTaiizor.Controls.MetroComboBox cb_userRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}