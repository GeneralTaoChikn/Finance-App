using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Services
{
    public interface IUserService
    {
        void addUser(String fname, String lname, String email, 
            String transactionSet, int currCash, int currChecking,
            int currSaving, int currCredit);
    }
}
