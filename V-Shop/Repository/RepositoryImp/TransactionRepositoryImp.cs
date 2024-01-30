using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Shop.Data.Model.Transactions;

namespace V_Shop.Repository.RepositoryImp
{
    public class TransactionRepositoryImp : ITransactionRepository
    {
        DatabaseHelper dbHelper;

        public TransactionRepositoryImp()
        {
            dbHelper = new DatabaseHelper();
        }

        public void AddTransaction(Transaction transaction)
        {
            string query = "Insert into Transactions(product_id, transaction_type, qty, transaction_date, pouches_price)" +
                "VALUES(@productID, @Type, @Qty, @Date, @Pouches)";
            using(SqlConnection conn = dbHelper.OpenConnection())
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productId", transaction.ProductId);
                    cmd.Parameters.AddWithValue("@Type", transaction.TransactionType);
                    cmd.Parameters.AddWithValue("@Qty", transaction.Qty);
                    cmd.Parameters.AddWithValue("@Date", transaction.TransactionDate);
                    cmd.Parameters.AddWithValue("@Pouches", transaction.PouchesPrice);
                    cmd.ExecuteNonQuery();
                } 
            }
        }

        public void DeleteTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetPouchesTransaction()
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetSaleTransactions()
        {
            throw new NotImplementedException();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}


























