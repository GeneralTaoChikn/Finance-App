using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Services
{
    public interface IFundService
    {
        Task<List<Models.Fund>> GetService();
        void UpdateFund(String userId, int currCash, 
            int currChecking, int currSaving, int currCredit);
        String UpdateFund();
    }
}
