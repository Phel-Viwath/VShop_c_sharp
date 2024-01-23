using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Shop.Data.Model.Order
{
    public class Order
    {
        private int order_id;
        private int cutomer_id;
        private DateTime orderDate;
        private double total_amount;

        public int OrderID
        {
            get { return order_id; }
            set { order_id = value;}
        }

        public int CutomerID
        {
            get { return cutomer_id; }
            set { cutomer_id = value;}
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public double TotalAmount
        {
            get { return total_amount; }
            set { total_amount = value; }
        }
    }
}
