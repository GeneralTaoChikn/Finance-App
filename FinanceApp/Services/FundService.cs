
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Models;

namespace FinanceApp.Services
{
    public class FundService: IFundService
    {
        private readonly FinanceApp.Models.financeworksContext _context;

        public FundService(FinanceApp.Models.financeworksContext context)
        {
            _context = context;
        }

        public async Task<List<Models.Fund>> GetService()
        {
           return await _context.Funds.ToListAsync();
        }

        public void UpdateFund(String userId, int currCash,
            int currChecking, int currSaving, int currCredit)
        {
            Fund recFund = _context.Funds.SingleOrDefault(f => f.UserId == userId);
            if(recFund != null)
            {
                recFund.Cash = currCash;
                recFund.Checking = currChecking;
                recFund.Savings = currSaving;
                recFund.Credit = currCredit;
            }
            //_context.Add(recFund);
            //_context.Update(recFund);
            _context.SaveChanges();
            return;
        }

        public String UpdateFund()
        {
            Guid guid = new Guid();

            User user = new User()
            {
                Id = guid.ToString(),
                FirstName = "Christopher",
                LastName = "Diasanta",
                Email = "",
                TransactionSet = 0
            };



            Fund fund = new Fund() {
                FundsId = Guid.NewGuid().ToString(),
                UserId = guid.ToString(),
                Cash = 1800,
                Checking = 2000,
                Savings = 8000,
                
            };
            
            _context.Funds.Add(fund);
            _context.Users.Add(user);
            //_context.SaveChangesAsync
            _context.SaveChanges();
            String query = "INSERT into funds VALUES( '0,'2075','1253.87','8000','-86.31')";

            return query;
        }
    }
}
