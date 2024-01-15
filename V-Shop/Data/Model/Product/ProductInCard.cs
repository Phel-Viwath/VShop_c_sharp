using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Shop.Data.Product
{
    public class ProductInCard
    {
        private int productId;
        private string name;
        private string description;
        private double price;
        private int qty;

        public int ProductID
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
    }
}
