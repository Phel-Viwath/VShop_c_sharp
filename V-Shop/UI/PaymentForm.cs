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
using V_Shop.MainFormComponent;

namespace V_Shop.UI
{
    public partial class PaymentForm : Form
    {
        CheckOutModalForm checkOutModal = new CheckOutModalForm();
        Customer customer = new Customer();
        private List<ProductInCard> products;
        private string total;
        private string subtotal;
        private string shipping;
        private string discount;


        public PaymentForm()
        {
            InitializeComponent();
        }

        public PaymentForm(List<ProductInCard> product, Customer customer, string subtotal, string total, string shipping, string discount)
        {
            InitializeComponent();
            this.products = product;
            this.customer = customer;
            this.total = total;
            this.subtotal = subtotal;
            this.shipping = shipping;
            this.discount = discount;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvoiceForm form = new InvoiceForm(products, customer, subtotal, total, shipping, discount);
            form.ShowDialog();
            this.Close();
        }

        private void panelPayWithCashier_Click(object sender, EventArgs e)
        {
            panelPayWithCashier.BorderColor = Color.Blue;
            panelPayWithCreditCard.BorderColor = Color.Black;
            chBoxDirectPay.Checked = true;
            chBoxPayWithBank.Checked = false;
        }

        private void panelPayWithCreditCard_Click(object sender, EventArgs e)
        {
            panelPayWithCashier.BorderColor = Color.Black;
            panelPayWithCreditCard.BorderColor = Color.Blue;
            chBoxDirectPay.Checked = false;
            chBoxPayWithBank.Checked = true;
        }

        private void chBoxPayWithBank_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxPayWithBank.Checked)
            {
                panelPayWithCashier.BorderColor = Color.Black;
                panelPayWithCreditCard.BorderColor = Color.Blue;
                chBoxDirectPay.Checked = false;
            }
            
        }

        private void chBoxDirectPay_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxDirectPay.Checked)
            {
                panelPayWithCashier.BorderColor = Color.Blue;
                panelPayWithCreditCard.BorderColor = Color.Black;
                chBoxPayWithBank.Checked = false;
            }
           
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            chBoxPayWithBank.Checked = true; 
            chBoxDirectPay.Checked = false;
        }
    }
}
