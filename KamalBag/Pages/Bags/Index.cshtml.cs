using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KamalSelectedBag.Models;

namespace KamalBag.Pages_Bags
{
    public class IndexModel : PageModel
    {
        private readonly KamalBagContext _context;

        public IndexModel(KamalBagContext context)
        {
            _context = context;
        }

        public IList<Bag> Bag { get;set; }

        public async Task OnGetAsync()
        {
            Bag = await _context.Bag.ToListAsync();
        }
    }
}
