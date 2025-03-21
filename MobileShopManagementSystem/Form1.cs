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
        string connection = "Data Source=.;Initial Catalog=mobilesystem;Integrated Security=True;";
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string query = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usern", txt_loginUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txt_loginPassword.Text.Trim());
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void c_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_loginPassword.PasswordChar = c_showPassword.Checked ? '\0' : '*';
        }

    }
}
