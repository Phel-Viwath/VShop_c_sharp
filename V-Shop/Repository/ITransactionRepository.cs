using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V_Shop.Data.Model.Transactions;

namespace V_Shop.Repository
{
    public interface ITransactionRepository
    {
        void AddTransaction(Transaction transaction);
        void DeleteTransaction(int id);
        List<Transaction> GetAllTransactions();
        List<Transaction> GetPouchesTransaction();
        List<Transaction> GetSaleTransactions();
        void UpdateTransaction(Transaction transaction);

    }
}
