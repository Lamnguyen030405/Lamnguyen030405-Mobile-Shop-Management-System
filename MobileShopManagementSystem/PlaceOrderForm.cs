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
    public partial class PlaceOrderForm : Form
    {
        private string orderID;
        private bool partialPayment;
        private double outstandingAmount;
        private double downPayment;
        public PlaceOrderForm(string orderID, bool partialPayment, double downPayment, double outstandingAmount)
        {
            InitializeComponent();
            this.orderID = orderID;
            this.partialPayment = partialPayment;
            this.downPayment = downPayment;
            this.outstandingAmount = outstandingAmount;
        }
        //MobileShopManagementDataContext db = new MobileShopManagementDataContext();
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var carts = db.Carts.Where(c => c.OrderID == this.orderID).ToList();
                var order = db.Orders.FirstOrDefault(o => o.OrderID == this.orderID);
                db.Orders.DeleteOnSubmit(order);
                db.Carts.DeleteAllOnSubmit(carts);
                db.SubmitChanges();
            }
            this.Close();
        }
        public static string getCustomerID()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var lastCartID = db.Customers
                    .OrderByDescending(c => c.CustomerID)
                    .Select(c => c.CustomerID)
                    .FirstOrDefault();

                if (lastCartID == null)
                {
                    return "CID0";
                }

                int numberPart = int.Parse(lastCartID.Substring(3));

                numberPart++;

                return $"CID{numberPart}";
            }
        }
        public static string getBillID()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var lastBillID = db.Bills
                    .OrderByDescending(b => b.BillID)
                    .Select(b => b.BillID)
                    .FirstOrDefault();
                if (lastBillID == null)
                {
                    return "BID0";
                }
                int numberPart = int.Parse(lastBillID.Substring(3));
                numberPart++;
                return $"BID{numberPart}";
            }
        }
        private void btn_accept_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    var carts = db.Carts.Where(c => c.OrderID == this.orderID).ToList();
                    foreach (var cart in carts)
                    {
                        var product = db.Products.FirstOrDefault(p => p.ProductID == cart.ProductID);
                        if (product != null)
                        {
                            product.Stock -= cart.Quantity;
                        }
                    }
                    if (string.IsNullOrEmpty(txt_customerName.TextButton.Trim()))
                    {
                        MessageBox.Show("Please enter customer name.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrEmpty(txt_phoneNumber.TextButton.Trim()))
                    {
                        MessageBox.Show("Please enter phone number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrEmpty(txt_address.TextButton.Trim()))
                    {
                        MessageBox.Show("Please enter address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string customerID = getCustomerID();
                    using (var customerCheck = new MobileShopManagementDataContext())
                    {
                        var cus = customerCheck.Customers.FirstOrDefault(c => c.PhoneNumber == txt_phoneNumber.TextButton.Trim());
                        if (cus != null)
                        {
                            customerID = cus.CustomerID;
                        }
                        else
                        {
                            Customer customer = new Customer()
                            {
                                CustomerID = customerID,
                                CustomerName = txt_customerName.TextButton.Trim(),
                                PhoneNumber = txt_phoneNumber.TextButton.Trim(),
                                Address = txt_address.TextButton.Trim(),
                            };
                            db.Customers.InsertOnSubmit(customer);
                        }
                    }
                    string status;
                    if (this.partialPayment)
                    {
                        status = "Not Complete";
                    }
                    else
                    {
                        status = "Complete";
                    }
                    Bill bill = new Bill()
                    {
                        BillID = getBillID(),
                        OrderID = this.orderID,
                        CustomerID = customerID,
                        UserID = Form1.userID,
                        OutstandingAmount = this.outstandingAmount,
                        PaymentHistory = $"Paid : ${downPayment} Date : {DateTime.Now}",
                        LateFee = 0,
                        Status = status,
                    };
                    db.Bills.InsertOnSubmit(bill);
                    db.SubmitChanges();
                    MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCart()
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    List<Cart> carts = db.Carts.Where(c => c.OrderID == this.orderID).ToList();
                    if (carts.Count == 0)
                    {
                        MessageBox.Show("No items in the cart.", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    foreach (var cart in carts)
                    {
                        dgv_cart.Rows.Add(cart.ProductName, cart.Quantity, cart.Price);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PlaceOrderForm_Load(object sender, EventArgs e)
        {
            LoadCart();
            txt_customerID.TextButton = getCustomerID();
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
    }
}
