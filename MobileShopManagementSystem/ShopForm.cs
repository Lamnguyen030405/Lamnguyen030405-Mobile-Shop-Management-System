using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShopManagementSystem.Utilities; // Thêm namespace để sử dụng ImageHelper

namespace MobileShopManagementSystem
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
        }

        public static string getOrderID()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var lastOrderID = db.Orders
                    .OrderByDescending(c => c.OrderID)
                    .Select(c => c.OrderID)
                    .FirstOrDefault();

                if (lastOrderID == null)
                {
                    return "OID0";
                }

                int numberPart = int.Parse(lastOrderID.Substring(3));
                numberPart++;
                return $"OID{numberPart}";
            }
        }

        int count = 1;
        public void cardItems(string productname, string stock, string sellingprice, string realprice, string discount, Image image, string productid, string category, string quantity)
        {
            var card = new CardProduct()
            {
                productName = productname,
                productStock = stock,
                productSellingPrice = sellingprice,
                productRealPrice = realprice,
                productDiscount = discount,
                productImage = image,
                productID = productid,
                productCategory = category,
                productQuantity = quantity
            };

            flowLayoutPanel1.Controls.Add(card);

            card.selectCard += (s, e) =>
            {
                try
                {
                    var selectedCard = (CardProduct)s;
                    bool flag = false;

                    if (string.IsNullOrWhiteSpace(selectedCard.productQuantity))
                    {
                        MessageBox.Show("Please enter quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (int.Parse(selectedCard.productQuantity) > int.Parse(selectedCard.productStock))
                    {
                        MessageBox.Show("Quantity is greater than stock", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (int.Parse(selectedCard.productQuantity) == 0)
                    {
                        MessageBox.Show("Quantity must be greater than 0", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    foreach (DataGridViewRow row in dgv_product.Rows)
                    {
                        if (row.Cells["productid"].Value != null && row.Cells["productid"].Value.ToString() == selectedCard.productID)
                        {
                            row.Cells["quantity"].Value = selectedCard.productQuantity;
                            flag = true;
                            break;
                        }
                    }

                    if (!flag)
                    {
                        dgv_product.Rows.Add($"{count++}", selectedCard.productID, selectedCard.productName, 1, selectedCard.productRealPrice);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                updateTotalPrice();
            };
        }

        private void updateTotalPrice()
        {
            decimal totalprice = 0;
            int totalquantity = 0;
            foreach (DataGridViewRow row in dgv_product.Rows)
            {
                if (row.Cells["quantity"].Value != null)
                {
                    totalquantity += Convert.ToInt16(row.Cells["quantity"].Value);
                    totalprice += Convert.ToDecimal(row.Cells["price"].Value) * Convert.ToInt16(row.Cells["quantity"].Value);
                }
            }
            total_price.Text = $"${totalprice:F2}";
            total_quantity.Text = $"{totalquantity} items";
            txt_downPaymentAmount.Text = total_price.Text.Replace("$", "");
        }

        public void LoadProducts()
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    List<Product> products = db.Products.Where(p => p.Stock > 0 && p.Status == "Available").ToList();
                    flowLayoutPanel1.Controls.Clear();
                    foreach (var product in products)
                    {
                        Image productImage = product.Image != null && product.Image.Length > 0
                            ? ImageHelper.ByteArrayToImage(product.Image.ToArray())
                            : null;
                        cardItems(product.ProductName, product.Stock.ToString(), product.SellingPrice.ToString(), product.RealPrice.ToString(), product.Discount.ToString(), productImage, product.ProductID, product.Category, "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayCategories()
        {
            cb_shopCategory.Items.Clear();
            using (var db = new MobileShopManagementDataContext())
            {
                List<Category> cat = db.Categories.Where(c => c.Status == "Active").ToList();
                if (cat.Count > 0)
                {
                    foreach (Category c in cat)
                    {
                        cb_shopCategory.Items.Add(c.CategoryName);
                    }
                }
            }
            cb_shopCategory.SelectedIndex = -1;
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            displayCategories();
        }

        bool check = false;

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string currentOrderID = getOrderID();

                if (dgv_product.Rows.Count == 0)
                {
                    MessageBox.Show("Please select product", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (c_partialPayment.Checked)
                {
                    if (check == false)
                    {
                        MessageBox.Show("Please enter down payment", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (cb_shopTerm.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select term", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                double downPayment = Convert.ToDouble(txt_downPaymentAmount.Text.Trim());
                double remainingAmount = Convert.ToDouble(lbl_remainingAmount.Text.Trim().Replace("$", ""));
                double totalAmount = Convert.ToDouble(total_price.Text.Trim().Replace("$", ""));
                string selectedTerm = cb_shopTerm.SelectedItem?.ToString().Trim() ?? "";
                int days = 0;
                int.TryParse(selectedTerm.Replace("days", "").Trim(), out days);
                DateTime duedate = DateTime.Now.AddDays(days);
                double interestRate = 0;
                double penaltyRate = 0;
                if (selectedTerm == "30 days")
                {
                    interestRate = 5;
                    penaltyRate = 1;
                }
                else if (selectedTerm == "60 days")
                {
                    interestRate = 10;
                    penaltyRate = 0.75;
                }
                else if (selectedTerm == "90 days")
                {
                    interestRate = 15;
                    penaltyRate = 0.5;
                }
                else if (selectedTerm == "120 days")
                {
                    interestRate = 20;
                    penaltyRate = 0.25;
                }
                int totalQuantity = Convert.ToInt32(total_quantity.Text.Trim().Replace("items", ""));
                double outstandingAmount = Math.Round(remainingAmount * (1 + interestRate / 100), 2);

                using (var db = new MobileShopManagementDataContext())
                {
                    var order = new Order()
                    {
                        OrderID = currentOrderID,
                        DownPaymentAmount = downPayment,
                        RemainingAmount = remainingAmount,
                        SelectedTerm = selectedTerm,
                        InterestRate = interestRate,
                        PenaltyRate = penaltyRate,
                        DueDate = duedate,
                        DateOrder = DateTime.Now,
                        TotalPrice = totalAmount,
                        TotalQuantity = totalQuantity,
                    };
                    db.Orders.InsertOnSubmit(order);
                    db.SubmitChanges();

                    foreach (DataGridViewRow row in dgv_product.Rows)
                    {
                        Cart cart = new Cart()
                        {
                            ProductID = row.Cells["productid"].Value.ToString(),
                            Quantity = Convert.ToInt32(row.Cells["quantity"].Value),
                            ProductName = row.Cells["productname"].Value.ToString(),
                            Price = Convert.ToDouble(row.Cells["price"].Value),
                            OrderID = currentOrderID
                        };
                        db.Carts.InsertOnSubmit(cart);
                        db.SubmitChanges();
                    }
                }

                PlaceOrderForm placeOrderForm = new PlaceOrderForm(currentOrderID, c_partialPayment.Checked, downPayment, outstandingAmount);
                placeOrderForm.ShowDialog();

                btn_refresh_Click(sender, e);
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
                if (dgv_product.Rows.Count == 0)
                {
                    MessageBox.Show("Please select product", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                for (int i = dgv_product.SelectedRows.Count - 1; i >= 0; i--)
                {
                    dgv_product.Rows.RemoveAt(dgv_product.SelectedRows[i].Index);
                }
                updateTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearData()
        {
            dgv_product.Rows.Clear();
            txt_downPaymentAmount.Text = "";
            lbl_remainingAmount.Text = "$0.00";
            total_price.Text = "$0.00";
            total_quantity.Text = "0 items";
            cb_shopTerm.SelectedIndex = -1;
        }

        public void refreshData()
        {
            LoadProducts();
            clearData();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btn_categoryRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    List<Product> products = db.Products.Where(p => p.Stock > 0 && p.Status == "Available" && p.Category == cb_shopCategory.SelectedItem.ToString()).ToList();
                    flowLayoutPanel1.Controls.Clear();
                    foreach (var product in products)
                    {
                        Image productImage = product.Image != null && product.Image.Length > 0
                            ? ImageHelper.ByteArrayToImage(product.Image.ToArray())
                            : null;
                        cardItems(product.ProductName, product.Stock.ToString(), product.SellingPrice.ToString(), product.RealPrice.ToString(), product.Discount.ToString(), productImage, product.ProductID, product.Category, "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_search.TextButton.Trim().ToLower();

                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Please enter a product name to search", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new MobileShopManagementDataContext())
                {
                    var products = db.Products
                        .Where(p => p.Stock > 0 && p.Status == "Available" &&
                                    p.ProductName.ToLower().Contains(keyword))
                        .ToList();

                    flowLayoutPanel1.Controls.Clear();
                    foreach (var product in products)
                    {
                        Image productImage = product.Image != null && product.Image.Length > 0
                            ? ImageHelper.ByteArrayToImage(product.Image.ToArray())
                            : null;
                        cardItems(product.ProductName, product.Stock.ToString(), product.SellingPrice.ToString(), product.RealPrice.ToString(), product.Discount.ToString(),
                                  productImage, product.ProductID, product.Category, "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c_partialPayment_CheckedChanged()
        {
            if(c_partialPayment.Checked)
            {
                txt_downPaymentAmount.Enabled = true;
                txt_downPaymentAmount.Text = "0.0";
                cb_shopTerm.Enabled = true;
                txt_downPaymentAmount.Focus();
            }
            else
            {
                txt_downPaymentAmount.Enabled = false;
                txt_downPaymentAmount.Text = total_price.Text.Replace("$", "");
                cb_shopTerm.SelectedIndex = -1;
                cb_shopTerm.Enabled = false;
                lbl_remainingAmount.Text = "$0.00";
            }
        }

        private void txt_downPaymentAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (dgv_product.Rows.Count == 0)
                    {
                        MessageBox.Show("Please select product", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txt_downPaymentAmount.Text))
                    {
                        MessageBox.Show("Please enter down payment amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    decimal getdownpaymentamount = Convert.ToDecimal(txt_downPaymentAmount.Text);
                    decimal total = Convert.ToDecimal(total_price.Text.Substring(1));
                    if (getdownpaymentamount < 0)
                    {
                        MessageBox.Show("Down payment amount must be greater than or equal to 0", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (getdownpaymentamount > total)
                    {
                        MessageBox.Show("Down payment amount must be less than total price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        check = true;
                        lbl_remainingAmount.Text = $"${total - getdownpaymentamount:F2}";
                    }
                    e.SuppressKeyPress = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}