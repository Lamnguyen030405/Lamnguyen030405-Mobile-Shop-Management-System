using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShopManagementSystem.Utilities;

namespace MobileShopManagementSystem
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void displayCategories()
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    List<Category> cat = db.Categories.Where(c => c.Status == "Active").ToList();
                    if (cat.Count > 0)
                    {
                        cb_inventoryCategory.DataSource = null;
                        cb_inventoryCategory.DataSource = cat;
                        cb_inventoryCategory.DisplayMember = "CategoryName";
                        cb_inventoryCategory.ValueMember = "CategoryID";
                    }
                    else
                    {
                        cb_inventoryCategory.DataSource = null;
                        MessageBox.Show("No categories found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("E: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void updateStatus()
        //{
        //    try
        //    {
        //        using (var db = new MobileShopManagementDataContext())
        //        {
        //            var products = db.Products.ToList();
        //            foreach (var product in products)
        //            {
        //                if (product.Stock <= 0)
        //                {
        //                    product.Status = "Unavailable";
        //                }
        //                else
        //                {
        //                    product.Status = "Available";
        //                }
        //            }
        //            db.SubmitChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void updateStatus()
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    var allProducts = db.Products.ToList();
                    var allCategories = db.Categories.ToList();

                    foreach (var product in allProducts)
                    {
                        var category = allCategories.FirstOrDefault(c => c.CategoryID == product.CategoryID);

                        if (category != null && category.Status == "Inactive")
                        {
                            product.Status = "Unavailable";
                        }
                        else
                        {
                            // Nếu danh mục Active, kiểm tra tồn kho
                            product.Status = (product.Stock <= 0) ? "Unavailable" : "Available";
                        }
                    }

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string getProductID()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var allIDs = db.Products
                    .Select(p => p.ProductID)
                    .ToList();

                var maxNumber = allIDs
                    .Select(id => id.Substring(3)) // bỏ tiền tố "PID"
                    .Where(s => int.TryParse(s, out var num))
                    .Select(s => int.Parse(s))
                    .DefaultIfEmpty(0)
                    .Max();

                return $"PID{maxNumber + 1}";
            }
        }

        private void LoadData()
        {
            try
            {
                updateStatus();
                using (var db = new MobileShopManagementDataContext())
                {
                    var products = db.Products.ToList();

                    // Tạo DataTable để tùy chỉnh dữ liệu
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ProductID", typeof(string));
                    dt.Columns.Add("ProductName", typeof(string));
                    dt.Columns.Add("ImportPrice", typeof(double));
                    dt.Columns.Add("SellingPrice", typeof(double));
                    dt.Columns.Add("Discount", typeof(double));
                    dt.Columns.Add("RealPrice", typeof(double));
                    dt.Columns.Add("Description", typeof(string));
                    dt.Columns.Add("CategoryID", typeof(string));
                    dt.Columns.Add("Category", typeof(string));
                    dt.Columns.Add("Stock", typeof(int));
                    dt.Columns.Add("Status", typeof(string));
                    dt.Columns.Add("DateInsert", typeof(DateTime));
                    dt.Columns.Add("DateUpdate", typeof(DateTime));
                    dt.Columns.Add("Image", typeof(Image)); // Cột để lưu hình ảnh

                    foreach (var product in products)
                    {
                        DataRow row = dt.NewRow();
                        row["ProductID"] = product.ProductID;
                        row["ProductName"] = product.ProductName;
                        row["ImportPrice"] = product.ImportPrice;
                        row["SellingPrice"] = product.SellingPrice;
                        row["Discount"] = product.Discount;
                        row["RealPrice"] = product.RealPrice;
                        row["Description"] = product.Description;
                        row["CategoryID"] = product.CategoryID;
                        row["Category"] = product.Category;
                        row["Stock"] = product.Stock;
                        row["Status"] = product.Status;
                        row["DateInsert"] = product.DateInsert ?? DateTime.Now;
                        row["DateUpdate"] = product.DateUpdate ?? DateTime.Now;

                        // Chuyển đổi byte[] thành Image
                        if (product.Image != null && product.Image.Length > 0)
                        {
                            row["Image"] = ImageHelper.ByteArrayToImage(product.Image.ToArray());
                        }
                        else
                        {
                            row["Image"] = null;
                        }

                        dt.Rows.Add(row);
                    }

                    dgv_products.DataSource = dt;
                }
                displayCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_inventoryProductID.TextButton = getProductID();
            dgv_products.Refresh();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_search.SelectedIndex = 0;
            cb_inventoryStatus.SelectedIndex = 0;
            cb_inventoryCategory.SelectedIndex = -1;
            cb_filter.SelectedItem = "All";
            displayCategories();
        }

        private void btn_inventoryImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    this.Text = openFileDialog.FileName;
                    MessageBox.Show("Import successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearData()
        {
            txt_inventoryImportPrice.TextButton = "";
            txt_inventoryDiscount.TextButton = "";
            txt_inventoryDescription.Text = "";
            txt_inventorySellingPrice.TextButton = "";
            txt_inventoryProductName.TextButton = "";
            txt_inventoryStock.TextButton = "";
            cb_inventoryCategory.SelectedIndex = -1;
            cb_inventoryStatus.SelectedIndex = 0;
            pictureBox1.Image = null;
            txt_inventoryProductID.TextButton = getProductID();
        }

        private async void btn_inventoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(x => x.UserID == Form1.userID);
                    if (user == null || user.Role != "Admin")
                    {
                        MessageBox.Show("You do not have permission to add products", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txt_inventoryProductName.TextButton) ||
                        string.IsNullOrWhiteSpace(txt_inventoryImportPrice.TextButton) ||
                        string.IsNullOrWhiteSpace(txt_inventoryProductID.TextButton) ||
                        string.IsNullOrWhiteSpace(cb_inventoryCategory.Text) ||
                        string.IsNullOrWhiteSpace(txt_inventoryStock.TextButton) ||
                        string.IsNullOrWhiteSpace(cb_inventoryStatus.Text) ||
                        pictureBox1.Image == null ||
                        string.IsNullOrWhiteSpace(txt_inventorySellingPrice.TextButton))
                    {
                        MessageBox.Show("Please fill in all the fields marked with stars", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (db.Products.Any(x => x.ProductID == txt_inventoryProductID.TextButton))
                    {
                        MessageBox.Show("Product ID already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    double discount = 0.00;
                    if (c_Discount.Checked)
                    {
                        if (string.IsNullOrWhiteSpace(txt_inventoryDiscount.TextButton))
                        {
                            MessageBox.Show("Please fill in discount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        discount = Convert.ToDouble(txt_inventoryDiscount.TextButton.Trim().Replace("%", ""));
                        if (discount < 0 || discount > 100)
                        {
                            MessageBox.Show("Discount must be between 0% and 100%", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    double sellingPrice = Convert.ToDouble(txt_inventorySellingPrice.TextButton.Trim());
                    double importPrice = Convert.ToDouble(txt_inventoryImportPrice.TextButton.Trim());
                    int stock = Convert.ToInt32(txt_inventoryStock.TextButton.Trim());

                    if (sellingPrice <= 0)
                    {
                        MessageBox.Show("Selling price must be greater than 0", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (importPrice <= 0)
                    {
                        MessageBox.Show("Import price must be greater than 0", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (stock <= 0)
                    {
                        MessageBox.Show("Stock must be greater than 0", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (sellingPrice < importPrice)
                    {
                        MessageBox.Show("Selling price cannot be less than import price", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    byte[] imageBytes = null;
                    if (pictureBox1.Image != null)
                    {
                        Image resizedImage = ImageHelper.ResizeImage(pictureBox1.Image, 200, 200);
                        imageBytes = ImageHelper.ImageToByteArray(resizedImage);
                    }

                    Product p = new Product()
                    {
                        ProductID = txt_inventoryProductID.TextButton,
                        ProductName = txt_inventoryProductName.TextButton.Trim(),
                        ImportPrice = importPrice,
                        SellingPrice = sellingPrice,
                        Discount = discount,
                        RealPrice = sellingPrice - (sellingPrice * discount / 100),
                        Description = string.IsNullOrWhiteSpace(txt_inventoryDescription.Text) ? null : txt_inventoryDescription.Text.Trim(),
                        CategoryID = cb_inventoryCategory.SelectedValue.ToString(),
                        Category = cb_inventoryCategory.Text.Trim(),
                        Stock = stock,
                        Status = cb_inventoryStatus.Text.Trim(),
                        DateInsert = DateTime.Now,
                        DateUpdate = DateTime.Now,
                        Image = imageBytes // Lưu dưới dạng byte[]
                    };
                    db.Products.InsertOnSubmit(p);
                    await Task.Run(() => db.SubmitChanges());
                    LoadData();
                    MessageBox.Show("Product added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgv_products.Rows[e.RowIndex];
                txt_inventoryProductID.TextButton = row.Cells["col_productid"]?.Value?.ToString() ?? "";
                txt_inventoryProductName.TextButton = row.Cells["col_name"]?.Value?.ToString() ?? "";
                cb_inventoryCategory.Text = row.Cells["col_category"]?.Value?.ToString() ?? "";
                txt_inventoryStock.TextButton = row.Cells["col_stock"]?.Value?.ToString() ?? "";
                txt_inventoryImportPrice.TextButton = row.Cells["col_importprice"]?.Value?.ToString() ?? "";
                txt_inventorySellingPrice.TextButton = row.Cells["col_sellingprice"]?.Value?.ToString() ?? "";
                c_Discount.Checked = Convert.ToDouble(row.Cells["col_discount"]?.Value?.ToString() ?? "0") != 0;
                txt_inventoryDiscount.TextButton = row.Cells["col_discount"]?.Value?.ToString() ?? "";
                cb_inventoryStatus.Text = row.Cells["col_status"]?.Value?.ToString() ?? "";
                txt_inventoryDescription.Text = row.Cells["col_description"]?.Value?.ToString() ?? "";

                pictureBox1.Image = row.Cells["col_image"]?.Value as Image;
                if (pictureBox1.Image == null)
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void ReleaseImage()
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private async void btn_inventoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(x => x.UserID == Form1.userID);
                    if (user == null || user.Role != "Admin")
                    {
                        MessageBox.Show("You do not have permission to delete products", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txt_inventoryProductID.TextButton))
                    {
                        MessageBox.Show("Please select a product to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                    Product p = db.Products.FirstOrDefault(x => x.ProductID == txt_inventoryProductID.TextButton);
                    if (p == null)
                    {
                        MessageBox.Show("Product not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ReleaseImage();

                    db.Products.DeleteOnSubmit(p);
                    await Task.Run(() => db.SubmitChanges());

                }
                LoadData();
                MessageBox.Show("Product deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_inventoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(x => x.UserID == Form1.userID);
                    if (user == null || user.Role != "Admin")
                    {
                        MessageBox.Show("You do not have permission to update products", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txt_inventoryProductName.TextButton) ||
                        string.IsNullOrWhiteSpace(txt_inventoryImportPrice.TextButton) ||
                        string.IsNullOrWhiteSpace(txt_inventoryProductID.TextButton) ||
                        string.IsNullOrWhiteSpace(cb_inventoryCategory.Text) ||
                        string.IsNullOrWhiteSpace(txt_inventoryStock.TextButton) ||
                        string.IsNullOrWhiteSpace(cb_inventoryStatus.Text) ||
                        pictureBox1.Image == null ||
                        string.IsNullOrWhiteSpace(txt_inventorySellingPrice.TextButton))
                    {
                        MessageBox.Show("Please fill in all the fields marked with stars", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    double discount = 0.00;
                    if (c_Discount.Checked)
                    {
                        if (string.IsNullOrWhiteSpace(txt_inventoryDiscount.TextButton))
                        {
                            MessageBox.Show("Please fill in discount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        discount = Convert.ToDouble(txt_inventoryDiscount.TextButton.Trim().Replace("%", ""));
                        if (discount < 0 || discount > 100)
                        {
                            MessageBox.Show("Discount must be between 0% and 100%", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    double sellingPrice = Convert.ToDouble(txt_inventorySellingPrice.TextButton.Trim());
                    double importPrice = Convert.ToDouble(txt_inventoryImportPrice.TextButton.Trim());
                    int stock = Convert.ToInt32(txt_inventoryStock.TextButton.Trim());

                    if (sellingPrice <= 0)
                    {
                        MessageBox.Show("Selling price must be greater than 0", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (importPrice <= 0)
                    {
                        MessageBox.Show("Import price must be greater than 0", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (stock <= 0)
                    {
                        MessageBox.Show("Stock must be greater than 0", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (sellingPrice < importPrice)
                    {
                        MessageBox.Show("Selling price cannot be less than import price", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show("Are you sure you want to update this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                    Product p = db.Products.FirstOrDefault(x => x.ProductID == txt_inventoryProductID.TextButton);
                    if (p == null)
                    {
                        MessageBox.Show("Product not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    byte[] imageBytes = null;
                    if (pictureBox1.Image != null)
                    {
                        Image resizedImage = ImageHelper.ResizeImage(pictureBox1.Image, 200, 200);
                        imageBytes = ImageHelper.ImageToByteArray(resizedImage);
                    }

                    p.ProductName = txt_inventoryProductName.TextButton.Trim();
                    p.ImportPrice = importPrice;
                    p.SellingPrice = sellingPrice;
                    p.Discount = discount;
                    p.RealPrice = sellingPrice - (sellingPrice * discount / 100);
                    p.Description = txt_inventoryDescription.Text.Trim();
                    p.Category = cb_inventoryCategory.Text.Trim();
                    p.CategoryID = cb_inventoryCategory.SelectedValue.ToString();
                    p.Stock = stock;
                    p.Status = cb_inventoryStatus.Text.Trim();
                    p.DateUpdate = DateTime.Now;
                    p.Image = imageBytes; // Lưu dưới dạng byte[]

                    await Task.Run(() => db.SubmitChanges());
                    LoadData();
                    MessageBox.Show("Product updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_inventoryClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        public void refreshData()
        {
            clearData();
            LoadData();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_search.TextButton))
                {
                    MessageBox.Show("Please enter a product name to search", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string searchText = txt_search.TextButton.Trim().ToLower();
                List<Product> search = new List<Product>();
                using (var db = new MobileShopManagementDataContext())
                {
                    switch (cb_search.SelectedItem?.ToString())
                    {
                        case "Product ID":
                            search = db.Products
                                .Where(x => x.ProductID.ToLower().Contains(searchText))
                                .ToList();
                            break;

                        case "Product Name":
                            search = db.Products
                                .Where(x => x.ProductName.ToLower().Contains(searchText))
                                .ToList();
                            break;

                        case "Category":
                            search = db.Products
                                .Where(x => x.Category.ToLower().Contains(searchText))
                                .ToList();
                            break;
                    }

                    if (search.Count > 0)
                    {
                        // Tạo DataTable để hiển thị kết quả tìm kiếm
                        DataTable dt = new DataTable();
                        dt.Columns.Add("ProductID", typeof(string));
                        dt.Columns.Add("ProductName", typeof(string));
                        dt.Columns.Add("ImportPrice", typeof(double));
                        dt.Columns.Add("SellingPrice", typeof(double));
                        dt.Columns.Add("Discount", typeof(double));
                        dt.Columns.Add("RealPrice", typeof(double));
                        dt.Columns.Add("Description", typeof(string));
                        dt.Columns.Add("CategoryID", typeof(string));
                        dt.Columns.Add("Category", typeof(string));
                        dt.Columns.Add("Stock", typeof(int));
                        dt.Columns.Add("Status", typeof(string));
                        dt.Columns.Add("DateInsert", typeof(DateTime));
                        dt.Columns.Add("DateUpdate", typeof(DateTime));
                        dt.Columns.Add("Image", typeof(Image));

                        foreach (var product in search)
                        {
                            DataRow row = dt.NewRow();
                            row["ProductID"] = product.ProductID;
                            row["ProductName"] = product.ProductName;
                            row["ImportPrice"] = product.ImportPrice;
                            row["SellingPrice"] = product.SellingPrice;
                            row["Discount"] = product.Discount;
                            row["RealPrice"] = product.RealPrice;
                            row["Description"] = product.Description;
                            row["CategoryID"] = product.CategoryID;
                            row["Category"] = product.Category;
                            row["Stock"] = product.Stock;
                            row["Status"] = product.Status;
                            row["DateInsert"] = product.DateInsert ?? DateTime.Now;
                            row["DateUpdate"] = product.DateUpdate ?? DateTime.Now;

                            if (product.Image != null && product.Image.Length > 0)
                            {
                                row["Image"] = ImageHelper.ByteArrayToImage(product.Image.ToArray());
                            }
                            else
                            {
                                row["Image"] = null;
                            }

                            dt.Rows.Add(row);
                        }

                        dgv_products.DataSource = dt;
                        dgv_products.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No product found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void c_Discount_CheckedChanged(object sender, EventArgs e)
        {
            if (c_Discount.Checked)
            {
                txt_inventoryDiscount.Enabled = true;
                txt_inventoryDiscount.TextButton = "";
                txt_inventoryDiscount.Focus();
            }
            else
            {
                txt_inventoryDiscount.Enabled = false;
                txt_inventoryDiscount.TextButton = "0";
            }
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Product> result = new List<Product>();
                using (var db = new MobileShopManagementDataContext())
                {
                    if (cb_filter.SelectedItem.ToString() == "All")
                    {
                        refreshData();
                    }
                    else
                    {
                        result = db.Products.Where(x => x.Status == cb_filter.SelectedItem.ToString()).ToList();
                        if (result.Count > 0)
                        {
                            dgv_products.DataSource = result;
                            dgv_products.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("No matching records found.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}