using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.Data.Model.Cutomers;
using V_Shop.Data.Product;
using V_Shop.Data.User;
using V_Shop.UI;
using V_Shop.User;
using V_Shop.View.Modal;

namespace V_Shop.MainFormComponent
{
    public partial class CheckOutModalForm : Form
    {
        private readonly UserRepository repository;
        private List<ProductInCard> inCards;
        private double totalPay;
        Customer customer;

        public CheckOutModalForm(List<ProductInCard> products)
        {
            InitializeComponent();
            repository = new UserRepository();
            this.inCards = products;
        }
        
        public CheckOutModalForm()
        {
            InitializeComponent();
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckOutModalForm_Load(object sender, EventArgs e)
        {
            dataGridViewProduct.Rows.Clear();
            dataGridViewProduct.DataSource = inCards;
            // Get total pay
            totalPay = 0.0;
            foreach(DataGridViewRow row in dataGridViewProduct.Rows)
            {
                if (row.IsNewRow) continue;
                double price = Convert.ToDouble(row.Cells[2].Value);
                int qty = Convert.ToInt32(row.Cells[3].Value);

                double total = price * (double)qty;
                totalPay += total;
            }

            lbSubtotal.Text = $"{totalPay} $";
            lbTotal.Text = $"{totalPay}";
            lbShipping.Text = "Free";

            Users user = repository.GetUser(AccountType.id);
            if (user != null)
            {
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtEmail.Text = user.Email;
            }
        }

        private void dataGridViewProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            totalPay = 0.0;
            foreach (DataGridViewRow row in dataGridViewProduct.Rows)
            {
                if (row.IsNewRow) continue;

                double price = Convert.ToDouble(row.Cells[2].Value);
                int qty = Convert.ToInt32(row.Cells[3].Value);

                double total = price * (double)qty;
                totalPay += total;
            }

            lbSubtotal.Text = $"{totalPay} $";
            lbTotal.Text = $"{totalPay} $";
        }

        private void BtPay_Click(object sender, EventArgs e)
        {
            string cusFirstName = txtFirstName.Text;
            string cusLastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string address = txtAddress.Text;

            string subtotal = lbSubtotal.Text;
            string totalPay = lbTotal.Text;
            string discount = lbDiscount.Text;
            string shipping = lbShipping.Text;


            customer = new Customer
            {
                FirstName = cusFirstName,
                LastName = cusLastName,
                Email = email,
                Phone = phone,
                Address = address
            };

            Form background = new Form();
            try
            {
                using (PaymentForm modal = new PaymentForm(inCards, customer, subtotal, totalPay, shipping, discount))
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
    }
}
