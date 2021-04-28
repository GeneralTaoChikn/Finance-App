using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Services
{
    public interface IFundService
    {
        Task<List<Models.Fund>> GetService();
        String UpdateFund();
    }
}
