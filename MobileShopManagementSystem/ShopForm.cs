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
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
        }

        MobileShopManagementDataContext db = new MobileShopManagementDataContext();

        public static string getOrderID()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var lastCartID = db.Orders
                    .OrderByDescending(c => c.OrderID)
                    .Select(c => c.OrderID)
                    .FirstOrDefault();

                if (lastCartID == null)
                {
                    return "OR0";
                }

                int numberPart = int.Parse(lastCartID.Substring(2));
                numberPart++;
                return $"OR{numberPart}";
            }
        }
        int count = 1;
        public void cardItems(string productname, string stock, string price, Image image, string productid, string category, string quantity)
        {
            var card = new CardProduct()
            {
                productName = productname,
                productStock = stock,
                productPrice = price,
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

                    if (selectedCard.productQuantity == "")
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
                        dgv_product.Rows.Add($"{count++}", selectedCard.productID, selectedCard.productName, 1, selectedCard.productPrice);
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
            foreach(DataGridViewRow row in dgv_product.Rows)
            {
                if (row.Cells["quantity"].Value != null)
                {
                    totalprice += Convert.ToDecimal(row.Cells["price"].Value) * Convert.ToInt16(row.Cells["quantity"].Value);
                }
            }
            total_price.Text = $"${totalprice:F2}";
        }

        public void LoadProducts()
        {
            try
            {
                List<Product> products = db.Products.Where(p => p.Stock > 0 && p.Status == "Available").ToList();
                flowLayoutPanel1.Controls.Clear();
                foreach (var product in products)
                {
                    cardItems(product.ProductName, product.Stock.ToString(), product.Price.ToString(), Image.FromFile(PathHelper.GetImagePath(product.Image)), product.ProductID, product.Category, "");
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
            List<Category> cat = db.Categories.Where(c => c.Status == "Active").ToList();
            if (cat.Count > 0)
            {
                foreach (Category c in cat)
                {
                    cb_shopCategory.Items.Add(c.CategoryName);
                }
            }
            cb_shopCategory.SelectedIndex = -1;
        }
        private void ShopForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        bool check = false;
        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if(dgv_product.Rows.Count == 0)
                    {
                        MessageBox.Show("Please select product", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (txt_amount.Text == "")
                    {
                        MessageBox.Show("Please enter amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (int.Parse(txt_amount.Text) == 0)
                    {
                        MessageBox.Show("Amount must be greater than 0", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    decimal getamount = Convert.ToDecimal(txt_amount.Text);
                    decimal total = Convert.ToDecimal(total_price.Text.Substring(1));

                    if (getamount < total)
                    {
                        MessageBox.Show("Amount is less than total price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        check = true;
                        change.Text = $"${getamount - total:F2}";
                    }
                    e.SuppressKeyPress = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
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
                if (check == false)
                {
                    MessageBox.Show("Please enter amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var order = new Order()
                {
                    OrderID = currentOrderID,
                    //Amount = Convert.ToDecimal(ShopForm.amount.Text),
                    //Change = Convert.ToDecimal(change.Text.Substring(1)),
                    //PaymentMethod = cb_paymentMethod.Text,
                    DateOrder = DateTime.Now,
                    TotalPrice = 0,
                    TotalQuantity = 0,
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
                PlaceOrderForm placeOrderForm = new PlaceOrderForm(currentOrderID);
                placeOrderForm.Show();
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            db = new MobileShopManagementDataContext();
            LoadProducts();
            dgv_product.Rows.Clear();
        }

        private void btn_categoryRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> products = db.Products.Where(p => p.Stock > 0 && p.Status == "Available" && p.Category == cb_shopCategory.SelectedItem.ToString()).ToList();
                flowLayoutPanel1.Controls.Clear();
                foreach (var product in products)
                {
                    cardItems(product.ProductName, product.Stock.ToString(), product.Price.ToString(), Image.FromFile(PathHelper.GetImagePath(product.Image)), product.ProductID, product.Category, "");
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
                string keyword = txt_search.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Please enter a product name to search", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var products = db.Products
                    .Where(p => p.Stock > 0 && p.Status == "Available" &&
                                p.ProductName.ToLower().Contains(keyword))
                    .ToList();

                flowLayoutPanel1.Controls.Clear();
                foreach (var product in products)
                {
                    cardItems(product.ProductName, product.Stock.ToString(), product.Price.ToString(),
                              Image.FromFile(PathHelper.GetImagePath(product.Image)), product.ProductID, product.Category, "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
