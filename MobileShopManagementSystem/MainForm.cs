using Microsoft.VisualBasic.ApplicationServices;
using MobileShopManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MobileShopManagementSystem
{
    public partial class MainForm : Form
    {
        DashboardForm dashboardForm;
        InventoryForm inventoryForm;
        ShopForm shopForm;
        BillForm billForm;
        CategoriesForm categoriesForm;
        CustomersForm customersForm;
        UserForm userForm;
        SettingForm settingForm;

        private bool isProfileComplete = false;

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            // Ẩn tất cả các nút chức năng ban đầu
            DisableAllButtons();
        }
        public void refreshData()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserID == Form1.userID);
                lbl_userName.Text = user.Name;
                lbl_role.Text = user.Role;
                if (user.Image != null && user.Image.Length > 0)
                {
                    pictureBox1.Image = ImageHelper.ByteArrayToImage(user.Image.ToArray());
                }
            }
        }
        public void MainForm_Load(object sender, EventArgs e)
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserID == Form1.userID);
                if (user != null)
                {
                    //if (user.Status == "Inactive")
                    //{
                    //    MessageBox.Show("Your account is inactive. Please contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    Application.Exit();
                    //}
                    if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Name) ||
                        string.IsNullOrEmpty(user.Address) || string.IsNullOrEmpty(user.PhoneNumber))
                    {
                        if (MessageBox.Show("Please complete your profile information", "Information",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            OpenSettingForm();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        isProfileComplete = true;
                        EnableAllButtons();
                        lbl_userName.Text = user.Name;
                        lbl_role.Text = user.Role;
                        if (user.Image != null && user.Image.Length > 0)
                        {
                            pictureBox1.Image = ImageHelper.ByteArrayToImage(user.Image.ToArray());
                        }
                        if (user.Role != "Admin")
                        {
                            btn_user.Enabled = false;
                            btn_dashboard.Enabled = false;
                            btn_categories.Enabled = false;
                            btn_customers.Enabled = false;
                        }
                    }
                }
            }
        }

        private void OpenSettingForm()
        {
            if (settingForm == null || settingForm.IsDisposed)
            {
                settingForm = new SettingForm();
                settingForm.FormClosed += SettingForm_FormClosed;
                settingForm.MdiParent = this;
                settingForm.Dock = DockStyle.Fill;

                settingForm.SuspendLayout();
                EventHandler loadHandler = null;
                loadHandler = (s, ev) =>
                {
                    settingForm.ResumeLayout();
                    settingForm.refreshData();
                    settingForm.Load -= loadHandler;
                };
                settingForm.Load += loadHandler;

                settingForm.Show();
            }
            else
            {
                settingForm.SuspendLayout();
                settingForm.Show();
                settingForm.BringToFront();
                settingForm.refreshData();
                settingForm.ResumeLayout();
            }
            this.SuspendLayout();
            CloseAllMdiChildren();
            this.ResumeLayout();
        }

        private void DisableAllButtons()
        {
            btn_shop.Enabled = false;
            btn_dashboard.Enabled = false;
            btn_bill.Enabled = false;
            btn_categories.Enabled = false;
            btn_inventory.Enabled = false;
            btn_customers.Enabled = false;
            btn_user.Enabled = false;
        }

        private void EnableAllButtons()
        {
            btn_shop.Enabled = true;
            btn_dashboard.Enabled = true;
            btn_bill.Enabled = true;
            btn_categories.Enabled = true;
            btn_inventory.Enabled = true;
            btn_customers.Enabled = true;
            btn_user.Enabled = true;
            btn_setting.Enabled = true;
            btn_logout.Enabled = true;

            // Ẩn các nút nếu không phải Admin
            using (var db = new MobileShopManagementDataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserID == Form1.userID);
                if (user != null && user.Role != "Admin")
                {
                    btn_user.Enabled = false;
                    btn_dashboard.Enabled = false;
                    btn_categories.Enabled = false;
                    btn_customers.Enabled = false;
                }
            }
        }

        bool shopExpand = false;
        private void shopTransition_Tick(object sender, EventArgs e)
        {
            if (!shopExpand)
            {
                shopContainer.Height += 10;
                if (shopContainer.Height >= 160)
                {
                    shopContainer.Height = 160;
                    shopTransition.Stop();
                    shopExpand = true;
                    flowLayoutPanel1.ResumeLayout();
                }
            }
            else
            {
                shopContainer.Height -= 10;
                if (shopContainer.Height <= 49)
                {
                    shopContainer.Height = 49;
                    shopTransition.Stop();
                    shopExpand = false;
                    flowLayoutPanel1.ResumeLayout();
                }
            }
        }

        private void btn_shop_Click(object sender, EventArgs e)
        {
            if (!isProfileComplete) return; // Không cho phép mở nếu chưa hoàn thành profile

            this.SuspendLayout();
            CloseAllMdiChildren();

            shopTransition.Start();
            flowLayoutPanel1.SuspendLayout();

            if (shopForm == null || shopForm.IsDisposed)
            {
                shopForm = new ShopForm();
                shopForm.FormClosed += ShopForm_FormClosed;
                shopForm.MdiParent = this;
                shopForm.Dock = DockStyle.Fill;

                shopForm.SuspendLayout();
                EventHandler loadHandler = null;
                loadHandler = (s, ev) =>
                {
                    shopForm.ResumeLayout();
                    shopForm.refreshData();
                    shopForm.Load -= loadHandler;
                };
                shopForm.Load += loadHandler;

                shopForm.Show();
            }
            else
            {
                shopForm.SuspendLayout();
                shopForm.Show();
                shopForm.BringToFront();
                shopForm.refreshData();
                shopForm.ResumeLayout();
            }

            this.ResumeLayout();
        }

        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            shopForm?.Hide();
        }

        private void CloseAllMdiChildren()
        {
            pictureBox2.Visible = false;
            foreach (Form child in this.MdiChildren)
            {
                if (child.Visible)
                {
                    child.SuspendLayout();
                    child.Hide();
                    child.ResumeLayout();
                }
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (!isProfileComplete) return; // Không cho phép mở nếu chưa hoàn thành profile

            this.SuspendLayout();
            CloseAllMdiChildren();

            if (dashboardForm == null || dashboardForm.IsDisposed)
            {
                dashboardForm = new DashboardForm();
                dashboardForm.FormClosed += DashboardForm_FormClosed;
                dashboardForm.MdiParent = this;
                dashboardForm.Dock = DockStyle.Fill;

                dashboardForm.SuspendLayout();
                EventHandler loadHandler = null;
                loadHandler = (s, ev) =>
                {
                    dashboardForm.ResumeLayout();
                    dashboardForm.refreshData();
                    dashboardForm.Load -= loadHandler;
                };
                dashboardForm.Load += loadHandler;

                dashboardForm.Show();
            }
            else
            {
                dashboardForm.SuspendLayout();
                dashboardForm.Show();
                dashboardForm.BringToFront();
                dashboardForm.refreshData();
                dashboardForm.ResumeLayout();
            }

            this.ResumeLayout();
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboardForm?.Hide();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            if (!isProfileComplete) return; // Không cho phép mở nếu chưa hoàn thành profile

            this.SuspendLayout();
            CloseAllMdiChildren();

            if (billForm == null || billForm.IsDisposed)
            {
                billForm = new BillForm();
                billForm.FormClosed += BillForm_FormClosed;
                billForm.MdiParent = this;
                billForm.Dock = DockStyle.Fill;

                billForm.SuspendLayout();
                EventHandler loadHandler = null;
                loadHandler = (s, ev) =>
                {
                    billForm.ResumeLayout();
                    billForm.refreshData();
                    billForm.Load -= loadHandler;
                };
                billForm.Load += loadHandler;

                billForm.Show();
            }
            else
            {
                billForm.SuspendLayout();
                billForm.Show();
                billForm.BringToFront();
                billForm.refreshData();
                billForm.ResumeLayout();
            }

            this.ResumeLayout();
        }

        private void BillForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            billForm?.Hide();
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            if (!isProfileComplete) return; // Không cho phép mở nếu chưa hoàn thành profile

            this.SuspendLayout();
            CloseAllMdiChildren();

            if (categoriesForm == null || categoriesForm.IsDisposed)
            {
                categoriesForm = new CategoriesForm();
                categoriesForm.FormClosed += CategoriesForm_FormClosed;
                categoriesForm.MdiParent = this;
                categoriesForm.Dock = DockStyle.Fill;

                categoriesForm.SuspendLayout();
                EventHandler loadHandler = null;
                loadHandler = (s, ev) =>
                {
                    categoriesForm.ResumeLayout();
                    categoriesForm.refreshData();
                    categoriesForm.Load -= loadHandler;
                };
                categoriesForm.Load += loadHandler;

                categoriesForm.Show();
            }
            else
            {
                categoriesForm.SuspendLayout();
                categoriesForm.Show();
                categoriesForm.BringToFront();
                categoriesForm.refreshData();
                categoriesForm.ResumeLayout();
            }

            this.ResumeLayout();
        }

        private void CategoriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            categoriesForm?.Hide();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            if (!isProfileComplete) return; // Không cho phép mở nếu chưa hoàn thành profile

            this.SuspendLayout();
            CloseAllMdiChildren();

            if (inventoryForm == null || inventoryForm.IsDisposed)
            {
                inventoryForm = new InventoryForm();
                inventoryForm.FormClosed += InventoryForm_FormClosed;
                inventoryForm.MdiParent = this;
                inventoryForm.Dock = DockStyle.Fill;

                inventoryForm.SuspendLayout();
                EventHandler loadHandler = null;
                loadHandler = (s, ev) =>
                {
                    inventoryForm.ResumeLayout();
                    inventoryForm.refreshData();
                    inventoryForm.Load -= loadHandler;
                };
                inventoryForm.Load += loadHandler;

                inventoryForm.Show();
            }
            else
            {
                inventoryForm.SuspendLayout();
                inventoryForm.Show();
                inventoryForm.BringToFront();
                inventoryForm.refreshData();
                inventoryForm.ResumeLayout();
            }

            this.ResumeLayout();
        }

        private void InventoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventoryForm?.Hide();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            if (!isProfileComplete) return; // Không cho phép mở nếu chưa hoàn thành profile

            this.SuspendLayout();
            CloseAllMdiChildren();

            if (customersForm == null || customersForm.IsDisposed)
            {
                customersForm = new CustomersForm();
                customersForm.FormClosed += CustomersForm_FormClosed;
                customersForm.MdiParent = this;
                customersForm.Dock = DockStyle.Fill;

                customersForm.SuspendLayout();
                EventHandler loadHandler = null;
                loadHandler = (s, ev) =>
                {
                    customersForm.ResumeLayout();
                    customersForm.refreshData();
                    customersForm.Load -= loadHandler;
                };
                customersForm.Load += loadHandler;

                customersForm.Show();
            }
            else
            {
                customersForm.SuspendLayout();
                customersForm.Show();
                customersForm.BringToFront();
                customersForm.refreshData();
                customersForm.ResumeLayout();
            }

            this.ResumeLayout();
        }

        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customersForm?.Hide();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            if (!isProfileComplete) return; // Không cho phép mở nếu chưa hoàn thành profile

            this.SuspendLayout();
            CloseAllMdiChildren();

            if (userForm == null || userForm.IsDisposed)
            {
                userForm = new UserForm();
                userForm.FormClosed += UserForm_FormClosed;
                userForm.MdiParent = this;
                userForm.Dock = DockStyle.Fill;

                userForm.SuspendLayout();
                EventHandler loadHandler = null;
                loadHandler = (s, ev) =>
                {
                    userForm.ResumeLayout();
                    userForm.refreshData();
                    userForm.Load -= loadHandler;
                };
                userForm.Load += loadHandler;

                userForm.Show();
            }
            else
            {
                userForm.SuspendLayout();
                userForm.Show();
                userForm.BringToFront();
                userForm.refreshData();
                userForm.ResumeLayout();
            }

            this.ResumeLayout();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            userForm?.Hide();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {

            this.SuspendLayout();
            CloseAllMdiChildren();

            if (settingForm == null || settingForm.IsDisposed)
            {
                settingForm = new SettingForm();
                settingForm.FormClosed += SettingForm_FormClosed;
                settingForm.MdiParent = this;
                settingForm.Dock = DockStyle.Fill;

                settingForm.SuspendLayout();
                EventHandler loadHandler = null;
                loadHandler = (s, ev) =>
                {
                    settingForm.ResumeLayout();
                    settingForm.refreshData();
                    settingForm.Load -= loadHandler;
                };
                settingForm.Load += loadHandler;

                settingForm.Show();
            }
            else
            {
                settingForm.SuspendLayout();
                settingForm.Show();
                settingForm.BringToFront();
                settingForm.refreshData();
                settingForm.ResumeLayout();
            }

            this.ResumeLayout();
        }

        private void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingForm?.Hide();
            // Kiểm tra lại thông tin cá nhân sau khi đóng SettingForm
            using (var db = new MobileShopManagementDataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserID == Form1.userID);
                if (user != null && !string.IsNullOrEmpty(user.Email) && !string.IsNullOrEmpty(user.Name) &&
                    !string.IsNullOrEmpty(user.Address) && !string.IsNullOrEmpty(user.PhoneNumber))
                {
                    isProfileComplete = true;
                    EnableAllButtons();
                    lbl_userName.Text = user.Name;
                    lbl_role.Text = user.Role;
                    if (user.Image != null && user.Image.Length > 0)
                    {
                        pictureBox1.Image = ImageHelper.ByteArrayToImage(user.Image.ToArray());
                    }
                    if (user.Role != "Admin")
                    {
                        btn_user.Visible = false;
                        btn_dashboard.Visible = false;
                        btn_categories.Visible = false;
                    }
                }
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void titlepanel_MouseDown(object sender, MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void titlepanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            slidebar.SuspendLayout();
            foreach (Form child in this.MdiChildren)
            {
                if (child.Visible)
                    child.SuspendLayout();
            }
            refreshData();
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            CloseAllMdiChildren();
            pictureBox2.Visible = !pictureBox2.Visible;
            this.ResumeLayout();
        }

        private void slidebar_OnCollapsedStateChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Collapsed state changed: " + slidebar.Collapsed);
            cyberGroupBox1.Visible = !cyberGroupBox1.Visible;
            foreach (Form child in this.MdiChildren)
            {
                if (child.Visible)
                    child.ResumeLayout();
            }
            slidebar.ResumeLayout();
        }
    }
}