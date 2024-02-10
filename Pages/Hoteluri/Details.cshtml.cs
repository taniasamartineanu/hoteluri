using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using hoteluri.Data;
using hoteluri.Models;

namespace hoteluri.Pages.Hoteluri
{
    public class DetailsModel : PageModel
    {
        private readonly hoteluri.Data.hoteluriContext _context;

        public DetailsModel(hoteluri.Data.hoteluriContext context)
        {
            _context = context;
        }

        public Hotel Hotel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hotel = await _context.Hotel
                .Include(h => h.Camere)
                .FirstOrDefaultAsync(m => m.HotelId == id);

            if (Hotel == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
