using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Shop.Data.Model.Transactions
{
    public class Transaction
    {
        private int transactionId;
        private int productId;
        private string transactionType;
        private int qty;
        private DateTime transactionDate;

        public int TransactionId 
        { 
            get { return transactionId; } 
            set { transactionId = value; } 
        }
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public string TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        public DateTime TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }
    }
}
