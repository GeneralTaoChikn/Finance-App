using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinanceApp.Models;

namespace FinanceApp.Pages
{
    public class EditModel : PageModel
    {
        private readonly FinanceApp.Models.financeworksContext _context;

        public EditModel(FinanceApp.Models.financeworksContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Fund).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FundExists(Fund.IdFunds))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FundExists(int id)
        {
            return _context.Funds.Any(e => e.IdFunds == id);
        }
    }
}
