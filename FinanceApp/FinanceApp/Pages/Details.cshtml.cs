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
    public class DetailsModel : PageModel
    {
        private readonly FinanceApp.Models.financeworksContext _context;

        public DetailsModel(FinanceApp.Models.financeworksContext context)
        {
            _context = context;
        }

        public Fund Fund { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fund = await _context.Funds.FirstOrDefaultAsync(m => m.IdFunds == id);

            if (Fund == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
