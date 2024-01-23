using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.Data.Product;
using V_Shop.Repository;
using V_Shop.Data.Model;
using V_Shop.Data.Model.Cutomers;
using V_Shop.MainFormComponent;
using V_Shop.Presentation;

namespace V_Shop.UI
{
    public partial class InvoiceForm : Form
    {
        // Repository
        private readonly CashierRepository _cashierRepository;
        private readonly CustomerRepository _customerRepository;

      


        //
        private Customer _customer;
        private List<ProductInCard> _product;
        private string total;
        private string subtotal;
        private string shipping;
        private string discount;

        List<string> cashierName = new List<string>();
        

        public InvoiceForm()
        {
            InitializeComponent();
            _cashierRepository = new CashierRepository();
            
        }

        public InvoiceForm(List<ProductInCard> products, Customer customer, string subtotal, string total, string shipping, string discount)
        {
            InitializeComponent();
            _cashierRepository = new CashierRepository();
            _product = products;
            _customer = customer;
            this.subtotal = subtotal;
            this.total = total;
            this.shipping = shipping;
            this.discount = discount;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            
            dataGridViewProducts.DataSource = _product;
            lbCusFirstName.Text = _customer.FirstName;
            lbCusLastName.Text = _customer.LastName;
            lbCusEmail.Text = _customer.Email;
            lbCusPhone.Text = _customer.Phone;
            lbCusAddress.Text = _customer.Address;

            lbSubtotal.Text = subtotal;
            lbShipping.Text = shipping;
            lbDiscount.Text = discount;
            lbTotal.Text = total;

            cashierName = _cashierRepository.GetAllCashierName();
            foreach(string name in cashierName)
            {
                cboCashierName.Items.Add(name);
            }
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            
        }

        private void InvoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
