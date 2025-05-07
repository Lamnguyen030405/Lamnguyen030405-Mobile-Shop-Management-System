using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
        }
        Random random = new Random();
        string newPassword;
        private void btn_request_Click(object sender, EventArgs e)
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == txt_email.Text.ToString().Trim());
                if (user == null)
                {
                    MessageBox.Show("Email not found. Please create your account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string lst = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                string randomString = new string(Enumerable.Repeat(lst, 12)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                newPassword = randomString;

                var fromAddress = new MailAddress("nguyentrilam0304@gmail.com");
                var toAddress = new MailAddress(txt_email.Text.ToString().Trim());
                const string frompass = "duvh lhtp kxcv hick";
                const string subject = "New Password";
                string body = $"Your user name is : {user.Username}\r\nYour new password is: {newPassword}";
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("New password sent to your email", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        user.Password = newPassword.ToString();
                        db.SubmitChanges();
                        Form1 loginform = new Form1();
                        loginform.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
            RemovePlaceholder(txt_email, "Email Address");
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            SetPlaceholder(txt_email, "Email Address");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sigupForm sigupForm = new sigupForm();
            sigupForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void forgotPassword_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_request;
        }
    }
}
