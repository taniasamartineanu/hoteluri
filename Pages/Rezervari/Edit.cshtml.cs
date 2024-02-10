using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using hoteluri.Data;
using hoteluri.Models;

namespace hoteluri.Pages.Rezervari
{
    public class EditModel : PageModel
    {
        private readonly hoteluri.Data.hoteluriContext _context;

        public EditModel(hoteluri.Data.hoteluriContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rezervare Rezervare { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervare =  await _context.Rezervare.FirstOrDefaultAsync(m => m.RezervareId == id);
            if (rezervare == null)
            {
                return NotFound();
            }
            Rezervare = rezervare;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Rezervare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RezervareExists(Rezervare.RezervareId))
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

        private bool RezervareExists(int id)
        {
            return _context.Rezervare.Any(e => e.RezervareId == id);
        }
    }
}
