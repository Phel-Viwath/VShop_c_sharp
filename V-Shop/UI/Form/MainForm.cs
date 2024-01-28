using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.View.Modal;
using V_Shop.View;
using V_Shop.User;
using V_Shop.Data.Product;
using System.Web.UI.WebControls;
using V_Shop.Presentation.Modal;
using V_Shop.MainFormComponent;

namespace V_Shop.Presentation
{
    public partial class MainForm : Form
    {
        public static MainForm instance;

        // Object 
        private AdminForm adminForm;
        private SignUpForm signUpForm;
        private readonly ProductRepositoryImp repository;

        // User data fields
        private string role;
        private int userID;
        // Product data fields
        private int productID;
        private string productName;
        private int productQty;
        private string productDescription;
        private double productPrice;
        List<ProductInCard> productInCardsList = new List<ProductInCard>();

        //
        private bool expandPanelMenu = false;
        private bool expandPanelOption = false;
        private bool expandPanelCategory = false;
        private bool expandFlowLayout = false;
        double totalPay = 0;


        // Constructor
        public MainForm()
        {
            InitializeComponent();
            repository = new ProductRepositoryImp();
        }

        // Constructor
        public MainForm(string role, int id)
        {
            InitializeComponent();
            this.role = role;
            this.userID = id;
            repository = new ProductRepositoryImp();
        }

        // Properties

        
        // Method and Event

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelInCard.Visible = false;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            instance = this;
            panelMenu.Height = 0;
            if (AccountType.type == "A")
            {
                btDashboard.Visible = true;
            }
            else if (AccountType.type == "U")
            {
                panelMenu.MaximumSize = new Size(panelMenu.MaximumSize.Width, 178);
                btDashboard.Visible = false;
            }

            List<Product> products = repository.GetAllProductInStock();

            foreach(Product product in products)
            {
                ProductCardView productCardView = new ProductCardView(product);
                flowLayoutPanel1.Controls.Add(productCardView);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(expandPanelMenu == false)
            {
                panelMenu.Height += 15;
                if(panelMenu.Height >= panelMenu.MaximumSize.Height)
                {
                    timer1.Stop();
                    expandPanelMenu = true;
                }
            }
            else
            {
                panelMenu.Height -= 15;
                if(panelMenu.Height <= panelMenu.MinimumSize.Height)
                {
                    timer1.Stop();
                    expandPanelMenu = false;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if(expandPanelOption == false)
            {
                panelOption.Width += 15;
                if (panelOption.Width >= panelOption.MaximumSize.Width)
                {
                    timer2.Stop();
                    expandPanelOption = true;
                }
            }
            else
            {
                panelOption.Width -= 15;
                if (panelOption.Width <= panelOption.MinimumSize.Width)
                {
                    timer2.Stop();
                    expandPanelOption = false;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(expandPanelCategory == false)
            {
                panelCategory.Height += 15;
                if(panelCategory.Height >= panelCategory.MaximumSize.Height)
                {
                    timer3.Stop();
                    expandPanelCategory = true;
                }
            }
            else
            {
                panelCategory.Height -= 15;
                if(panelCategory.Height <= panelCategory.MinimumSize.Height)
                {
                    timer3.Stop();
                    expandPanelCategory = false;
                }
            }
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void BtMenu_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void BtCategory_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }
        
        private void btDashboard_Click(object sender, EventArgs e)
        {
            adminForm = new AdminForm();
            this.ShowInTaskbar = false;
            adminForm.ShowDialog();
        }

        private void btSignOut_Click(object sender, EventArgs e)
        {
            signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.ShowDialog();
            this.Dispose();
        }

        private void btAccount_Click(object sender, EventArgs e)
        {

            Form background = new Form();
            try
            {
                using (ProfileVewModal modal = new ProfileVewModal())
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
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { background.Dispose(); }
            this.Show();
        }

        private void BtInCard_Click(object sender, EventArgs e)
        {
            if (expandFlowLayout == false)
            {
                flowLayoutPanel1.Hide();
                panelInCard.Dock = DockStyle.Fill;
                panelInCard.Visible = true;
                expandFlowLayout = true;
            }
            else
            {
                panelInCard.Dock = DockStyle.Right;
                panelInCard.Visible = false;
                flowLayoutPanel1.Show();
                expandFlowLayout = false;
            }
        }

        public void AddProductToListBox(int productId, int buyQty, string name, string description, double price)
        {
            // Add the product ID to the ListBox
            this.productID = productId;
            this.productName = name;
            this.productQty = buyQty;
            this.productDescription = description;
            this.productPrice = price;
            
            //ListBoxProduct.Items.Add($"ID: {productId}, Name: {name}, Qty: {buyQty}");

            dataGridViewProduct.Rows.Add(productID, productName, productPrice, productQty, productDescription);
            totalPay = 0.0;
            foreach (DataGridViewRow row in dataGridViewProduct.Rows)
            {
                if (row.IsNewRow) continue;

               
                double prices = Convert.ToDouble(row.Cells[2].Value);
                int qtys = Convert.ToInt32(row.Cells[3].Value);
               
                double total = prices * (double) qtys;
                totalPay += total;
            }
            lbSubTotal.Text = $"{totalPay} $";
            lbTotal.Text = $"{totalPay} $";  
        }

        

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridViewProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    //txtBuyQty.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            //}
        }

        private void BtCheckOut_Click(object sender, EventArgs e)
        {

            foreach(DataGridViewRow row in dataGridViewProduct.Rows)
            {
                if (row.IsNewRow) continue;

                int productId = Convert.ToInt32(row.Cells[0].Value);
                string name = Convert.ToString(row.Cells[1].Value);
                double price = Convert.ToDouble(row.Cells[2].Value);
                int qty = Convert.ToInt32(row.Cells[3].Value);
                string description = Convert.ToString(row.Cells[4].Value);

                ProductInCard product = new ProductInCard
                {
                    ProductID = productId,
                    ProductName = name,
                    Description = description,
                    Price = price,
                    Qty = qty
                };

                productInCardsList.Add(product);
            }

            //MessageBox.Show(totalPay.ToString());

            //////////
            Form background = new Form();

            try
            {
                using (CheckOutModalForm modal = new CheckOutModalForm(productInCardsList))
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
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { background.Dispose(); }
        }

       

        private void dataGridViewProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewProduct.Columns[3].Index)
            {
                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            totalPay = 0.0;
            foreach (DataGridViewRow row in dataGridViewProduct.Rows)
            {
                if (row.IsNewRow) continue;

                double price = Convert.ToDouble(row.Cells[2].Value);
                int qty = Convert.ToInt32(row.Cells[3].Value);

                double total = price * (double) qty;
                totalPay += total;
            }

            lbSubTotal.Text = $"${totalPay}";
            lbTotal.Text = $"${totalPay} ";
        }
    }
}
















