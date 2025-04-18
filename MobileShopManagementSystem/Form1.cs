using ReaLTaiizor.Controls;
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
    public partial class Form1 : Form
    {
        MobileShopManagementDataContext dataContext = new MobileShopManagementDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_login;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sigupForm sigupForm = new sigupForm();
            sigupForm.Show();
            this.Hide();
        }
        public static string userID;
        private void btn_login_Click(object sender, EventArgs e)
        {
            var user = dataContext.Users.Where(u => u.Username == txt_loginUsername.Text.Trim() && u.Password == txt_loginPassword.Text.Trim()).FirstOrDefault();
            if(user != null) {
                userID = user.UserID;
                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            txt_loginPassword.UseSystemPasswordChar = !c_showPassword.Checked;
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
            RemovePlaceholder(txt_loginUsername, "Username");
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txt_loginUsername, "Username");
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder(txt_loginPassword, "Password", true);
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txt_loginPassword, "Password", true);
        }
    }
}
