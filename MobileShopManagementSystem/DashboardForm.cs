using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            // Áp dụng Gradient làm nền
            Gradient backgroundGradient = new Gradient
            {
                Dock = DockStyle.Fill,
                Color1 = Color.White,
                Color2 = Color.Navy,
                GradientMode = LinearGradientMode.Vertical
            };

            this.Controls.Add(backgroundGradient);
            backgroundGradient.SendToBack();
            this.DoubleBuffered = true;
        }
        //private async void ResizePanelSmoothly(Control panel, int targetWidth, int targetHeight)
        //{
        //    int step = 10; // Điều chỉnh bước resize

        //    while (panel.Width != targetWidth || panel.Height != targetHeight)
        //    {
        //        if (panel.Width < targetWidth) panel.Width += step;
        //        else if (panel.Width > targetWidth) panel.Width -= step;

        //        if (panel.Height < targetHeight) panel.Height += step;
        //        else if (panel.Height > targetHeight) panel.Height -= step;

        //        await Task.Delay(10); // Điều chỉnh tốc độ resize
        //    }
        //}
        public void OnParentButtonClicked(object sender, EventArgs e)
        {
           slidebarTransition.Start();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            
        }

        private void slidebarTransition_Tick(object sender, EventArgs e)
        {
            //if (this.MdiParent != null && this.MdiParent is MainForm parent)
            //{
            //    if (parent.slidebarExpand)
            //    {
            //        ResizePanelSmoothly(tabe)
            //    }
            //    else
            //    {
            //        slidebar.Width += step;
            //        if (slidebar.Width >= 249)
            //        {
            //            slidebar.Width = 249;
            //            slidebarTransition.Stop();
            //            slidebarExpand = true;
            //        }
            //    }
            //}
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
