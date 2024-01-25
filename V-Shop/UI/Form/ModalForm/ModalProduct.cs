using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.Data.Product;
using V_Shop.Presentation.Admin_Form_Component;

namespace V_Shop.Presentation.Modal
{
    public partial class ModalProduct : Form
    {

        public static ModalProduct instance;
        private int _id;
        private string _notice;
        private ProductRepository repository;

        public ModalProduct()
        {
            InitializeComponent();
            instance = this;
            repository = new ProductRepository();
            SetRoundForm();
        }

        public ModalProduct(int id, string notice)
        {
            InitializeComponent();
            _id = id;
            _notice = notice;
            repository = new ProductRepository();
            SetRoundForm();
        }

        private void SetRoundForm()
        {
            int radius = 30; // Adjust this value to set the radius of the rounded corners

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModalProduct_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BtBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *PNG)|*.jpg; *.jpeg; *.PNG";

            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open.FileName);
                pictureBoxProduct.Image = img;
            }
        }



        private void BtSaveProduct_Click(object sender, EventArgs e)
        {
            if (_notice == "Update")
            {
                // Update 
                try
                {
                    Product product = new Product
                    {
                        Name = txtProductName.Text,
                        SalePrice = double.Parse(txtSalePrice.Text),
                        Qty = int.Parse(txtQty.Text),
                        Description = txtDescription.Text,
                        ImageData = ConvertImageToByteArray(),
                        Category = comboCategory.Text,
                    };

                    DialogResult result = MessageBox.Show("Are you sure?", "Comfermation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        repository.UpdateProduct(product, _id);
                        this.Close();
                    }
                    else { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error input" + ex.Message);
                }
            }
            else
            {
                ////// Save the product
                try
                {
                    Product product = new Product
                    {
                        Name = txtProductName.Text,
                        SalePrice = double.Parse(txtSalePrice.Text),
                        Qty = int.Parse(txtQty.Text),
                        Description = txtDescription.Text,
                        ImageData = ConvertImageToByteArray(),
                        Category = comboCategory.Text
                    };
                    repository.Save(product);


                    DialogResult result = MessageBox.Show(
                        "Add more?",
                        "Comfirmation!",
                        MessageBoxButtons.YesNo
                    );
                    if (result == DialogResult.Yes)
                    {
                        txtProductName.Clear();
                        txtPouchesPrice.Clear();
                        txtSalePrice.Clear();
                        txtQty.Clear();
                        txtDescription.Clear();
                        comboCategory.Text = String.Empty;
                        pictureBoxProduct.Image = null;
                        return;
                    }
                    else this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void ModalProduct_Load(object sender, EventArgs e)
        {
            if (_notice == "Update")
            {
                
                BtSaveProduct.Text = "Update";

                Product product = repository.GetProduct(_id);
                txtProductName.Text = product.Name;
                txtDescription.Text = product.Description;
                txtSalePrice.Text = product.SalePrice.ToString();
                txtQty.Text = product.Qty.ToString();
                comboCategory.Text = product.Category.ToString();

                pictureBoxProduct.Image = ConvertByteArrayToImage(product.ImageData);
            }
        }

        private byte[] ConvertImageToByteArray()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap bitmap = new Bitmap(pictureBoxProduct.Image))
                {
                    bitmap.Save(ms, pictureBoxProduct.Image.RawFormat);
                }
                return ms.ToArray();
            }
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
    }
}
