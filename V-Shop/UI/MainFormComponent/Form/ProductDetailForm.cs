using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.Presentation;
namespace V_Shop.Data.Product
{
    public partial class ProductDetailForm : Form
    {
        private Product product;
        int buyQty = 1;
       
        public ProductDetailForm(Product product)
        {
            InitializeComponent();
            LabelDescription.AutoSize = true;
            this.product = product;
            SetRoundForm();
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            LabelDescription.Text = product.Description;
            LabelName.Text = $"Name: {product.Name}";
            LabelStock.Text = $"In Stock: {product.Qty}";
            LabelPrice.Text = $"Price: ${product.SalePrice}";
            pictureBoxProduct.Image = ConvertByteArrayToImage(product.ImageData);
        }

        private void SetRoundForm()
        {
            int radius = 20; // Adjust this value to set the radius of the rounded corners

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using(MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        
        private void BtAddToCard_Click(object sender, EventArgs e)
        {

            MainForm mainForm = MainForm.instance;
            if (mainForm != null)
            {
                mainForm.AddProductToListBox(
                    product.Id, 
                    int.Parse(txtTotalQty.Text),
                    product.Name,
                    product.Description,
                    product.SalePrice
                );
            }else
                MessageBox.Show("Error: MainForm instance not found.");
            this.Close();
        }

        
    }
}
