using FinanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Services
{
    public class TransactionService : ITransactionService
    {

        private readonly FinanceApp.Models.financeworksContext _context;

        public TransactionService(FinanceApp.Models.financeworksContext context)
        {
            _context = context;
        }
        public void addTransaction(String userID, String type, int amount)
        {
            Transaction transaction = new Transaction()
            {
                TransactionId = Guid.NewGuid().ToString(),
                UserId = userID,
                Type = type,
                Amount = amount,
            };

            _context.Transactions.Add(transaction);
        }

        public void deleteTransaction()
        {

        }

        public void modifyTransaction()
        {

        }

    }
}
