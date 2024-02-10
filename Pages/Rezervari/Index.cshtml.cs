using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using hoteluri.Data;
using hoteluri.Models;

namespace hoteluri.Pages.Rezervari
{
    public class IndexModel : PageModel
    {
        private readonly hoteluri.Data.hoteluriContext _context;

        public IndexModel(hoteluri.Data.hoteluriContext context)
        {
            _context = context;
        }

        public IList<Rezervare> Rezervare { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Rezervare = await _context.Rezervare.ToListAsync();
        }
    }
}
