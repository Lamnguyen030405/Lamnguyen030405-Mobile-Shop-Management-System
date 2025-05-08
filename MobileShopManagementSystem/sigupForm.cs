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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }
        public static string getUserID()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var allIDs = db.Users
                    .Select(u => u.UserID)
                    .ToList();

                var maxNumber = allIDs
                    .Select(id => id.Substring(3)) // bỏ tiền tố "UID"
                    .Where(s => int.TryParse(s, out var num))
                    .Select(s => int.Parse(s))
                    .DefaultIfEmpty(0)
                    .Max();

                return $"UID{maxNumber + 1}";
            }
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
                        UserID = getUserID(),
                        Username = txt_signupUsername.Text.Trim(),
                        Password = txt_signupPassword.Text.Trim(),
                        Status = "Inactive",
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

        private void sigupForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_register;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void titlepanel_MouseDown(object sender, MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void titlepanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void c_showPassword_CheckedChanged(object sender)
        {
            txt_signupPassword.UseSystemPasswordChar = !c_signupShowPassword.Checked;
            txt_signupConfirmPassword.UseSystemPasswordChar = !c_signupShowPassword.Checked;

        }

        private void SetPlaceholder(ReaLTaiizor.Controls.DungeonTextBox textBox, string placeholder, bool isPassword = false)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = placeholder;
                if (isPassword)
                    textBox.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceholder(ReaLTaiizor.Controls.DungeonTextBox textBox, string placeholder, bool isPassword = false)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (isPassword)
                    textBox.UseSystemPasswordChar = true;
            }
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(txt_signupUsername, "Username");
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txt_signupUsername, "Username");
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(txt_signupPassword, "Password", true);
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txt_signupPassword, "Password", true);
        }
        private void txt_confirmpassword_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(txt_signupConfirmPassword, "Confirm Password", true);
        }

        private void txt_confirmpassword_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txt_signupConfirmPassword, "Confirm Password", true);
        }
    }
}
