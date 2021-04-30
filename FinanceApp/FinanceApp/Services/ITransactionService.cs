using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Services
{
    public interface ITransactionService
    {
        void addTransaction(String userID, String type,
            int amount);
        void deleteTransaction();
        void modifyTransaction();
    }
}
