using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    internal class Gradient : Panel
    {
        // Màu bắt đầu và màu kết thúc
        public Color Color1 { get; set; } = Color.White;
        public Color Color2 { get; set; } = Color.Navy;
        public LinearGradientMode GradientMode { get; set; } = LinearGradientMode.Vertical;

        private Bitmap gradientImage; // Cache hình ảnh Gradient

        public Gradient()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (gradientImage == null || gradientImage.Size != this.Size)
            {
                GenerateGradientImage();
            }

            e.Graphics.DrawImage(gradientImage, 0, 0);
        }

        private void GenerateGradientImage()
        {
            if (this.Width < 1 || this.Height < 1)
                return;

            // Giải phóng bộ nhớ cũ trước khi tạo mới
            gradientImage?.Dispose();

            gradientImage = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(gradientImage))
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color1, Color2, GradientMode))
            {
                ColorBlend colorBlend = new ColorBlend
                {
                    Colors = new Color[]
                    {
                        Color1,          // Trắng
                        Color.LightBlue, // Xanh nhạt
                        Color2           // Xanh navy
                    },
                    Positions = new float[] { 0.0f, 0.5f, 1.0f }
                };

                brush.InterpolationColors = colorBlend;
                g.FillRectangle(brush, this.ClientRectangle);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this.Width > 0 && this.Height > 0)
            {
                GenerateGradientImage();
                this.Invalidate();
            }
        }
    }
}
