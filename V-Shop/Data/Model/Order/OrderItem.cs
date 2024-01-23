using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Shop.Data.Model.Order
{
    public class OrderItem
    {
        private int orderDetailId;
        private int orderId;
        private int productId;
        private int qty;
        private double subtotal;
        private double totalPrice;
        private int cashierId;

        public int OrderDetailId 
        { 
            get { return orderDetailId; }
            set { orderDetailId = value; }
        }

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        public int CashierId
        {
            get { return cashierId; }
            set { cashierId = value;}
        }

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
    }
}
