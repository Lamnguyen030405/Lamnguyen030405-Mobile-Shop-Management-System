using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        //MobileShopManagementDataContext db = new MobileShopManagementDataContext();

        private void displayCategories()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                cb_inventoryCategory.Items.Clear();
                List<Category> cat = db.Categories.Where(c => c.Status == "Active").ToList();
                if (cat.Count > 0)
                {
                    cb_inventoryCategory.DataSource = cat;
                    cb_inventoryCategory.DisplayMember = "CategoryName";
                    cb_inventoryCategory.ValueMember = "CategoryID";
                }
            }
        }
        public static string getProductID()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var lastProductID = db.Products
                    .OrderByDescending(p => p.ProductID)
                    .Select(p => p.ProductID)
                    .FirstOrDefault();
                if (lastProductID == null)
                {
                    return "PID0";
                }
                int numberPart = int.Parse(lastProductID.Substring(3));
                numberPart++;
                return $"PID{numberPart}";
            }
        }
        private void LoadData()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                dgv_products.DataSource = db.Products.ToList();
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
            displayCategories();
        }

        private void btn_inventoryImport_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                string imagePath = "";

                ReleaseImage();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;
            txt_inventoryProductID.TextButton = getProductID();
        }

        private void btn_inventoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_inventoryProductName.TextButton == "" || txt_inventoryImportPrice.TextButton == "" || txt_inventoryProductID.TextButton == "" || cb_inventoryCategory.Text == ""
                    || txt_inventoryStock.TextButton == "" || cb_inventoryStatus.Text == "" || pictureBox1.Image == null || txt_inventorySellingPrice.TextButton == "")
                {
                    MessageBox.Show("Please fill in all the fields marked with stars", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    if (db.Products.Any(x => x.ProductID == txt_inventoryProductID.TextButton))
                    {
                        MessageBox.Show("Product ID already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    double discount = 0.00;
                    if (c_Discount.Checked == true)
                    {
                        if (txt_inventoryDiscount.TextButton == "")
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

                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    string relativePath = Path.Combine("product_directory", txt_inventoryProductID.TextButton.Trim() + ".jpg");
                    string path = Path.Combine(baseDirectory, relativePath);

                    string directory = Path.GetDirectoryName(relativePath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    File.Copy(pictureBox1.ImageLocation, path, true);


                    Product p = new Product()
                    {
                        ProductID = getProductID(),
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
                        Image = relativePath.Trim()
                    };
                    db.Products.InsertOnSubmit(p);
                    db.SubmitChanges();
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
                c_Discount.Checked = row.Cells["col_discount"]?.Value?.ToString() != "0" ? true : false;
                txt_inventoryDiscount.TextButton = row.Cells["col_discount"]?.Value?.ToString() ?? "";
                cb_inventoryStatus.Text = row.Cells["col_status"]?.Value?.ToString() ?? "";
                txt_inventoryDescription.Text = row.Cells["col_description"]?.Value?.ToString() ?? "";
                string relative_path = row.Cells["col_image"].Value.ToString();
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relative_path);
                try
                {
                    if (path != "")
                    {
                        var temp = Image.FromFile(path);
                        pictureBox1.Image = new Bitmap(temp); // copy image
                        temp.Dispose();
                        pictureBox1.ImageLocation = path;
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_inventoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_inventoryProductID.TextButton == "")
                {
                    MessageBox.Show("Please select a product to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    Product p = db.Products.FirstOrDefault(x => x.ProductID == txt_inventoryProductID.TextButton);
                    if (p == null)
                    {
                        MessageBox.Show("Product not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ReleaseImage();

                    if (!string.IsNullOrEmpty(p.Image) && File.Exists(p.Image))
                    {
                        try
                        {
                            File.Delete(p.Image);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to delete image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    db.Products.DeleteOnSubmit(p);
                    db.SubmitChanges();

                    LoadData();
                    MessageBox.Show("Product deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_inventoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_inventoryProductName.TextButton == "" || txt_inventoryImportPrice.TextButton == "" || txt_inventoryProductID.TextButton == "" || cb_inventoryCategory.Text == ""
                    || txt_inventoryStock.TextButton == "" || cb_inventoryStatus.Text == "" || pictureBox1.Image == null || txt_inventorySellingPrice.TextButton == "")
                {
                    MessageBox.Show("Please fill in all the fields marked with stars", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double discount = 0.00;
                if (c_Discount.Checked == true)
                {
                    if (txt_inventoryDiscount.TextButton == "")
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

                using (var db = new MobileShopManagementDataContext())
                {
                    Product p = db.Products.FirstOrDefault(x => x.ProductID == txt_inventoryProductID.TextButton);
                    if (p == null)
                    {
                        MessageBox.Show("Product not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    string relativePath = Path.Combine("product_directory", txt_inventoryProductID.TextButton.Trim() + ".jpg");
                    string path = Path.Combine(baseDirectory, relativePath);

                    if (!string.Equals(Path.GetFullPath(pictureBox1.ImageLocation), Path.GetFullPath(path), StringComparison.OrdinalIgnoreCase))
                        File.Copy(pictureBox1.ImageLocation, path, true);

                    p.Image = relativePath.Trim();


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

                    db.SubmitChanges();
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
                        dgv_products.DataSource = search;
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
    }
}