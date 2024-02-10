using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using hoteluri.Data;
using hoteluri.Models;

namespace hoteluri.Pages.Rezervari
{
    public class CreateModel : PageModel
    {
        private readonly hoteluriContext _context;

        public CreateModel(hoteluriContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateDropdowns();
            return Page();
        }

        [BindProperty]
        public Rezervare Rezervare { get; set; } = new Rezervare();

        public List<SelectListItem> ClientOptions { get; set; }
        public List<SelectListItem> HotelOptions { get; set; }
        public List<SelectListItem> CameraOptions { get; set; }

        public void PopulateDropdowns()
        {
            ClientOptions = _context.Client
                .Select(c => new SelectListItem
                {
                    Value = c.ClientId.ToString(),
                    Text = $"{c.Nume} {c.Prenume}"
                })
                .ToList();


            HotelOptions = _context.Hotel
                .Select(h => new SelectListItem
                {
                    Value = h.HotelId.ToString(),
                    Text = h.NumeHotel
                })
                .ToList();

            CameraOptions = _context.Camera
                .Select(c => new SelectListItem
                {
                    Value = c.CameraId.ToString(),
                    Text = c.NumarCamera
                })
                .ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                PopulateDropdowns();
                return Page();
            }

            _context.Rezervare.Add(Rezervare);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
