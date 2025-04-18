using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MobileShopManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        MobileShopManagementDataContext db = new MobileShopManagementDataContext();
        private void LoadData()
        {
            try
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
                LoadDataToChart();
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
                DateTime fromDate = dt_from.Value.Date.AddDays(-7);
                DateTime toDate = dt_to.Value.Date;

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
                chartRevenue.ChartAreas[0].AxisY.Title = "Revenue";

                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
                chartRevenue.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

                chartRevenue.ChartAreas[0].AxisX.Interval = 1;

                chartRevenue.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

                var series = new System.Windows.Forms.DataVisualization.Charting.Series("Revenue")
                {
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };

                foreach (var item in data)
                {
                    series.Points.AddXY(item.Date, item.Total);
                }

                chartRevenue.Series.Add(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTop3Products()
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

            lbl_priceProdcut1.Text = product1?.Price != null ? string.Format("{0:N0} VND", product1.Price) : "N/A";
            lbl_priceProduct2.Text = product2?.Price != null ? string.Format("{0:N0} VND", product2.Price) : "N/A";
            lbl_priceProduct3.Text = product3?.Price != null ? string.Format("{0:N0} VND", product3.Price) : "N/A";

            try
            {
                pic_product1.Image = !string.IsNullOrEmpty(product1?.Image)
                    ? Image.FromFile(PathHelper.GetImagePath(product1.Image))
                    : null;
            }
            catch { pic_product1.Image = null; }

            try
            {
                pic_product2.Image = !string.IsNullOrEmpty(product2?.Image)
                    ? Image.FromFile(PathHelper.GetImagePath(product2.Image))
                    : null;
            }
            catch { pic_product2.Image = null; }

            try
            {
                pic_product3.Image = !string.IsNullOrEmpty(product3?.Image)
                    ? Image.FromFile(PathHelper.GetImagePath(product3.Image))
                    : null;
            }
            catch { pic_product3.Image = null; }

            lbl_totalSold1.Text = Top3Products.ElementAtOrDefault(0)?.TotalSold.ToString() ?? "N/A";
            lbl_totalSold2.Text = Top3Products.ElementAtOrDefault(1)?.TotalSold.ToString() ?? "N/A";
            lbl_totalSold3.Text = Top3Products.ElementAtOrDefault(2)?.TotalSold.ToString() ?? "N/A";
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_generateChart_Click(object sender, EventArgs e)
        {
            LoadDataToChart();
        }
    }
}
