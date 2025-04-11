using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            Gradient backgroundGradient = new Gradient
            {
                Dock = DockStyle.Fill,  // Phủ toàn bộ Form
                Color1 = Color.White,   // Trắng
                Color2 = Color.Navy,    // Xanh navy
                GradientMode = LinearGradientMode.Vertical
            };

            this.Controls.Add(backgroundGradient);
            backgroundGradient.SendToBack();
        }
        MobileShopManagementDataContext db = new MobileShopManagementDataContext();
        private void LoadData()
        {
            var customers = db.Customers.ToList();
            dgv_customer.DataSource = customers;
        }
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_search.SelectedIndex = 0;
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgv_customer.Rows[e.RowIndex];
                txt_customerID.Text = row.Cells["id"].Value.ToString();
                txt_customerName.Text = row.Cells["name"].Value.ToString();
                txt_customerPN.Text = row.Cells["phonenumber"].Value.ToString();
                txt_customerAddress.Text = row.Cells["address"].Value.ToString();
            }
        }
        private void clearData()
        {
            txt_customerID.Clear();
            txt_customerName.Clear();
            txt_customerPN.Clear();
            txt_customerAddress.Clear();
            txt_search.Clear();
            txt_search.Focus();
        }
        private void btn_customerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_customerID.Text))
                {
                    MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                var customer = db.Customers.FirstOrDefault(c => c.CustomerID == txt_customerID.Text);
                if (customer != null)
                {
                    db.Customers.DeleteOnSubmit(customer);
                    db.SubmitChanges();
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    clearData();
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_customerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_customerID.Text))
                {
                    MessageBox.Show("Please select a customer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txt_customerName.Text.Trim()))
                {
                    MessageBox.Show("Please enter customer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txt_customerPN.Text.Trim()))
                {
                    MessageBox.Show("Please enter customer phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(MessageBox.Show("Are you sure you want to update this customer?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                var customer = db.Customers.FirstOrDefault(c => c.CustomerID == txt_customerID.Text);
                if (customer != null)
                {
                    customer.CustomerName = txt_customerName.Text;
                    customer.PhoneNumber = txt_customerPN.Text;
                    customer.Address = txt_customerAddress.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    clearData();
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_customerClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_search.Text.Trim()))
                {
                    MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string searchText = txt_search.Text.Trim();
                List<Customer> search = new List<Customer>();

                switch (cb_search.SelectedItem?.ToString())
                {
                    case "Customer ID":
                        search = db.Customers
                            .Where(x => x.CustomerID.ToLower().Contains(searchText))
                            .ToList();
                        break;

                    case "Customer Name":
                        search = db.Customers
                            .Where(x => x.CustomerName.ToLower().Contains(searchText))
                            .ToList();
                        break;

                    case "Phone Number":
                        search = db.Customers
                            .Where(x => x.PhoneNumber.ToLower().Contains(searchText))
                            .ToList();
                        break;
                }

                if (search.Count > 0)
                {
                    dgv_customer.DataSource = search;
                    dgv_customer.Refresh();
                }
                else
                {
                    MessageBox.Show("No product found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
