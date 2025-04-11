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

namespace MobileShopManagementSystem
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Gradient backgroundGradient = new Gradient
            {
                Dock = DockStyle.Fill,  // Phủ toàn bộ Form
                Color1 = Color.White,   // Trắng
                Color2 = Color.Navy,    // Xanh navy
                GradientMode = LinearGradientMode.Vertical
            };

            this.Controls.Add(backgroundGradient);
            backgroundGradient.SendToBack();
        }
        MobileShopManagementDataContext db = new MobileShopManagementDataContext();
        private void LoadData()
        {
            try
            {
                var result = db.vw_BillDetails.ToList();
                dgv_bill.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BillForm_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_search.SelectedIndex = 0;
        }

        private void dgv_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = dgv_bill.Rows[e.RowIndex];

                    string customerID = row.Cells["CustomerID"]?.Value?.ToString() ?? "";
                    string userID = row.Cells["UserID"]?.Value?.ToString() ?? "";
                    string status = row.Cells["Status"]?.Value?.ToString() ?? "";

                    txt_billID.Text = row.Cells["BillID"]?.Value?.ToString() ?? "";
                    txt_orderID.Text = row.Cells["OrderID"]?.Value?.ToString() ?? "";
                    txt_customerID.Text = customerID;
                    txt_customerName.Text = row.Cells["CustomerName"]?.Value?.ToString() ?? "";
                    txt_userID.Text = userID;
                    txt_userName.Text = row.Cells["Username"]?.Value?.ToString() ?? "";
                    dt_dateOrder.Text = row.Cells["DateOrder"]?.Value?.ToString() ?? "";

                    var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerID);
                    txt_customerAddr.Text = customer?.Address ?? "";
                    txt_customerPN.Text = customer?.PhoneNumber ?? "";

                    rad_notPaid.Checked = false;
                    rad_Paid.Checked = false;

                    if (status == "Not Paid")
                    {
                        rad_notPaid.Checked = true;
                    }
                    else if (status == "Paid")
                    {
                        rad_Paid.Checked = true;
                    }
                    var cart = db.Carts.Where(c => c.OrderID == txt_orderID.Text).ToList();
                    dgv_cart.Rows.Clear();
                    foreach (var item in cart)
                    {
                        dgv_cart.Rows.Add(item.ProductName, item.Quantity);
                    }
                    lbl_quantity.Text = row.Cells["totalquantity"]?.Value?.ToString() ?? "";
                    lbl_price.Text = row.Cells["totalprice"]?.Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearData()
        {
            txt_billID.Clear();
            txt_orderID.Clear();
            txt_customerID.Clear();
            txt_customerName.Clear();
            txt_userID.Clear();
            txt_userName.Clear();
            dt_dateOrder.Value = DateTime.Now;
            txt_customerAddr.Clear();
            txt_customerPN.Clear();
            rad_notPaid.Checked = true;
            rad_Paid.Checked = false;
            dgv_cart.Rows.Clear();
            cb_search.SelectedIndex = 0;
            txt_search.Clear();
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_search.Text))
                {
                    MessageBox.Show("Please enter a search term.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string searchText = txt_search.Text.Trim().ToLower();
                List<vw_BillDetail> search = new List<vw_BillDetail>();

                switch (cb_search.SelectedItem?.ToString())
                {
                    case "Bill ID":
                        search = db.vw_BillDetails
                            .Where(x => x.BillID.ToLower().Contains(searchText))  
                            .ToList();
                        break;

                    case "Customer ID":
                        search = db.vw_BillDetails
                            .Where(x => x.CustomerID.ToLower().Contains(searchText)) 
                            .ToList();
                        break;

                    case "Customer Name":
                        search = db.vw_BillDetails
                            .Where(x => x.CustomerName.ToLower().Contains(searchText))
                            .ToList();
                        break;

                    case "Order ID":
                        search = db.vw_BillDetails
                            .Where(x => x.OrderID.ToLower().Contains(searchText))
                            .ToList();
                        break;

                    case "Status":
                        search = db.vw_BillDetails
                            .Where(x => x.Status.ToLower().Contains(searchText))  
                            .ToList();
                        break;

                    case "User ID":
                        search = db.vw_BillDetails
                            .Where(x => x.UserID.ToLower().Contains(searchText)) 
                            .ToList();
                        break;

                    case "User Name":
                        search = db.vw_BillDetails
                            .Where(x => x.UserName.ToLower().Contains(searchText)) 
                            .ToList();
                        break;

                    default:
                        MessageBox.Show("Please select a valid search option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }
                if (search.Count > 0)
                {
                    dgv_bill.DataSource = search;
                    dgv_bill.Refresh();
                }
                else
                {
                    MessageBox.Show("No matching records found.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_billID.Text))
                {
                    MessageBox.Show("Please select a bill to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this bill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                var products = db.Products.ToList();
                foreach (var product in products)
                {
                    var cart = db.Carts.FirstOrDefault(c => c.ProductID == product.ProductID && c.OrderID == txt_orderID.Text);
                    if (cart != null)
                    {
                        product.Stock += cart.Quantity;
                        db.Carts.DeleteOnSubmit(cart);
                    }
                }
                var order = db.Orders.FirstOrDefault(o => o.OrderID == txt_orderID.Text);
                var customer = db.Customers.FirstOrDefault(c => c.CustomerID == txt_customerID.Text);
                if (order != null && customer != null)
                {
                    db.Customers.DeleteOnSubmit(customer);
                    db.Orders.DeleteOnSubmit(order);
                    db.SubmitChanges();
                    MessageBox.Show("Bill deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Bill not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_customerName.Text == null)
                {
                    MessageBox.Show("Please enter customer name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(txt_customerPN.Text == null)
                {
                    MessageBox.Show("Please enter customer phone number!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(MessageBox.Show("Are you sure you want to update this bill?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                var customer = db.Customers.FirstOrDefault(c => c.CustomerID == txt_customerID.Text);
                if (customer != null)
                {
                    customer.CustomerName = txt_customerName.Text.Trim();
                    customer.PhoneNumber = txt_customerPN.Text.Trim();
                    customer.Address = txt_customerAddr.Text.Trim();
                }
                var bill = db.Bills.FirstOrDefault(b => b.BillID == txt_billID.Text);
                if (bill != null)
                {
                    bill.Status = rad_notPaid.Checked ? "Not Paid" : "Paid";
                }
                var order = db.Orders.FirstOrDefault(o => o.OrderID == txt_orderID.Text);
                if (order != null)
                {
                    order.DateOrder = dt_dateOrder.Value;
                }
                db.SubmitChanges();
                MessageBox.Show("Bill updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
