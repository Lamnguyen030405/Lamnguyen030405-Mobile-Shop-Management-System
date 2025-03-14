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
        string connection = "Data Source=.;Initial Catalog=mobilesystem;Integrated Security=True;";
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
            using(SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string checkUsername = "SELECT * FROM users WHERE username = @usern";

                using(SqlCommand checkUsern =  new SqlCommand(checkUsername, conn))
                {
                    checkUsern.Parameters.AddWithValue("@usern", txt_signupUsername.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count != 0)
                    {
                        MessageBox.Show($"{txt_signupUsername.Text.Trim()} was taken already", "Error Message",
                                                                                    MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }
                    else if(txt_signupPassword.Text.Trim().Length < 8)
                    {
                        MessageBox.Show("Invalid Password, at least 8 characters required", "Error Message",
                                                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(txt_signupConfirmPassword.Text.Trim() != txt_signupPassword.Text.Trim())
                    {
                        MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertData = "INSERT INTO users (username, password, status, date_created) VALUES(@usern, @pass, @status, @date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, conn))
                        {
                            cmd.Parameters.AddWithValue("@usern", txt_signupUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", txt_signupPassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            DateTime today = DateTime.Now;

                            cmd.Parameters.AddWithValue("@date", today.ToString("yyyy-MM-dd"));

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form1 loginform = new Form1();
                            loginform.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
    }
}
