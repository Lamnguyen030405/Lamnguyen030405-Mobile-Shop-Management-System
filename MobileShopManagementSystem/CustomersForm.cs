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
        }

        private void LoadData()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var customers = db.Customers.ToList();
                dgv_customer.DataSource = customers;
            }
        }
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadData();
            cb_search.SelectedIndex = 0;
        }

        private void dgv_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgv_customer.Rows[e.RowIndex];
                txt_customerID.TextButton = row.Cells["id"].Value.ToString();
                txt_customerName.TextButton = row.Cells["name"].Value.ToString();
                txt_customerPN.TextButton = row.Cells["phonenumber"].Value.ToString();
                txt_customerAddress.TextButton = row.Cells["address"].Value.ToString();
            }
        }
        private void clearData()
        {
            txt_customerID.TextButton = "";
            txt_customerName.TextButton = "";
            txt_customerPN.TextButton = "";
            txt_customerAddress.TextButton = "";
            txt_search.TextButton = "";
            txt_search.Focus();
        }
        private void btn_customerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_customerID.TextButton))
                {
                    MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    var customer = db.Customers.FirstOrDefault(c => c.CustomerID == txt_customerID.TextButton);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_customerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_customerID.TextButton))
                {
                    MessageBox.Show("Please select a customer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txt_customerName.TextButton.Trim()))
                {
                    MessageBox.Show("Please enter customer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txt_customerPN.TextButton.Trim()))
                {
                    MessageBox.Show("Please enter customer phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this customer?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    var customer = db.Customers.FirstOrDefault(c => c.CustomerID == txt_customerID.TextButton);
                    if (customer != null)
                    {
                        customer.CustomerName = txt_customerName.TextButton;
                        customer.PhoneNumber = txt_customerPN.TextButton;
                        customer.Address = txt_customerAddress.TextButton;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_customerClear_Click(object sender, EventArgs e)
        {
            clearData();
        }
        public void refreshData()
        {
            LoadData();
            clearData();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_search.TextButton.Trim()))
                {
                    MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string searchText = txt_search.TextButton.Trim().ToLower();
                List<Customer> search = new List<Customer>();
                using (var db = new MobileShopManagementDataContext())
                {
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
                        MessageBox.Show("No customer found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
