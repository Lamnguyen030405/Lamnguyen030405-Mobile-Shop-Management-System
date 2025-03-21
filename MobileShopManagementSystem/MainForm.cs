using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        bool shopExpand = false;
        private void shopTransition_Tick(object sender, EventArgs e)
        {
            if (!shopExpand) // Nếu menu đang đóng -> Mở ra
            {
                shopContainer.Height += 5;
                if (shopContainer.Height >= 160) // Chiều cao tối đa
                {
                    shopContainer.Height = 160;
                    shopTransition.Stop();
                    shopExpand = true;
                }
            }
            else // Nếu menu đang mở -> Thu lại
            {
                shopContainer.Height -= 5;
                if (shopContainer.Height <= 49) // Chiều cao tối thiểu
                {
                    shopContainer.Height = 49;
                    shopTransition.Stop();
                    shopExpand = false;
                }
            }
        }



        private void btn_shop_Click(object sender, EventArgs e)
        {
            shopTransition.Start();
        }

        bool slidebarExpand = true;
        private void slidebarTransition_Tick(object sender, EventArgs e)
        {
            if (slidebarExpand)
            {
                slidebar.Width -= 5;
                if(slidebar.Width <= 62)
                {
                    slidebar.Width = 62;
                    slidebarTransition.Stop();
                    slidebarExpand = false;
                }
            }
            else
            {
                slidebar.Width += 5;
                if (slidebar.Width >= 249)
                {
                    slidebar.Width = 249;
                    slidebarTransition.Stop();
                    slidebarExpand = true;
                }
            }
        }

        
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this app?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            slidebarTransition.Start();
        }
    }
}
