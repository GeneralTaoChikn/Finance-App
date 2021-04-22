using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinanceApp.Models;

namespace FinanceApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly FinanceApp.Models.financeworksContext _context;

        public CreateModel(FinanceApp.Models.financeworksContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Fund Fund { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Funds.Add(Fund);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
