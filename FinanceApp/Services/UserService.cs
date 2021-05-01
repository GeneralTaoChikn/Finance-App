using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Models;

namespace FinanceApp.Services
{
    public class UserService : IUserService
    {

        private readonly FinanceApp.Models.financeworksContext _context;

        public UserService(FinanceApp.Models.financeworksContext context)
        {
            _context = context;
        }

        public void addUser(String fname, String lname, String email,
            String transactionSet, int currCash, int currChecking,
            int currSaving, int currCredit)
        {
            String guid = new Guid().ToString();

            User user = new User()
            {
                Id = guid,
                FirstName = fname,
                LastName = lname,
                Email = email,
                TransactionSet = 0
            };

            Fund fund = new Fund()
            {
                FundsId = new Guid().ToString(),
                UserId = guid,
                Cash = currCash,
                Checking = currChecking,
                Savings = currSaving,
                Credit = currCredit
            };


            _context.Users.Add(user);
            _context.Funds.Add(fund);
            _context.SaveChanges();

        }
    }
}
