using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    public partial class sigupForm : Form
    {
        MobileShopManagementDataContext dataContext = new MobileShopManagementDataContext();
        public sigupForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this app?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void c_signupShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_signupPassword.PasswordChar = c_signupShowPassword.Checked ? '\0' : '*';
            txt_signupConfirmPassword.PasswordChar = c_signupShowPassword.Checked ? '\0' : '*';
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            if (txt_signupUsername.Text.Trim() == "" || txt_signupPassword.Text.Trim() == "" || txt_signupConfirmPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var user = dataContext.Users.Where(u => u.Username == txt_signupUsername.Text.Trim()).FirstOrDefault();
                if (user != null)
                {
                    MessageBox.Show($"{txt_signupUsername.Text.Trim()} was taken already", "Error Message",
                                                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_signupPassword.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Invalid Password, at least 8 characters required", "Error Message",
                                                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_signupConfirmPassword.Text.Trim() != txt_signupPassword.Text.Trim())
                {
                    MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    User newUser = new User
                    {
                        Username = txt_signupUsername.Text.Trim(),
                        Password = txt_signupPassword.Text.Trim(),
                        Status = "Active",
                        DateCreated = DateTime.Now
                    };
                    dataContext.Users.InsertOnSubmit(newUser);
                    dataContext.SubmitChanges();
                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 loginform = new Form1();
                    loginform.Show();
                    this.Hide();
                }
            }
        }

    }
}
