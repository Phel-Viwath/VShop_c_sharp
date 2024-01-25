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
using System.Xml;
using V_Shop.Presentation;
using V_Shop.Presentation.Modal;

namespace V_Shop.Data.Product
{
    public partial class ProductCardView : UserControl
    {
        private Product product;

        public ProductCardView(Product product)
        {
            InitializeComponent();
            this.product = product;
            UpdateUI();
            SetRoundForm();
        }

        private void UpdateUI()
        {

            this.Margin = new Padding(10);
            labelName.Text = $"Name: {product.Name}";
            labelPrice.Text = $"Price: {product.SalePrice:C}";
            pictureBoxProduct.Image = ConvertByteArrayToImage(product.ImageData);
            
        }
       

        private Image ConvertByteArrayToImage(byte[] byteArray)
        {

            try
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image img = Image.FromStream(ms);
                    return img;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        private void BtDatail_Click(object sender, EventArgs e)
        {

            Form background = new Form();

            try
            {
                using (ProductDetailForm detailForm = new ProductDetailForm(product))
                {

                    background.StartPosition = FormStartPosition.CenterScreen;
                    background.FormBorderStyle = FormBorderStyle.None;
                    background.Opacity = .70d;
                    background.BackColor = Color.Black;
                    background.WindowState = FormWindowState.Maximized;
                    background.TopMost = true;
                    background.Location = this.Location;
                    background.ShowInTaskbar = false;

                    background.Show();

                    detailForm.Owner = background;
                    detailForm.ShowDialog();

                    background.Dispose();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { background.Dispose(); }
            
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
    }
}
