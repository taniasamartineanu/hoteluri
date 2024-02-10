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
    public class DetailsModel : PageModel
    {
        private readonly hoteluri.Data.hoteluriContext _context;

        public DetailsModel(hoteluri.Data.hoteluriContext context)
        {
            _context = context;
        }

        public Rezervare Rezervare { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervare = await _context.Rezervare.FirstOrDefaultAsync(m => m.RezervareId == id);
            if (rezervare == null)
            {
                return NotFound();
            }
            else
            {
                Rezervare = rezervare;
            }
            return Page();
        }
    }
}
