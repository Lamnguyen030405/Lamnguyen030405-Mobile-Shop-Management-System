using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        bool shopExpand = false;
        private void shopTransition_Tick(object sender, EventArgs e)
        {
            if (!shopExpand) 
            {
                shopContainer.Height += 5;
                if (shopContainer.Height >= 160) 
                {
                    shopContainer.Height = 160;
                    shopTransition.Stop();
                    shopExpand = true;
                }
            }
            else 
            {
                shopContainer.Height -= 5;
                if (shopContainer.Height <= 49) 
                {
                    shopContainer.Height = 49;
                    shopTransition.Stop();
                    shopExpand = false;
                }
            }
        }



        private void btn_shop_Click(object sender, EventArgs e)
        {
            shopTransition.Start();
            if (shopForm == null)
            {
                shopForm = new ShopForm();
                shopForm.FormClosed += ShopForm_FormClosed;
                shopForm.MdiParent = this;
                shopForm.Dock = DockStyle.Fill;
                shopForm.Show();
            }
            else
            {
                shopForm.Activate();
            }
        }
        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            shopForm = null;
        }

        bool slidebarExpand = true;
        private void slidebarTransition_Tick(object sender, EventArgs e)
        {
            if (slidebarExpand)
            {
                slidebar.Width -= 5;
                if(slidebar.Width <= 62)
                {
                    slidebar.Width = 62;
                    slidebarTransition.Stop();
                    slidebarExpand = false;
                }
            }
            else
            {
                slidebar.Width += 5;
                if (slidebar.Width >= 249)
                {
                    slidebar.Width = 249;
                    slidebarTransition.Stop();
                    slidebarExpand = true;
                }
            }
        }

        
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this app?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            slidebarTransition.Start();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if(dashboardForm == null)
            {
                dashboardForm = new DashboardForm();
                dashboardForm.FormClosed += DashboardForm_FormClosed;
                dashboardForm.MdiParent = this;
                dashboardForm.Dock = DockStyle.Fill;
                dashboardForm.Show();
            }
            else
            {
                dashboardForm.Activate();
            }
        }
        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboardForm = null;
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            if (billForm == null)
            {
                billForm = new BillForm();
                billForm.FormClosed += BillForm_FormClosed;
                billForm.MdiParent = this;
                billForm.Dock = DockStyle.Fill;
                billForm.Show();
            }
            else
            {
                billForm.Activate();
            }
        }
        private void BillForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            billForm = null;
        }
        private void btn_categories_Click(object sender, EventArgs e)
        {
            if (categoriesForm == null)
            {
                categoriesForm = new CategoriesForm();
                categoriesForm.FormClosed += CategoriesForm_FormClosed;
                categoriesForm.MdiParent = this;
                categoriesForm.Dock = DockStyle.Fill;
                categoriesForm.Show();
            }
            else
            {
                categoriesForm.Activate();
            }
        }
        private void CategoriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            categoriesForm = null;
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            if (inventoryForm == null)
            {
                inventoryForm = new InventoryForm();
                inventoryForm.FormClosed += InventoryForm_FormClosed;
                inventoryForm.MdiParent = this;
                inventoryForm.Dock = DockStyle.Fill;
                inventoryForm.Show();
            }
            else
            {
                inventoryForm.Activate();
            }
        }
        private void InventoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventoryForm = null;
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            if (customersForm == null)
            {
                customersForm = new CustomersForm();
                customersForm.FormClosed += CustomersForm_FormClosed;
                customersForm.MdiParent = this;
                customersForm.Dock = DockStyle.Fill;
                customersForm.Show();
            }
            else
            {
                customersForm.Activate();
            }
        }
        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            customersForm = null;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?", "Confirmation Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
