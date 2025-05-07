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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        //MobileShopManagementDataContext db = new MobileShopManagementDataContext();

        public static string getCategoryID()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var lastCategoryID = db.Categories
                    .OrderByDescending(c => c.CategoryID)
                    .Select(c => c.CategoryID)
                    .FirstOrDefault();
                if (lastCategoryID == null)
                {
                    return "CID0";
                }
                int numberPart = int.Parse(lastCategoryID.Substring(3));
                numberPart++;
                return $"CID{numberPart}";
            }
        }
        private void LoadData()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                dgv_categories.DataSource = db.Categories.ToList();
            }
            txt_categoriesID.TextButton = getCategoryID();
            dgv_categories.Refresh();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_categoriesStatus.SelectedIndex = 0;
            cb_search.SelectedIndex = 0;
        }

        private void btn_categoriesAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_categoriesInput.TextButton.Trim() == "")
                {
                    MessageBox.Show("Please enter category name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cb_categoriesStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please chose status!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    if (db.Categories.Any(c => c.CategoryID == txt_categoriesID.TextButton.Trim().ToUpper()))
                    {
                        MessageBox.Show("Category ID already exists!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (db.Categories.Any(c => c.CategoryName == txt_categoriesInput.TextButton.Trim().ToLower()))
                    {
                        MessageBox.Show("Category name already exists!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Category cat = new Category()
                    {
                        CategoryID = getCategoryID(),
                        CategoryName = txt_categoriesInput.TextButton.Trim().ToLower(),
                        Status = cb_categoriesStatus.SelectedItem.ToString().Trim(),
                        DateInsert = DateTime.Now
                    };
                    db.Categories.InsertOnSubmit(cat);
                    db.SubmitChanges();
                }
                LoadData();
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_categoriesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_categoriesInput.TextButton.Trim() == "")
                {
                    MessageBox.Show("Please enter category name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this category?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    Category cat = db.Categories.FirstOrDefault(c => c.CategoryID == txt_categoriesID.TextButton.Trim().ToUpper());
                    if (cat == null)
                    {
                        MessageBox.Show("Category name does not exist!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    db.Categories.DeleteOnSubmit(cat);
                    db.SubmitChanges();
                }
                LoadData();
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_categories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgv_categories.Rows[e.RowIndex];
                txt_categoriesID.TextButton = row.Cells[0].Value.ToString();
                txt_categoriesInput.TextButton = row.Cells[1].Value.ToString();
                cb_categoriesStatus.SelectedItem = row.Cells[2].Value.ToString();
            }
        }
        //private void updateStatus()
        //{
        //    try
        //    {
        //        using (var db = new MobileShopManagementDataContext())
        //        {
        //            var allProducts = db.Products.ToList();
        //            var allCategories = db.Categories.ToList();

        //            foreach (var product in allProducts)
        //            {
        //                var category = allCategories.FirstOrDefault(c => c.CategoryID == product.CategoryID);

        //                if (category != null && category.Status == "Inactive")
        //                {
        //                    product.Status = "Unavailable";
        //                }
        //                else
        //                {
        //                    // Nếu danh mục Active, kiểm tra tồn kho
        //                    product.Status = (product.Stock <= 0) ? "Unavailable" : "Available";
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

        private void btn_categoriesUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_categoriesInput.TextButton.Trim() == "")
                {
                    MessageBox.Show("Please enter category name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this category?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    Category cat = db.Categories.FirstOrDefault(c => c.CategoryID == txt_categoriesID.TextButton.Trim().ToUpper());
                    if (cat == null)
                    {
                        MessageBox.Show("Category name does not exist!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    cat.CategoryName = txt_categoriesInput.TextButton.Trim().ToLower();
                    cat.Status = cb_categoriesStatus.SelectedItem.ToString().Trim();
                    db.SubmitChanges();
                    //updateStatus();
                }
                LoadData();
                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearData()
        {
            txt_categoriesInput.TextButton = "";
            cb_categoriesStatus.SelectedIndex = 0;
            txt_categoriesID.TextButton = getCategoryID();
        }
        private void btn_categoriesClear_Click(object sender, EventArgs e)
        {
            clearData();
        }
        public void refreshData()
        {
            LoadData();
            clearData();
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
                    MessageBox.Show("Please enter search keyword!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string searchText = txt_search.TextButton.Trim().ToLower();
                List<Category> search = new List<Category>();
                using (var db = new MobileShopManagementDataContext())
                {
                    switch (cb_search.SelectedItem?.ToString())
                    {
                        case "Category ID":
                            search = db.Categories
                                .Where(x => x.CategoryID.ToLower().Contains(searchText))
                                .ToList();
                            break;

                        case "Category Name":
                            search = db.Categories
                                .Where(x => x.CategoryName.ToLower().Contains(searchText))
                                .ToList();
                            break;
                    }
                }

                if (search.Count > 0)
                {
                    dgv_categories.DataSource = search;
                    dgv_categories.Refresh();
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

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Category> result = new List<Category>();
                using (var db = new MobileShopManagementDataContext())
                {
                    if (cb_filter.SelectedItem.ToString() == "All")
                    {
                        result = db.Categories.ToList();
                    }
                    else
                    {
                        result = db.Categories.Where(x => x.Status == cb_filter.Text).ToList();
                    }

                    if (result.Count > 0)
                    {
                        dgv_categories.DataSource = result;
                        dgv_categories.Refresh();
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
    }
}
