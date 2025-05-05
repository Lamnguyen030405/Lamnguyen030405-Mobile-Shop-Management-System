using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MobileShopManagementSystem.Utilities; // Thêm namespace để sử dụng ImageHelper

namespace MobileShopManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void LoadData()
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    var totalCustomers = db.Customers.Count();
                    var totalProducts = db.Products.Count();
                    var todayRevenue = db.vw_BillDetails
                        .Where(b => b.DateOrder == DateTime.Today)
                        .Sum(b => b.TotalPrice) ?? 0;
                    var totalRevenue = db.vw_BillDetails.Sum(b => b.TotalPrice) ?? 0;
                    lbl_totalCustomer.Text = totalCustomers.ToString();
                    lbl_totalProducts.Text = totalProducts.ToString();
                    lbl_todayRevenue.Text = todayRevenue.ToString("C");
                    lbl_totalRevenue.Text = totalRevenue.ToString("C");
                }
                LoadTop3Products();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataToChart()
        {
            try
            {
                DateTime fromDate = dt_from1.Value.Date.AddDays(-7);
                DateTime toDate = dt_to1.Value.Date;
                if (fromDate.AddDays(7) > toDate)
                {
                    MessageBox.Show("From date must be less than or equal to To date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    var data = db.vw_BillDetails
                    .Where(b => b.DateOrder >= fromDate && b.DateOrder <= toDate)
                    .GroupBy(b => b.DateOrder)
                    .Select(g => new
                    {
                        Date = g.Key,
                        Total = g.Sum(x => x.TotalPrice ?? 0)
                    })
                    .OrderBy(x => x.Date)
                    .ToList();

                    chartRevenue.Series.Clear();
                    chartRevenue.ChartAreas[0].AxisX.Title = "Date";
                    chartRevenue.ChartAreas[0].AxisY.Title = "Revenue from sales";

                    chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
                    chartRevenue.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                    chartRevenue.ChartAreas[0].AxisX.Interval = 1;
                    chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

                    var series = new System.Windows.Forms.DataVisualization.Charting.Series("Revenue from sales")
                    {
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                    };

                    foreach (var item in data)
                    {
                        series.Points.AddXY(item.Date, item.Total);
                    }

                    chartRevenue.Series.Add(series);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTop3Products()
        {
            using (var db = new MobileShopManagementDataContext())
            {
                var Top3Products = db.Carts
                .GroupBy(c => new { c.ProductName, c.Price, c.ProductID })
                .Select(g => new
                {
                    ProductID = g.Key.ProductID,
                    ProductName = g.Key.ProductName,
                    Price = g.Key.Price ?? 0,
                    TotalSold = g.Sum(x => x.Quantity ?? 0)
                })
                .OrderByDescending(x => x.TotalSold)
                .Take(3)
                .ToList();

                string product1ID = Top3Products.ElementAtOrDefault(0)?.ProductID ?? null;
                string product2ID = Top3Products.ElementAtOrDefault(1)?.ProductID ?? null;
                string product3ID = Top3Products.ElementAtOrDefault(2)?.ProductID ?? null;

                var product1 = !string.IsNullOrEmpty(product1ID) ? db.Products.FirstOrDefault(p => p.ProductID == product1ID) : null;
                var product2 = !string.IsNullOrEmpty(product2ID) ? db.Products.FirstOrDefault(p => p.ProductID == product2ID) : null;
                var product3 = !string.IsNullOrEmpty(product3ID) ? db.Products.FirstOrDefault(p => p.ProductID == product3ID) : null;

                lbl_product1.Text = product1?.ProductName ?? "N/A";
                lbl_product2.Text = product2?.ProductName ?? "N/A";
                lbl_product3.Text = product3?.ProductName ?? "N/A";

                lbl_priceProdcut1.Text = product1?.RealPrice != null ? string.Format("$ {0:N0}", product1.RealPrice) : "N/A";
                lbl_priceProduct2.Text = product2?.RealPrice != null ? string.Format("$ {0:N0}", product2.RealPrice) : "N/A";
                lbl_priceProduct3.Text = product3?.RealPrice != null ? string.Format("$ {0:N0}", product3.RealPrice) : "N/A";

                try
                {
                    pic_product1.Image = product1?.Image != null && product1.Image.Length > 0
                        ? ImageHelper.ByteArrayToImage(product1.Image.ToArray())
                        : null;
                }
                catch { pic_product1.Image = null; }

                try
                {
                    pic_product2.Image = product2?.Image != null && product2.Image.Length > 0
                        ? ImageHelper.ByteArrayToImage(product2.Image.ToArray())
                        : null;
                }
                catch { pic_product2.Image = null; }

                try
                {
                    pic_product3.Image = product3?.Image != null && product3.Image.Length > 0
                        ? ImageHelper.ByteArrayToImage(product3.Image.ToArray())
                        : null;
                }
                catch { pic_product3.Image = null; }

                lbl_totalSold1.Text = Top3Products.ElementAtOrDefault(0)?.TotalSold.ToString() ?? "N/A";
                lbl_totalSold2.Text = Top3Products.ElementAtOrDefault(1)?.TotalSold.ToString() ?? "N/A";
                lbl_totalSold3.Text = Top3Products.ElementAtOrDefault(2)?.TotalSold.ToString() ?? "N/A";
            }
        }
        private void LoadProfit()
        {
            try
            {
                DateTime fromDate = dt_from2.Value.Date.AddDays(-7);
                DateTime toDate = dt_to2.Value.Date;
                if (fromDate.AddDays(7) > toDate)
                {
                    MessageBox.Show("From date must be less than or equal to To date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var db = new MobileShopManagementDataContext())
                {
                    // Tổng phí trễ hạn
                    double totalLateFee = db.vw_BillDetails
                        .Where(b => b.DateOrder >= fromDate && b.DateOrder <= toDate)
                        .Sum(b => (double?)b.LateFee) ?? 0;

                    //// Tổng lương của các nhân viên đã xử lý đơn hàng trong khoảng thời gian
                    ////var userIDs = db.vw_BillDetails
                    ////    .Where(b => b.DateOrder >= fromDate && b.DateOrder <= toDate)
                    ////    .Select(b => b.UserID)
                    ////    .Distinct();

                    ////var totalSalary = db.Users
                    ////    .Where(u => userIDs.Contains(u.UserID))
                    ////    .Sum(u => u.Salary ?? 0);

                    //var totalSalary = db.Users
                    //    .Where(u => u.Role == "Staff" && u.Status == "Active")
                    //    .Sum(u => u.Salary) ?? 0;


                    // Tổng tiền lãi = RemainingAmount * InterestRate
                    double totalInterestAmount = db.vw_BillDetails
                        .Where(b => b.DateOrder >= fromDate && b.DateOrder <= toDate)
                        .Sum(b => (double?)((b.RemainingAmount ?? 0) * (b.InterestRate ?? 0) / 100)) ?? 0;

                    // Tổng giá vốn hàng bán (Cost of Goods Sold)
                    var orderIDs = db.vw_BillDetails
                        .Where(b => b.DateOrder >= fromDate && b.DateOrder <= toDate)
                        .Select(b => b.OrderID)
                        .Distinct();

                    var costOfGoodsSold = (from c in db.Carts
                                           join p in db.Products on c.ProductID equals p.ProductID
                                           where orderIDs.Contains(c.OrderID)
                                           select (c.Quantity ?? 0) * (p.ImportPrice ?? 0))
                                          .Sum();
                    // Tổng doanh thu
                    double totalRevenue = db.vw_BillDetails
                        .Where(b => b.DateOrder >= fromDate && b.DateOrder <= toDate)
                        .Sum(b => (double?)b.TotalPrice) ?? 0;


                    // Gán lên giao diện
                    lbl_totalLateFee.Text = "$ " + totalLateFee.ToString("N0");
                    lbl_totalRevenue2.Text = "$ " + totalRevenue.ToString("N0");
                    lbl_totalInterestAmount.Text = "$ " + totalInterestAmount.ToString("N0");
                    lbl_costOfGoodsSold.Text = "$ " + costOfGoodsSold.ToString("N0");

                    // Tính toán lợi nhuận
                    var profit = totalRevenue + totalInterestAmount + totalLateFee - costOfGoodsSold;
                    lbl_profit.Text = "$ " + profit.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTodaySalesToDataGridView()
        {
            try
            {
                using (var db = new MobileShopManagementDataContext())
                {
                    var todaySales = db.vw_BillDetails
                        .Where(b => b.DateOrder == DateTime.Today).ToList();
                    dgv_bill.DataSource = todaySales;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void refreshData()
        {
            LoadData();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataToChart();
        }

        private void btn_generateChart_Click(object sender, EventArgs e)
        {
            LoadDataToChart();
        }

        private void dungeonTabPage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dungeonTabPage1.SelectedTab == tabPage1)
                {
                    LoadDataToChart();
                }
                else if (dungeonTabPage1.SelectedTab == tabPage2)
                {
                    LoadProfit();
                }
                else if (dungeonTabPage1.SelectedTab == tabPage3)
                {
                    LoadTodaySalesToDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            LoadProfit();
        }
    }
}