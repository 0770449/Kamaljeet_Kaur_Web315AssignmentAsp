using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KamalSelectedBag.Models;

namespace KamalBag.Pages_Bags
{
    public class CreateModel : PageModel
    {
        private readonly KamalBagContext _context;

        public CreateModel(KamalBagContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Bag Bag { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bag.Add(Bag);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
