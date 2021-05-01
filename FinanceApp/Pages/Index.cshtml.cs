using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinanceApp.Models;

namespace FinanceApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FinanceApp.Models.financeworksContext _context;

        public IndexModel(FinanceApp.Models.financeworksContext context)
        {
            _context = context;
        }

        public IList<Fund> Fund { get;set; }

        public async Task OnGetAsync()
        {
            Fund = await _context.Funds.ToListAsync();
        }
    }
}
