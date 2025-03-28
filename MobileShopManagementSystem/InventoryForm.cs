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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
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

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
