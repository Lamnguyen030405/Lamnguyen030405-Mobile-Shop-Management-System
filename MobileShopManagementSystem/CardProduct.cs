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
    public partial class CardProduct : UserControl
    {
        public CardProduct()
        {
            InitializeComponent();
        }
        public string productID { get; set; }
        public string productName
        {
            get { return productname.Text; }
            set { productname.Text = value; }
        }
        public string productPrice
        {
            get { return price.Text; }
            set { price.Text = value; }
        }
        public string productStock
        {
            get { return stock.Text; }
            set { stock.Text = value; }
        }
        public Image productImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public string productQuantity
        {
            get { return txt_quantity.Text; }
            set { txt_quantity.Text = value; }
        }
        public string productCategory { get; set; }
        
        public event EventHandler selectCard;

        private void btn_add_Click(object sender, EventArgs e)
        {
            selectCard?.Invoke(this, EventArgs.Empty);
        }

        private void CardProduct_Load(object sender, EventArgs e)
        {

        }
    }

}
