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
            displayCategories();
        }

        MobileShopManagementDataContext db = new MobileShopManagementDataContext();

        private void displayCategories()
        {
            cb_inventoryCategory.Items.Clear();
            List<Category> cat = db.Categories.Where(c => c.Status == "Active").ToList();
            if (cat.Count > 0)
            {
                foreach (Category c in cat)
                {
                    cb_inventoryCategory.Items.Add(c.CategoryName);
                }
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_inventoryImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                
                string imagePath = "";
                
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    pictureBox1.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
