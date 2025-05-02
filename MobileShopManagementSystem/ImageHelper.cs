using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace MobileShopManagementSystem.Utilities
{
    public static class ImageHelper
    {
        /// <summary>
        /// Chuyển đổi một đối tượng Image thành mảng byte[]
        /// </summary>
        /// <param name="imageIn">Đối tượng Image cần chuyển đổi</param>
        /// <returns>Mảng byte[] hoặc null nếu imageIn là null</returns>
        public static byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Chuyển đổi một mảng byte[] thành đối tượng Image
        /// </summary>
        /// <param name="byteArrayIn">Mảng byte[] cần chuyển đổi</param>
        /// <returns>Đối tượng Image hoặc null nếu byteArrayIn là null hoặc rỗng</returns>
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        /// <summary>
        /// Thay đổi kích thước của một hình ảnh
        /// </summary>
        /// <param name="image">Hình ảnh cần thay đổi kích thước</param>
        /// <param name="width">Chiều rộng mong muốn</param>
        /// <param name="height">Chiều cao mong muốn</param>
        /// <returns>Hình ảnh đã được thay đổi kích thước</returns>
        public static Image ResizeImage(Image image, int width, int height)
        {
            if (image == null)
                return null;

            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}