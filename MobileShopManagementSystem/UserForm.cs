using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShopManagementSystem.Utilities;

namespace MobileShopManagementSystem
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    var users = db.Users.ToList();

                    // Tạo DataTable để tùy chỉnh dữ liệu
                    DataTable dt = new DataTable();
                    dt.Columns.Add("UserId", typeof(string));
                    dt.Columns.Add("name", typeof(string));
                    dt.Columns.Add("birthdate", typeof(DateTime));
                    dt.Columns.Add("datecreated", typeof(DateTime));
                    dt.Columns.Add("address", typeof(string));
                    dt.Columns.Add("phonenumber", typeof(string));
                    dt.Columns.Add("gender", typeof(string));
                    dt.Columns.Add("role", typeof(string));
                    dt.Columns.Add("status", typeof(string));
                    dt.Columns.Add("image", typeof(Image)); // Cột để lưu hình ảnh
                    dt.Columns.Add("username", typeof(string));
                    dt.Columns.Add("password", typeof(string));
                    dt.Columns.Add("salary", typeof(string));
                    dt.Columns.Add("email", typeof(string));

                    foreach (var user in users)
                    {
                        DataRow row = dt.NewRow();
                        row["UserId"] = user.UserID;
                        row["name"] = user.Name;
                        row["birthdate"] = user.BirthDate ?? DateTime.Now;
                        row["datecreated"] = user.DateCreated ?? DateTime.Now;
                        row["address"] = user.Address;
                        row["phonenumber"] = user.PhoneNumber;
                        row["gender"] = user.Gender;
                        row["role"] = user.Role;
                        row["status"] = user.Status;
                        row["username"] = user.Username;
                        row["password"] = user.Password;
                        row["salary"] = user.Salary;
                        row["email"] = user.Email;

                        // Chuyển đổi byte[] thành Image
                        if (user.Image != null && user.Image.Length > 0)
                        {
                            row["image"] = ImageHelper.ByteArrayToImage(user.Image.ToArray());
                        }
                        else
                        {
                            row["image"] = null; // Hoặc một hình ảnh mặc định
                        }

                        dt.Rows.Add(row);
                    }

                    // Gán DataTable vào DataGridView
                    dgv_user.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_search.SelectedIndex = 0;
            cb_userGender.SelectedIndex = 0;
            cb_userRole.SelectedIndex = 0;
            cb_userStatus.SelectedIndex = 0;
        }
        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = dgv_user.Rows[e.RowIndex];
                    txt_userID.TextButton = row.Cells["id"]?.Value?.ToString() ?? "";
                    txt_name.TextButton = row.Cells["name"]?.Value?.ToString() ?? "";
                    txt_userAddress.TextButton = row.Cells["address"]?.Value?.ToString() ?? "";
                    txt_userPN.TextButton = row.Cells["phonenumber"]?.Value?.ToString() ?? "";
                    cb_userGender.Text = row.Cells["gender"]?.Value?.ToString() ?? "";
                    cb_userRole.Text = row.Cells["role"]?.Value?.ToString() ?? "";
                    cb_userStatus.Text = row.Cells["status"]?.Value?.ToString() ?? "";
                    dt_userBirthDate.Text = row.Cells["birthdate"]?.Value?.ToString() ?? "";
                    pictureBox1.Image = row.Cells["image"]?.Value as Image;
                    if (pictureBox1.Image == null)
                    {
                        pictureBox1.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearData()
        {
            txt_userID.TextButton = "";
            txt_name.TextButton = "";
            txt_userAddress.TextButton = "";
            txt_userPN.TextButton = "";
            cb_userGender.SelectedIndex = -1;
            cb_userRole.SelectedIndex = -1;
            cb_userStatus.SelectedIndex = -1;
            dt_userBirthDate.Value = DateTime.Now;
            txt_search.TextButton = "";
            txt_search.Focus();
        }
        private void btn_userDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_userID.TextButton))
                {
                    MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserID == txt_userID.TextButton);
                    if (user != null)
                    {
                        db.Users.DeleteOnSubmit(user);
                        db.SubmitChanges();
                        LoadData();
                        clearData();
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_userUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_userID.TextButton))
                {
                    MessageBox.Show("Please select a user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this customer?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserID == txt_userID.TextButton);
                    if (user != null)
                    {
                        user.Status = cb_userStatus.Text;
                        user.Name = txt_name.TextButton;
                        user.Address = txt_userAddress.TextButton;
                        user.PhoneNumber = txt_userPN.TextButton;
                        user.BirthDate = dt_userBirthDate.Value;
                        user.Role = cb_userRole.Text;
                        user.Gender = cb_userGender.Text;
                        user.Salary = Convert.ToDouble(txt_userSalary.TextButton);
                        user.Email = txt_userEmail.TextButton;
                        db.SubmitChanges();
                        LoadData();
                        clearData();
                        MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_userClear_Click(object sender, EventArgs e)
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
                if (string.IsNullOrEmpty(txt_search.TextButton.Trim()))
                {
                    MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string searchText = txt_search.TextButton.Trim().ToLower();
                List<User> search = new List<User>();
                using (var db = new MobileShopManagementDataContext())
                {
                    switch (cb_search.SelectedItem?.ToString())
                    {
                        case "User ID":
                            search = db.Users
                                .Where(x => x.UserID.ToLower().Contains(searchText))
                                .ToList();
                            break;

                        case "User Name":
                            search = db.Users
                                .Where(x => x.Name.ToLower().Contains(searchText))
                                .ToList();
                            break;

                        case "Phone Number":
                            search = db.Users
                                .Where(x => x.PhoneNumber.ToLower().Contains(searchText))
                                .ToList();
                            break;
                    }

                    if (search.Count > 0)
                    {
                        // Tạo DataTable để tùy chỉnh dữ liệu
                        DataTable dt = new DataTable();
                        dt.Columns.Add("UserId", typeof(string));
                        dt.Columns.Add("name", typeof(string));
                        dt.Columns.Add("birthdate", typeof(DateTime));
                        dt.Columns.Add("datecreated", typeof(DateTime));
                        dt.Columns.Add("address", typeof(string));
                        dt.Columns.Add("phonenumber", typeof(string));
                        dt.Columns.Add("gender", typeof(string));
                        dt.Columns.Add("role", typeof(string));
                        dt.Columns.Add("status", typeof(string));
                        dt.Columns.Add("image", typeof(Image)); // Cột để lưu hình ảnh
                        dt.Columns.Add("username", typeof(string));
                        dt.Columns.Add("password", typeof(string));
                        dt.Columns.Add("salary", typeof(string));
                        dt.Columns.Add("email", typeof(string));

                        foreach (var user in search)
                        {
                            DataRow row = dt.NewRow();
                            row["UserId"] = user.UserID;
                            row["name"] = user.Name;
                            row["birthdate"] = user.BirthDate ?? DateTime.Now;
                            row["datecreated"] = user.DateCreated ?? DateTime.Now;
                            row["address"] = user.Address;
                            row["phonenumber"] = user.PhoneNumber;
                            row["gender"] = user.Gender;
                            row["role"] = user.Role;
                            row["status"] = user.Status;
                            row["username"] = user.Username;
                            row["password"] = user.Password;
                            row["salary"] = user.Salary;
                            row["email"] = user.Email;

                            // Chuyển đổi byte[] thành Image
                            if (user.Image != null && user.Image.Length > 0)
                            {
                                row["image"] = ImageHelper.ByteArrayToImage(user.Image.ToArray());
                            }
                            else
                            {
                                row["image"] = null; // Hoặc một hình ảnh mặc định
                            }

                            dt.Rows.Add(row);

                            // Gán DataTable vào DataGridView
                            dgv_user.DataSource = dt;
                        }

                        dgv_user.DataSource = dt;
                        dgv_user.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No user found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<User> result = new List<User>();
                using (var db = new MobileShopManagementDataContext())
                {
                    if (cb_filter.SelectedItem.ToString() == "All")
                    {
                        result = db.Users.ToList();
                    }
                    else if (cb_filter.SelectedItem.ToString() == "Active")
                    {
                        result = db.Users.Where(x => x.Status == "Active").ToList();
                    }
                    else if (cb_filter.SelectedItem.ToString() == "Inactive")
                    {
                        result = db.Users.Where(x => x.Status == "Inactive").ToList();
                    }

                    if (result.Count > 0)
                    {
                        dgv_user.DataSource = result;
                        dgv_user.Refresh();
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
