using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NegosudAPI.Data;
using NegosudAPI.Models;

namespace NegosudAPI.test
{
    public class IndexModel : PageModel
    {
        private readonly NegosudAPI.Data.DataContext _context;

        public IndexModel(NegosudAPI.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Clients != null)
            {
                Client = await _context.Clients.ToListAsync();
            }
        }
    }
}
