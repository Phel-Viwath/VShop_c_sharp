using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_Shop.Presentation.Admin_Form_Component;
using V_Shop.Presentation.Modal;

namespace V_Shop.Presentation
{
    public partial class AdminForm : Form
    {
        private MainForm mainForm;
        CustomerForm cusForm = new CustomerForm();
        DashboardForm dashboardForm = new DashboardForm();
        ProductForm productForm = new ProductForm();
        OrderForm orderForm = new OrderForm();
        AnalyticsForm analyticsForm = new AnalyticsForm();

        ModalProduct modalProduct = new ModalProduct();
      

        public AdminForm()
        {
            InitializeComponent();
            mainForm = new MainForm();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ShowForm(dashboardForm);
            if (dashboardForm.Visible)
                btDashboard.FillColor = Color.FromArgb(255, 128, 0);
            else
                btDashboard.FillColor = Color.Transparent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            ShowForm(dashboardForm);
            btDashboard.FillColor = Color.FromArgb(255, 128, 0);
            btAnalytics.FillColor = Color.Transparent;
            btCutomer.FillColor = Color.Transparent;
            btProduct.FillColor = Color.Transparent;
            btOrder.FillColor = Color.Transparent;
        }

        private void btCutomer_Click(object sender, EventArgs e)
        {
            ShowForm(cusForm);
            btCutomer.FillColor = Color.Yellow;
            btDashboard.FillColor = Color.Transparent;
            btAnalytics.FillColor = Color.Transparent;
            btProduct.FillColor = Color.Transparent;
            btOrder.FillColor = Color.Transparent;
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            ShowForm(productForm);
            btCutomer.FillColor = Color.Transparent;
            btDashboard.FillColor = Color.Transparent;
            btAnalytics.FillColor = Color.Transparent;
            btProduct.FillColor = Color.Cyan;
            btOrder.FillColor = Color.Transparent;
        }

        private void btOrder_Click(object sender, EventArgs e)
        { 
            ShowForm(orderForm);
            btCutomer.FillColor = Color.Transparent;
            btDashboard.FillColor = Color.Transparent;
            btAnalytics.FillColor = Color.Transparent;
            btProduct.FillColor = Color.Transparent;
            btOrder.FillColor = Color.Lime;
        }
        private void btAnalytics_Click(object sender, EventArgs e)
        {
            ShowForm(analyticsForm);
            btCutomer.FillColor = Color.Transparent;
            btDashboard.FillColor = Color.Transparent;
            btAnalytics.FillColor = Color.Fuchsia;
            btProduct.FillColor = Color.Transparent;
            btOrder.FillColor = Color.Transparent;
        }

        private void ShowForm(Form form)
        {
            form.Size = PanelComponemt.Size;
            form.AutoScroll = true;
            form.TopLevel = false;
            PanelComponemt.Controls.Clear();
            PanelComponemt.Controls.Add(form);
            form.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
