using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ZooKeeping.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AnimalDbContext _context;

        public IndexModel(AnimalDbContext context)
        {
            _context = context;
        }

        public IList<Animal> Animal { get;set; } = default!;

        [BindProperty]
        public string Filter { get; set; }

        public async Task OnGetAsync()
        {
            if (Filter.IsNullOrEmpty()) {
                Animal = await _context.Animals.ToListAsync();
            }
            else
            {
                Animal = await _context.Animals.Where(x => x.Name.ToLower().Contains(Filter.ToLower())).ToListAsync();
            }
        }
    }
}
