using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.Data.Product;
using V_Shop.Presentation.Modal;

namespace V_Shop.Presentation.Admin_Form_Component
{
    public partial class ProductForm : Form
    {
        public static ProductForm instance;
        private DatabaseHelper dbHelper;
        private ProductRepository repository;
        
        
        /// Constructor
        public ProductForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            repository = new ProductRepository();
            instance = this;
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            dataGridViewProduct.DataSource = repository.GetAllProducts();
        }
        // Button Event
        private void btAddProduct_Click(object sender, EventArgs e)
        {
            Form background = new Form();

            try
            {
                using (ModalProduct modal = new ModalProduct())
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

                    modal.Owner = background;
                    modal.ShowDialog();


                    background.Dispose();
                    dataGridViewProduct.DataSource = repository.GetAllProducts();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { background.Dispose(); }
            
        }// End Button Event


        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn updateColumn = dataGridViewProduct.Columns[7];
            DataGridViewColumn deleteColumn = dataGridViewProduct.Columns[8];
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                if (e.ColumnIndex == deleteColumn.Index)
                {
                    DataGridViewCell cell = dataGridViewProduct.Rows[e.RowIndex].Cells[0];
                    if (cell != null && cell.Value != null)
                    {
                        // Handle delete button click
                        int productId = (int)cell.Value;
                        repository.DeleteProduct(productId);
                        dataGridViewProduct.DataSource = repository.GetAllProducts();
                    }

                }
                else if(e.ColumnIndex == updateColumn.Index)
                {
                    DataGridViewCell cell = dataGridViewProduct.Rows[e.RowIndex].Cells[0];
                    if (cell != null && cell.Value != null)
                    {
                        
                        int productId = (int)cell.Value;
                        LoadModalUpdate(productId, "Update");
                    }
                }
            }
        }

        // Load Modal Update 
        private void LoadModalUpdate(int id, string notice)
        {
            Form background = new Form();

            try
            {
                using (ModalProduct modal = new ModalProduct(id, notice))
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

                    modal.Owner = background;
                    modal.ShowDialog();

                    background.Dispose();
                    dataGridViewProduct.DataSource = repository.GetAllProducts();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { background.Dispose(); }
            
        }
    }
}
