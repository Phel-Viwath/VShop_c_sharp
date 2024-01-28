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

namespace V_Shop.Presentation
{
    public partial class DashboardForm : Form
    {

        private ProductRepositoryImp repository;

        public DashboardForm()
        {
            InitializeComponent();
            repository = new ProductRepositoryImp();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
