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

        MobileShopManagementDataContext db = new MobileShopManagementDataContext();

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
            dgv_categories.DataSource = db.Categories.ToList();
            txt_categoriesID.Text = getCategoryID();
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
                if (txt_categoriesInput.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter category name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cb_categoriesStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please chose status!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(db.Categories.Any(c => c.CategoryID == txt_categoriesID.Text.Trim().ToUpper()))
                {
                    MessageBox.Show("Category ID already exists!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (db.Categories.Any(c => c.CategoryName == txt_categoriesInput.Text.Trim().ToLower()))
                {
                    MessageBox.Show("Category name already exists!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Category cat = new Category()
                {
                    CategoryID = getCategoryID(),
                    CategoryName = txt_categoriesInput.Text.Trim().ToLower(),
                    Status = cb_categoriesStatus.SelectedItem.ToString().Trim(),
                    DateInsert = DateTime.Now
                };
                db.Categories.InsertOnSubmit(cat);
                db.SubmitChanges();
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
                if (txt_categoriesInput.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter category name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(MessageBox.Show("Are you sure you want to delete this category?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                Category cat = db.Categories.FirstOrDefault(c => c.CategoryID == txt_categoriesID.Text.Trim().ToUpper());
                if (cat == null)
                {
                    MessageBox.Show("Category name does not exist!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                db.Categories.DeleteOnSubmit(cat);
                db.SubmitChanges();
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
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgv_categories.Rows[e.RowIndex];
                txt_categoriesID.Text = row.Cells[0].Value.ToString();
                txt_categoriesInput.Text = row.Cells[1].Value.ToString();
                cb_categoriesStatus.SelectedItem = row.Cells[2].Value.ToString();
            }
        }

        private void btn_categoriesUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_categoriesInput.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter category name!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this category?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                Category cat = db.Categories.FirstOrDefault(c => c.CategoryID == txt_categoriesID.Text.Trim().ToUpper());
                if (cat == null)
                {
                    MessageBox.Show("Category name does not exist!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cat.CategoryName = txt_categoriesInput.Text.Trim().ToLower();
                cat.Status = cb_categoriesStatus.SelectedItem.ToString().Trim();
                db.SubmitChanges();
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
            txt_categoriesInput.ResetText();
            cb_categoriesStatus.SelectedIndex = 0;
            txt_categoriesID.Text = getCategoryID();
        }
        private void btn_categoriesClear_Click(object sender, EventArgs e)
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
                if(string.IsNullOrEmpty(txt_search.Text))
                {
                    MessageBox.Show("Please enter search keyword!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string searchText = txt_search.Text.Trim().ToLower();
                List<Category> search = new List<Category>();

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
    }
}
