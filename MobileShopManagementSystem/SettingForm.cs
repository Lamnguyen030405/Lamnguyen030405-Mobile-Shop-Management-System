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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void c_showPassword_CheckedChanged()
        {
            txt_oldPassword.Password = !c_showPassword.Checked;
            txt_newPassword.Password = !c_showPassword.Checked;
            txt_confirmPassword.Password = !c_showPassword.Checked;
        }

        private void btn_userChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_oldPassword.TextButton))
                {
                    MessageBox.Show("Please enter your old password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_newPassword.TextButton))
                {
                    MessageBox.Show("Please enter your new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_confirmPassword.TextButton))
                {
                    MessageBox.Show("Please enter your confirm password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserID == txt_userID.TextButton);
                    if (user != null)
                    {
                        if (txt_oldPassword.TextButton == user.Password)
                        {
                            if (txt_newPassword.TextButton == txt_confirmPassword.TextButton)
                            {
                                user.Password = txt_newPassword.TextButton;
                                db.SubmitChanges();
                                MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("New password and confirm password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Old password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserID == Form1.userID);
                    if (user != null)
                    {
                        txt_userID.TextButton = user.UserID;
                        txt_userPN.TextButton = user.PhoneNumber;
                        txt_userAddress.TextButton = user.Address;
                        txt_name.TextButton = user.Name;
                        cb_userGender.Text = user.Gender;
                        txt_userEmail.TextButton = user.Email;
                        txt_userSalary.TextButton = user.Salary.ToString();
                        dt_userBirthDate.Value = user.BirthDate ?? DateTime.Now;
                        byte[] imageBytes = user.Image?.ToArray();
                        if (imageBytes != null && imageBytes.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
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
            txt_userPN.TextButton = "";
            txt_userAddress.TextButton = "";
            txt_name.TextButton = "";
            cb_userGender.SelectedIndex = 0;
            txt_userEmail.TextButton = "";
            dt_userBirthDate.Value = DateTime.Now;
        }

        public void refreshData()
        {
            LoadData();
        }

        private void btn_userClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private async void btn_userUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_name.TextButton) ||
                   string.IsNullOrWhiteSpace(txt_userPN.TextButton) ||
                   string.IsNullOrWhiteSpace(txt_userAddress.TextButton) ||
                   string.IsNullOrWhiteSpace(cb_userGender.Text) ||
                   string.IsNullOrWhiteSpace(txt_userEmail.TextButton))
                {
                    MessageBox.Show("Please fill in all the fields marked with stars", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to update this user?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

                // Hiển thị con trỏ bận để báo hiệu đang xử lý
                Cursor.Current = Cursors.WaitCursor;

                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserID == txt_userID.TextButton);
                    if (user != null)
                    {
                        byte[] b = null;
                        if (pictureBox1.Image != null)
                        {
                            // Thay đổi kích thước hình ảnh để tối ưu hóa
                            Image resizedImage = ImageHelper.ResizeImage(pictureBox1.Image, 200, 200); // Thay đổi kích thước thành 200x200
                            b = ImageHelper.ImageToByteArray(resizedImage);
                        }

                        user.Name = txt_name.TextButton;
                        user.PhoneNumber = txt_userPN.TextButton;
                        user.Address = txt_userAddress.TextButton;
                        user.Gender = cb_userGender.Text;
                        user.BirthDate = dt_userBirthDate.Value;
                        user.Email = txt_userEmail.TextButton;
                        user.Image = b;

                        // Sử dụng async để tránh treo giao diện
                        await Task.Run(() => db.SubmitChanges());

                        MainForm mainForm = new MainForm();
                        LoadData();
                        MessageBox.Show("User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đặt lại con trỏ sau khi xử lý xong
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_settingImport_Click(object sender, EventArgs e)
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
    }
}