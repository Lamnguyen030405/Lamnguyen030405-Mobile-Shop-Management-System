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

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to close this app?","Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void c_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_loginPassword.PasswordChar = c_showPassword.Checked ? '\0' : '*';
        }

    }
}
