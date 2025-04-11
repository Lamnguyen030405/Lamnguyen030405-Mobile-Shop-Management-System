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
            displayCategories();
        }

        MobileShopManagementDataContext db = new MobileShopManagementDataContext();

        private void displayCategories()
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
            dgv_products.DataSource = db.Products.ToList();
            //if (dgv_products.Columns.Contains("Category1"))
            //{
            //    dgv_products.Columns.Remove("Category1");
            //}
            txt_inventoryProductID.Text = getProductID();
            dgv_products.Refresh();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_search.SelectedIndex = 0;
            cb_inventoryStatus.SelectedIndex = 0;
            cb_inventoryCategory.SelectedIndex = -1;
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
            txt_inventoryPrice.ResetText();
            txt_inventoryProductName.ResetText();
            txt_inventoryStock.ResetText();
            cb_inventoryCategory.SelectedIndex = -1;
            cb_inventoryStatus.SelectedIndex = -1;
            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;
            txt_inventoryProductID.Text = getProductID();
        }

        private void btn_inventoryAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_inventoryProductName.Text == "" || txt_inventoryPrice.Text == "" || txt_inventoryProductID.Text == "" || cb_inventoryCategory.Text == ""
                    || txt_inventoryStock.Text == "" || cb_inventoryStatus.Text == "" || pictureBox1.Image == null)
                {
                    MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (db.Products.Any(x => x.ProductID == txt_inventoryProductID.Text))
                {
                    MessageBox.Show("Product ID already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string relativePath = Path.Combine("product_directory", txt_inventoryProductID.Text.Trim() + ".jpg");
                string path = Path.Combine(baseDirectory, relativePath);

                string directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.Copy(pictureBox1.ImageLocation, path, true);

                Product p = new Product()
                {
                    ProductID = getProductID(),
                    ProductName = txt_inventoryProductName.Text.Trim(),
                    Price = Convert.ToDouble(txt_inventoryPrice.Text.Trim()),
                    CategoryID = cb_inventoryCategory.SelectedValue.ToString(),
                    Category = cb_inventoryCategory.Text.Trim(),
                    Stock = Convert.ToInt32(txt_inventoryStock.Text.Trim()),
                    Status = cb_inventoryStatus.Text.Trim(),
                    DateInsert = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    Image = path.Trim()
                };
                db.Products.InsertOnSubmit(p);
                db.SubmitChanges();
                LoadData();
                MessageBox.Show("Product added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
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
                txt_inventoryProductID.Text = row.Cells[0].Value.ToString();
                txt_inventoryProductName.Text = row.Cells[1].Value.ToString();
                cb_inventoryCategory.Text = row.Cells[3].Value.ToString();
                txt_inventoryStock.Text = row.Cells[4].Value.ToString();
                txt_inventoryPrice.Text = row.Cells[5].Value.ToString();
                cb_inventoryStatus.Text = row.Cells[6].Value.ToString();
                string path = row.Cells[7].Value.ToString();

                try
                {
                    if (path != "")
                    {
                        pictureBox1.Image = Image.FromFile(path);
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
                if (txt_inventoryProductID.Text == "")
                {
                    MessageBox.Show("Please select a product to delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                Product p = db.Products.FirstOrDefault(x => x.ProductID == txt_inventoryProductID.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_inventoryUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_inventoryProductName.Text == "" || txt_inventoryPrice.Text == "" || txt_inventoryProductID.Text == "" || cb_inventoryCategory.Text == ""
                    || txt_inventoryStock.Text == "" || cb_inventoryStatus.Text == "" || pictureBox1.Image == null)
                {
                    MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (MessageBox.Show("Are you sure you want to update this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                Product p = db.Products.FirstOrDefault(x => x.ProductID == txt_inventoryProductID.Text);
                if (p == null)
                {
                    MessageBox.Show("Product not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string relativePath = Path.Combine("product_directory", txt_inventoryProductID.Text.Trim() + ".jpg");
                string path = Path.Combine(baseDirectory, relativePath);

                File.Copy(pictureBox1.ImageLocation, path, true);

                p.Image = path.Trim();

                p.ProductName = txt_inventoryProductName.Text.Trim();
                p.Price = Convert.ToDouble(txt_inventoryPrice.Text.Trim());
                p.Category = cb_inventoryCategory.Text.Trim();
                p.CategoryID = cb_inventoryCategory.SelectedValue.ToString();
                p.Stock = Convert.ToInt32(txt_inventoryStock.Text.Trim());
                p.Status = cb_inventoryStatus.Text.Trim();
                p.DateUpdate = DateTime.Now;

                db.SubmitChanges();
                LoadData();
                MessageBox.Show("Product updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_search.Text))
                {
                    MessageBox.Show("Please enter a product name to search", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string searchText = txt_search.Text.Trim().ToLower();
                List<Product> search = new List<Product>();

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
