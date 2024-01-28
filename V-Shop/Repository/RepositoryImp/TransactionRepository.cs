using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Shop.Data.Model.Transactions;

namespace V_Shop.Repository.RepositoryImp
{
    public class TransactionRepository : ITransactionRepository
    {
        DatabaseHelper dbHelper;

        public TransactionRepository(DatabaseHelper dbHelper)
        {
            this.dbHelper = dbHelper;
        }

        public void AddTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
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


























