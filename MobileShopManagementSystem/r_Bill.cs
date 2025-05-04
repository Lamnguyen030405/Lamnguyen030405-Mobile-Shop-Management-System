using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MobileShopManagementSystem
{
    public partial class r_Bill : Form
    {

        private string BillID;
        public r_Bill(string BillID)
        {
            InitializeComponent();
            this.BillID = BillID;
        }
        MobileShopManagementDataContext db = new MobileShopManagementDataContext();

        private DataTable ConvertToDataTable(vw_BillDetail bill)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("BillID", typeof(string));
            dt.Columns.Add("UserID", typeof(string));
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("CustomerID", typeof(string));
            dt.Columns.Add("CustomerName", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("DateOrder", typeof(DateTime));
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Amount", typeof(double));
            dt.Columns.Add("TotalPrice", typeof(double));
            dt.Columns.Add("PaymentHistory", typeof(string));
            dt.Columns.Add("TotalQuantity", typeof(int));
            dt.Columns.Add("InterestRate", typeof(double));
            dt.Columns.Add("PenaltyRate", typeof(double));
            dt.Columns.Add("DownPaymentAmount", typeof(double));
            dt.Columns.Add("RemainingAmount", typeof(double));
            dt.Columns.Add("OutstandingAmount", typeof(double));
            dt.Columns.Add("SelectedTerm", typeof(string));
            dt.Columns.Add("LateFee", typeof(double));


            int id = 1;
            
            Customer customer = db.Customers.FirstOrDefault(c => c.CustomerID == bill.CustomerID);

            List<Cart> carts = db.Carts.Where(o => o.OrderID == bill.OrderID).ToList();

            foreach (var cart in carts)
            {
                dt.Rows.Add(
                    bill.BillID,
                    bill.UserID,
                    bill.UserName,
                    bill.CustomerID,
                    bill.CustomerName,
                    customer.Address,
                    customer.PhoneNumber,
                    bill.DateOrder,
                    id++,
                    cart.ProductName,
                    cart.Quantity,
                    cart.Price,
                    cart.Price * cart.Quantity,
                    bill.TotalPrice,
                    bill.PaymentHistory,
                    bill.TotalQuantity,
                    bill.InterestRate,
                    bill.PenaltyRate,
                    bill.DownPaymentAmount,
                    bill.RemainingAmount,
                    bill.OutstandingAmount,
                    bill.SelectedTerm,
                    bill.LateFee
                );
            }

            return dt;
        }
        private void r_Bill_Load(object sender, EventArgs e)
        {
            try
            {
                vw_BillDetail bill = db.vw_BillDetails.FirstOrDefault(b => b.BillID == this.BillID);

                DataTable dt = ConvertToDataTable(bill);

                BillReport billReport = new BillReport();
                billReport.SetDataSource(dt);

                crystalReportViewer1.ReportSource = billReport;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
