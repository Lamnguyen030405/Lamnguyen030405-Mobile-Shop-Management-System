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
        public PlaceOrderForm(string orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }
        MobileShopManagementDataContext db = new MobileShopManagementDataContext();
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            var carts = db.Carts.Where(c => c.OrderID == this.orderID).ToList();
            var order = db.Orders.FirstOrDefault(o => o.OrderID == this.orderID);
            db.Orders.DeleteOnSubmit(order);
            db.Carts.DeleteAllOnSubmit(carts);
            db.SubmitChanges();
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
                var order = db.Orders.FirstOrDefault(o => o.OrderID == this.orderID);
                var carts = db.Carts.Where(c => c.OrderID == this.orderID).ToList();
                foreach (var cart in carts)
                {
                    var product = db.Products.FirstOrDefault(p => p.ProductID == cart.ProductID);
                    if (product != null)
                    {
                        product.Stock -= cart.Quantity;
                    }
                    order.TotalPrice += cart.Quantity * cart.Price;
                    order.TotalQuantity += cart.Quantity;
                }
                if (string.IsNullOrEmpty(txt_customerName.Text.Trim()))
                {
                    MessageBox.Show("Please enter customer name.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txt_phoneNumber.Text.Trim()))
                {
                    MessageBox.Show("Please enter phone number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txt_address.Text.Trim()))
                {
                    MessageBox.Show("Please enter address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Customer customer = new Customer()
                {
                    CustomerID = getCustomerID(),
                    CustomerName = txt_customerName.Text.Trim(),
                    PhoneNumber = txt_phoneNumber.Text.Trim(),
                    Address = txt_address.Text.Trim(),
                };
                Bill bill = new Bill()
                {
                    BillID = getBillID(),
                    OrderID = this.orderID,
                    CustomerID = customer.CustomerID,
                    UserID = Form1.userID,
                    Status = "Not Paid",
                };
                db.Bills.InsertOnSubmit(bill);
                db.Customers.InsertOnSubmit(customer);
                db.SubmitChanges();
                MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PlaceOrderForm_Load(object sender, EventArgs e)
        {
            LoadCart();
            txt_customerID.Text = getCustomerID();
        }
    }
}
