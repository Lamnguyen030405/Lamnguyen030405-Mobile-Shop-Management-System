using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
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
        }

        private void UpdateLateFees()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var bills = db.Bills
                    .Join(db.Orders, b => b.OrderID, o => o.OrderID, (b, o) => new { Bill = b, Order = o })
                    .Where(x => x.Order.DueDate != x.Order.DateOrder && x.Order.DueDate < DateTime.Now && x.Bill.Status == "Not Complete")
                    .ToList();

                foreach (var item in bills)
                {
                    int daysLate = item.Order.DueDate.HasValue
                        ? (int)Math.Floor((DateTime.Now - item.Order.DueDate.Value).TotalDays)
                        : 0;
                    double outstandingAmount = item.Bill.OutstandingAmount ?? 0;
                    double rate = item.Order.PenaltyRate ?? 0;
                    double lateFee = Math.Round(outstandingAmount * rate * daysLate / 100, 2);

                    item.Bill.LateFee = lateFee;
                }

                db.SubmitChanges();
            }
        }

        private void LoadData()
        {
            try
            {
                UpdateLateFees();
                using (var db = new MobileShopManagementDataContext())
                {
                    var result = db.vw_BillDetails.ToList();
                    dgv_bill.DataSource = result;

                    var user = db.Users.FirstOrDefault(u => u.UserID == Form1.userID);
                    if (user.Role == "Admin")
                    {
                        txt_userID.Enabled = true;
                    }
                }
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
            cb_filter.SelectedItem = "All";
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
                    DateTime dueDate = Convert.ToDateTime(row.Cells["DueDate"]?.Value ?? DateTime.Now);
                    double outStanding = Convert.ToDouble(row.Cells["OutstandingAmount"]?.Value ?? 0);
                    double lateFee = Convert.ToDouble(row.Cells["LateFee"]?.Value ?? 0);

                    txt_paymentHistory.Text = row.Cells["PaymentHistory"]?.Value?.ToString() ?? "";
                    txt_billID.TextButton = row.Cells["BillID"]?.Value?.ToString() ?? "";
                    txt_orderID.TextButton = row.Cells["OrderID"]?.Value?.ToString() ?? "";
                    txt_customerID.TextButton = customerID;
                    txt_customerName.TextButton = row.Cells["CustomerName"]?.Value?.ToString() ?? "";
                    txt_userID.TextButton = userID;
                    txt_userName.TextButton = row.Cells["Username"]?.Value?.ToString() ?? "";
                    dt_dateOrder.Text = row.Cells["DateOrder"]?.Value?.ToString() ?? "";
                    lbl_outstandingAmount.Text = "$" + outStanding.ToString() ?? "";
                    lbl_lateFee.Text = "$" + lateFee.ToString() ?? "";
                    if (lateFee > 0)
                    {
                        lbl_lateFee.ForeColor = Color.Red;
                        txt_paymentAmount.Text = (outStanding + lateFee).ToString();
                    }
                    else
                    {
                        lbl_lateFee.ForeColor = Color.Green;
                        txt_paymentAmount.Text = outStanding.ToString();
                    }

                    using (var db = new MobileShopManagementDataContext())
                    {
                        var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerID);
                        txt_customerAddr.TextButton = customer?.Address ?? "";
                        txt_customerPN.TextButton = customer?.PhoneNumber ?? "";

                        var cart = db.Carts.Where(c => c.OrderID == txt_orderID.TextButton).ToList();
                        dgv_cart.Rows.Clear();
                        foreach (var item in cart)
                        {
                            dgv_cart.Rows.Add(item.ProductName, item.Quantity);
                        }
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
            txt_billID.TextButton = "";
            txt_orderID.TextButton = "";
            txt_customerID.TextButton = "";
            txt_customerName.TextButton = "";
            txt_userID.TextButton = "";
            txt_userName.TextButton = "";
            dt_dateOrder.Value = DateTime.Now;
            txt_customerAddr.TextButton = "";
            txt_customerPN.TextButton = "";
            dgv_cart.Rows.Clear();
            cb_search.SelectedIndex = 0;
            txt_search.TextButton = "";
            txt_paymentHistory.Text = "";
        }

        public void refreshData()
        {
            LoadData();
            ClearData();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_search.TextButton))
                {
                    MessageBox.Show("Please enter a search term.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string searchText = txt_search.TextButton.Trim().ToLower();
                List<vw_BillDetail> search = new List<vw_BillDetail>();

                using (var db = new MobileShopManagementDataContext())
                {
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
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserID == Form1.userID);
                    if (user == null || user.Role != "Admin")
                    {
                        MessageBox.Show("You do not have permission to delete this bill.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(txt_billID.TextButton))
                    {
                        MessageBox.Show("Please select a bill to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (MessageBox.Show("Are you sure you want to delete this bill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                    string billID = txt_billID.TextButton;
                    string orderID = txt_orderID.TextButton;
                    string customerID = txt_customerID.TextButton;

                    var bill = db.Bills.FirstOrDefault(b => b.BillID == billID);
                    var order = db.Orders.FirstOrDefault(o => o.OrderID == orderID);
                    var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerID);

                    var carts = db.Carts.Where(c => c.OrderID == orderID).ToList();
                    foreach (var cart in carts)
                    {
                        var product = db.Products.FirstOrDefault(p => p.ProductID == cart.ProductID);
                        if (product != null)
                        {
                            product.Stock += cart.Quantity;
                        }
                        db.Carts.DeleteOnSubmit(cart);
                    }

                    if (bill != null)
                        db.Bills.DeleteOnSubmit(bill);

                    if (order != null)
                        db.Orders.DeleteOnSubmit(order);

                    //if (customer != null)
                    //    db.Customers.DeleteOnSubmit(customer);

                    db.SubmitChanges();
                }

                MessageBox.Show("Bill deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearData();
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
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserID == Form1.userID);
                    if (txt_userID.TextButton != user.UserID && user.Role != "Admin")
                    {
                        MessageBox.Show("You do not have permission to update this bill.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (txt_customerName.TextButton == null)
                    {
                        MessageBox.Show("Please enter customer name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_customerPN.TextButton == null)
                    {
                        MessageBox.Show("Please enter customer phone number!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to update this bill?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                    var bill = db.Bills.FirstOrDefault(b => b.BillID == txt_billID.TextButton);
                    if (bill != null)
                    {
                        bill.UserID = txt_userID.TextButton.Trim();
                    }
                    var customer = db.Customers.FirstOrDefault(c => c.CustomerID == txt_customerID.TextButton);
                    if (customer != null)
                    {
                        customer.CustomerName = txt_customerName.TextButton.Trim();
                        customer.PhoneNumber = txt_customerPN.TextButton.Trim();
                        customer.Address = txt_customerAddr.TextButton.Trim();
                    }
                    db.SubmitChanges();
                }

                MessageBox.Show("Bill updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_billID.TextButton))
            {
                MessageBox.Show("Please select a bill to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            r_Bill bill = new r_Bill(txt_billID.TextButton);
            bill.Show();
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<vw_BillDetail> result = new List<vw_BillDetail>();
                using (var db = new MobileShopManagementDataContext())
                {
                    if (cb_filter.SelectedItem.ToString() == "All")
                    {
                        result = db.vw_BillDetails.ToList();
                    }
                    else if (cb_filter.SelectedItem.ToString() == "Over Due")
                    {
                        result = db.vw_BillDetails.Where(x => x.DueDate != null && x.DueDate < DateTime.Now).ToList();
                    }
                    else
                    {
                        result = db.vw_BillDetails.Where(x => x.Status == cb_filter.SelectedItem.ToString()).ToList();
                    }

                    if (result.Count > 0)
                    {
                        dgv_bill.DataSource = result;
                        dgv_bill.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No matching records found.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserID == Form1.userID);
                    if (txt_userID.TextButton != user.UserID && user.Role != "Admin")
                    {
                        MessageBox.Show("You do not have permission to update this bill.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_billID.TextButton == "")
                    {
                        MessageBox.Show("Please select a bill to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (lbl_outstandingAmount.Text == "$0")
                    {
                        MessageBox.Show("This bill has been paid in full.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrEmpty(txt_paymentAmount.Text))
                    {
                        MessageBox.Show("Please enter a payment amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    double paymentAmount = Convert.ToDouble(txt_paymentAmount.Text);
                    if (paymentAmount <= 0)
                    {
                        MessageBox.Show("Payment amount must be greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to update this payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    double outstandingAmount = Convert.ToDouble(lbl_outstandingAmount.Text.Trim('$'));
                    double lateFee = Convert.ToDouble(lbl_lateFee.Text.Trim('$'));
                    if (lateFee > 0 && paymentAmount < outstandingAmount + lateFee)
                    {
                        MessageBox.Show("Payment amount must be greater than or equal to the total outstanding amount and late fee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var bill = db.Bills.FirstOrDefault(b => b.BillID == txt_billID.TextButton);
                    if (bill != null)
                    {
                        bill.OutstandingAmount = outstandingAmount - paymentAmount;
                        bill.PaymentHistory += $"\r\nPaid: ${paymentAmount} Date: {DateTime.Now} User ID: {Form1.userID}";
                        if (bill.OutstandingAmount <= 0)
                        {
                            bill.Status = "Complete";
                            bill.LateFee = 0;
                            bill.OutstandingAmount = 0;
                        }
                        db.SubmitChanges();
                    }
                    else
                    {
                        MessageBox.Show("Bill not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Payment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}