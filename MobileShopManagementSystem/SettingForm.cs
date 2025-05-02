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
                        cb_userGender. Text = user.Gender;
                        dt_userBirthDate.Value = user.BirthDate ?? DateTime.Now;
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
            cb_userGender.SelectedIndex = -1;
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
        private void btn_userUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txt_name.TextButton) ||
                   string.IsNullOrWhiteSpace(txt_userPN.TextButton) ||
                   string.IsNullOrWhiteSpace(txt_userAddress.TextButton) ||
                   string.IsNullOrWhiteSpace(cb_userGender.Text))
                {
                    MessageBox.Show("Please fill in all the fields marked with stars", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(MessageBox.Show("Are you sure you want to update this user?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.UserID == txt_userID.TextButton);
                    if (user != null)
                    {
                        user.Name = txt_name.TextButton;
                        user.PhoneNumber = txt_userPN.TextButton;
                        user.Address = txt_userAddress.TextButton;
                        user.Gender = cb_userGender.SelectedItem.ToString();
                        user.BirthDate = dt_userBirthDate.Value;
                        db.SubmitChanges();
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
        }

    }
}
