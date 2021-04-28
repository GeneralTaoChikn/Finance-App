using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Services
{
    public class FundService: IFundService
    {
        private readonly FinanceApp.Models.financeworksContext _context;
        public IConfiguration Configuration { get; }

        public FundService(FinanceApp.Models.financeworksContext context)
        {
            _context = context;
        }

        public async Task<List<Models.Fund>> GetService()
        {
           return await _context.Funds.ToListAsync();
        }

        public String UpdateFund()
        {
            String query = "INSERT into funds VALUES( '0,'2075','1253.87','8000','-86.31')";

            //using (SqlConnection cnn = new SqlConnection(Configuration.GetConnectionString("DefaultConnection")))
            //{
            //    try
            //    {
            //        cnn.Open();
            //        cnn.BeginTransaction(query);
            //        return;
            //    }
            //    catch
            //    {
            //        return;
            //    }
            //}

            return query;
        }
    }
}
