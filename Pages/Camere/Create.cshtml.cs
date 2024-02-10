using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using hoteluri.Data;
using hoteluri.Models;

namespace hoteluri.Pages.Camere
{
    public class CreateModel : PageModel
    {
        private readonly hoteluri.Data.hoteluriContext _context;

        public CreateModel(hoteluri.Data.hoteluriContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet()
        {
            ViewData["HotelId"] = new SelectList(_context.Hotel, "HotelId", "NumeHotel");
            return Page();
        }


        [BindProperty]
        public Camera Camera { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Camera.Add(Camera);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
